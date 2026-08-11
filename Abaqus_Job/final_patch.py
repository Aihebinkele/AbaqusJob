import os
path = r'F:\FTP\培训教程\Abaqus\abaqus插件\JOB\Python版\Abaqus_Job\AbaqusJob\Form1.cs'
with open(path, 'r', encoding='utf-8') as f:
    c = f.read()

# 1. CS0165
c = c.replace('new _Closure_0024__90_002D0(arg)', 'new _Closure_0024__90_002D0(null)')

# 2. Icon
c = c.replace('\t\tInitializeComponent();', '\t\tInitializeComponent();\n\t\ttry { base.Icon = System.Drawing.Icon.ExtractAssociatedIcon(System.Windows.Forms.Application.ExecutablePath); } catch { }', 1)

# 3. ODB column + OutputDir + MultiSelect + About + RemoveMenuItem + warnings + WorkingDirectory
c = c.replace('new string[8] { "FilePath"', 'new string[9] { "FilePath"')
c = c.replace(
    'Name = "Status",\n\t\t\tHeaderText = "状态",\n\t\t\tDataPropertyName = "Status",\n\t\t\tReadOnly = true,\n\t\t\tWidth = 60\n\t\t};',
    'Name = "Status",\n\t\t\tHeaderText = "状态",\n\t\t\tDataPropertyName = "Status",\n\t\t\tReadOnly = true,\n\t\t\tWidth = 60\n\t\t};\n\t\tDataGridViewTextBoxColumn colOdbPath = new DataGridViewTextBoxColumn\n\t\t{\n\t\t\tName = "OdbPath",\n\t\t\tHeaderText = "ODB 文件",\n\t\t\tDataPropertyName = "OdbPath",\n\t\t\tReadOnly = true,\n\t\t\tWidth = 260\n\t\t};', 1)
c = c.replace('dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5', 'dataGridViewTextBoxColumn4, colOdbPath, dataGridViewTextBoxColumn5', 1)
c = c.replace('Name = "OutputDir",\n\t\t\tHeaderText = "输出路径",\n\t\t\tDataPropertyName = "OutputDir",\n\t\t\tVisible = false', 'Name = "OutputDir",\n\t\t\tHeaderText = "输出路径",\n\t\t\tDataPropertyName = "OutputDir",\n\t\t\tVisible = true,\n\t\t\tWidth = 220', 1)
c = c.replace('this.dgvJobs.MultiSelect = false;', 'this.dgvJobs.MultiSelect = true;')
c = c.replace('new string[9] { "FilePath", "USubPath", "Status", "JobName", "OutputDir", "TaskType", "SolverType", "OldJobName" }', 'new string[9] { "FilePath", "USubPath", "Status", "OdbPath", "JobName", "OutputDir", "TaskType", "SolverType", "OldJobName" }', 1)
c = c.replace('作者：陈思达      版本：V11', '作者：Cui Davis      版本：V01', 1)
c = c.replace('\t\t\t\tif (Operators.CompareString(jobItem.Status, "等待", TextCompare: false) == 0 || Operators.CompareString(jobItem.Status, "已终止", TextCompare: false) == 0)\n\t\t\t\t{\n\t\t\t\t\tRemoveMenuItem.Enabled = true;', '\t\t\t\tRemoveMenuItem.Enabled = true;\n\t\t\t\tif (Operators.CompareString(jobItem.Status, "等待", TextCompare: false) == 0 || Operators.CompareString(jobItem.Status, "已终止", TextCompare: false) == 0)\n\t\t\t\t{', 1)
c = c.replace('bool flag = false;\n\t\tif (!MySettingsProperty.Settings.ShutdownAfterCompletion)', 'if (!MySettingsProperty.Settings.ShutdownAfterCompletion)', 1)
c = c.replace('public Func<JobItem, bool> _0024I1;', 'public Func<JobItem, bool> _0024I1 = null!;', 1)
old_wd = '\t\t\tstring text = jobItem.OutputDir?.Trim();\n\t\t\tif (string.IsNullOrEmpty(text) || !Directory.Exists(text))\n\t\t\t{\n\t\t\t\ttext = Path.GetDirectoryName(jobItem.FilePath);\n\t\t\t}'
c = c.replace(old_wd, old_wd + '\n\t\t\tstring wd = MySettingsProperty.Settings.WorkingDirectory;\n\t\t\tif (!string.IsNullOrEmpty(wd) && Directory.Exists(wd))\n\t\t\t{\n\t\t\t\ttext = wd;\n\t\t\t\tjobItem._OutputDir = wd;\n\t\t\t}', 1)

