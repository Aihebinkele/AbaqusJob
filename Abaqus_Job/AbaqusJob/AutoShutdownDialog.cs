using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace AbaqusJob;

[DesignerGenerated]
public class AutoShutdownDialog : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnCancel")]
	private Button _btnCancel;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("timerCountdown")]
	private Timer _timerCountdown;

	private int remainingSeconds;

	[field: AccessedThroughProperty("lblMessage")]
	internal virtual Label lblMessage
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	internal virtual Timer timerCountdown
	{
		[CompilerGenerated]
		get
		{
			return _timerCountdown;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = timerCountdown_Tick;
			Timer timer = _timerCountdown;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			_timerCountdown = value;
			timer = _timerCountdown;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
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
		this.components = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbaqusJob.AutoShutdownDialog));
		this.lblMessage = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.timerCountdown = new System.Windows.Forms.Timer(this.components);
		base.SuspendLayout();
		this.lblMessage.AutoSize = true;
		this.lblMessage.Font = new System.Drawing.Font("宋体", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 134);
		this.lblMessage.Location = new System.Drawing.Point(31, 24);
		this.lblMessage.Name = "lblMessage";
		this.lblMessage.Size = new System.Drawing.Size(273, 57);
		this.lblMessage.TabIndex = 0;
		this.lblMessage.Text = "所有任务已完成。\r\n系统将在 60 秒后自动关机。\r\n点击【取消】可中止关机。";
		this.btnCancel.Font = new System.Drawing.Font("宋体", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 134);
		this.btnCancel.Location = new System.Drawing.Point(212, 102);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(92, 31);
		this.btnCancel.TabIndex = 1;
		this.btnCancel.Text = "取消";
		this.btnCancel.UseVisualStyleBackColor = true;
		this.timerCountdown.Enabled = true;
		this.timerCountdown.Interval = 1000;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(324, 145);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.lblMessage);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "AutoShutdownDialog";
		this.Text = "关机确认";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public AutoShutdownDialog(int seconds)
	{
		base.FormClosed += AutoShutdownDialog_FormClosed;
		InitializeComponent();
	try { base.Icon = System.Drawing.Icon.ExtractAssociatedIcon(System.Windows.Forms.Application.ExecutablePath); } catch { }
		remainingSeconds = seconds;
		UpdateMessage();
	}

	private void UpdateMessage()
	{
		lblMessage.Text = string.Format("所有任务已完成。{0}", "\r\n") + string.Format("系统将在 {0} 秒后自动关机。{1}", remainingSeconds, "\r\n") + "点击【取消】可中止关机。";
	}

	private void timerCountdown_Tick(object sender, EventArgs e)
	{
		checked
		{
			remainingSeconds--;
			UpdateMessage();
			if (remainingSeconds <= 0)
			{
				timerCountdown.Stop();
				base.DialogResult = DialogResult.OK;
				Close();
			}
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		timerCountdown.Stop();
		base.DialogResult = DialogResult.Cancel;
		Close();
	}

	private void AutoShutdownDialog_FormClosed(object sender, FormClosedEventArgs e)
	{
		timerCountdown.Stop();
	}
}
