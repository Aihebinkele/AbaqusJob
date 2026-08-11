"""Add WorkDirMenu to Form1.cs safely."""

path = r'F:\FTP\培训教程\Abaqus\abaqus插件\JOB\Python版\Abaqus_Job\AbaqusJob\Form1.cs'
with open(path, 'r', encoding='utf-8') as f:
    c = f.read()

# 1. Add partial keyword to class
c = c.replace('public class Form1 : Form', 'public partial class Form1 : Form', 1)

# 2. Add _WorkDirMenu field after _XTSMenu
c = c.replace(
    '\t\tprivate ToolStripMenuItem _XTSMenu;',
    '\t\tprivate ToolStripMenuItem _XTSMenu;\n\t\tprivate ToolStripMenuItem _WorkDirMenu;', 1)

# 3. Add WorkDirMenu creation + click wiring in InitializeComponent
c = c.replace(
    'this.XTSMenu = new System.Windows.Forms.ToolStripMenuItem();',
    'this.XTSMenu = new System.Windows.Forms.ToolStripMenuItem();\n\t\t\tthis.WorkDirMenu = new System.Windows.Forms.ToolStripMenuItem();\n\t\t\tthis.WorkDirMenu.Click += WorkDirMenu_Click;', 1)

# 4. Add to File dropdown (change count from 5 to 6)
c = c.replace(
    'new System.Windows.Forms.ToolStripItem[5] { this.NTSMenu, this.OTSMenu, this.添加包含子程序的任务ToolStripMenuItem, this.toolStripSeparator, this.XTSMenu }',
    'new System.Windows.Forms.ToolStripItem[6] { this.NTSMenu, this.OTSMenu, this.添加包含子程序的任务ToolStripMenuItem, this.toolStripSeparator, this.WorkDirMenu, this.XTSMenu }', 1)

# 5. Add properties
c = c.replace(
    'this.XTSMenu.Text = "退出(&X)";',
    'this.XTSMenu.Text = "退出(&X)";\n\t\t\tthis.WorkDirMenu.Name = "WorkDirMenu";\n\t\t\tthis.WorkDirMenu.Size = new System.Drawing.Size(207, 22);\n\t\t\tthis.WorkDirMenu.Text = "设置工作目录(&W)...";', 1)

with open(path, 'w', encoding='utf-8') as f:
    f.write(c)
print('WorkDirMenu UI added to Form1.cs')