# 4. RunPostProcess method before LogFinalSummary
rp = ('\t\tprivate void RunPostProcess(string odbPath)\n'
'\t\t{\n'
'\t\t\ttry\n'
'\t\t\t{\n'
'\t\t\t\tstring batPath = MySettingsProperty.Settings.PostProcessBatPath;\n'
'\t\t\t\tif (string.IsNullOrEmpty(batPath) || !File.Exists(batPath))\n'
'\t\t\t\t\tbatPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"python\\run_postprocess.bat");\n'
'\t\t\t\tif (!File.Exists(batPath)) { AppendLog("[Post] bat not found: " + batPath); return; }\n'
'\t\t\t\tstring configCsv = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"result_config.csv");\n'
'\t\t\t\tstring args = "--odb \\"" + odbPath + "\\" --config \\"" + configCsv + "\\"";\n'
'\t\t\t\tAppendLog("[Post] ODB: " + Path.GetFileName(odbPath));\n'
'\t\t\t\tTask.Run(() =>\n'
'\t\t\t\t{\n'
'\t\t\t\t\ttry\n'
'\t\t\t\t\t{\n'
'\t\t\t\t\t\tusing (Process p = new Process())\n'
'\t\t\t\t\t\t{\n'
'\t\t\t\t\t\t\tp.StartInfo = new ProcessStartInfo(batPath, args)\n'
'\t\t\t\t\t\t\t{\n'
'\t\t\t\t\t\t\t\tUseShellExecute = false, CreateNoWindow = true,\n'
'\t\t\t\t\t\t\t\tRedirectStandardOutput = true, RedirectStandardError = true,\n'
'\t\t\t\t\t\t\t\tStandardOutputEncoding = System.Text.Encoding.UTF8,\n'
'\t\t\t\t\t\t\t\tStandardErrorEncoding = System.Text.Encoding.UTF8\n'
'\t\t\t\t\t\t\t};\n'
'\t\t\t\t\t\t\tp.OutputDataReceived += (s, e) => { if (!string.IsNullOrEmpty(e.Data)) SafeInvoke(() => AppendLog(e.Data)); };\n'
'\t\t\t\t\t\t\tp.ErrorDataReceived += (s, e) => { if (!string.IsNullOrEmpty(e.Data)) SafeInvoke(() => AppendLog("[Post] " + e.Data)); };\n'
'\t\t\t\t\t\t\tp.Start(); p.BeginOutputReadLine(); p.BeginErrorReadLine();\n'
'\t\t\t\t\t\t\tp.WaitForExit(300000);\n'
'\t\t\t\t\t\t\tSafeInvoke(() => AppendLog("[Post] Done (exit " + p.ExitCode + ")"));\n'
'\t\t\t\t\t\t}\n'
'\t\t\t\t\t}\n'
'\t\t\t\t\tcatch (Exception ex2) { SafeInvoke(() => AppendLog("[Post] err: " + ex2.Message)); }\n'
'\t\t\t\t});\n'
'\t\t\t}\n'
'\t\t\tcatch (Exception ex) { AppendLog("[Post] err: " + ex.Message); }\n'
'\t\t}\n')
c = c.replace('\t\tprivate void LogFinalSummary()', rp + '\n\t\tprivate void LogFinalSummary()', 1)

