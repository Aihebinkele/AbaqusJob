using System;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using AbaqusJob.My;

namespace AbaqusJob;
public partial class Form1
{
    internal ToolStripMenuItem WorkDirMenu;
    internal ToolStripMenuItem MergeOdbMenuItem;

    private void WorkDirMenu_Click(object sender, EventArgs e)
    {
        using (FolderBrowserDialog dlg = new FolderBrowserDialog())
        {
            dlg.Description = "Select working directory for Abaqus output files";
            dlg.ShowNewFolderButton = true;
            string wd = MySettingsProperty.Settings.WorkingDirectory;
            if (!string.IsNullOrEmpty(wd) && Directory.Exists(wd)) dlg.SelectedPath = wd;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                MySettingsProperty.Settings.WorkingDirectory = dlg.SelectedPath;
                MySettingsProperty.Settings.Save();
                foreach (JobItem job in jobList) job._OutputDir = dlg.SelectedPath;
                UpdateUI();
                AppendLog("[Info] Working directory: " + dlg.SelectedPath);
            }
        }
    }

    private void MergeOdbMenuItem_Click(object sender, EventArgs e)
    {
        JobItem j1 = jobList[dgvJobs.SelectedRows[0].Index];
        JobItem j2 = jobList[dgvJobs.SelectedRows[1].Index];
        string odb1 = j1.OdbPath;
        string odb2 = j2.OdbPath;
        if (!File.Exists(odb1)) { AppendLog("[Merge] File not found: " + odb1); return; }
        if (!File.Exists(odb2)) { AppendLog("[Merge] File not found: " + odb2); return; }
        string abqPath = MySettingsProperty.Settings.AbaqusPath;
        if (string.IsNullOrEmpty(abqPath) || !File.Exists(abqPath)) abqPath = FindAbaqusBat();
        if (string.IsNullOrEmpty(abqPath)) { AppendLog("[Merge] abaqus.bat not found"); return; }
        string outDir = Path.GetDirectoryName(odb1) ?? ".";
        string args = "restartjoin originalodb=\"" + odb1 + "\" restartodb=\"" + odb2 + "\" -copyoriginal -history";
        AppendLog("[Merge] " + Path.GetFileName(odb1) + " + " + Path.GetFileName(odb2));
        Task.Run(() => {
            try {
                string cmd = "/c \"\"" + abqPath + "\" " + args + "\"";
                using (Process p = new Process()) {
                    p.StartInfo = new ProcessStartInfo("cmd.exe", cmd) { UseShellExecute = false, CreateNoWindow = true, RedirectStandardOutput = true, RedirectStandardError = true, WorkingDirectory = outDir };
                    p.OutputDataReceived += (s, ev) => { if (!string.IsNullOrEmpty(ev.Data)) SafeInvoke(() => AppendLog(ev.Data)); };
                    p.ErrorDataReceived += (s, ev) => { if (!string.IsNullOrEmpty(ev.Data)) SafeInvoke(() => AppendLog("[Merge] " + ev.Data)); };
                    p.Start(); p.BeginOutputReadLine(); p.BeginErrorReadLine();
                    p.WaitForExit(120000);
                    SafeInvoke(() => AppendLog("[Merge] Done (exit " + p.ExitCode + ")"));
                }
            } catch (Exception ex) { SafeInvoke(() => AppendLog("[Merge] err: " + ex.Message)); }
        });
    }
}
