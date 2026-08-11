using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AbaqusJob.My;
using Microsoft.VisualBasic.CompilerServices;

namespace AbaqusJob;

[DesignerGenerated]
public class SettingsForm : Form
{
	public delegate void RequestCleanLockFilesEventHandler();

	private IContainer components = null!;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnBrowse")]
	private Button _btnBrowse;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnOK")]
	private Button _btnOK;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnCancel")]
	private Button _btnCancel;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnAutoDetect")]
	private Button _btnAutoDetect;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnCleanLckNow")]
	private Button _btnCleanLckNow;

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPath")]
	internal virtual TextBox txtPath
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnBrowse
	{
		[CompilerGenerated]
		get
		{
			return _btnBrowse;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnBrowse_Click;
			Button button = _btnBrowse;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnBrowse = value;
			button = _btnBrowse;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button btnOK
	{
		[CompilerGenerated]
		get
		{
			return _btnOK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnOK_Click;
			Button button = _btnOK;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnOK = value;
			button = _btnOK;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button btnCancel
	{
		[CompilerGenerated]
		get
		{
			return _btnCancel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnCancel_Click;
			Button button = _btnCancel;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnCancel = value;
			button = _btnCancel;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	internal virtual Button btnAutoDetect
	{
		[CompilerGenerated]
		get
		{
			return _btnAutoDetect;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnAutoDetect_Click;
			Button button = _btnAutoDetect;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnAutoDetect = value;
			button = _btnAutoDetect;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("chkCleanBeforeStart")]
	internal virtual CheckBox chkCleanBeforeStart
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkCleanAfterStop")]
	internal virtual CheckBox chkCleanAfterStop
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnCleanLckNow
	{
		[CompilerGenerated]
		get
		{
			return _btnCleanLckNow;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnCleanLckNow_Click;
			Button button = _btnCleanLckNow;
			if (button != null)
			{
				button.Click -= value2;
			}
			_btnCleanLckNow = value;
			button = _btnCleanLckNow;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("GroupBox2")]
	internal virtual GroupBox GroupBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("radRenameByForName")]
	internal virtual RadioButton radRenameByForName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("radRenameByIndex")]
	internal virtual RadioButton radRenameByIndex
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox3")]
	internal virtual GroupBox GroupBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkCol_SolverType")]
	internal virtual CheckBox chkCol_SolverType
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkCol_TaskType")]
	internal virtual CheckBox chkCol_TaskType
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkCol_OldJobName")]
	internal virtual CheckBox chkCol_OldJobName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkCol_OutputDir")]
	internal virtual CheckBox chkCol_OutputDir
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkCol_JobName")]
	internal virtual CheckBox chkCol_JobName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkCol_Status")]
	internal virtual CheckBox chkCol_Status
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkCol_USubPath")]
	internal virtual CheckBox chkCol_USubPath
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkCol_FilePath")]
	internal virtual CheckBox chkCol_FilePath
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("nudMemoryLimit")]
	internal virtual NumericUpDown nudMemoryLimit
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox4")]
	internal virtual GroupBox GroupBox4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox5")]
	internal virtual GroupBox GroupBox5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkShutdown")]
	internal virtual CheckBox chkShutdown
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkPostProcess")]
		internal virtual CheckBox chkPostProcess
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox6")]
	internal virtual GroupBox GroupBox6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtCompletionKeyword")]
	internal virtual TextBox txtCompletionKeyword
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox7")]
	internal virtual GroupBox GroupBox7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkScrollOnTabSwitch")]
	internal virtual CheckBox chkScrollOnTabSwitch
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkScrollOnUpdate")]
	internal virtual CheckBox chkScrollOnUpdate
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox8")]
	internal virtual GroupBox GroupBox8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkRestart")]
	internal virtual CheckBox chkRestart
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("chkRecover")]
	internal virtual CheckBox chkRecover
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public event RequestCleanLockFilesEventHandler RequestCleanLockFiles;

	public SettingsForm()
	{
		base.Load += SettingsForm_Load;
		InitializeComponent();
		try { base.Icon = System.Drawing.Icon.ExtractAssociatedIcon(System.Windows.Forms.Application.ExecutablePath); } catch { }
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbaqusJob.SettingsForm));
		this.Label1 = new System.Windows.Forms.Label();
		this.txtPath = new System.Windows.Forms.TextBox();
		this.btnBrowse = new System.Windows.Forms.Button();
		this.btnOK = new System.Windows.Forms.Button();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnAutoDetect = new System.Windows.Forms.Button();
		this.chkCleanBeforeStart = new System.Windows.Forms.CheckBox();
		this.GroupBox1 = new System.Windows.Forms.GroupBox();
		this.btnCleanLckNow = new System.Windows.Forms.Button();
		this.chkCleanAfterStop = new System.Windows.Forms.CheckBox();
		this.GroupBox2 = new System.Windows.Forms.GroupBox();
		this.radRenameByForName = new System.Windows.Forms.RadioButton();
		this.radRenameByIndex = new System.Windows.Forms.RadioButton();
		this.GroupBox3 = new System.Windows.Forms.GroupBox();
		this.chkCol_SolverType = new System.Windows.Forms.CheckBox();
		this.chkCol_TaskType = new System.Windows.Forms.CheckBox();
		this.chkCol_OldJobName = new System.Windows.Forms.CheckBox();
		this.chkCol_OutputDir = new System.Windows.Forms.CheckBox();
		this.chkCol_JobName = new System.Windows.Forms.CheckBox();
		this.chkCol_Status = new System.Windows.Forms.CheckBox();
		this.chkCol_USubPath = new System.Windows.Forms.CheckBox();
		this.chkCol_FilePath = new System.Windows.Forms.CheckBox();
		this.nudMemoryLimit = new System.Windows.Forms.NumericUpDown();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.GroupBox4 = new System.Windows.Forms.GroupBox();
		this.GroupBox5 = new System.Windows.Forms.GroupBox();
			this.chkPostProcess = new System.Windows.Forms.CheckBox();
		this.chkShutdown = new System.Windows.Forms.CheckBox();
		this.GroupBox6 = new System.Windows.Forms.GroupBox();
		this.txtCompletionKeyword = new System.Windows.Forms.TextBox();
		this.GroupBox7 = new System.Windows.Forms.GroupBox();
		this.chkScrollOnUpdate = new System.Windows.Forms.CheckBox();
		this.chkScrollOnTabSwitch = new System.Windows.Forms.CheckBox();
		this.GroupBox8 = new System.Windows.Forms.GroupBox();
		this.chkRestart = new System.Windows.Forms.CheckBox();
		this.chkRecover = new System.Windows.Forms.CheckBox();
		this.GroupBox1.SuspendLayout();
		this.GroupBox2.SuspendLayout();
		this.GroupBox3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nudMemoryLimit).BeginInit();
		this.GroupBox4.SuspendLayout();
		this.GroupBox5.SuspendLayout();
		this.GroupBox6.SuspendLayout();
		this.GroupBox7.SuspendLayout();
		this.GroupBox8.SuspendLayout();
		base.SuspendLayout();
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(34, 15);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(65, 12);
		this.Label1.TabIndex = 0;
		this.Label1.Text = "Abaqus路径";
		this.txtPath.Location = new System.Drawing.Point(123, 11);
		this.txtPath.Name = "txtPath";
		this.txtPath.Size = new System.Drawing.Size(226, 21);
		this.txtPath.TabIndex = 1;
		this.btnBrowse.Location = new System.Drawing.Point(369, 10);
		this.btnBrowse.Name = "btnBrowse";
		this.btnBrowse.Size = new System.Drawing.Size(59, 23);
		this.btnBrowse.TabIndex = 2;
		this.btnBrowse.Text = "浏览...";
		this.btnBrowse.UseVisualStyleBackColor = true;
		this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
		this.btnOK.Location = new System.Drawing.Point(336, 497);
		this.btnOK.Name = "btnOK";
		this.btnOK.Size = new System.Drawing.Size(75, 23);
		this.btnOK.TabIndex = 3;
		this.btnOK.Text = "确定";
		this.btnOK.UseVisualStyleBackColor = true;
		this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.btnCancel.Location = new System.Drawing.Point(434, 497);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(75, 23);
		this.btnCancel.TabIndex = 4;
		this.btnCancel.Text = "取消";
		this.btnCancel.UseVisualStyleBackColor = true;
		this.btnAutoDetect.Location = new System.Drawing.Point(434, 10);
		this.btnAutoDetect.Name = "btnAutoDetect";
		this.btnAutoDetect.Size = new System.Drawing.Size(75, 23);
		this.btnAutoDetect.TabIndex = 5;
		this.btnAutoDetect.Text = "自动检索";
		this.btnAutoDetect.UseVisualStyleBackColor = true;
		this.chkCleanBeforeStart.AutoSize = true;
		this.chkCleanBeforeStart.Checked = true;
		this.chkCleanBeforeStart.CheckState = System.Windows.Forms.CheckState.Checked;
		this.chkCleanBeforeStart.Location = new System.Drawing.Point(11, 29);
		this.chkCleanBeforeStart.Name = "chkCleanBeforeStart";
		this.chkCleanBeforeStart.Size = new System.Drawing.Size(84, 16);
		this.chkCleanBeforeStart.TabIndex = 6;
		this.chkCleanBeforeStart.Text = "开始前清理";
		this.chkCleanBeforeStart.UseVisualStyleBackColor = true;
		this.GroupBox1.Controls.Add(this.btnCleanLckNow);
		this.GroupBox1.Controls.Add(this.chkCleanAfterStop);
		this.GroupBox1.Controls.Add(this.chkCleanBeforeStart);
		this.GroupBox1.Location = new System.Drawing.Point(36, 77);
		this.GroupBox1.Name = "GroupBox1";
		this.GroupBox1.Size = new System.Drawing.Size(112, 133);
		this.GroupBox1.TabIndex = 7;
		this.GroupBox1.TabStop = false;
		this.GroupBox1.Text = "清理lck文件";
		this.btnCleanLckNow.Location = new System.Drawing.Point(11, 95);
		this.btnCleanLckNow.Name = "btnCleanLckNow";
		this.btnCleanLckNow.Size = new System.Drawing.Size(84, 23);
		this.btnCleanLckNow.TabIndex = 8;
		this.btnCleanLckNow.Text = "立即清理";
		this.btnCleanLckNow.UseVisualStyleBackColor = true;
		this.chkCleanAfterStop.AutoSize = true;
		this.chkCleanAfterStop.Checked = true;
		this.chkCleanAfterStop.CheckState = System.Windows.Forms.CheckState.Checked;
		this.chkCleanAfterStop.Location = new System.Drawing.Point(11, 62);
		this.chkCleanAfterStop.Name = "chkCleanAfterStop";
		this.chkCleanAfterStop.Size = new System.Drawing.Size(84, 16);
		this.chkCleanAfterStop.TabIndex = 7;
		this.chkCleanAfterStop.Text = "终止后清理";
		this.chkCleanAfterStop.UseVisualStyleBackColor = true;
		this.GroupBox2.Controls.Add(this.radRenameByForName);
		this.GroupBox2.Controls.Add(this.radRenameByIndex);
		this.GroupBox2.Location = new System.Drawing.Point(181, 77);
		this.GroupBox2.Name = "GroupBox2";
		this.GroupBox2.Size = new System.Drawing.Size(168, 133);
		this.GroupBox2.TabIndex = 8;
		this.GroupBox2.TabStop = false;
		this.GroupBox2.Text = "同名inp任务命名方式";
		this.radRenameByForName.AutoSize = true;
		this.radRenameByForName.Location = new System.Drawing.Point(15, 61);
		this.radRenameByForName.Name = "radRenameByForName";
		this.radRenameByForName.Size = new System.Drawing.Size(137, 16);
		this.radRenameByForName.TabIndex = 1;
		this.radRenameByForName.Text = "inp文件名+For文件名";
		this.radRenameByForName.UseVisualStyleBackColor = true;
		this.radRenameByIndex.AutoSize = true;
		this.radRenameByIndex.Checked = true;
		this.radRenameByIndex.Location = new System.Drawing.Point(15, 28);
		this.radRenameByIndex.Name = "radRenameByIndex";
		this.radRenameByIndex.Size = new System.Drawing.Size(107, 16);
		this.radRenameByIndex.TabIndex = 0;
		this.radRenameByIndex.TabStop = true;
		this.radRenameByIndex.Text = "inp文件名+序号";
		this.radRenameByIndex.UseVisualStyleBackColor = true;
		this.GroupBox3.Controls.Add(this.chkCol_SolverType);
		this.GroupBox3.Controls.Add(this.chkCol_TaskType);
		this.GroupBox3.Controls.Add(this.chkCol_OldJobName);
		this.GroupBox3.Controls.Add(this.chkCol_OutputDir);
		this.GroupBox3.Controls.Add(this.chkCol_JobName);
		this.GroupBox3.Controls.Add(this.chkCol_Status);
		this.GroupBox3.Controls.Add(this.chkCol_USubPath);
		this.GroupBox3.Controls.Add(this.chkCol_FilePath);
		this.GroupBox3.Location = new System.Drawing.Point(377, 77);
		this.GroupBox3.Name = "GroupBox3";
		this.GroupBox3.Size = new System.Drawing.Size(132, 209);
		this.GroupBox3.TabIndex = 9;
		this.GroupBox3.TabStop = false;
		this.GroupBox3.Text = "任务列表列显示";
		this.chkCol_SolverType.AutoSize = true;
		this.chkCol_SolverType.Location = new System.Drawing.Point(16, 183);
		this.chkCol_SolverType.Name = "chkCol_SolverType";
		this.chkCol_SolverType.Size = new System.Drawing.Size(84, 16);
		this.chkCol_SolverType.TabIndex = 7;
		this.chkCol_SolverType.Text = "求解器类型";
		this.chkCol_SolverType.UseVisualStyleBackColor = true;
		this.chkCol_TaskType.AutoSize = true;
		this.chkCol_TaskType.Location = new System.Drawing.Point(16, 161);
		this.chkCol_TaskType.Name = "chkCol_TaskType";
		this.chkCol_TaskType.Size = new System.Drawing.Size(72, 16);
		this.chkCol_TaskType.TabIndex = 6;
		this.chkCol_TaskType.Text = "任务类型";
		this.chkCol_TaskType.UseVisualStyleBackColor = true;
		this.chkCol_OldJobName.AutoSize = true;
		this.chkCol_OldJobName.Location = new System.Drawing.Point(16, 139);
		this.chkCol_OldJobName.Name = "chkCol_OldJobName";
		this.chkCol_OldJobName.Size = new System.Drawing.Size(96, 16);
		this.chkCol_OldJobName.TabIndex = 5;
		this.chkCol_OldJobName.Text = "重启动文件名";
		this.chkCol_OldJobName.UseVisualStyleBackColor = true;
		this.chkCol_OutputDir.AutoSize = true;
		this.chkCol_OutputDir.Location = new System.Drawing.Point(16, 117);
		this.chkCol_OutputDir.Name = "chkCol_OutputDir";
		this.chkCol_OutputDir.Size = new System.Drawing.Size(72, 16);
		this.chkCol_OutputDir.TabIndex = 4;
		this.chkCol_OutputDir.Text = "输出路径";
		this.chkCol_OutputDir.UseVisualStyleBackColor = true;
		this.chkCol_JobName.AutoSize = true;
		this.chkCol_JobName.Location = new System.Drawing.Point(16, 95);
		this.chkCol_JobName.Name = "chkCol_JobName";
		this.chkCol_JobName.Size = new System.Drawing.Size(72, 16);
		this.chkCol_JobName.TabIndex = 3;
		this.chkCol_JobName.Text = "任务名称";
		this.chkCol_JobName.UseVisualStyleBackColor = true;
		this.chkCol_Status.AutoSize = true;
		this.chkCol_Status.Checked = true;
		this.chkCol_Status.CheckState = System.Windows.Forms.CheckState.Checked;
		this.chkCol_Status.Location = new System.Drawing.Point(16, 73);
		this.chkCol_Status.Name = "chkCol_Status";
		this.chkCol_Status.Size = new System.Drawing.Size(48, 16);
		this.chkCol_Status.TabIndex = 2;
		this.chkCol_Status.Text = "状态";
		this.chkCol_Status.UseVisualStyleBackColor = true;
		this.chkCol_USubPath.AutoSize = true;
		this.chkCol_USubPath.Checked = true;
		this.chkCol_USubPath.CheckState = System.Windows.Forms.CheckState.Checked;
		this.chkCol_USubPath.Location = new System.Drawing.Point(16, 51);
		this.chkCol_USubPath.Name = "chkCol_USubPath";
		this.chkCol_USubPath.Size = new System.Drawing.Size(84, 16);
		this.chkCol_USubPath.TabIndex = 1;
		this.chkCol_USubPath.Text = "子程序文件";
		this.chkCol_USubPath.UseVisualStyleBackColor = true;
		this.chkCol_FilePath.AutoSize = true;
		this.chkCol_FilePath.Checked = true;
		this.chkCol_FilePath.CheckState = System.Windows.Forms.CheckState.Checked;
		this.chkCol_FilePath.Location = new System.Drawing.Point(16, 29);
		this.chkCol_FilePath.Name = "chkCol_FilePath";
		this.chkCol_FilePath.Size = new System.Drawing.Size(66, 16);
		this.chkCol_FilePath.TabIndex = 0;
		this.chkCol_FilePath.Text = "inp文件";
		this.chkCol_FilePath.UseVisualStyleBackColor = true;
		this.nudMemoryLimit.Font = new System.Drawing.Font("等线", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
		this.nudMemoryLimit.Increment = new decimal(new int[4] { 5, 0, 0, 0 });
		this.nudMemoryLimit.Location = new System.Drawing.Point(74, 20);
		this.nudMemoryLimit.Minimum = new decimal(new int[4] { 10, 0, 0, 0 });
		this.nudMemoryLimit.Name = "nudMemoryLimit";
		this.nudMemoryLimit.Size = new System.Drawing.Size(55, 21);
		this.nudMemoryLimit.TabIndex = 10;
		this.nudMemoryLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.nudMemoryLimit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
		this.nudMemoryLimit.Value = new decimal(new int[4] { 80, 0, 0, 0 });
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(15, 24);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(53, 12);
		this.Label2.TabIndex = 11;
		this.Label2.Text = "内存控制";
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("等线", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
		this.Label3.Location = new System.Drawing.Point(132, 22);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(16, 17);
		this.Label3.TabIndex = 11;
		this.Label3.Text = "%";
		this.GroupBox4.Controls.Add(this.nudMemoryLimit);
		this.GroupBox4.Controls.Add(this.Label3);
		this.GroupBox4.Controls.Add(this.Label2);
		this.GroupBox4.Location = new System.Drawing.Point(181, 228);
		this.GroupBox4.Name = "GroupBox4";
		this.GroupBox4.Size = new System.Drawing.Size(168, 58);
		this.GroupBox4.TabIndex = 12;
		this.GroupBox4.TabStop = false;
			this.GroupBox5.Controls.Add(this.chkPostProcess);
		this.GroupBox4.Text = "求解器设置";
		this.GroupBox5.Controls.Add(this.chkShutdown);
		this.GroupBox5.Location = new System.Drawing.Point(36, 228);
		this.GroupBox5.Name = "GroupBox5";
		this.GroupBox5.Size = new System.Drawing.Size(140, 80);
		this.GroupBox5.TabIndex = 13;
		this.GroupBox5.TabStop = false;
		this.GroupBox5.Text = "其他设置";
		this.chkShutdown.AutoSize = true;
		this.chkShutdown.Location = new System.Drawing.Point(11, 24);
		this.chkShutdown.Name = "chkShutdown";
		this.chkShutdown.Size = new System.Drawing.Size(84, 16);
			this.chkPostProcess.AutoSize = true;
			this.chkPostProcess.Location = new System.Drawing.Point(11, 46);
			this.chkPostProcess.Name = "chkPostProcess";
			this.chkPostProcess.Size = new System.Drawing.Size(96, 16);
			this.chkPostProcess.TabIndex = 1;
			this.chkPostProcess.Text = "后处理(ODB)";
			this.chkPostProcess.UseVisualStyleBackColor = true;
		this.chkShutdown.TabIndex = 0;
		this.chkShutdown.Text = "完成后关机";
		this.chkShutdown.UseVisualStyleBackColor = true;
		this.GroupBox6.Controls.Add(this.txtCompletionKeyword);
		this.GroupBox6.Location = new System.Drawing.Point(36, 409);
		this.GroupBox6.Name = "GroupBox6";
		this.GroupBox6.Size = new System.Drawing.Size(313, 56);
		this.GroupBox6.TabIndex = 14;
		this.GroupBox6.TabStop = false;
		this.GroupBox6.Text = "sta完成判定标识";
		this.txtCompletionKeyword.Location = new System.Drawing.Point(11, 19);
		this.txtCompletionKeyword.Name = "txtCompletionKeyword";
		this.txtCompletionKeyword.Size = new System.Drawing.Size(286, 21);
		this.txtCompletionKeyword.TabIndex = 0;
		this.GroupBox7.Controls.Add(this.chkScrollOnTabSwitch);
		this.GroupBox7.Controls.Add(this.chkScrollOnUpdate);
		this.GroupBox7.Location = new System.Drawing.Point(36, 308);
		this.GroupBox7.Name = "GroupBox7";
		this.GroupBox7.Size = new System.Drawing.Size(112, 73);
		this.GroupBox7.TabIndex = 15;
		this.GroupBox7.TabStop = false;
		this.GroupBox7.Text = "监视器设置";
		this.chkScrollOnUpdate.AutoSize = true;
		this.chkScrollOnUpdate.Checked = true;
		this.chkScrollOnUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
		this.chkScrollOnUpdate.Location = new System.Drawing.Point(16, 20);
		this.chkScrollOnUpdate.Name = "chkScrollOnUpdate";
		this.chkScrollOnUpdate.Size = new System.Drawing.Size(84, 16);
		this.chkScrollOnUpdate.TabIndex = 0;
		this.chkScrollOnUpdate.Text = "更新时滚动";
		this.chkScrollOnUpdate.UseVisualStyleBackColor = true;
		this.chkScrollOnTabSwitch.AutoSize = true;
		this.chkScrollOnTabSwitch.Checked = true;
		this.chkScrollOnTabSwitch.CheckState = System.Windows.Forms.CheckState.Checked;
		this.chkScrollOnTabSwitch.Location = new System.Drawing.Point(16, 42);
		this.chkScrollOnTabSwitch.Name = "chkScrollOnTabSwitch";
		this.chkScrollOnTabSwitch.Size = new System.Drawing.Size(84, 16);
		this.chkScrollOnTabSwitch.TabIndex = 1;
		this.chkScrollOnTabSwitch.Text = "翻页时滚动";
		this.chkScrollOnTabSwitch.UseVisualStyleBackColor = true;
		this.GroupBox8.Controls.Add(this.chkRecover);
		this.GroupBox8.Controls.Add(this.chkRestart);
		this.GroupBox8.Location = new System.Drawing.Point(181, 308);
		this.GroupBox8.Name = "GroupBox8";
		this.GroupBox8.Size = new System.Drawing.Size(168, 73);
		this.GroupBox8.TabIndex = 16;
		this.GroupBox8.TabStop = false;
		this.GroupBox8.Text = "重启动设置";
		this.chkRestart.AutoSize = true;
		this.chkRestart.Location = new System.Drawing.Point(15, 20);
		this.chkRestart.Name = "chkRestart";
		this.chkRestart.Size = new System.Drawing.Size(126, 16);
		this.chkRestart.TabIndex = 0;
		this.chkRestart.Text = "使用Restart关键字";
		this.chkRestart.UseVisualStyleBackColor = true;
		this.chkRecover.AutoSize = true;
		this.chkRecover.Location = new System.Drawing.Point(15, 42);
		this.chkRecover.Name = "chkRecover";
		this.chkRecover.Size = new System.Drawing.Size(126, 16);
		this.chkRecover.TabIndex = 1;
		this.chkRecover.Text = "使用Recover关键字";
		this.chkRecover.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(534, 542);
		base.Controls.Add(this.GroupBox8);
		base.Controls.Add(this.GroupBox7);
		base.Controls.Add(this.GroupBox6);
		base.Controls.Add(this.GroupBox5);
		base.Controls.Add(this.GroupBox4);
		base.Controls.Add(this.GroupBox3);
		base.Controls.Add(this.GroupBox2);
		base.Controls.Add(this.GroupBox1);
		base.Controls.Add(this.btnAutoDetect);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.btnOK);
		base.Controls.Add(this.btnBrowse);
		base.Controls.Add(this.txtPath);
		base.Controls.Add(this.Label1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "SettingsForm";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "设置";
		this.GroupBox1.ResumeLayout(false);
		this.GroupBox1.PerformLayout();
		this.GroupBox2.ResumeLayout(false);
		this.GroupBox2.PerformLayout();
		this.GroupBox3.ResumeLayout(false);
		this.GroupBox3.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nudMemoryLimit).EndInit();
		this.GroupBox4.ResumeLayout(false);
		this.GroupBox4.PerformLayout();
		this.GroupBox5.ResumeLayout(false);
		this.GroupBox5.PerformLayout();
		this.GroupBox6.ResumeLayout(false);
		this.GroupBox6.PerformLayout();
		this.GroupBox7.ResumeLayout(false);
		this.GroupBox7.PerformLayout();
		this.GroupBox8.ResumeLayout(false);
		this.GroupBox8.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void SettingsForm_Load(object sender, EventArgs e)
	{
		txtPath.Text = MySettingsProperty.Settings.AbaqusPath;
		chkCleanBeforeStart.Checked = MySettingsProperty.Settings.CleanLckBeforeStart;
		chkCleanAfterStop.Checked = MySettingsProperty.Settings.CleanLckAfterStop;
		chkShutdown.Checked = MySettingsProperty.Settings.ShutdownAfterCompletion;
			chkPostProcess.Checked = MySettingsProperty.Settings.EnablePostProcess;
		txtCompletionKeyword.Text = MySettingsProperty.Settings.CompletionKeyword;
		chkScrollOnUpdate.Checked = MySettingsProperty.Settings.AutoScrollOnUpdate;
		chkScrollOnTabSwitch.Checked = MySettingsProperty.Settings.AutoScrollOnTabSwitch;
		chkRestart.Checked = MySettingsProperty.Settings.UseRestart;
		chkRecover.Checked = MySettingsProperty.Settings.UseRecover;
		string inpRenameMode = MySettingsProperty.Settings.InpRenameMode;
		if (Operators.CompareString(inpRenameMode, "ByForFileName", TextCompare: false) == 0)
		{
			radRenameByForName.Checked = true;
		}
		else
		{
			radRenameByIndex.Checked = true;
		}
		int memoryLimit = MySettingsProperty.Settings.MemoryLimit;
		nudMemoryLimit.Value = new decimal(memoryLimit);
		string[] configurableColumns = Form1.ConfigurableColumns;
		foreach (string arg in configurableColumns)
		{
			CheckBox checkBox = (CheckBox)base.Controls.Find($"chkCol_{arg}", searchAllChildren: true).FirstOrDefault();
			if (checkBox != null)
			{
				checkBox.Checked = Conversions.ToBoolean(MySettingsProperty.Settings[$"ShowColumn_{arg}"]);
			}
		}
	}

	private void btnCleanLckNow_Click(object sender, EventArgs e)
	{
		DialogResult dialogResult = MessageBox.Show("确定要立即删除所有任务对应的 .lck 锁文件吗？\r\n此操作不可逆。", "立即清理锁文件", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
		if (dialogResult == DialogResult.Yes)
		{
			RequestCleanLockFiles?.Invoke();
		}
	}

	private void btnAutoDetect_Click(object sender, EventArgs e)
	{
		string text = FindAbaqusBat();
		if (!string.IsNullOrEmpty(text))
		{
			txtPath.Text = text;
			MessageBox.Show($"已自动检测到 Abaqus 路径：{text}", "检测成功", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		else
		{
			MessageBox.Show("未能在常见位置找到 abaqus.bat。请手动指定路径。", "未找到", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private void btnBrowse_Click(object sender, EventArgs e)
	{
		using OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = "Abaqus 启动文件|abaqus.bat;abaqus.exe|批处理文件 (*.bat)|*.bat|可执行文件 (*.exe)|*.exe|所有文件|*.*";
		openFileDialog.Title = "选择 Abaqus 启动文件（通常为 abaqus.bat）";
		openFileDialog.CheckFileExists = true;
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			txtPath.Text = openFileDialog.FileName;
		}
	}

	private void btnOK_Click(object sender, EventArgs e)
	{
		string text = txtPath.Text?.Trim();
		if (string.IsNullOrWhiteSpace(text))
		{
			MessageBox.Show("路径不能为空。", "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		if (!File.Exists(text))
		{
			DialogResult dialogResult = MessageBox.Show($"指定的路径不存在：{text}" + "\r\n\r\n是否仍要保存此路径？", "路径不存在", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
			if (dialogResult == DialogResult.No)
			{
				return;
			}
		}
		else if (!text.EndsWith("abaqus.bat", StringComparison.OrdinalIgnoreCase) && !text.EndsWith("abaqus.exe", StringComparison.OrdinalIgnoreCase))
		{
			DialogResult dialogResult2 = MessageBox.Show("该文件不是 abaqus.bat 或 abaqus.exe，可能无法正常工作。是否继续？", "文件类型警告", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
			if (dialogResult2 == DialogResult.No)
			{
				return;
			}
		}
		if (radRenameByIndex.Checked)
		{
			MySettingsProperty.Settings.InpRenameMode = "ByIndex";
		}
		else if (radRenameByForName.Checked)
		{
			MySettingsProperty.Settings.InpRenameMode = "ByForFileName";
		}
		MySettingsProperty.Settings.AbaqusPath = text;
		MySettingsProperty.Settings.CleanLckBeforeStart = chkCleanBeforeStart.Checked;
		MySettingsProperty.Settings.CleanLckAfterStop = chkCleanAfterStop.Checked;
		MySettingsProperty.Settings.MemoryLimit = Convert.ToInt32(nudMemoryLimit.Value);
		MySettingsProperty.Settings.ShutdownAfterCompletion = chkShutdown.Checked;
			MySettingsProperty.Settings.EnablePostProcess = chkPostProcess.Checked;
		MySettingsProperty.Settings.CompletionKeyword = txtCompletionKeyword.Text;
		MySettingsProperty.Settings.AutoScrollOnUpdate = chkScrollOnUpdate.Checked;
		MySettingsProperty.Settings.AutoScrollOnTabSwitch = chkScrollOnTabSwitch.Checked;
		MySettingsProperty.Settings.UseRestart = chkRestart.Checked;
		MySettingsProperty.Settings.UseRecover = chkRecover.Checked;
		MySettingsProperty.Settings.Save();
		string[] configurableColumns = Form1.ConfigurableColumns;
		foreach (string arg in configurableColumns)
		{
			CheckBox checkBox = (CheckBox)base.Controls.Find($"chkCol_{arg}", searchAllChildren: true).FirstOrDefault();
			if (checkBox != null)
			{
				MySettingsProperty.Settings[$"ShowColumn_{arg}"] = checkBox.Checked;
			}
		}
		MySettingsProperty.Settings.Save();
		Application.OpenForms.OfType<Form1>().FirstOrDefault()?.RefreshColumnVisibility();
		base.DialogResult = DialogResult.OK;
		Close();
	}

	private string FindAbaqusBat()
	{
		try
		{
			string environmentVariable = Environment.GetEnvironmentVariable("PATH");
			if (!string.IsNullOrEmpty(environmentVariable))
			{
				string[] array = environmentVariable.Split(';');
				foreach (string text in array)
				{
					string text2 = Path.Combine(text.Trim(), "abaqus.bat");
					if (File.Exists(text2))
					{
						return text2;
					}
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		string[] array2 = new string[8] { "C:\\SIMULIA\\Commands\\abaqus.bat", "C:\\Program Files\\Dassault Systemes\\SIMULIA\\Commands\\abaqus.bat", "C:\\Program Files (x86)\\Dassault Systemes\\SIMULIA\\Commands\\abaqus.bat", "D:\\SIMULIA\\Commands\\abaqus.bat", "D:\\Program Files\\Dassault Systemes\\SIMULIA\\Commands\\abaqus.bat", "D:\\Program Files (x86)\\Dassault Systemes\\SIMULIA\\Commands\\abaqus.bat", "E:\\SIMULIA\\Commands\\abaqus.bat", "F:\\SIMULIA\\Commands\\abaqus.bat" };
		string[] array3 = array2;
		foreach (string text3 in array3)
		{
			if (File.Exists(text3))
			{
				return text3;
			}
		}
		return null;
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.Cancel;
		Close();
	}
}