# 5. PP call in MonitorJob
old_pp = ('\t\t\t\tif (!isStopping)\n'
'\t\t\t\t{\n'
'\t\t\t\t\tstring status = (flag ? "完成" : "失败");\n'
'\t\t\t\t\tUpdateJobStatus(CS_0024_003C_003E8__locals1._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_jobIndex, status);\n'
'\t\t\t\t}')
new_pp = ('\t\t\t\tif (!isStopping)\n'
'\t\t\t\t{\n'
'\t\t\t\t\tstring status = (flag ? "完成" : "失败");\n'
'\t\t\t\t\tUpdateJobStatus(CS_0024_003C_003E8__locals1._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_jobIndex, status);\n'
'\t\t\t\t\tif (flag && MySettingsProperty.Settings.EnablePostProcess)\n'
'\t\t\t\t\t{\n'
'\t\t\t\t\t\tRunPostProcess(jobList[CS_0024_003C_003E8__locals1._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_jobIndex].OdbPath);\n'
'\t\t\t\t\t}\n'
'\t\t\t\t}')
c = c.replace(old_pp, new_pp, 1)

# 6. Batch report after LogFinalSummary
report = ('\n\t\t\t\tif (MySettingsProperty.Settings.EnablePostProcess)\n'
'\t\t\t\t{\n'
'\t\t\t\t\ttry {\n'
'\t\t\t\t\t\tstring batPath2 = MySettingsProperty.Settings.PostProcessBatPath;\n'
'\t\t\t\t\t\tif (string.IsNullOrEmpty(batPath2) || !File.Exists(batPath2))\n'
'\t\t\t\t\t\t\tbatPath2 = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"python\\run_postprocess.bat");\n'
'\t\t\t\t\t\tif (File.Exists(batPath2)) {\n'
'\t\t\t\t\t\t\tstring outputDir = System.IO.Path.GetDirectoryName(jobList[0].FilePath) ?? ".";\n'
'\t\t\t\t\t\t\tstring reportArgs = "--report --results-dir \\"" + outputDir + "\\"";\n'
'\t\t\t\t\t\t\tAppendLog("[Post] Report: " + outputDir);\n'
'\t\t\t\t\t\t\tTask.Run(() => {\n'
'\t\t\t\t\t\t\t\ttry {\n'
'\t\t\t\t\t\t\t\t\tusing (Process pr = new Process()) {\n'
'\t\t\t\t\t\t\t\t\t\tpr.StartInfo = new ProcessStartInfo(batPath2, reportArgs) { UseShellExecute = false, CreateNoWindow = true, RedirectStandardOutput = true, RedirectStandardError = true, StandardOutputEncoding = System.Text.Encoding.UTF8, StandardErrorEncoding = System.Text.Encoding.UTF8 };\n'
'\t\t\t\t\t\t\t\t\t\tpr.OutputDataReceived += (s, e) => { if (!string.IsNullOrEmpty(e.Data)) SafeInvoke(() => AppendLog(e.Data)); };\n'
'\t\t\t\t\t\t\t\t\t\tpr.ErrorDataReceived += (s, e) => { if (!string.IsNullOrEmpty(e.Data)) SafeInvoke(() => AppendLog("[Rpt] " + e.Data)); };\n'
'\t\t\t\t\t\t\t\t\t\tpr.Start(); pr.BeginOutputReadLine(); pr.BeginErrorReadLine();\n'
'\t\t\t\t\t\t\t\t\t\tpr.WaitForExit(120000);\n'
'\t\t\t\t\t\t\t\t\t\tSafeInvoke(() => AppendLog("[Post] Report done (exit " + pr.ExitCode + ")"));\n'
'\t\t\t\t\t\t\t\t\t}\n'
'\t\t\t\t\t\t\t\t} catch (Exception ex3) { SafeInvoke(() => AppendLog("[Post] Report err: " + ex3.Message)); }\n'
'\t\t\t\t\t\t\t});\n'
'\t\t\t\t\t\t}\n'
'\t\t\t\t\t} catch (Exception ex2) { AppendLog("[Post] Report err: " + ex2.Message); }\n'
'\t\t\t\t}')
c = c.replace('\t\t\t\tLogFinalSummary();', '\t\t\t\tLogFinalSummary();' + report, 1)

with open(path, 'w', encoding='utf-8') as f:
    f.write(c)
print('All patches applied. Lines:', c.count('\n'))
