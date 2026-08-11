using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace AbaqusJob;

[DesignerGenerated]
public class ScheduleSetupForm : Form
{
	private IContainer components = null!;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("rbTimePicker")]
	private RadioButton _rbTimePicker;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnOK")]
	private Button _btnOK;

	internal virtual RadioButton rbTimePicker
	{
		[CompilerGenerated]
		get
		{
			return _rbTimePicker;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = rbTimePicker_CheckedChanged;
			RadioButton radioButton = _rbTimePicker;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value2;
			}
			_rbTimePicker = value;
			radioButton = _rbTimePicker;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value2;
			}
		}
	}

	[field: AccessedThroughProperty("rbManualInput")]
	internal virtual RadioButton rbManualInput
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("dtpTime")]
	internal virtual DateTimePicker dtpTime
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblColon")]
	internal virtual Label lblColon
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("btnCancel")]
	internal virtual Button btnCancel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("nudHour")]
	internal virtual NumericUpDown nudHour
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("nudMinute")]
	internal virtual NumericUpDown nudMinute
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public DateTime? ScheduledTime { get; set; }

	public ScheduleSetupForm()
	{
		base.Load += ScheduleSetupForm_Load;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbaqusJob.ScheduleSetupForm));
		this.rbTimePicker = new System.Windows.Forms.RadioButton();
		this.rbManualInput = new System.Windows.Forms.RadioButton();
		this.dtpTime = new System.Windows.Forms.DateTimePicker();
		this.lblColon = new System.Windows.Forms.Label();
		this.btnOK = new System.Windows.Forms.Button();
		this.btnCancel = new System.Windows.Forms.Button();
		this.Label1 = new System.Windows.Forms.Label();
		this.nudHour = new System.Windows.Forms.NumericUpDown();
		this.nudMinute = new System.Windows.Forms.NumericUpDown();
		((System.ComponentModel.ISupportInitialize)this.nudHour).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nudMinute).BeginInit();
		base.SuspendLayout();
		this.rbTimePicker.AutoSize = true;
		this.rbTimePicker.Checked = true;
		this.rbTimePicker.Location = new System.Drawing.Point(32, 26);
		this.rbTimePicker.Name = "rbTimePicker";
		this.rbTimePicker.Size = new System.Drawing.Size(95, 16);
		this.rbTimePicker.TabIndex = 1;
		this.rbTimePicker.TabStop = true;
		this.rbTimePicker.Text = "选择开始时间";
		this.rbTimePicker.UseVisualStyleBackColor = true;
		this.rbManualInput.AutoSize = true;
		this.rbManualInput.Location = new System.Drawing.Point(32, 63);
		this.rbManualInput.Name = "rbManualInput";
		this.rbManualInput.Size = new System.Drawing.Size(95, 16);
		this.rbManualInput.TabIndex = 2;
		this.rbManualInput.Text = "输入延时时间";
		this.rbManualInput.UseVisualStyleBackColor = true;
		this.dtpTime.CustomFormat = "HH:mm";
		this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
		this.dtpTime.Location = new System.Drawing.Point(148, 24);
		this.dtpTime.Name = "dtpTime";
		this.dtpTime.ShowUpDown = true;
		this.dtpTime.Size = new System.Drawing.Size(73, 21);
		this.dtpTime.TabIndex = 3;
		this.lblColon.AutoSize = true;
		this.lblColon.Font = new System.Drawing.Font("宋体", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
		this.lblColon.Location = new System.Drawing.Point(198, 65);
		this.lblColon.Name = "lblColon";
		this.lblColon.Size = new System.Drawing.Size(29, 12);
		this.lblColon.TabIndex = 5;
		this.lblColon.Text = "小时";
		this.btnOK.Location = new System.Drawing.Point(152, 111);
		this.btnOK.Name = "btnOK";
		this.btnOK.Size = new System.Drawing.Size(75, 23);
		this.btnOK.TabIndex = 6;
		this.btnOK.Text = "开始计时";
		this.btnOK.UseVisualStyleBackColor = true;
		this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.btnCancel.Location = new System.Drawing.Point(233, 111);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(75, 23);
		this.btnCancel.TabIndex = 7;
		this.btnCancel.Text = "取消";
		this.btnCancel.UseVisualStyleBackColor = true;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("宋体", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
		this.Label1.Location = new System.Drawing.Point(283, 65);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(29, 12);
		this.Label1.TabIndex = 5;
		this.Label1.Text = "分钟";
		this.nudHour.Location = new System.Drawing.Point(148, 61);
		this.nudHour.Name = "nudHour";
		this.nudHour.Size = new System.Drawing.Size(44, 21);
		this.nudHour.TabIndex = 8;
		this.nudMinute.Increment = new decimal(new int[4] { 5, 0, 0, 0 });
		this.nudMinute.Location = new System.Drawing.Point(233, 61);
		this.nudMinute.Maximum = new decimal(new int[4] { 59, 0, 0, 0 });
		this.nudMinute.Name = "nudMinute";
		this.nudMinute.Size = new System.Drawing.Size(44, 21);
		this.nudMinute.TabIndex = 9;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(343, 146);
		base.Controls.Add(this.nudMinute);
		base.Controls.Add(this.nudHour);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.btnOK);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.lblColon);
		base.Controls.Add(this.dtpTime);
		base.Controls.Add(this.rbManualInput);
		base.Controls.Add(this.rbTimePicker);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "ScheduleSetupForm";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "定时开始";
		((System.ComponentModel.ISupportInitialize)this.nudHour).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nudMinute).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void ScheduleSetupForm_Load(object sender, EventArgs e)
	{
		rbTimePicker.Checked = true;
		dtpTime.Value = DateTime.Now.AddHours(1.0);
		nudHour.Minimum = 0m;
		nudHour.Maximum = 999m;
		nudHour.Value = 1m;
		nudMinute.Minimum = 0m;
		nudMinute.Maximum = 59m;
		nudMinute.Value = 0m;
		base.AcceptButton = btnOK;
		base.CancelButton = btnCancel;
	}

	private void rbTimePicker_CheckedChanged(object sender, EventArgs e)
	{
		dtpTime.Enabled = rbTimePicker.Checked;
		nudHour.Enabled = rbManualInput.Checked;
		nudMinute.Enabled = rbManualInput.Checked;
	}

	private void btnOK_Click(object sender, EventArgs e)
	{
		DateTime? scheduledTime;
		if (rbTimePicker.Checked)
		{
			TimeSpan timeOfDay = dtpTime.Value.TimeOfDay;
			DateTime dateTime = DateTime.Today.Add(timeOfDay);
			if (DateTime.Compare(dateTime, DateTime.Now) <= 0)
			{
				MessageBox.Show("开始时间必须晚于当前时间！", "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				dtpTime.Focus();
				return;
			}
			scheduledTime = dateTime;
		}
		else
		{
			int num = Convert.ToInt32(nudHour.Value);
			int num2 = Convert.ToInt32(nudMinute.Value);
			if (num == 0 && num2 == 0)
			{
				MessageBox.Show("延迟时间不能为零，请至少输入1分钟。", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				nudMinute.Focus();
				return;
			}
			scheduledTime = DateTime.Now.AddHours(num).AddMinutes(num2);
		}
		ScheduledTime = scheduledTime;
		base.DialogResult = DialogResult.OK;
		Close();
	}
}
