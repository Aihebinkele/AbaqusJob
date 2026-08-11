#define DEBUG
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AbaqusJob.My;
using Microsoft.VisualBasic.CompilerServices;

namespace AbaqusJob;

[DesignerGenerated]
public partial class Form1 : Form
{
	public class ProcessInfo
	{
		public Process Process { get; set; }

		public int JobIndex { get; set; }

		public string StaFile { get; set; }

		public int LastReadLineCount { get; set; }

		public ProcessInfo()
		{
			LastReadLineCount = 0;
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__20_002D0
	{
		public string _0024VB_0024Local_f;

		public _Closure_0024__20_002D0(_Closure_0024__20_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_f = arg0._0024VB_0024Local_f;
			}
		}

		[SpecialName]
		internal bool _Lambda_0024__0(JobItem j)
		{
			return Operators.CompareString(j.FilePath, _0024VB_0024Local_f, TextCompare: false) == 0;
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__45_002D0
	{
		public object _0024VB_0024Local_sender;

		public EventArgs _0024VB_0024Local_e;

		public Form1 _0024VB_0024Me;

		public _Closure_0024__45_002D0(_Closure_0024__45_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_sender = arg0._0024VB_0024Local_sender;
				_0024VB_0024Local_e = arg0._0024VB_0024Local_e;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			_0024VB_0024Me.btnNInp1For_Click(RuntimeHelpers.GetObjectValue(_0024VB_0024Local_sender), _0024VB_0024Local_e);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__45_002D1
	{
		public string _0024VB_0024Local_f;

		public _Closure_0024__45_002D1(_Closure_0024__45_002D1 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_f = arg0._0024VB_0024Local_f;
			}
		}

		[SpecialName]
		internal bool _Lambda_0024__1(JobItem j)
		{
			return Operators.CompareString(j.FilePath, _0024VB_0024Local_f, TextCompare: false) == 0;
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__46_002D0
	{
		public object _0024VB_0024Local_sender;

		public EventArgs _0024VB_0024Local_e;

		public Form1 _0024VB_0024Me;

		public _Closure_0024__46_002D0(_Closure_0024__46_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_sender = arg0._0024VB_0024Local_sender;
				_0024VB_0024Local_e = arg0._0024VB_0024Local_e;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			_0024VB_0024Me.btnNInpNFor_Click(RuntimeHelpers.GetObjectValue(_0024VB_0024Local_sender), _0024VB_0024Local_e);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__47_002D0
	{
		public object _0024VB_0024Local_sender;

		public EventArgs _0024VB_0024Local_e;

		public Form1 _0024VB_0024Me;

		public _Closure_0024__47_002D0(_Closure_0024__47_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_sender = arg0._0024VB_0024Local_sender;
				_0024VB_0024Local_e = arg0._0024VB_0024Local_e;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			_0024VB_0024Me.btn1InpNFor_Click(RuntimeHelpers.GetObjectValue(_0024VB_0024Local_sender), _0024VB_0024Local_e);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__47_002D1
	{
		public string _0024VB_0024Local_jobName;

		public Func<JobItem, bool> _0024I1 = null!;

		public _Closure_0024__47_002D1(_Closure_0024__47_002D1 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_jobName = arg0._0024VB_0024Local_jobName;
			}
		}

		[SpecialName]
		internal bool _Lambda_0024__1(JobItem j)
		{
			return string.Equals(j.JobName, _0024VB_0024Local_jobName, StringComparison.OrdinalIgnoreCase);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__81_002D0
	{
		public string _0024VB_0024Local_f;

		public _Closure_0024__81_002D0(_Closure_0024__81_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_f = arg0._0024VB_0024Local_f;
			}
		}

		[SpecialName]
		internal bool _Lambda_0024__0(JobItem j)
		{
			return Operators.CompareString(j.FilePath, _0024VB_0024Local_f, TextCompare: false) == 0;
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__86_002D0
	{
		public int _0024VB_0024Local_localIndex;

		public ProcessInfo _0024VB_0024Local_localPi;

		public Form1 _0024VB_0024Me;

		public _Closure_0024__86_002D0(_Closure_0024__86_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_localIndex = arg0._0024VB_0024Local_localIndex;
				_0024VB_0024Local_localPi = arg0._0024VB_0024Local_localPi;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			_0024VB_0024Me.MonitorJob(_0024VB_0024Local_localIndex, _0024VB_0024Local_localPi);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__90_002D0
	{
		public int _0024VB_0024Local_jobIndex;

		public Form1 _0024VB_0024Me;

		public _Closure_0024__90_002D0(_Closure_0024__90_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_jobIndex = arg0._0024VB_0024Local_jobIndex;
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__90_002D1
	{
		public string _0024VB_0024Local_newContent;

		public _Closure_0024__90_002D3 _0024VB_0024NonLocal__0024VB_0024Closure_3;

		public _Closure_0024__90_002D1(_Closure_0024__90_002D1 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_newContent = arg0._0024VB_0024Local_newContent;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			_0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.jobList[_0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_jobIndex].LatestLog += _0024VB_0024Local_newContent;
			if (_0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.IsCurrentSelectedJob(_0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_jobIndex))
			{
				_0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.UpdateStaDisplay(_0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_jobIndex);
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__90_002D2
	{
		public List<string> _0024VB_0024Local_newWarnings;

		public _Closure_0024__90_002D3 _0024VB_0024NonLocal__0024VB_0024Closure_4;

		public _Closure_0024__90_002D2(_Closure_0024__90_002D2 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_newWarnings = arg0._0024VB_0024Local_newWarnings;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__1()
		{
			_0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.jobList[_0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_jobIndex].AddWarnings(_0024VB_0024Local_newWarnings);
			if (_0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.IsCurrentSelectedJob(_0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_jobIndex))
			{
				_0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.UpdateWarningDisplay(_0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_jobIndex);
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__90_002D3
	{
		public string _0024VB_0024Local_finalStaContent;

		public _Closure_0024__90_002D0 _0024VB_0024NonLocal__0024VB_0024Closure_2;

		public _Closure_0024__90_002D3(_Closure_0024__90_002D3 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_finalStaContent = arg0._0024VB_0024Local_finalStaContent;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__2()
		{
			_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.jobList[_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_jobIndex].LatestLog = _0024VB_0024Local_finalStaContent;
			if (_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.IsCurrentSelectedJob(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_jobIndex))
			{
				_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.UpdateStaDisplay(_0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_jobIndex);
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__90_002D4
	{
		public List<string> _0024VB_0024Local_finalWarnings;

		public _Closure_0024__90_002D3 _0024VB_0024NonLocal__0024VB_0024Closure_5;

		public _Closure_0024__90_002D4(_Closure_0024__90_002D4 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_finalWarnings = arg0._0024VB_0024Local_finalWarnings;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__3()
		{
			_0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.jobList[_0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_jobIndex].AddWarnings(_0024VB_0024Local_finalWarnings);
			if (_0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.IsCurrentSelectedJob(_0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_jobIndex))
			{
				_0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.UpdateWarningDisplay(_0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_jobIndex);
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__99_002D0
	{
		public ListView _0024VB_0024Local_lv;

		public string _0024VB_0024Local_filePath;

		public Form _0024VB_0024Local_form;

		public Form1 _0024VB_0024Me;

		public _Closure_0024__99_002D0(_Closure_0024__99_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_lv = arg0._0024VB_0024Local_lv;
				_0024VB_0024Local_filePath = arg0._0024VB_0024Local_filePath;
				_0024VB_0024Local_form = arg0._0024VB_0024Local_form;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R1(object a0, EventArgs a1)
		{
			_Lambda_0024__0();
		}

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			_0024VB_0024Local_lv.SelectedItems.Clear();
			_0024VB_0024Me.BrowseAndOpen(_0024VB_0024Local_filePath);
			_0024VB_0024Local_form.Close();
		}
	}

	public static readonly string[] ConfigurableColumns = new string[9] { "FilePath", "USubPath", "Status", "OdbPath", "JobName", "OutputDir", "TaskType", "SolverType", "OldJobName" };

	private DateTime? scheduledStartTime;

	private System.Windows.Forms.Timer scheduledStartTimer;

	private System.Windows.Forms.Timer countdownTimer;

	private BindingList<JobItem> jobList;

	private ToolStripNumericUpDown numParallelToolStrip;

	private ToolStripNumericUpDown numCpusToolStrip;

	private List<ProcessInfo> activeProcesses;

	private bool isStopping;

	private int maxParallel;

	private int cpuThreads;

	private ConcurrentDictionary<int, Process> runningProcesses;

	private int currentSelectedIndex;

	private const string STATUS_WAITING = "等待";

	private const string STATUS_RUNNING = "运行中";

	private const string STATUS_COMPLETED = "完成";

	private const string STATUS_FAILED = "失败";

	private const string STATUS_STOPPED = "已终止";

	private int nextJobIndexToSchedule;

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DGVMenu")]
	private ContextMenuStrip _DGVMenu;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("StartMenuItem")]
	private ToolStripMenuItem _StartMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("KillMenuItem")]
	private ToolStripMenuItem _KillMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("NTSMenu")]
	private ToolStripMenuItem _NTSMenu;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("OTSMenu")]
	private ToolStripMenuItem _OTSMenu;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("XTSMenu")]
	private ToolStripMenuItem _XTSMenu;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("AboutTSMenu")]
	private ToolStripMenuItem _AboutTSMenu;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("EditTSMenu")]
	private ToolStripMenuItem _EditTSMenu;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("UpTSMenuI")]
	private ToolStripMenuItem _UpTSMenuI;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DownTSMenu")]
	private ToolStripMenuItem _DownTSMenu;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BtnStart")]
	private ToolStripButton _BtnStart;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BtnStop")]
	private ToolStripButton _BtnStop;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("dgvJobs")]
	private DataGridView _dgvJobs;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TabpageN")]
	private TabControl _TabpageN;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btn1InpNFor")]
	private ToolStripMenuItem _btn1InpNFor;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnNInp1For")]
	private ToolStripMenuItem _btnNInp1For;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnNInpNFor")]
	private ToolStripMenuItem _btnNInpNFor;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnOpenInp")]
	private ToolStripMenuItem _btnOpenInp;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnOpenUSubPath")]
	private ToolStripMenuItem _btnOpenUSubPath;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnShowInpFile")]
	private ToolStripMenuItem _btnShowInpFile;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnShowSubroutineFile")]
	private ToolStripMenuItem _btnShowSubroutineFile;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RemoveMenuItem")]
	private ToolStripMenuItem _RemoveMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RemoveAllMenuItem")]
	private ToolStripMenuItem _RemoveAllMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RemoveUSubMenuItem")]
	private ToolStripMenuItem _RemoveUSubMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RemoveResMenuItem")]
	private ToolStripMenuItem _RemoveResMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("btnScheduled")]
	private ToolStripButton _btnScheduled;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("AddinpMenuItem")]
	private ToolStripMenuItem _AddinpMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("AddSubMenuItem")]
	private ToolStripMenuItem _AddSubMenuItem;

	[field: AccessedThroughProperty("StatusStrip1")]
	internal virtual StatusStrip StatusStrip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tslStatus")]
	internal virtual ToolStripStatusLabel tslStatus
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("OpenFileDialog1")]
	internal virtual OpenFileDialog OpenFileDialog1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FolderBrowserDialog1")]
	internal virtual FolderBrowserDialog FolderBrowserDialog1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BackgroundWorker1")]
	internal virtual BackgroundWorker BackgroundWorker1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ContextMenuStrip DGVMenu
	{
		[CompilerGenerated]
		get
		{
			return _DGVMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			CancelEventHandler value2 = DGVMenu_Opening;
			ContextMenuStrip dGVMenu = _DGVMenu;
			if (dGVMenu != null)
			{
				dGVMenu.Opening -= value2;
			}
			_DGVMenu = value;
			dGVMenu = _DGVMenu;
			if (dGVMenu != null)
			{
				dGVMenu.Opening += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem StartMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _StartMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = StartMenuItem_Click;
			ToolStripMenuItem startMenuItem = _StartMenuItem;
			if (startMenuItem != null)
			{
				startMenuItem.Click -= value2;
			}
			_StartMenuItem = value;
			startMenuItem = _StartMenuItem;
			if (startMenuItem != null)
			{
				startMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem KillMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _KillMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = KillMenuItem_Click;
			ToolStripMenuItem killMenuItem = _KillMenuItem;
			if (killMenuItem != null)
			{
				killMenuItem.Click -= value2;
			}
			_KillMenuItem = value;
			killMenuItem = _KillMenuItem;
			if (killMenuItem != null)
			{
				killMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ToolStripContainer1")]
	internal virtual ToolStripContainer ToolStripContainer1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MenuStrip1")]
	internal virtual MenuStrip MenuStrip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("文件FToolStripMenuItem")]
	internal virtual ToolStripMenuItem 文件FToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem NTSMenu
	{
		[CompilerGenerated]
		get
		{
			return _NTSMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = NTSMenu_Click;
			ToolStripMenuItem nTSMenu = _NTSMenu;
			if (nTSMenu != null)
			{
				nTSMenu.Click -= value2;
			}
			_NTSMenu = value;
			nTSMenu = _NTSMenu;
			if (nTSMenu != null)
			{
				nTSMenu.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem OTSMenu
	{
		[CompilerGenerated]
		get
		{
			return _OTSMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = OTSMenu_Click;
			ToolStripMenuItem oTSMenu = _OTSMenu;
			if (oTSMenu != null)
			{
				oTSMenu.Click -= value2;
			}
			_OTSMenu = value;
			oTSMenu = _OTSMenu;
			if (oTSMenu != null)
			{
				oTSMenu.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("toolStripSeparator")]
	internal virtual ToolStripSeparator toolStripSeparator
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem XTSMenu
	{
		[CompilerGenerated]
		get
		{
			return _XTSMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = XTSMenu_Click;
			ToolStripMenuItem xTSMenu = _XTSMenu;
			if (xTSMenu != null)
			{
				xTSMenu.Click -= value2;
			}
			_XTSMenu = value;
			xTSMenu = _XTSMenu;
			if (xTSMenu != null)
			{
				xTSMenu.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("HToolStripMenu")]
	internal virtual ToolStripMenuItem HToolStripMenu
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem AboutTSMenu
	{
		[CompilerGenerated]
		get
		{
			return _AboutTSMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = AboutTSMenu_Click;
			ToolStripMenuItem aboutTSMenu = _AboutTSMenu;
			if (aboutTSMenu != null)
			{
				aboutTSMenu.Click -= value2;
			}
			_AboutTSMenu = value;
			aboutTSMenu = _AboutTSMenu;
			if (aboutTSMenu != null)
			{
				aboutTSMenu.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem EditTSMenu
	{
		[CompilerGenerated]
		get
		{
			return _EditTSMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = EditTSMenu_Click;
			ToolStripMenuItem editTSMenu = _EditTSMenu;
			if (editTSMenu != null)
			{
				editTSMenu.Click -= value2;
			}
			_EditTSMenu = value;
			editTSMenu = _EditTSMenu;
			if (editTSMenu != null)
			{
				editTSMenu.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem UpTSMenuI
	{
		[CompilerGenerated]
		get
		{
			return _UpTSMenuI;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = UpTSMenuI_Click;
			ToolStripMenuItem upTSMenuI = _UpTSMenuI;
			if (upTSMenuI != null)
			{
				upTSMenuI.Click -= value2;
			}
			_UpTSMenuI = value;
			upTSMenuI = _UpTSMenuI;
			if (upTSMenuI != null)
			{
				upTSMenuI.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem DownTSMenu
	{
		[CompilerGenerated]
		get
		{
			return _DownTSMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = DownTSMenu_Click;
			ToolStripMenuItem downTSMenu = _DownTSMenu;
			if (downTSMenu != null)
			{
				downTSMenu.Click -= value2;
			}
			_DownTSMenu = value;
			downTSMenu = _DownTSMenu;
			if (downTSMenu != null)
			{
				downTSMenu.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ToolStrip1")]
	internal virtual ToolStrip ToolStrip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ToolStrip2")]
	internal virtual ToolStrip ToolStrip2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripButton BtnStart
	{
		[CompilerGenerated]
		get
		{
			return _BtnStart;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = BtnStart_Click_2;
			ToolStripButton btnStart = _BtnStart;
			if (btnStart != null)
			{
				btnStart.Click -= value2;
			}
			_BtnStart = value;
			btnStart = _BtnStart;
			if (btnStart != null)
			{
				btnStart.Click += value2;
			}
		}
	}

	internal virtual ToolStripButton BtnStop
	{
		[CompilerGenerated]
		get
		{
			return _BtnStop;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = BtnStop_Click_1;
			ToolStripButton btnStop = _BtnStop;
			if (btnStop != null)
			{
				btnStop.Click -= value2;
			}
			_BtnStop = value;
			btnStop = _BtnStop;
			if (btnStop != null)
			{
				btnStop.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("SplitContainer2")]
	internal virtual SplitContainer SplitContainer2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView dgvJobs
	{
		[CompilerGenerated]
		get
		{
			return _dgvJobs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = dgvJobs_SelectionChanged;
			DataGridViewCellFormattingEventHandler value3 = dgvJobs_CellFormatting;
			DataGridView dataGridView = _dgvJobs;
			if (dataGridView != null)
			{
				dataGridView.SelectionChanged -= value2;
				dataGridView.CellFormatting -= value3;
			}
			_dgvJobs = value;
			dataGridView = _dgvJobs;
			if (dataGridView != null)
			{
				dataGridView.SelectionChanged += value2;
				dataGridView.CellFormatting += value3;
			}
		}
	}

	internal virtual TabControl TabpageN
	{
		[CompilerGenerated]
		get
		{
			return _TabpageN;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			TabControlEventHandler value2 = TabpageN_Selected;
			TabControl tabpageN = _TabpageN;
			if (tabpageN != null)
			{
				tabpageN.Selected -= value2;
			}
			_TabpageN = value;
			tabpageN = _TabpageN;
			if (tabpageN != null)
			{
				tabpageN.Selected += value2;
			}
		}
	}

	[field: AccessedThroughProperty("TabPage1")]
	internal virtual TabPage TabPage1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtLog")]
	internal virtual TextBox txtLog
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage2")]
	internal virtual TabPage TabPage2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtStatus")]
	internal virtual TextBox txtStatus
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TabPage3")]
	internal virtual TabPage TabPage3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtWarn")]
	internal virtual TextBox txtWarn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ToolStripSeparator1")]
	internal virtual ToolStripSeparator ToolStripSeparator1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("添加包含子程序的任务ToolStripMenuItem")]
	internal virtual ToolStripMenuItem 添加包含子程序的任务ToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem btn1InpNFor
	{
		[CompilerGenerated]
		get
		{
			return _btn1InpNFor;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btn1InpNFor_Click;
			ToolStripMenuItem toolStripMenuItem = _btn1InpNFor;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_btn1InpNFor = value;
			toolStripMenuItem = _btn1InpNFor;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem btnNInp1For
	{
		[CompilerGenerated]
		get
		{
			return _btnNInp1For;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnNInp1For_Click;
			ToolStripMenuItem toolStripMenuItem = _btnNInp1For;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_btnNInp1For = value;
			toolStripMenuItem = _btnNInp1For;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem btnNInpNFor
	{
		[CompilerGenerated]
		get
		{
			return _btnNInpNFor;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnNInpNFor_Click;
			ToolStripMenuItem toolStripMenuItem = _btnNInpNFor;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_btnNInpNFor = value;
			toolStripMenuItem = _btnNInpNFor;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("tslSpring")]
	internal virtual ToolStripStatusLabel tslSpring
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tslCompleted")]
	internal virtual ToolStripStatusLabel tslCompleted
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tslFailed")]
	internal virtual ToolStripStatusLabel tslFailed
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tslRunning")]
	internal virtual ToolStripStatusLabel tslRunning
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("btnOpenFilePath")]
	internal virtual ToolStripMenuItem btnOpenFilePath
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem btnOpenInp
	{
		[CompilerGenerated]
		get
		{
			return _btnOpenInp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnOpenInp_Click;
			ToolStripMenuItem toolStripMenuItem = _btnOpenInp;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_btnOpenInp = value;
			toolStripMenuItem = _btnOpenInp;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem btnOpenUSubPath
	{
		[CompilerGenerated]
		get
		{
			return _btnOpenUSubPath;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnOpenUSubPath_Click;
			ToolStripMenuItem toolStripMenuItem = _btnOpenUSubPath;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_btnOpenUSubPath = value;
			toolStripMenuItem = _btnOpenUSubPath;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem btnShowInpFile
	{
		[CompilerGenerated]
		get
		{
			return _btnShowInpFile;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnShowInpFile_Click;
			ToolStripMenuItem toolStripMenuItem = _btnShowInpFile;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_btnShowInpFile = value;
			toolStripMenuItem = _btnShowInpFile;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem btnShowSubroutineFile
	{
		[CompilerGenerated]
		get
		{
			return _btnShowSubroutineFile;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnShowSubroutineFile_Click;
			ToolStripMenuItem toolStripMenuItem = _btnShowSubroutineFile;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click -= value2;
			}
			_btnShowSubroutineFile = value;
			toolStripMenuItem = _btnShowSubroutineFile;
			if (toolStripMenuItem != null)
			{
				toolStripMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("移除ToolStripMenuItem")]
	internal virtual ToolStripMenuItem 移除ToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem RemoveMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _RemoveMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = RemoveMenuItem_Click;
			ToolStripMenuItem removeMenuItem = _RemoveMenuItem;
			if (removeMenuItem != null)
			{
				removeMenuItem.Click -= value2;
			}
			_RemoveMenuItem = value;
			removeMenuItem = _RemoveMenuItem;
			if (removeMenuItem != null)
			{
				removeMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem RemoveAllMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _RemoveAllMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = RemoveAllMenuItem_Click;
			ToolStripMenuItem removeAllMenuItem = _RemoveAllMenuItem;
			if (removeAllMenuItem != null)
			{
				removeAllMenuItem.Click -= value2;
			}
			_RemoveAllMenuItem = value;
			removeAllMenuItem = _RemoveAllMenuItem;
			if (removeAllMenuItem != null)
			{
				removeAllMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem RemoveUSubMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _RemoveUSubMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = RemoveUSubMenuItem_Click;
			ToolStripMenuItem removeUSubMenuItem = _RemoveUSubMenuItem;
			if (removeUSubMenuItem != null)
			{
				removeUSubMenuItem.Click -= value2;
			}
			_RemoveUSubMenuItem = value;
			removeUSubMenuItem = _RemoveUSubMenuItem;
			if (removeUSubMenuItem != null)
			{
				removeUSubMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem RemoveResMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _RemoveResMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = RemoveResMenuItem_Click;
			ToolStripMenuItem removeResMenuItem = _RemoveResMenuItem;
			if (removeResMenuItem != null)
			{
				removeResMenuItem.Click -= value2;
			}
			_RemoveResMenuItem = value;
			removeResMenuItem = _RemoveResMenuItem;
			if (removeResMenuItem != null)
			{
				removeResMenuItem.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("ToolStripSeparator2")]
	internal virtual ToolStripSeparator ToolStripSeparator2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripButton btnScheduled
	{
		[CompilerGenerated]
		get
		{
			return _btnScheduled;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = btnScheduled_Click;
			ToolStripButton toolStripButton = _btnScheduled;
			if (toolStripButton != null)
			{
				toolStripButton.Click -= value2;
			}
			_btnScheduled = value;
			toolStripButton = _btnScheduled;
			if (toolStripButton != null)
			{
				toolStripButton.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("lblScheduledInfo")]
	internal virtual ToolStripLabel lblScheduledInfo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("添加ToolStripMenuItem")]
	internal virtual ToolStripMenuItem 添加ToolStripMenuItem
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem AddinpMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _AddinpMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = AddinpMenuItem_Click;
			ToolStripMenuItem addinpMenuItem = _AddinpMenuItem;
			if (addinpMenuItem != null)
			{
				addinpMenuItem.Click -= value2;
			}
			_AddinpMenuItem = value;
			addinpMenuItem = _AddinpMenuItem;
			if (addinpMenuItem != null)
			{
				addinpMenuItem.Click += value2;
			}
		}
	}

	internal virtual ToolStripMenuItem AddSubMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _AddSubMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = AddSubMenuItem_Click;
			ToolStripMenuItem addSubMenuItem = _AddSubMenuItem;
			if (addSubMenuItem != null)
			{
				addSubMenuItem.Click -= value2;
			}
			_AddSubMenuItem = value;
			addSubMenuItem = _AddSubMenuItem;
			if (addSubMenuItem != null)
			{
				addSubMenuItem.Click += value2;
			}
		}
	}

	public Form1()
	{
		base.FormClosing += MainForm_FormClosing;
		base.Load += Form1_Load;
		jobList = new BindingList<JobItem>();
		activeProcesses = new List<ProcessInfo>();
		isStopping = false;
		maxParallel = 1;
		cpuThreads = 4;
		runningProcesses = new ConcurrentDictionary<int, Process>();
		currentSelectedIndex = -1;
		nextJobIndexToSchedule = 0;
		InitializeComponent();
		try { base.Icon = System.Drawing.Icon.ExtractAssociatedIcon(System.Windows.Forms.Application.ExecutablePath); } catch { }
	}

	private int GetRunningJobCount()
	{
		int num = 0;
		foreach (Process value in runningProcesses.Values)
		{
			if (value != null && !value.HasExited)
			{
				num = checked(num + 1);
			}
		}
		return num;
	}

	private int GetCurrentMaxParallel()
	{
		NumericUpDown numericUpDownControl = numParallelToolStrip.NumericUpDownControl;
		if (numericUpDownControl.InvokeRequired)
		{
			return Conversions.ToInteger(numericUpDownControl.Invoke((VB_0024AnonymousDelegate_0<decimal>)([SpecialName] () => numericUpDownControl.Value)));
		}
		return Convert.ToInt32(numericUpDownControl.Value);
	}

	private int GetCurrentCpus()
	{
		NumericUpDown numericUpDownControl = numCpusToolStrip.NumericUpDownControl;
		if (numericUpDownControl.InvokeRequired)
		{
			return Conversions.ToInteger(numericUpDownControl.Invoke((VB_0024AnonymousDelegate_0<decimal>)([SpecialName] () => numericUpDownControl.Value)));
		}
		return Convert.ToInt32(numericUpDownControl.Value);
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

	private string SelectSingleForOrF()
	{
		using OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = "User Subroutine (*.for;*.f)|*.for;*.f|All files (*.*)|*.*";
		openFileDialog.Title = "选择一个子程序文件 (.for 或 .f)";
		return (openFileDialog.ShowDialog() == DialogResult.OK) ? openFileDialog.FileName : null;
	}

	private List<string> SelectMultipleForOrF()
	{
		using OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = "User Subroutine (*.for;*.f)|*.for;*.f|All files (*.*)|*.*";
		openFileDialog.Multiselect = true;
		openFileDialog.Title = "选择一个或多个子程序文件 (.for 或 .f)";
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			return openFileDialog.FileNames.Where([SpecialName] (string f) =>
			{
				string left = Path.GetExtension(f).ToLowerInvariant();
				return Operators.CompareString(left, ".for", TextCompare: false) == 0 || Operators.CompareString(left, ".f", TextCompare: false) == 0;
			}).ToList();
		}
		return new List<string>();
	}

	private string SelectSingleInp()
	{
		using OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = "INP Files (*.inp)|*.inp";
		openFileDialog.Title = "选择一个 .inp 文件";
		return (openFileDialog.ShowDialog() == DialogResult.OK) ? openFileDialog.FileName : null;
	}

	private List<string> SelectMultipleInp()
	{
		using OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = "INP Files (*.inp)|*.inp";
		openFileDialog.Multiselect = true;
		openFileDialog.Title = "选择一个或多个 .inp 文件";
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			return openFileDialog.FileNames.Where([SpecialName] (string f) => Operators.CompareString(Path.GetExtension(f).ToLowerInvariant(), ".inp", TextCompare: false) == 0).ToList();
		}
		return new List<string>();
	}

	private List<(string DisplayName, string ExePath)> GetAvailableEditorsWithIcons()
	{
		List<(string, string)> list = new List<(string, string)>();
		list.Add(("记事本", "notepad.exe"));
		list.Add(("Notepad++", "C:\\Program Files\\Notepad++\\notepad++.exe"));
		list.Add(("Notepad++ (x86)", "C:\\Program Files (x86)\\Notepad++\\notepad++.exe"));
		list.Add(($"VS Code (用户: {Environment.UserName})", $"C:\\Users\\{Environment.UserName}\\AppData\\Local\\Programs\\Microsoft VS Code\\Code.exe"));
		list.Add(("VS Code (系统安装)", "C:\\Program Files\\Microsoft VS Code\\Code.exe"));
		list.Add(("写字板", "write.exe"));
		list.Add(("Sublime Text", "C:\\Program Files\\Sublime Text\\sublime_text.exe"));
		list.Add(("Sublime Text (x86)", "C:\\Program Files (x86)\\Sublime Text\\sublime_text.exe"));
		List<(string, string)> list2 = list;
		List<(string, string)> list3 = new List<(string, string)>();
		foreach (var (item, text) in list2)
		{
			if (text.Contains("\\"))
			{
				if (File.Exists(text))
				{
					list3.Add((item, text));
				}
			}
			else if (IsExecutableInPath(text))
			{
				list3.Add((item, text));
			}
		}
		list3.Insert(0, ("系统默认程序", "DEFAULT"));
		return list3;
	}

	private bool IsExecutableInPath(string exeName)
	{
		bool result;
		try
		{
			using Process process = new Process();
			process.StartInfo.FileName = exeName;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.Arguments = "/?";
			process.Start();
			process.Kill();
			result = true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private void BrowseAndOpen(string filePath)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog
		{
			Filter = "可执行文件 (*.exe)|*.exe|所有文件 (*.*)|*.*",
			Title = "选择用于打开文件的程序",
			CheckFileExists = true
		};
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			MySettingsProperty.Settings.LastUsedEditorPath = openFileDialog.FileName;
			MySettingsProperty.Settings.Save();
			string arguments = "\"" + filePath.Replace("\"", "\\\"\"") + "\"";
			Process.Start(openFileDialog.FileName, arguments);
		}
	}

	private DataGridViewRow GetSelectedJobRow()
	{
		if (dgvJobs.SelectedRows.Count == 0)
		{
			MessageBox.Show("请先在表格中选择一个任务。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			return null;
		}
		DataGridViewRow dataGridViewRow = dgvJobs.SelectedRows[0];
		if (dataGridViewRow.IsNewRow)
		{
			MessageBox.Show("请选择一个有效的任务行。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			return null;
		}
		if (dataGridViewRow.DataBoundItem == null)
		{
			MessageBox.Show("选中的行数据无效。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return null;
		}
		return dataGridViewRow;
	}

	public void RefreshColumnVisibility()
	{
		string[] configurableColumns = ConfigurableColumns;
		foreach (string text in configurableColumns)
		{
			if (dgvJobs.Columns.Contains(text))
			{
				bool settingOrDefault = GetSettingOrDefault($"ShowColumn_{text}", defaultValue: true);
				dgvJobs.Columns[text].Visible = settingOrDefault;
			}
		}
	}

	internal bool GetSettingOrDefault(string settingName, bool defaultValue)
	{
		bool result;
		try
		{
			object objectValue = RuntimeHelpers.GetObjectValue(MySettingsProperty.Settings[settingName]);
			result = ((objectValue == null) ? defaultValue : Conversions.ToBoolean(objectValue));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			result = defaultValue;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private void SetUIEnabled(bool enabled)
	{
		if (base.InvokeRequired)
		{
			Invoke((VB_0024AnonymousDelegate_1)([SpecialName] () =>
			{
				SetUIEnabled(enabled);
			}));
			return;
		}
		RemoveMenuItem.Enabled = enabled;
		RemoveAllMenuItem.Enabled = enabled;
		NTSMenu.Enabled = enabled;
		StartMenuItem.Enabled = enabled;
		BtnStart.Enabled = enabled;
		btnScheduled.Enabled = enabled;
		KillMenuItem.Enabled = !enabled;
		BtnStop.Enabled = !enabled;
		HToolStripMenu.Enabled = enabled;
	}

	private void ShutdownComputer()
	{
		if (isStopping)
		{
			return;
		}
		if (!MySettingsProperty.Settings.ShutdownAfterCompletion)
		{
			return;
		}
		AutoShutdownDialog autoShutdownDialog = new AutoShutdownDialog(60);
		DialogResult dialogResult = default(DialogResult);
		Invoke((VB_0024AnonymousDelegate_1)([SpecialName] () =>
		{
			dialogResult = autoShutdownDialog.ShowDialog(this);
		}));
		if (dialogResult != DialogResult.OK)
		{
			return;
		}
		try
		{
			Process.Start("shutdown", "/s /t 10 /f /c \"任务已完成，系统即将关机\"");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Exception ex3 = ex2;
			Invoke((VB_0024AnonymousDelegate_1)([SpecialName] () =>
			{
				MessageBox.Show($"无法执行关机：{ex3.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}));
			ProjectData.ClearProjectError();
		}
	}

	private void CleanUpLockFiles()
	{
		checked
		{
			int num = jobList.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				JobItem jobItem = jobList[i];
				if (string.IsNullOrEmpty(jobItem.FilePath))
				{
					continue;
				}
				string text = Path.ChangeExtension(jobItem.FilePath, ".lck");
				if (File.Exists(text))
				{
					try
					{
						File.Delete(text);
						AppendLog($"已删除锁文件: {Path.GetFileName(text)}");
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						AppendLog($"无法删除锁文件 {text}: {ex2.Message}");
						ProjectData.ClearProjectError();
					}
				}
			}
		}
	}

	private void Addfiles()
	{
		OpenFileDialog1.Filter = "INP Files (*.inp)|*.inp";
		OpenFileDialog1.Multiselect = true;
		if (OpenFileDialog1.ShowDialog() != DialogResult.OK)
		{
			return;
		}
		string[] fileNames = OpenFileDialog1.FileNames;
		_Closure_0024__20_002D0 closure_0024__20_002D = default(_Closure_0024__20_002D0);
		for (int i = 0; i < fileNames.Length; i = checked(i + 1))
		{
			closure_0024__20_002D = new _Closure_0024__20_002D0(closure_0024__20_002D);
			closure_0024__20_002D._0024VB_0024Local_f = fileNames[i];
			if (!jobList.Any(closure_0024__20_002D._Lambda_0024__0))
			{
				jobList.Add(new JobItem(closure_0024__20_002D._0024VB_0024Local_f));
				UpdateUI();
				UpdateStaLable();
			}
		}
	}

	private void RemoveAll()
	{
		if (jobList == null || jobList.Count == 0)
		{
			MessageBox.Show("当前没有任务可删除。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			return;
		}
		DialogResult dialogResult = MessageBox.Show("确定要删除所有任务吗？", "确认删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		if (dialogResult != DialogResult.No)
		{
			isStopping = true;
			TerminateAllRunningJobs();
			Invoke((VB_0024AnonymousDelegate_1)([SpecialName] () =>
			{
				jobList.Clear();
			}));
			UpdateUI();
			UpdateStaLable();
		}
	}

	private void StartScheduledCountdown(DateTime targetTime)
	{
		scheduledStartTime = targetTime;
		scheduledStartTimer?.Stop();
		scheduledStartTimer = new System.Windows.Forms.Timer();
		int num = checked((int)Math.Round((targetTime - DateTime.Now).TotalMilliseconds));
		if (num < 0)
		{
			num = 0;
		}
		scheduledStartTimer.Interval = num;
		scheduledStartTimer.Tick += OnScheduledTimeReached;
		scheduledStartTimer.Start();
		countdownTimer?.Stop();
		countdownTimer = new System.Windows.Forms.Timer();
		countdownTimer.Interval = 60000;
		countdownTimer.Tick += UpdateScheduledDisplay;
		countdownTimer.Start();
		UpdateScheduledDisplay(null, null);
		AppendLog($"[计划] 将于 {targetTime:MM-dd HH:mm} 启动任务");
	}

	private void OnScheduledTimeReached(object sender, EventArgs e)
	{
		CleanupScheduledTimers();
		lblScheduledInfo.Text = "";
		maxParallel = GetCurrentMaxParallel();
		cpuThreads = GetCurrentCpus();
		isStopping = false;
		txtLog.Clear();
		ScheduleJobs();
		AppendLog("[信息] 定时任务已启动");
	}

	private void UpdateScheduledDisplay(object sender, EventArgs e)
	{
		if (scheduledStartTime.HasValue && DateTime.Compare(scheduledStartTime.Value, DateTime.Now) > 0)
		{
			DateTime value = scheduledStartTime.Value;
			int num = checked((int)Math.Floor((value - DateTime.Now).TotalMinutes));
			if (num < 0)
			{
				num = 0;
			}
			int num2 = num / 60;
			int num3 = num % 60;
			string arg = $"{value:HH:mm}";
			string arg2 = ((num2 <= 0) ? $"（{num3}分后）启动" : $"（{num2}小时{num3}分后）启动");
			lblScheduledInfo.Text = $"{arg}{arg2}";
		}
		else
		{
			lblScheduledInfo.Text = "";
		}
	}

	private void CleanupScheduledTimers()
	{
		scheduledStartTimer?.Stop();
		countdownTimer?.Stop();
		if (scheduledStartTimer != null)
		{
			scheduledStartTimer.Tick -= OnScheduledTimeReached;
			scheduledStartTimer.Dispose();
		}
		if (countdownTimer != null)
		{
			countdownTimer.Tick -= UpdateScheduledDisplay;
			countdownTimer.Dispose();
		}
		scheduledStartTimer = null;
		countdownTimer = null;
		scheduledStartTime = null;
	}

	private void CancelScheduledStart()
	{
		CleanupScheduledTimers();
		lblScheduledInfo.Text = "";
		AppendLog("[信息] 已取消定时启动");
		SetUIEnabled(enabled: true);
	}

	private void dgvJobs_SelectionChanged(object sender, EventArgs e)
	{
		int num = -1;
		if (dgvJobs.CurrentCell != null)
		{
			num = dgvJobs.CurrentCell.RowIndex;
		}
		if (num >= 0 && num < jobList.Count)
		{
			currentSelectedIndex = num;
			UpdateStaDisplay(num);
			UpdateWarningDisplay(num);
		}
		else
		{
			currentSelectedIndex = -1;
			txtStatus.Text = "(未选择任务)";
			txtWarn.Text = "(未选择任务)";
		}
	}

	private void XTSMenu_Click(object sender, EventArgs e)
	{
		int runningJobCount = GetRunningJobCount();
		if (runningJobCount > 0)
		{
			string text = $"当前有 {runningJobCount} 个任务正在运行。是否强制结束所有任务并退出程序？";
			DialogResult dialogResult = MessageBox.Show(text, "任务正在进行", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
			if (dialogResult == DialogResult.Yes)
			{
				TerminateAllRunningJobs();
				Close();
			}
		}
		else
		{
			Close();
		}
	}

	private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
	{
		int runningJobCount = GetRunningJobCount();
		if (runningJobCount > 0)
		{
			string text = $"当前有 {runningJobCount} 个任务正在运行。是否强制结束所有任务并退出程序？";
			DialogResult dialogResult = MessageBox.Show(text, "任务正在进行", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
			if (dialogResult == DialogResult.Yes)
			{
				TerminateAllRunningJobs();
			}
			else
			{
				e.Cancel = true;
			}
		}
	}

	private void OTSMenu_Click(object sender, EventArgs e)
	{
		Addfiles();
	}

	private void NTSMenu_Click(object sender, EventArgs e)
	{
		RemoveAll();
	}

	private void BtnStart_Click_2(object sender, EventArgs e)
	{
		if (MySettingsProperty.Settings.CleanLckBeforeStart)
		{
			CleanUpLockFiles();
		}
		StartCalculate();
	}

	private void BtnStop_Click_1(object sender, EventArgs e)
	{
		if (scheduledStartTime.HasValue)
		{
			CancelScheduledStart();
		}
		else
		{
			KillJob();
		}
	}

	private void StartMenuItem_Click(object sender, EventArgs e)
	{
		StartCalculate();
	}

	private void KillMenuItem_Click(object sender, EventArgs e)
	{
		KillJob();
	}

	private void AboutTSMenu_Click(object sender, EventArgs e)
	{
		if (dgvJobs.CurrentRow != null)
		{
			dgvJobs.ClearSelection();
			currentSelectedIndex = -1;
		}
		string text = "Abaqus 批处理任务管理器\r\n========================================\r\n\r\n作者：Cui Davis      版本：V01\r\n\r\n使用步骤：\r\n1. 启动时自动检索，如检索失败需手动【设置】 Abaqus.bat 路径\r\n2. 【添加】或拖入 .inp 文件（计算中可添加）\r\n3. （可选）【添加】或拖入子程序文件（可添加到等待中的任务）\r\n4. 在【文件】菜单下可以使用多对多添加带子程序的inp文件\r\n5. 调整【并行数】和【CPU 核数】（计算中可调整）\r\n6. 点击【开始计算】提交任务\r\n7. 计算过程中选择列表中任务可查看状态与日志\r\n8. （可选）勾选【完成后自动关机】\r\n9. 新增定时开始功能，点击停止可取消定时\r\n10. 新增完成判定字符设置，整合右键菜单\r\n11. 增加并行上限，优化状态更新\r\n";
		txtLog.Text = text;
		txtLog.SelectionStart = txtLog.TextLength;
		txtLog.ScrollToCaret();
	}

	private void UpTSMenuI_Click(object sender, EventArgs e)
	{
		MoveSelectedJob(-1);
	}

	private void DownTSMenu_Click(object sender, EventArgs e)
	{
		MoveSelectedJob(1);
	}

	private void AddinpMenuItem_Click(object sender, EventArgs e)
	{
		Addfiles();
	}

	private void AddSubMenuItem_Click(object sender, EventArgs e)
	{
		if (currentSelectedIndex < 0 || currentSelectedIndex >= jobList.Count)
		{
			MessageBox.Show("请先选择一个任务行。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			return;
		}
		using OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = "Fortran 子程序 (*.for)|*.for|Fortran 子程序 (*.f)|*.f|所有文件 (*.*)|*.*";
		openFileDialog.Title = "选择子程序文件";
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			AddUSubFileToRow(currentSelectedIndex, openFileDialog.FileName);
		}
	}

	private void EditTSMenu_Click(object sender, EventArgs e)
	{
		using SettingsForm settingsForm = new SettingsForm();
		settingsForm.RequestCleanLockFiles += CleanUpLockFiles;
		settingsForm.ShowDialog();
		settingsForm.RequestCleanLockFiles -= CleanUpLockFiles;
	}

	private void btnNInp1For_Click(object sender, EventArgs e)
	{
		_Closure_0024__45_002D0 arg = default(_Closure_0024__45_002D0);
		_Closure_0024__45_002D0 CS_0024_003C_003E8__locals0 = new _Closure_0024__45_002D0(arg);
		CS_0024_003C_003E8__locals0._0024VB_0024Me = this;
		CS_0024_003C_003E8__locals0._0024VB_0024Local_sender = sender;
		CS_0024_003C_003E8__locals0._0024VB_0024Local_e = e;
		if (base.InvokeRequired)
		{
			Invoke((MethodInvoker)([SpecialName] () =>
			{
				CS_0024_003C_003E8__locals0._0024VB_0024Me.btnNInp1For_Click(RuntimeHelpers.GetObjectValue(CS_0024_003C_003E8__locals0._0024VB_0024Local_sender), CS_0024_003C_003E8__locals0._0024VB_0024Local_e);
			}));
			return;
		}
		List<string> list = SelectMultipleInp();
		if (list.Count == 0)
		{
			return;
		}
		string text = SelectSingleForOrF();
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		using (List<string>.Enumerator enumerator = list.GetEnumerator())
		{
			_Closure_0024__45_002D1 closure_0024__45_002D = default(_Closure_0024__45_002D1);
			while (enumerator.MoveNext())
			{
				closure_0024__45_002D = new _Closure_0024__45_002D1(closure_0024__45_002D);
				closure_0024__45_002D._0024VB_0024Local_f = enumerator.Current;
				if (!jobList.Any(closure_0024__45_002D._Lambda_0024__1))
				{
					jobList.Add(new JobItem(closure_0024__45_002D._0024VB_0024Local_f, text));
				}
			}
		}
		AppendLog($"[N:1] 添加 {list.Count} 个任务");
		UpdateStaLable();
	}

	private void btnNInpNFor_Click(object sender, EventArgs e)
	{
		_Closure_0024__46_002D0 arg = default(_Closure_0024__46_002D0);
		_Closure_0024__46_002D0 CS_0024_003C_003E8__locals0 = new _Closure_0024__46_002D0(arg);
		CS_0024_003C_003E8__locals0._0024VB_0024Me = this;
		CS_0024_003C_003E8__locals0._0024VB_0024Local_sender = sender;
		CS_0024_003C_003E8__locals0._0024VB_0024Local_e = e;
		if (base.InvokeRequired)
		{
			Invoke((MethodInvoker)([SpecialName] () =>
			{
				CS_0024_003C_003E8__locals0._0024VB_0024Me.btnNInpNFor_Click(RuntimeHelpers.GetObjectValue(CS_0024_003C_003E8__locals0._0024VB_0024Local_sender), CS_0024_003C_003E8__locals0._0024VB_0024Local_e);
			}));
			return;
		}
		List<string> list = SelectMultipleInp();
		if (list.Count == 0)
		{
			return;
		}
		List<string> list2 = SelectMultipleForOrF();
		if (list2.Count == 0)
		{
			return;
		}
		if (list.Count != list2.Count)
		{
			MessageBox.Show($"数量不匹配：{list.Count} inp vs {list2.Count} for/f", "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		checked
		{
			int num = list.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				jobList.Add(new JobItem(list[i], list2[i]));
			}
			AppendLog($"[N:N] 添加 {list.Count} 个任务");
			UpdateStaLable();
		}
	}

	private void btn1InpNFor_Click(object sender, EventArgs e)
	{
		_Closure_0024__47_002D0 arg = default(_Closure_0024__47_002D0);
		_Closure_0024__47_002D0 CS_0024_003C_003E8__locals0 = new _Closure_0024__47_002D0(arg);
		CS_0024_003C_003E8__locals0._0024VB_0024Me = this;
		CS_0024_003C_003E8__locals0._0024VB_0024Local_sender = sender;
		CS_0024_003C_003E8__locals0._0024VB_0024Local_e = e;
		if (base.InvokeRequired)
		{
			Invoke((MethodInvoker)([SpecialName] () =>
			{
				CS_0024_003C_003E8__locals0._0024VB_0024Me.btn1InpNFor_Click(RuntimeHelpers.GetObjectValue(CS_0024_003C_003E8__locals0._0024VB_0024Local_sender), CS_0024_003C_003E8__locals0._0024VB_0024Local_e);
			}));
			return;
		}
		string text = SelectSingleInp();
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		List<string> list = SelectMultipleForOrF();
		if (list.Count == 0)
		{
			return;
		}
		string directoryName = Path.GetDirectoryName(text);
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text);
		string inpRenameMode = MySettingsProperty.Settings.InpRenameMode;
		checked
		{
			int num = list.Count - 1;
			_Closure_0024__47_002D1 closure_0024__47_002D = default(_Closure_0024__47_002D1);
			for (int i = 0; i <= num; i++)
			{
				closure_0024__47_002D = new _Closure_0024__47_002D1(closure_0024__47_002D);
				string text2 = list[i];
				closure_0024__47_002D._0024VB_0024Local_jobName = "";
				int num2 = 1;
				while (true)
				{
					if (Operators.CompareString(inpRenameMode, "ByForFileName", TextCompare: false) == 0)
					{
						string fileNameWithoutExtension2 = Path.GetFileNameWithoutExtension(text2);
						string arg2 = ((num2 == 1) ? "" : $"_{num2}");
						closure_0024__47_002D._0024VB_0024Local_jobName = $"{fileNameWithoutExtension}_{fileNameWithoutExtension2}{arg2}";
					}
					else
					{
						int num3 = i + num2;
						closure_0024__47_002D._0024VB_0024Local_jobName = $"{fileNameWithoutExtension}_{num3:D3}";
					}
					if (jobList.Any(closure_0024__47_002D._Lambda_0024__1))
					{
						num2++;
						if (num2 > 1000)
						{
							MessageBox.Show($"无法为 {text2} 生成唯一任务名，请检查任务列表。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							break;
						}
						continue;
					}
					jobList.Add(new JobItem(text, text2, closure_0024__47_002D._0024VB_0024Local_jobName));
					break;
				}
			}
			AppendLog($"[1:N] 添加 {list.Count} 个任务（共用 INP，独立任务名）");
			UpdateStaLable();
		}
	}

	private void btnOpenInp_Click(object sender, EventArgs e)
	{
		DataGridViewRow selectedJobRow = GetSelectedJobRow();
		if (selectedJobRow != null)
		{
			JobItem jobItem = (JobItem)selectedJobRow.DataBoundItem;
			OpenFileWithSmartChoice(jobItem.FilePath);
		}
		UpdateStaLable();
	}

	private void btnOpenUSubPath_Click(object sender, EventArgs e)
	{
		DataGridViewRow selectedJobRow = GetSelectedJobRow();
		if (selectedJobRow != null)
		{
			JobItem jobItem = (JobItem)selectedJobRow.DataBoundItem;
			OpenFileWithSmartChoice(jobItem.USubPath);
		}
	}

	private void btnShowInpFile_Click(object sender, EventArgs e)
	{
		DataGridViewRow selectedJobRow = GetSelectedJobRow();
		if (selectedJobRow != null)
		{
			JobItem jobItem = (JobItem)selectedJobRow.DataBoundItem;
			ShowFileInExplorer(jobItem.FilePath);
		}
	}

	private void btnShowSubroutineFile_Click(object sender, EventArgs e)
	{
		DataGridViewRow selectedJobRow = GetSelectedJobRow();
		if (selectedJobRow != null)
		{
			JobItem jobItem = (JobItem)selectedJobRow.DataBoundItem;
			ShowFileInExplorer(jobItem.USubPath);
		}
	}

	private void DGVMenu_Opening(object sender, CancelEventArgs e)
	{
		UpTSMenuI.Enabled = false;
		DownTSMenu.Enabled = false;
		RemoveMenuItem.Enabled = false;
		AddSubMenuItem.Enabled = false;
		RemoveUSubMenuItem.Enabled = false;
		btnOpenInp.Enabled = false;
		btnOpenUSubPath.Enabled = false;
		btnShowInpFile.Enabled = false;
		btnShowSubroutineFile.Enabled = false;
		RemoveResMenuItem.Enabled = false;
		if (dgvJobs.SelectedRows.Count == 0)
		{
			return;
		}
		int index = dgvJobs.SelectedRows[0].Index;
		JobItem jobItem = jobList[index];
		if (!string.IsNullOrEmpty(jobItem.FilePath))
		{
			AddSubMenuItem.Enabled = true;
			btnOpenInp.Enabled = true;
			btnShowInpFile.Enabled = true;
		}
		if (!string.IsNullOrEmpty(jobItem.USubPath))
		{
			btnOpenUSubPath.Enabled = true;
			btnShowSubroutineFile.Enabled = true;
		}
		if (!string.IsNullOrEmpty(jobItem.OldJobName))
		{
			RemoveResMenuItem.Enabled = true;
		}
		checked
		{
			if (Operators.CompareString(jobItem.Status, "等待", TextCompare: false) == 0 || Operators.CompareString(jobItem.Status, "已终止", TextCompare: false) == 0)
			{
				RemoveMenuItem.Enabled = true;
				if (!string.IsNullOrEmpty(jobItem.FilePath))
				{
					AddSubMenuItem.Enabled = true;
				}
				if (!string.IsNullOrEmpty(jobItem.USubPath))
				{
					RemoveUSubMenuItem.Enabled = true;
				}
				if (index > 0 && Operators.CompareString(jobList[index - 1].Status, "等待", TextCompare: false) == 0)
				{
					UpTSMenuI.Enabled = true;
				}
				if (index < jobList.Count - 1 && Operators.CompareString(jobList[index + 1].Status, "等待", TextCompare: false) == 0)
				{
					DownTSMenu.Enabled = true;
				}
			}
		}
	}

	private void dgvJobs_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
		if (e.ColumnIndex == 0 && e.RowIndex >= 0)
		{
			e.Value = checked(e.RowIndex + 1).ToString();
			e.FormattingApplied = true;
		}
	}

	private void RemoveMenuItem_Click(object sender, EventArgs e)
	{
		if (dgvJobs.SelectedRows.Count > 0)
		{
			jobList.RemoveAt(dgvJobs.SelectedRows[0].Index);
		}
		UpdateStaLable();
	}

	private void RemoveAllMenuItem_Click(object sender, EventArgs e)
	{
		RemoveAll();
	}

	private void RemoveUSubMenuItem_Click(object sender, EventArgs e)
	{
		if (dgvJobs.SelectedRows.Count != 0)
		{
			int index = dgvJobs.SelectedRows[0].Index;
			JobItem jobItem = jobList[index];
			if (string.IsNullOrEmpty(jobItem.USubPath))
			{
				MessageBox.Show("该任务未关联子程序文件。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			jobItem.USubPath = "";
			UpdateUI();
		}
	}

	private void RemoveResMenuItem_Click(object sender, EventArgs e)
	{
		if (dgvJobs.SelectedRows.Count != 0)
		{
			int index = dgvJobs.SelectedRows[0].Index;
			JobItem jobItem = jobList[index];
			if (string.IsNullOrEmpty(jobItem.OldJobName))
			{
				MessageBox.Show("该任务未关联重启动文件（.res）。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			jobItem.OldJobName = "";
			jobItem.TaskType = "Full analysis";
			UpdateUI();
		}
	}

	private void UpdateUI()
	{
		if (base.InvokeRequired)
		{
			Invoke((VB_0024AnonymousDelegate_1)([SpecialName] () =>
			{
				UpdateUI();
			}));
		}
		else
		{
			dgvJobs.Refresh();
		}
	}

	private void AppendLog(string text)
	{
		if (base.InvokeRequired)
		{
			Invoke((VB_0024AnonymousDelegate_1)([SpecialName] () =>
			{
				AppendLog(text);
			}));
			return;
		}
		txtLog.AppendText($"[{DateTime.Now:HH:mm:ss}] {text}{Environment.NewLine}");
		if (MySettingsProperty.Settings.AutoScrollOnUpdate)
		{
			txtLog.ScrollToCaret();
		}
	}

	private void UpdateStaDisplay(int jobIndex)
	{
		if (jobIndex >= 0 && jobIndex < jobList.Count)
		{
			txtStatus.Text = jobList[jobIndex].LatestLog;
			if (MySettingsProperty.Settings.AutoScrollOnUpdate)
			{
				txtStatus.SelectionStart = txtStatus.Text.Length;
				txtStatus.SelectionLength = 0;
				txtStatus.ScrollToCaret();
			}
		}
	}

	private void UpdateWarningDisplay(int jobIndex)
	{
		List<string> uniqueWarnings = jobList[jobIndex].UniqueWarnings;
		List<string> list = new List<string>();
		list.AddRange(uniqueWarnings);
		txtWarn.Text = string.Join(Environment.NewLine, list);
		txtWarn.AppendText("\r\n");
		if (MySettingsProperty.Settings.AutoScrollOnUpdate)
		{
			txtWarn.ScrollToCaret();
		}
	}

	private void TabpageN_Selected(object sender, TabControlEventArgs e)
	{
		if (!MySettingsProperty.Settings.AutoScrollOnTabSwitch)
		{
			return;
		}
		BeginInvoke((VB_0024AnonymousDelegate_1)([SpecialName] () =>
		{
			if (e.TabPage == TabPage1)
			{
				if (txtLog.TextLength > 0)
				{
					txtLog.SelectionStart = txtLog.TextLength;
					txtLog.SelectionLength = 0;
					txtLog.ScrollToCaret();
				}
			}
			else if (e.TabPage == TabPage2)
			{
				if (txtStatus.TextLength > 0)
				{
					txtStatus.SelectionStart = txtStatus.TextLength;
					txtStatus.SelectionLength = 0;
					txtStatus.ScrollToCaret();
				}
			}
			else if (e.TabPage == TabPage3 && txtWarn.TextLength > 0)
			{
				txtWarn.SelectionStart = txtWarn.TextLength;
				txtWarn.SelectionLength = 0;
				txtWarn.ScrollToCaret();
			}
		}));
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		dgvJobs.AutoGenerateColumns = false;
		dgvJobs.DataSource = jobList;
		dgvJobs.Columns.Clear();
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn
		{
			Name = "RowIndex",
			HeaderText = "序号",
			Width = 60,
			ReadOnly = true
		};
		dataGridViewTextBoxColumn.DefaultCellStyle.BackColor = SystemColors.Control;
		dgvJobs.Columns.Insert(0, dataGridViewTextBoxColumn);
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn
		{
			Name = "FilePath",
			HeaderText = "INP 文件",
			DataPropertyName = "FilePath",
			Width = 240,
			ReadOnly = true
		};
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn
		{
			Name = "USubPath",
			HeaderText = "子程序 (.for/.f)",
			DataPropertyName = "USubPath",
			Width = 200,
			ReadOnly = false
		};
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn
		{
			Name = "Status",
			HeaderText = "状态",
			DataPropertyName = "Status",
			ReadOnly = true,
			Width = 60
		};
		DataGridViewTextBoxColumn colOdbPath = new DataGridViewTextBoxColumn
		{
			Name = "OdbPath",
			HeaderText = "ODB 文件",
			DataPropertyName = "OdbPath",
			ReadOnly = true,
			Width = 260
		};
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn
		{
			Name = "JobName",
			HeaderText = "任务名",
			DataPropertyName = "JobName",
			Visible = false,
			Width = 80
		};
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn
		{
			Name = "OutputDir",
			HeaderText = "输出路径",
			DataPropertyName = "OutputDir",
			Visible = true,
			Width = 220
		};
		DataGridViewComboBoxColumn dataGridViewComboBoxColumn = new DataGridViewComboBoxColumn
		{
			Name = "TaskType",
			HeaderText = "任务类型",
			DataPropertyName = "TaskType",
			Visible = false,
			DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton,
			Width = 120
		};
		dataGridViewComboBoxColumn.Items.AddRange("Full analysis", "Restart", "Recover");
		DataGridViewComboBoxColumn dataGridViewComboBoxColumn2 = new DataGridViewComboBoxColumn
		{
			Name = "SolverType",
			HeaderText = "求解器",
			DataPropertyName = "SolverType",
			Visible = false,
			DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton
		};
		dataGridViewComboBoxColumn2.Items.AddRange("Auto", "Standard", "Explicit");
		DataGridViewTextBoxColumn dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn
		{
			Name = "OldJobName",
			HeaderText = "重启动文件名（.res）",
			DataPropertyName = "OldJobName",
			Visible = false,
			Width = 160
		};
		dgvJobs.Columns.AddRange(dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, colOdbPath, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewComboBoxColumn, dataGridViewComboBoxColumn2, dataGridViewTextBoxColumn7);
		RefreshColumnVisibility();
		dgvJobs.AllowDrop = true;
		dgvJobs.DragEnter += dgvJobs_DragEnter;
		dgvJobs.DragDrop += dgvJobs_DragDrop;
		ToolStrip1.Items.Add(new ToolStripLabel("并行数量："));
		numParallelToolStrip = new ToolStripNumericUpDown();
		NumericUpDown numericUpDownControl = numParallelToolStrip.NumericUpDownControl;
		numericUpDownControl.Minimum = 1m;
		numericUpDownControl.Maximum = 100m;
		numericUpDownControl.Value = 1m;
		numericUpDownControl.Font = new Font("Microsoft YaHei", 9f);
		numericUpDownControl.TextAlign = HorizontalAlignment.Center;
		numericUpDownControl = null;
		ToolStrip1.Items.Add(numParallelToolStrip);
		ToolStrip1.Items.Add(new ToolStripLabel("    "));
		ToolStrip1.Items.Add(new ToolStripLabel("CPU数："));
		numCpusToolStrip = new ToolStripNumericUpDown();
		NumericUpDown numericUpDownControl2 = numCpusToolStrip.NumericUpDownControl;
		numericUpDownControl2.Minimum = 1m;
		numericUpDownControl2.Maximum = 128m;
		numericUpDownControl2.Value = new decimal(Math.Max(Environment.ProcessorCount / 2, 1));
		numericUpDownControl2.Font = new Font("Microsoft YaHei", 9f);
		numericUpDownControl2.TextAlign = HorizontalAlignment.Center;
		numericUpDownControl2 = null;
		ToolStrip1.Items.Add(numCpusToolStrip);
		string text = FindAbaqusBat();
		if (!string.IsNullOrEmpty(text))
		{
			if (!File.Exists(MySettingsProperty.Settings.AbaqusPath))
			{
				MySettingsProperty.Settings.AbaqusPath = text;
				MySettingsProperty.Settings.Save();
			}
			AppendLog($"[信息] 自动检测到 Abaqus 路径: {text}");
		}
		else
		{
			AppendLog("[提示] 未自动检测到 Abaqus 安装路径，请通过【设置】手动指定 abaqus.bat 文件。");
		}
	}

	private void dgvJobs_DragEnter(object sender, DragEventArgs e)
	{
		if (e.Data.GetDataPresent(DataFormats.FileDrop))
		{
			string[] source = (string[])e.Data.GetData(DataFormats.FileDrop);
			if (source.Any([SpecialName] (string f) => Operators.CompareString(Path.GetExtension(f).ToLower(), ".inp", TextCompare: false) == 0) || source.Any([SpecialName] (string f) => Operators.CompareString(Path.GetExtension(f).ToLower(), ".for", TextCompare: false) == 0) || source.Any([SpecialName] (string f) => Operators.CompareString(Path.GetExtension(f).ToLower(), ".f", TextCompare: false) == 0) || source.Any([SpecialName] (string f) => Operators.CompareString(Path.GetExtension(f).ToLower(), ".res", TextCompare: false) == 0))
			{
				e.Effect = DragDropEffects.Copy;
				return;
			}
		}
		e.Effect = DragDropEffects.None;
	}

	private void dgvJobs_DragDrop(object sender, DragEventArgs e)
	{
		if (!e.Data.GetDataPresent(DataFormats.FileDrop))
		{
			return;
		}
		string[] array = (string[])e.Data.GetData(DataFormats.FileDrop);
		Point point = dgvJobs.PointToClient(new Point(e.X, e.Y));
		DataGridView.HitTestInfo hitTestInfo = dgvJobs.HitTest(point.X, point.Y);
		string[] array2 = array;
		_Closure_0024__81_002D0 closure_0024__81_002D = default(_Closure_0024__81_002D0);
		for (int i = 0; i < array2.Length; i = checked(i + 1))
		{
			closure_0024__81_002D = new _Closure_0024__81_002D0(closure_0024__81_002D);
			closure_0024__81_002D._0024VB_0024Local_f = array2[i];
			string left = Path.GetExtension(closure_0024__81_002D._0024VB_0024Local_f).ToLower();
			if (Operators.CompareString(left, ".inp", TextCompare: false) == 0)
			{
				if (!jobList.Any(closure_0024__81_002D._Lambda_0024__0))
				{
					string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(closure_0024__81_002D._0024VB_0024Local_f);
					jobList.Add(new JobItem(closure_0024__81_002D._0024VB_0024Local_f)
					{
						JobName = fileNameWithoutExtension
					});
					AppendLog($"已添加任务: {fileNameWithoutExtension}");
				}
			}
			else if (Operators.CompareString(left, ".for", TextCompare: false) == 0 || Operators.CompareString(left, ".f", TextCompare: false) == 0)
			{
				if (hitTestInfo.RowIndex >= 0 && hitTestInfo.RowIndex < jobList.Count)
				{
					int rowIndex = hitTestInfo.RowIndex;
					if (!string.IsNullOrEmpty(jobList[rowIndex].FilePath))
					{
						AddUSubFileToRow(rowIndex, closure_0024__81_002D._0024VB_0024Local_f);
					}
				}
			}
			else if (Operators.CompareString(left, ".res", TextCompare: false) == 0 && hitTestInfo.RowIndex >= 0 && hitTestInfo.RowIndex < jobList.Count)
			{
				int rowIndex2 = hitTestInfo.RowIndex;
				string filePath = jobList[rowIndex2].FilePath;
				if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
				{
					AddRestartFileToRow(rowIndex2, closure_0024__81_002D._0024VB_0024Local_f, filePath);
				}
				else
				{
					MessageBox.Show("请先为该行指定有效的 INP 文件，再拖入 .res 文件。", "操作无效", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			UpdateUI();
			UpdateStaLable();
		}
	}

	private void AddUSubFileToRow(int rowIndex, string forFilePath)
	{
		if (rowIndex >= 0 && rowIndex < jobList.Count && File.Exists(forFilePath))
		{
			jobList[rowIndex].USubPath = forFilePath;
			UpdateUI();
			AppendLog($"已关联子程序: {Path.GetFileName(forFilePath)} 到任务 {checked(rowIndex + 1)}");
		}
	}

	private void AddRestartFileToRow(int rowIndex, string resFilePath, string inpFilePath)
	{
		if (!File.Exists(resFilePath))
		{
			return;
		}
		string text = Path.GetDirectoryName(resFilePath).TrimEnd('\\');
		string text2 = Path.GetDirectoryName(inpFilePath).TrimEnd('\\');
		if (string.Compare(text, text2, ignoreCase: true) != 0)
		{
			DialogResult dialogResult = MessageBox.Show($"重启动文件路径：{text}{Environment.NewLine}" + $"INP 文件路径：{text2}{Environment.NewLine}{Environment.NewLine}" + "路径不一致，可能导致求解失败。是否仍要关联？", "路径不匹配", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
			if (dialogResult == DialogResult.No)
			{
				return;
			}
		}
		jobList[rowIndex].OldJobName = Path.GetFileName(resFilePath);
		jobList[rowIndex].TaskType = "Restart";
		AppendLog($"已关联重启动文件: {Path.GetFileName(resFilePath)} 到任务 {checked(rowIndex + 1)}");
	}

	private void StartCalculate()
	{
		if (jobList.Count == 0)
		{
			MessageBox.Show("请添加 INP 文件！", "提示");
			return;
		}
		maxParallel = GetCurrentMaxParallel();
		cpuThreads = GetCurrentCpus();
		isStopping = false;
		SetUIEnabled(enabled: false);
		txtLog.Clear();
		foreach (JobItem job in jobList)
		{
			job.Status = "等待";
		}
		UpdateStaLable();
		ScheduleJobs();
	}

	private void KillJob()
	{
		isStopping = true;
		AppendLog("正在终止所有运行中的任务...");
		TerminateAllRunningJobs();
		Invoke((VB_0024AnonymousDelegate_1)checked([SpecialName] () =>
		{
			int num = jobList.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				string status = jobList[i].Status;
				if (Operators.CompareString(status, "运行中", TextCompare: false) == 0)
				{
					jobList[i].Status = "已终止";
				}
			}
			UpdateUI();
			SetUIEnabled(enabled: true);
			UpdateStaLable();
		}));
	}

	private async void ScheduleJobs()
	{
		nextJobIndexToSchedule = 0;
		checked
		{
			_Closure_0024__86_002D0 closure_0024__86_002D = default(_Closure_0024__86_002D0);
			while (!isStopping)
			{
				while (nextJobIndexToSchedule < jobList.Count && !isStopping)
				{
					int runningJobCount = GetRunningJobCount();
					if (runningJobCount >= GetCurrentMaxParallel())
					{
						break;
					}
					int num = nextJobIndexToSchedule;
					UpdateJobStatus(num, "运行中");
					UpdateUI();
					ProcessInfo processInfo = StartAbaqusJob(num);
					if (processInfo != null)
					{
						closure_0024__86_002D = new _Closure_0024__86_002D0(closure_0024__86_002D);
						closure_0024__86_002D._0024VB_0024Me = this;
						closure_0024__86_002D._0024VB_0024Local_localIndex = num;
						closure_0024__86_002D._0024VB_0024Local_localPi = processInfo;
						Task.Run((Action)closure_0024__86_002D._Lambda_0024__0);
					}
					else
					{
						UpdateJobStatus(num, "失败");
					}
					nextJobIndexToSchedule++;
					UpdateUI();
					UpdateStaLable();
				}
				int runningJobCount2 = GetRunningJobCount();
				bool flag = nextJobIndexToSchedule >= jobList.Count;
				if (runningJobCount2 == 0 && flag)
				{
					break;
				}
				await Task.Delay(1000);
			}
			LogFinalSummary();
				if (MySettingsProperty.Settings.EnablePostProcess)
				{
					try {
						string batPath2 = MySettingsProperty.Settings.PostProcessBatPath;
						if (string.IsNullOrEmpty(batPath2) || !File.Exists(batPath2))
							batPath2 = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"python\run_postprocess.bat");						if (File.Exists(batPath2)) {
							string outputDir = System.IO.Path.GetDirectoryName(jobList[0].FilePath) ?? ".";
							string reportArgs = "--report --results-dir \"" + outputDir + "\"";
							AppendLog("[Post] Report: " + outputDir);
							Task.Run(() => {
								try {
									using (Process pr = new Process()) {
										pr.StartInfo = new ProcessStartInfo(batPath2, reportArgs) { UseShellExecute = false, CreateNoWindow = true, RedirectStandardOutput = true, RedirectStandardError = true, StandardOutputEncoding = System.Text.Encoding.UTF8, StandardErrorEncoding = System.Text.Encoding.UTF8 };
										pr.OutputDataReceived += (s, e) => { if (!string.IsNullOrEmpty(e.Data)) SafeInvoke(() => AppendLog(e.Data)); };
										pr.ErrorDataReceived += (s, e) => { if (!string.IsNullOrEmpty(e.Data)) SafeInvoke(() => AppendLog("[Rpt] " + e.Data)); };
										pr.Start(); pr.BeginOutputReadLine(); pr.BeginErrorReadLine();
										pr.WaitForExit(120000);
										SafeInvoke(() => AppendLog("[Post] Report done (exit " + pr.ExitCode + ")"));
									}
								} catch (Exception ex3) { SafeInvoke(() => AppendLog("[Post] Report err: " + ex3.Message)); }
							});
						}
					} catch (Exception ex2) { AppendLog("[Post] Report err: " + ex2.Message); }
				}
			SetUIEnabled(enabled: true);
			UpdateUI();
			UpdateStaLable();
			ShutdownComputer();
		}
	}

	private ProcessInfo StartAbaqusJob(int jobIndex)
	{
		JobItem jobItem = jobList[jobIndex];
		ProcessInfo result;
		checked
		{
			if (string.IsNullOrEmpty(jobItem.FilePath) || !File.Exists(jobItem.FilePath))
			{
				UpdateJobStatus(jobIndex, "失败");
				AppendLog($"[错误] 任务 {jobIndex + 1} 的 INP 文件无效或未指定。");
				result = null;
			}
			else
			{
				string text = jobItem.OutputDir?.Trim();
				if (string.IsNullOrEmpty(text) || !Directory.Exists(text))
				{
					text = Path.GetDirectoryName(jobItem.FilePath);
				}
				string text2 = jobItem.JobName?.Trim();
				if (string.IsNullOrEmpty(text2))
				{
					text2 = Path.GetFileNameWithoutExtension(jobItem.FilePath);
				}
				string text3 = MySettingsProperty.Settings.AbaqusPath.Trim();
				if (string.IsNullOrEmpty(text3))
				{
					text3 = "C:\\SIMULIA\\Commands\\abaqus.bat";
				}
				if (!File.Exists(text3))
				{
					UpdateJobStatus(jobIndex, "失败");
					AppendLog($"[错误] Abaqus 路径不存在: {text3}");
					result = null;
				}
				else
				{
					List<string> list = new List<string>();
					list.Add($"job={text2}");
					list.Add($"input=\"{jobItem.FilePath}\"");
					int currentCpus = GetCurrentCpus();
					list.Add($"cpus={currentCpus}");
					list.Add("memory=\"" + MySettingsProperty.Settings.MemoryLimit + "%\"");
					list.Add("interactive");
					list.Add("ask=off");
					string text4 = jobItem.TaskType?.Trim();
					if (Operators.CompareString(text4, "Restart", TextCompare: false) == 0 || Operators.CompareString(text4, "Recover", TextCompare: false) == 0)
					{
						if (string.IsNullOrEmpty(jobItem.OldJobName))
						{
							UpdateJobStatus(jobIndex, "失败");
							AppendLog($"[错误] 任务 {jobIndex + 1} 类型为 '{text4}'，但未指定重启动文件（.res）。");
							result = null;
							goto IL_0551;
						}
						string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(jobItem.OldJobName);
						list.Add($"oldjob={fileNameWithoutExtension}");
						if (Operators.CompareString(text4, "Restart", TextCompare: false) == 0 && MySettingsProperty.Settings.UseRestart)
						{
							list.Add("restart");
						}
						else if (Operators.CompareString(text4, "Recover", TextCompare: false) == 0 && MySettingsProperty.Settings.UseRecover)
						{
							list.Add("recover");
						}
						AppendLog($"[信息] 任务 {jobIndex + 1} 将以 {text4} 模式运行，基于旧任务: {fileNameWithoutExtension}");
					}
					string left = jobItem.SolverType?.Trim();
					if (Operators.CompareString(left, "Standard", TextCompare: false) == 0)
					{
						list.Add("standard");
					}
					else if (Operators.CompareString(left, "Explicit", TextCompare: false) == 0)
					{
						list.Add("explicit");
					}
					if (!string.IsNullOrEmpty(jobItem.USubPath) && File.Exists(jobItem.USubPath))
					{
						list.Add($"user=\"{jobItem.USubPath}\"");
						AppendLog($"[信息] 任务 {jobIndex + 1} 将使用子程序: {Path.GetFileName(jobItem.USubPath)}");
					}
					string text5 = Path.Combine(text, text2 + ".sta");
					if (File.Exists(text5))
					{
						try
						{
							File.Delete(text5);
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							AppendLog($"[警告] 无法删除旧日志文件 {text5}: {ex2.Message}");
							ProjectData.ClearProjectError();
						}
					}
					ProcessStartInfo processStartInfo = new ProcessStartInfo();
					processStartInfo.FileName = text3;
					processStartInfo.Arguments = string.Join(" ", list);
					processStartInfo.WorkingDirectory = text;
					processStartInfo.UseShellExecute = false;
					processStartInfo.CreateNoWindow = true;
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					processStartInfo.RedirectStandardOutput = true;
					processStartInfo.RedirectStandardError = true;
					ProcessStartInfo startInfo = processStartInfo;
					try
					{
						Process process = Process.Start(startInfo);
						if (process == null)
						{
							AppendLog($"[错误] 无法启动进程（返回 Nothing），任务 {jobIndex}");
							result = null;
						}
						else
						{
							process.OutputDataReceived += OnOutputDataReceived;
							process.ErrorDataReceived += OnErrorDataReceived;
							process.BeginOutputReadLine();
							process.BeginErrorReadLine();
							runningProcesses[jobIndex] = process;
							UpdateJobStatus(jobIndex, "运行中");
							UpdateUI();
							result = new ProcessInfo
							{
								Process = process,
								JobIndex = jobIndex,
								StaFile = text5,
								LastReadLineCount = 0
							};
						}
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						UpdateJobStatus(jobIndex, "失败");
						AppendLog($"[错误] 启动任务 {jobIndex} 失败: {ex4.Message}");
						UpdateUI();
						result = null;
						ProjectData.ClearProjectError();
					}
				}
			}
			goto IL_0551;
		}
		IL_0551:
		return result;
	}

	private void OnOutputDataReceived(object sender, DataReceivedEventArgs e)
	{
		if (string.IsNullOrEmpty(e.Data))
		{
			return;
		}
		string text = e.Data.Trim();
		AppendLog($"[OUT] {text}");
		if (text.IndexOf("COMPLETED", StringComparison.OrdinalIgnoreCase) < 0)
		{
			return;
		}
		Process process = (Process)sender;
		int num = -1;
		lock (runningProcesses)
		{
			foreach (KeyValuePair<int, Process> runningProcess in runningProcesses)
			{
				if (runningProcess.Value.Id == process.Id)
				{
					num = runningProcess.Key;
					break;
				}
			}
		}
		if (num >= 0 && num < jobList.Count)
		{
			jobList[num].CompletedDetected = true;
		}
	}

	private void OnErrorDataReceived(object sender, DataReceivedEventArgs e)
	{
		if (!string.IsNullOrEmpty(e.Data))
		{
			AppendLog($"[ERR]{e.Data}");
		}
	}

	private void MonitorJob(int jobIndex, ProcessInfo pi)
	{
		_Closure_0024__90_002D0 arg = new _Closure_0024__90_002D0(null);
		arg._0024VB_0024Me = this;
		arg._0024VB_0024Local_jobIndex = jobIndex;
		string staFile = pi.StaFile;
		string text = Path.ChangeExtension(staFile, ".dat");
		long num = 0L;
		long num2 = 0L;
		string pendingWarning = "";
		try
		{
			_Closure_0024__90_002D3 arg2 = default(_Closure_0024__90_002D3);
			_Closure_0024__90_002D3 CS_0024_003C_003E8__locals1 = new _Closure_0024__90_002D3(arg2);
			CS_0024_003C_003E8__locals1._0024VB_0024NonLocal__0024VB_0024Closure_2 = arg;
			while (!File.Exists(staFile) && pi.Process != null && !pi.Process.HasExited)
			{
				Thread.Sleep(500);
			}
			_Closure_0024__90_002D1 closure_0024__90_002D = default(_Closure_0024__90_002D1);
			_Closure_0024__90_002D2 closure_0024__90_002D2 = default(_Closure_0024__90_002D2);
			while (pi.Process != null && !pi.Process.HasExited && !isStopping)
			{
				if (File.Exists(staFile))
				{
					FileInfo fileInfo = new FileInfo(staFile);
					if (fileInfo.Length > num)
					{
						try
						{
							using FileStream fileStream = new FileStream(staFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
							fileStream.Position = num;
							using StreamReader streamReader = new StreamReader(fileStream);
							closure_0024__90_002D = new _Closure_0024__90_002D1(closure_0024__90_002D);
							closure_0024__90_002D._0024VB_0024NonLocal__0024VB_0024Closure_3 = CS_0024_003C_003E8__locals1;
							closure_0024__90_002D._0024VB_0024Local_newContent = streamReader.ReadToEnd();
							if (!string.IsNullOrEmpty(closure_0024__90_002D._0024VB_0024Local_newContent))
							{
								SafeInvoke(closure_0024__90_002D._Lambda_0024__0);
								num = fileInfo.Length;
							}
						}
						catch (IOException ex)
						{
							ProjectData.SetProjectError(ex);
							IOException ex2 = ex;
							ProjectData.ClearProjectError();
						}
					}
				}
				if (File.Exists(text))
				{
					FileInfo fileInfo2 = new FileInfo(text);
					if (fileInfo2.Length > num2)
					{
						try
						{
							using FileStream fileStream2 = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
							fileStream2.Position = num2;
							using StreamReader streamReader2 = new StreamReader(fileStream2);
							string text2 = streamReader2.ReadToEnd();
							if (!string.IsNullOrEmpty(text2))
							{
								closure_0024__90_002D2 = new _Closure_0024__90_002D2(closure_0024__90_002D2);
								closure_0024__90_002D2._0024VB_0024NonLocal__0024VB_0024Closure_4 = CS_0024_003C_003E8__locals1;
								closure_0024__90_002D2._0024VB_0024Local_newWarnings = ParseWarningsFromIncrement(text2, ref pendingWarning);
								if (closure_0024__90_002D2._0024VB_0024Local_newWarnings.Count > 0)
								{
									SafeInvoke(closure_0024__90_002D2._Lambda_0024__1);
								}
								num2 = fileInfo2.Length;
							}
						}
						catch (IOException ex3)
						{
							ProjectData.SetProjectError(ex3);
							IOException ex4 = ex3;
							ProjectData.ClearProjectError();
						}
					}
				}
				Thread.Sleep(1000);
			}
			CS_0024_003C_003E8__locals1._0024VB_0024Local_finalStaContent = "";
			if (File.Exists(staFile))
			{
				try
				{
					CS_0024_003C_003E8__locals1._0024VB_0024Local_finalStaContent = File.ReadAllText(staFile);
					SafeInvoke([SpecialName] () =>
					{
						CS_0024_003C_003E8__locals1._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.jobList[CS_0024_003C_003E8__locals1._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_jobIndex].LatestLog = CS_0024_003C_003E8__locals1._0024VB_0024Local_finalStaContent;
						if (CS_0024_003C_003E8__locals1._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.IsCurrentSelectedJob(CS_0024_003C_003E8__locals1._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_jobIndex))
						{
							CS_0024_003C_003E8__locals1._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.UpdateStaDisplay(CS_0024_003C_003E8__locals1._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_jobIndex);
						}
					});
				}
				catch (Exception ex5)
				{
					ProjectData.SetProjectError(ex5);
					Exception ex6 = ex5;
					ProjectData.ClearProjectError();
				}
			}
			else
			{
				CS_0024_003C_003E8__locals1._0024VB_0024Local_finalStaContent = "";
			}
			if (File.Exists(text))
			{
				try
				{
					_Closure_0024__90_002D4 arg3 = default(_Closure_0024__90_002D4);
					_Closure_0024__90_002D4 CS_0024_003C_003E8__locals0 = new _Closure_0024__90_002D4(arg3);
					CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_5 = CS_0024_003C_003E8__locals1;
					string incrementText = File.ReadAllText(text);
					CS_0024_003C_003E8__locals0._0024VB_0024Local_finalWarnings = ParseWarningsFromIncrement(incrementText, ref pendingWarning);
					if (!string.IsNullOrEmpty(pendingWarning))
					{
						CS_0024_003C_003E8__locals0._0024VB_0024Local_finalWarnings.Add(pendingWarning.Trim());
						pendingWarning = "";
					}
					if (CS_0024_003C_003E8__locals0._0024VB_0024Local_finalWarnings.Count > 0)
					{
						SafeInvoke([SpecialName] () =>
						{
							CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.jobList[CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_jobIndex].AddWarnings(CS_0024_003C_003E8__locals0._0024VB_0024Local_finalWarnings);
							if (CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.IsCurrentSelectedJob(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_jobIndex))
							{
								CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Me.UpdateWarningDisplay(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_jobIndex);
							}
						});
					}
				}
				catch (Exception ex7)
				{
					ProjectData.SetProjectError(ex7);
					Exception ex8 = ex7;
					ProjectData.ClearProjectError();
				}
			}
			bool flag = false;
			if (File.Exists(staFile))
			{
				try
				{
					string text3 = File.ReadAllText(staFile);
					if (!string.IsNullOrWhiteSpace(text3))
					{
						string value = MySettingsProperty.Settings.CompletionKeyword;
						if (string.IsNullOrWhiteSpace(value))
						{
							value = "COMPLETED SUCCESSFULLY";
						}
						flag = text3.IndexOf(value, StringComparison.OrdinalIgnoreCase) >= 0;
					}
					else
					{
						flag = jobList[CS_0024_003C_003E8__locals1._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_jobIndex].CompletedDetected;
					}
				}
				catch (Exception ex9)
				{
					ProjectData.SetProjectError(ex9);
					Exception ex10 = ex9;
					flag = jobList[CS_0024_003C_003E8__locals1._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_jobIndex].CompletedDetected;
					ProjectData.ClearProjectError();
				}
			}
			else
			{
				flag = jobList[CS_0024_003C_003E8__locals1._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_jobIndex].CompletedDetected;
			}
			if (!isStopping)
			{
				string status = (flag ? "完成" : "失败");
				UpdateJobStatus(CS_0024_003C_003E8__locals1._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_jobIndex, status);
					if (flag && MySettingsProperty.Settings.EnablePostProcess)
					{
						RunPostProcess(jobList[CS_0024_003C_003E8__locals1._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_jobIndex].OdbPath);
					}
			}
		}
		catch (Exception ex11)
		{
			ProjectData.SetProjectError(ex11);
			Exception ex12 = ex11;
			if (!isStopping)
			{
				AppendLog($"任务 {arg._0024VB_0024Local_jobIndex} 监控出错: {ex12.Message}");
				UpdateUI();
			}
			ProjectData.ClearProjectError();
		}
		finally
		{
			try
			{
				if (pi.Process != null)
				{
					if (!pi.Process.HasExited)
					{
						try
						{
							pi.Process.Kill();
							pi.Process.WaitForExit(2000);
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
					}
					pi.Process.Dispose();
				}
			}
			catch (Exception ex13)
			{
				ProjectData.SetProjectError(ex13);
				Exception ex14 = ex13;
				Debug.WriteLine($"[Cleanup] 清理进程失败: {ex14.Message}");
				ProjectData.ClearProjectError();
			}
			ConcurrentDictionary<int, Process> concurrentDictionary = runningProcesses;
			int _0024VB_0024Local_jobIndex = arg._0024VB_0024Local_jobIndex;
			Process value2 = null;
			concurrentDictionary.TryRemove(_0024VB_0024Local_jobIndex, out value2);
		}
		UpdateUI();
		UpdateStaLable();
	}

	private List<string> ParseWarningsFromIncrement(string incrementText, ref string pendingWarning)
	{
		List<string> list = new List<string>();
		if (string.IsNullOrEmpty(incrementText))
		{
			return list;
		}
		string[] array = incrementText.Replace("\r", "").Split('\n');
		string[] array2 = array;
		foreach (string text in array2)
		{
			bool flag = list.Count >= 100;
			if (list.Count >= 100 && string.IsNullOrEmpty(pendingWarning))
			{
				list.Add("更多警告请查看 .dat 文件.");
				break;
			}
			string text2 = text.Trim();
			if (string.IsNullOrEmpty(text2))
			{
				if (!flag && !string.IsNullOrEmpty(pendingWarning))
				{
					list.Add(pendingWarning.Trim());
					pendingWarning = "";
				}
			}
			else if (text2.StartsWith("***WARNING:", StringComparison.OrdinalIgnoreCase))
			{
				if (!string.IsNullOrEmpty(pendingWarning))
				{
					if (!flag)
					{
						list.Add(pendingWarning.Trim());
					}
					pendingWarning = "";
				}
				pendingWarning = text2;
			}
			else if (text2.StartsWith("*"))
			{
				if (!string.IsNullOrEmpty(pendingWarning))
				{
					if (!flag)
					{
						list.Add(pendingWarning.Trim());
					}
					pendingWarning = "";
				}
			}
			else if (!string.IsNullOrEmpty(pendingWarning))
			{
				pendingWarning = pendingWarning + " " + text2;
			}
		}
		return list;
	}

	private void SafeInvoke(Action action)
	{
		if (base.IsDisposed || base.Disposing)
		{
			return;
		}
		if (base.InvokeRequired)
		{
			try
			{
				Invoke(action);
				return;
			}
			catch (InvalidOperationException ex)
			{
				ProjectData.SetProjectError(ex);
				InvalidOperationException ex2 = ex;
				Debug.WriteLine("SafeInvoke: 窗体已关闭，跳过 UI 更新");
				ProjectData.ClearProjectError();
				return;
			}
		}
		action();
	}

	private bool IsCurrentSelectedJob(int index)
	{
		return index == currentSelectedIndex;
	}

	private void TerminateAllRunningJobs()
	{
		KeyValuePair<int, Process>[] array = runningProcesses.ToArray();
		KeyValuePair<int, Process>[] array2 = array;
		checked
		{
			for (int i = 0; i < array2.Length; i++)
			{
				KeyValuePair<int, Process> keyValuePair = array2[i];
				int key = keyValuePair.Key;
				Process value = keyValuePair.Value;
				try
				{
					if (value == null || value.HasExited)
					{
						continue;
					}
					AppendLog($"正在终止任务 {key + 1} (PID={value.Id}) 及其子进程...");
					try
					{
						using (Process process = new Process())
						{
							process.StartInfo.FileName = "taskkill";
							process.StartInfo.Arguments = $"/PID {value.Id} /T /F";
							process.StartInfo.CreateNoWindow = true;
							process.StartInfo.UseShellExecute = false;
							process.Start();
							process.WaitForExit(5000);
						}
						if (!value.HasExited)
						{
							value.WaitForExit(2000);
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						AppendLog($"taskkill 失败 (PID={value.Id}): {ex2.Message}");
						ProjectData.ClearProjectError();
					}
					if (!value.HasExited)
					{
						try
						{
							value.Kill();
							value.WaitForExit(1000);
						}
						catch (Exception ex3)
						{
							ProjectData.SetProjectError(ex3);
							Exception ex4 = ex3;
							AppendLog($"Fallback Kill 失败: {ex4.Message}");
							ProjectData.ClearProjectError();
						}
					}
				}
				catch (Exception ex5)
				{
					ProjectData.SetProjectError(ex5);
					Exception ex6 = ex5;
					AppendLog($"终止任务 {key + 1} 出错: {ex6.Message}");
					ProjectData.ClearProjectError();
				}
				finally
				{
					value?.Dispose();
					ConcurrentDictionary<int, Process> concurrentDictionary = runningProcesses;
					Process value2 = null;
					concurrentDictionary.TryRemove(key, out value2);
				}
			}
			AppendLog("所有任务终止信号已发送。");
			if (MySettingsProperty.Settings.CleanLckAfterStop)
			{
				CleanUpLockFiles();
			}
		}
	}

	private void MoveSelectedJob(int offset)
	{
		if (dgvJobs.SelectedRows.Count == 0)
		{
			return;
		}
		int index = dgvJobs.SelectedRows[0].Index;
		int num = checked(index + offset);
		if (num >= 0 && num < jobList.Count)
		{
			JobItem jobItem = jobList[index];
			JobItem jobItem2 = jobList[num];
			if (Operators.CompareString(jobItem.Status, "等待", TextCompare: false) == 0 && Operators.CompareString(jobItem2.Status, "等待", TextCompare: false) == 0)
			{
				jobList.RemoveAt(index);
				jobList.Insert(num, jobItem);
				dgvJobs.ClearSelection();
				dgvJobs.Rows[num].Selected = true;
				currentSelectedIndex = num;
				UpdateStaDisplay(num);
				UpdateUI();
				UpdateStaLable();
			}
		}
	}

	private void UpdateStaLable()
	{
		if (base.InvokeRequired)
		{
			Invoke((VB_0024AnonymousDelegate_1)([SpecialName] () =>
			{
				UpdateStaLable();
			}));
		}
		else
		{
			if (jobList == null)
			{
				return;
			}
			int count = jobList.Count;
			int num = nextJobIndexToSchedule;
			if (num > count)
			{
				num = count;
			}
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			checked
			{
				foreach (JobItem job in jobList)
				{
					if (Operators.CompareString(job.Status, "运行中", TextCompare: false) == 0)
					{
						num2++;
					}
					if (job.CompletedDetected)
					{
						num3++;
					}
					if (Operators.CompareString(job.Status, "失败", TextCompare: false) == 0)
					{
						num4++;
					}
				}
			}
			string text = (isStopping ? "任务已终止" : ((count == 0 || num == 0) ? "就绪" : ((num < count || num2 != 0) ? $"正在提交...({num}/{count})" : $"完成（{count}/{count}）")));
			tslStatus.Text = text;
			tslRunning.Text = $"运行中: {num2}";
			tslCompleted.Text = $"完成: {num3}";
			tslFailed.Text = $"失败: {num4}";
		}
	}

	private void UpdateJobStatus(int index, string status)
	{
		if (base.InvokeRequired)
		{
			Invoke((VB_0024AnonymousDelegate_1)([SpecialName] () =>
			{
				jobList[index].Status = status;
			}));
		}
		else
		{
			jobList[index].Status = status;
		}
		UpdateUI();
	}

		private void RunPostProcess(string odbPath)
		{
			try
			{
				string batPath = MySettingsProperty.Settings.PostProcessBatPath;
				if (string.IsNullOrEmpty(batPath) || !File.Exists(batPath))
					batPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"python\run_postprocess.bat");
				if (!File.Exists(batPath)) { AppendLog("[Post] bat not found: " + batPath); return; }
				string configCsv = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"result_config.csv");
				string args = "--odb \"" + odbPath + "\" --config \"" + configCsv + "\"";
				AppendLog("[Post] ODB: " + Path.GetFileName(odbPath));
				Task.Run(() =>
				{
					try
					{
						using (Process p = new Process())
						{
							p.StartInfo = new ProcessStartInfo(batPath, args)
							{
								UseShellExecute = false, CreateNoWindow = true,
								RedirectStandardOutput = true, RedirectStandardError = true,
								StandardOutputEncoding = System.Text.Encoding.UTF8,
								StandardErrorEncoding = System.Text.Encoding.UTF8
							};
							p.OutputDataReceived += (s, e) => { if (!string.IsNullOrEmpty(e.Data)) SafeInvoke(() => AppendLog(e.Data)); };
							p.ErrorDataReceived += (s, e) => { if (!string.IsNullOrEmpty(e.Data)) SafeInvoke(() => AppendLog("[Post] " + e.Data)); };
							p.Start(); p.BeginOutputReadLine(); p.BeginErrorReadLine();
							p.WaitForExit(300000);
							SafeInvoke(() => AppendLog("[Post] Done (exit " + p.ExitCode + ")"));
						}
					}
					catch (Exception ex2) { SafeInvoke(() => AppendLog("[Post] err: " + ex2.Message)); }
				});
			}
			catch (Exception ex) { AppendLog("[Post] err: " + ex.Message); }
		}

	private void LogFinalSummary()
	{
		if (jobList == null || jobList.Count == 0)
		{
			AppendLog("未检测到任何任务。");
			return;
		}
		int count = jobList.Count;
		int num = 0;
		int num2 = 0;
		List<string> list = new List<string>();
		checked
		{
			foreach (JobItem job in jobList)
			{
				if (job.CompletedDetected)
				{
					num++;
				}
				if (Operators.CompareString(job.Status, "失败", TextCompare: false) == 0)
				{
					num2++;
					if (!string.IsNullOrEmpty(job.FilePath))
					{
						string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(job.FilePath);
						list.Add(fileNameWithoutExtension);
					}
					else
					{
						list.Add("(未知文件)");
					}
				}
			}
			string text = ((list.Count > 0) ? string.Join("、", list) : "无");
			string text2 = $"提交总数量：{count}；完成：{num}；失败：{num2}；失败任务：{text}";
			AppendLog(text2);
		}
	}

	public void OpenFileWithSmartChoice(string filePath)
	{
		_Closure_0024__99_002D0 arg = default(_Closure_0024__99_002D0);
		_Closure_0024__99_002D0 CS_0024_003C_003E8__locals0 = new _Closure_0024__99_002D0(arg);
		CS_0024_003C_003E8__locals0._0024VB_0024Me = this;
		CS_0024_003C_003E8__locals0._0024VB_0024Local_filePath = filePath;
		if (string.IsNullOrEmpty(CS_0024_003C_003E8__locals0._0024VB_0024Local_filePath) || !File.Exists(CS_0024_003C_003E8__locals0._0024VB_0024Local_filePath))
		{
			MessageBox.Show("文件不存在或路径无效！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		List<(string, string)> availableEditorsWithIcons = GetAvailableEditorsWithIcons();
		if (availableEditorsWithIcons.Count == 0)
		{
			BrowseAndOpen(CS_0024_003C_003E8__locals0._0024VB_0024Local_filePath);
			return;
		}
		CS_0024_003C_003E8__locals0._0024VB_0024Local_form = new Form
		{
			Width = 400,
			Height = 280,
			Text = "选择打开方式",
			StartPosition = FormStartPosition.CenterParent,
			FormBorderStyle = FormBorderStyle.FixedDialog,
			MaximizeBox = false,
			MinimizeBox = false,
			ShowIcon = false
		};
		Label label = new Label
		{
			Text = "请选择用于打开文件的程序：",
			Left = 20,
			Top = 15,
			Width = 360
		};
		CS_0024_003C_003E8__locals0._0024VB_0024Local_lv = new ListView
		{
			View = View.LargeIcon,
			LargeImageList = new ImageList(),
			Left = 20,
			Top = 45,
			Width = 360,
			Height = 140,
			MultiSelect = false,
			FullRowSelect = false,
			HideSelection = false
		};
		ImageList imageList = new ImageList();
		imageList.ImageSize = new Size(32, 32);
		checked
		{
			int num = availableEditorsWithIcons.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				(string, string) tuple = availableEditorsWithIcons[i];
				Icon icon = null;
				if (Operators.CompareString(tuple.Item2, "DEFAULT", TextCompare: false) == 0)
				{
					try
					{
						icon = Icon.ExtractAssociatedIcon(CS_0024_003C_003E8__locals0._0024VB_0024Local_filePath);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						icon = SystemIcons.Application;
						ProjectData.ClearProjectError();
					}
				}
				else
				{
					try
					{
						icon = Icon.ExtractAssociatedIcon(tuple.Item2);
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						icon = SystemIcons.Application;
						ProjectData.ClearProjectError();
					}
				}
				if (icon != null)
				{
					Bitmap image = icon.ToBitmap();
					imageList.Images.Add(tuple.Item1, image);
					icon.Dispose();
				}
				else
				{
					imageList.Images.Add(tuple.Item1, SystemIcons.Application.ToBitmap());
				}
				ListViewItem value = new ListViewItem(tuple.Item1, tuple.Item1);
				CS_0024_003C_003E8__locals0._0024VB_0024Local_lv.Items.Add(value);
			}
			CS_0024_003C_003E8__locals0._0024VB_0024Local_lv.LargeImageList = imageList;
			string lastUsedEditorPath = MySettingsProperty.Settings.LastUsedEditorPath;
			if (Operators.CompareString(lastUsedEditorPath, "DEFAULT", TextCompare: false) == 0)
			{
				if (CS_0024_003C_003E8__locals0._0024VB_0024Local_lv.Items.Count > 0)
				{
					CS_0024_003C_003E8__locals0._0024VB_0024Local_lv.Items[0].Selected = true;
				}
			}
			else if (!string.IsNullOrEmpty(lastUsedEditorPath))
			{
				int num2 = availableEditorsWithIcons.Count - 1;
				for (int j = 1; j <= num2; j++)
				{
					if (string.Equals(availableEditorsWithIcons[j].Item2, lastUsedEditorPath, StringComparison.OrdinalIgnoreCase))
					{
						CS_0024_003C_003E8__locals0._0024VB_0024Local_lv.Items[j].Selected = true;
						CS_0024_003C_003E8__locals0._0024VB_0024Local_lv.EnsureVisible(j);
						break;
					}
				}
			}
			if (CS_0024_003C_003E8__locals0._0024VB_0024Local_lv.SelectedItems.Count == 0 && CS_0024_003C_003E8__locals0._0024VB_0024Local_lv.Items.Count > 0)
			{
				CS_0024_003C_003E8__locals0._0024VB_0024Local_lv.Items[0].Selected = true;
			}
			Button button = new Button
			{
				Text = "选择其他程序...",
				Left = 20,
				Top = 195,
				Width = 150
			};
			button.Click += [SpecialName] [DebuggerHidden] (object a0, EventArgs a1) =>
			{
				CS_0024_003C_003E8__locals0._Lambda_0024__0();
			};
			Button button2 = new Button
			{
				Text = "确定",
				DialogResult = DialogResult.OK,
				Left = 270,
				Top = 195,
				Width = 80
			};
			CS_0024_003C_003E8__locals0._0024VB_0024Local_form.Controls.AddRange(new Control[4] { label, CS_0024_003C_003E8__locals0._0024VB_0024Local_lv, button, button2 });
			if (CS_0024_003C_003E8__locals0._0024VB_0024Local_form.ShowDialog() == DialogResult.OK && CS_0024_003C_003E8__locals0._0024VB_0024Local_lv.SelectedItems.Count > 0)
			{
				int index = CS_0024_003C_003E8__locals0._0024VB_0024Local_lv.SelectedItems[0].Index;
				(string, string) tuple2 = availableEditorsWithIcons[index];
				if (Operators.CompareString(tuple2.Item2, "DEFAULT", TextCompare: false) == 0)
				{
					try
					{
						Process.Start(CS_0024_003C_003E8__locals0._0024VB_0024Local_filePath);
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						MessageBox.Show("无法使用默认程序打开文件：\r\n" + ex2.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						ProjectData.ClearProjectError();
					}
				}
				else
				{
					try
					{
						ProcessStartInfo startInfo = new ProcessStartInfo
						{
							FileName = tuple2.Item2,
							Arguments = "\"" + CS_0024_003C_003E8__locals0._0024VB_0024Local_filePath + "\"",
							UseShellExecute = true
						};
						Process.Start(startInfo);
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						MessageBox.Show($"无法启动程序：{ex4.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						ProjectData.ClearProjectError();
					}
				}
				MySettingsProperty.Settings.LastUsedEditorPath = tuple2.Item2;
				MySettingsProperty.Settings.Save();
			}
			CS_0024_003C_003E8__locals0._0024VB_0024Local_form.Dispose();
		}
	}

	public void ShowFileInExplorer(string filePath)
	{
		if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
		{
			MessageBox.Show("文件路径无效或文件不存在。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			return;
		}
		try
		{
			Process.Start("explorer.exe", $"/select,\"{filePath}\"");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show($"无法打开资源管理器：{ex2.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			ProjectData.ClearProjectError();
		}
	}

	private void btnScheduled_Click(object sender, EventArgs e)
	{
		if (jobList.Count == 0)
		{
			MessageBox.Show("请添加 INP 文件！", "提示");
			return;
		}
		foreach (JobItem job in jobList)
		{
			job.Status = "等待";
		}
		using ScheduleSetupForm scheduleSetupForm = new ScheduleSetupForm();
		if (scheduleSetupForm.ShowDialog(this) == DialogResult.OK && scheduleSetupForm.ScheduledTime.HasValue)
		{
			StartScheduledCountdown(scheduleSetupForm.ScheduledTime.Value);
			SetUIEnabled(enabled: false);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbaqusJob.Form1));
		this.DGVMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
		this.StartMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.KillMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.UpTSMenuI = new System.Windows.Forms.ToolStripMenuItem();
		this.DownTSMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.MergeOdbMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MergeOdbMenuItem.Click += MergeOdbMenuItem_Click;
		this.添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.AddinpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.AddSubMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.移除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.RemoveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.RemoveAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.RemoveUSubMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.RemoveResMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.btnOpenFilePath = new System.Windows.Forms.ToolStripMenuItem();
		this.btnOpenInp = new System.Windows.Forms.ToolStripMenuItem();
		this.btnOpenUSubPath = new System.Windows.Forms.ToolStripMenuItem();
		this.btnShowInpFile = new System.Windows.Forms.ToolStripMenuItem();
		this.btnShowSubroutineFile = new System.Windows.Forms.ToolStripMenuItem();
		this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
		this.tslStatus = new System.Windows.Forms.ToolStripStatusLabel();
		this.tslSpring = new System.Windows.Forms.ToolStripStatusLabel();
		this.tslRunning = new System.Windows.Forms.ToolStripStatusLabel();
		this.tslCompleted = new System.Windows.Forms.ToolStripStatusLabel();
		this.tslFailed = new System.Windows.Forms.ToolStripStatusLabel();
		this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
		this.FolderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
		this.BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
		this.ToolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
		this.SplitContainer2 = new System.Windows.Forms.SplitContainer();
		this.dgvJobs = new System.Windows.Forms.DataGridView();
		this.TabpageN = new System.Windows.Forms.TabControl();
		this.TabPage1 = new System.Windows.Forms.TabPage();
		this.txtLog = new System.Windows.Forms.TextBox();
		this.TabPage2 = new System.Windows.Forms.TabPage();
		this.txtStatus = new System.Windows.Forms.TextBox();
		this.TabPage3 = new System.Windows.Forms.TabPage();
		this.txtWarn = new System.Windows.Forms.TextBox();
		this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
		this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.NTSMenu = new System.Windows.Forms.ToolStripMenuItem();
		this.OTSMenu = new System.Windows.Forms.ToolStripMenuItem();
		this.添加包含子程序的任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.btn1InpNFor = new System.Windows.Forms.ToolStripMenuItem();
		this.btnNInp1For = new System.Windows.Forms.ToolStripMenuItem();
		this.btnNInpNFor = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
		this.XTSMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.WorkDirMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.WorkDirMenu.Click += WorkDirMenu_Click;
		this.EditTSMenu = new System.Windows.Forms.ToolStripMenuItem();
		this.HToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
		this.AboutTSMenu = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStrip2 = new System.Windows.Forms.ToolStrip();
		this.BtnStart = new System.Windows.Forms.ToolStripButton();
		this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
		this.BtnStop = new System.Windows.Forms.ToolStripButton();
		this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
		this.btnScheduled = new System.Windows.Forms.ToolStripButton();
		this.lblScheduledInfo = new System.Windows.Forms.ToolStripLabel();
		this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
		this.DGVMenu.SuspendLayout();
		this.StatusStrip1.SuspendLayout();
		this.ToolStripContainer1.ContentPanel.SuspendLayout();
		this.ToolStripContainer1.TopToolStripPanel.SuspendLayout();
		this.ToolStripContainer1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.SplitContainer2).BeginInit();
		this.SplitContainer2.Panel1.SuspendLayout();
		this.SplitContainer2.Panel2.SuspendLayout();
		this.SplitContainer2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvJobs).BeginInit();
		this.TabpageN.SuspendLayout();
		this.TabPage1.SuspendLayout();
		this.TabPage2.SuspendLayout();
		this.TabPage3.SuspendLayout();
		this.MenuStrip1.SuspendLayout();
		this.ToolStrip2.SuspendLayout();
		base.SuspendLayout();
		this.DGVMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[8] { this.StartMenuItem, this.KillMenuItem, this.UpTSMenuI, this.DownTSMenu, this.MergeOdbMenuItem, this.添加ToolStripMenuItem, this.移除ToolStripMenuItem, this.btnOpenFilePath });
		this.DGVMenu.Name = "DGVMenu";
		this.DGVMenu.Size = new System.Drawing.Size(125, 158);
		this.StartMenuItem.Name = "StartMenuItem";
		this.StartMenuItem.Size = new System.Drawing.Size(124, 22);
		this.StartMenuItem.Text = "开始计算";
		this.KillMenuItem.Name = "KillMenuItem";
		this.KillMenuItem.Size = new System.Drawing.Size(124, 22);
		this.KillMenuItem.Text = "停止计算";
		this.UpTSMenuI.Name = "UpTSMenuI";
		this.UpTSMenuI.Size = new System.Drawing.Size(124, 22);
		this.UpTSMenuI.Text = "上移";
		this.DownTSMenu.Name = "DownTSMenu";
		this.DownTSMenu.Size = new System.Drawing.Size(124, 22);
		this.DownTSMenu.Text = "下移";
			this.MergeOdbMenuItem.Name = "MergeOdbMenuItem";
			this.MergeOdbMenuItem.Size = new System.Drawing.Size(124, 22);
			this.MergeOdbMenuItem.Text = "合并ODB";
		this.添加ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.AddinpMenuItem, this.AddSubMenuItem });
		this.添加ToolStripMenuItem.Name = "添加ToolStripMenuItem";
		this.添加ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
		this.添加ToolStripMenuItem.Text = "添加";
		this.AddinpMenuItem.Name = "AddinpMenuItem";
		this.AddinpMenuItem.Size = new System.Drawing.Size(118, 22);
		this.AddinpMenuItem.Text = "inp文件";
		this.AddSubMenuItem.Name = "AddSubMenuItem";
		this.AddSubMenuItem.Size = new System.Drawing.Size(118, 22);
		this.AddSubMenuItem.Text = "子程序";
		this.移除ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[4] { this.RemoveMenuItem, this.RemoveAllMenuItem, this.RemoveUSubMenuItem, this.RemoveResMenuItem });
		this.移除ToolStripMenuItem.Name = "移除ToolStripMenuItem";
		this.移除ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
		this.移除ToolStripMenuItem.Text = "移除";
		this.RemoveMenuItem.Name = "RemoveMenuItem";
		this.RemoveMenuItem.Size = new System.Drawing.Size(136, 22);
		this.RemoveMenuItem.Text = "选中任务";
		this.RemoveAllMenuItem.Name = "RemoveAllMenuItem";
		this.RemoveAllMenuItem.Size = new System.Drawing.Size(136, 22);
		this.RemoveAllMenuItem.Text = "所有任务";
		this.RemoveUSubMenuItem.Name = "RemoveUSubMenuItem";
		this.RemoveUSubMenuItem.Size = new System.Drawing.Size(136, 22);
		this.RemoveUSubMenuItem.Text = "子程序";
		this.RemoveResMenuItem.Name = "RemoveResMenuItem";
		this.RemoveResMenuItem.Size = new System.Drawing.Size(136, 22);
		this.RemoveResMenuItem.Text = "重启动文件";
		this.btnOpenFilePath.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[4] { this.btnOpenInp, this.btnOpenUSubPath, this.btnShowInpFile, this.btnShowSubroutineFile });
		this.btnOpenFilePath.Name = "btnOpenFilePath";
		this.btnOpenFilePath.Size = new System.Drawing.Size(124, 22);
		this.btnOpenFilePath.Text = "打开";
		this.btnOpenInp.Name = "btnOpenInp";
		this.btnOpenInp.Size = new System.Drawing.Size(180, 22);
		this.btnOpenInp.Text = "inp文件";
		this.btnOpenUSubPath.Name = "btnOpenUSubPath";
		this.btnOpenUSubPath.Size = new System.Drawing.Size(180, 22);
		this.btnOpenUSubPath.Text = "子程序文件";
		this.btnShowInpFile.Name = "btnShowInpFile";
		this.btnShowInpFile.Size = new System.Drawing.Size(180, 22);
		this.btnShowInpFile.Text = "inp文件夹";
		this.btnShowSubroutineFile.Name = "btnShowSubroutineFile";
		this.btnShowSubroutineFile.Size = new System.Drawing.Size(180, 22);
		this.btnShowSubroutineFile.Text = "子程序文件夹";
		this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[5] { this.tslStatus, this.tslSpring, this.tslRunning, this.tslCompleted, this.tslFailed });
		this.StatusStrip1.Location = new System.Drawing.Point(0, 569);
		this.StatusStrip1.Name = "StatusStrip1";
		this.StatusStrip1.Size = new System.Drawing.Size(595, 22);
		this.StatusStrip1.TabIndex = 6;
		this.StatusStrip1.Text = "StatusStrip1";
		this.tslStatus.Name = "tslStatus";
		this.tslStatus.Size = new System.Drawing.Size(32, 17);
		this.tslStatus.Text = "就绪";
		this.tslSpring.Name = "tslSpring";
		this.tslSpring.Size = new System.Drawing.Size(383, 17);
		this.tslSpring.Spring = true;
		this.tslRunning.Name = "tslRunning";
		this.tslRunning.Size = new System.Drawing.Size(63, 17);
		this.tslRunning.Text = "运行中：0";
		this.tslCompleted.Name = "tslCompleted";
		this.tslCompleted.Size = new System.Drawing.Size(51, 17);
		this.tslCompleted.Text = "完成：0";
		this.tslFailed.Name = "tslFailed";
		this.tslFailed.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.tslFailed.Size = new System.Drawing.Size(51, 17);
		this.tslFailed.Text = "失败：0";
		this.OpenFileDialog1.FileName = "OpenFileDialog1";
		this.OpenFileDialog1.Filter = "INP Files (*.inp)|*.inp";
		this.ToolStripContainer1.ContentPanel.Controls.Add(this.SplitContainer2);
		this.ToolStripContainer1.ContentPanel.Size = new System.Drawing.Size(595, 519);
		this.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.ToolStripContainer1.Location = new System.Drawing.Point(0, 0);
		this.ToolStripContainer1.Name = "ToolStripContainer1";
		this.ToolStripContainer1.Size = new System.Drawing.Size(595, 569);
		this.ToolStripContainer1.TabIndex = 14;
		this.ToolStripContainer1.Text = "ToolStripContainer1";
		this.ToolStripContainer1.TopToolStripPanel.Controls.Add(this.MenuStrip1);
		this.ToolStripContainer1.TopToolStripPanel.Controls.Add(this.ToolStrip2);
		this.ToolStripContainer1.TopToolStripPanel.Controls.Add(this.ToolStrip1);
		this.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.SplitContainer2.Location = new System.Drawing.Point(0, 0);
		this.SplitContainer2.Name = "SplitContainer2";
		this.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
		this.SplitContainer2.Panel1.Controls.Add(this.dgvJobs);
		this.SplitContainer2.Panel2.Controls.Add(this.TabpageN);
		this.SplitContainer2.Size = new System.Drawing.Size(595, 519);
		this.SplitContainer2.SplitterDistance = 226;
		this.SplitContainer2.TabIndex = 13;
		this.dgvJobs.AllowDrop = true;
		this.dgvJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvJobs.ContextMenuStrip = this.DGVMenu;
		this.dgvJobs.Dock = System.Windows.Forms.DockStyle.Fill;
		this.dgvJobs.Location = new System.Drawing.Point(0, 0);
		this.dgvJobs.MultiSelect = true;
		this.dgvJobs.Name = "dgvJobs";
		this.dgvJobs.RowTemplate.Height = 23;
		this.dgvJobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.dgvJobs.Size = new System.Drawing.Size(595, 226);
		this.dgvJobs.TabIndex = 5;
		this.TabpageN.Controls.Add(this.TabPage1);
		this.TabpageN.Controls.Add(this.TabPage2);
		this.TabpageN.Controls.Add(this.TabPage3);
		this.TabpageN.Dock = System.Windows.Forms.DockStyle.Fill;
		this.TabpageN.Font = new System.Drawing.Font("Consolas", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.TabpageN.Location = new System.Drawing.Point(0, 0);
		this.TabpageN.Name = "TabpageN";
		this.TabpageN.SelectedIndex = 0;
		this.TabpageN.Size = new System.Drawing.Size(595, 289);
		this.TabpageN.TabIndex = 8;
		this.TabPage1.Controls.Add(this.txtLog);
		this.TabPage1.Location = new System.Drawing.Point(4, 23);
		this.TabPage1.Name = "TabPage1";
		this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage1.Size = new System.Drawing.Size(587, 262);
		this.TabPage1.TabIndex = 0;
		this.TabPage1.Text = "Log";
		this.TabPage1.UseVisualStyleBackColor = true;
		this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
		this.txtLog.Font = new System.Drawing.Font("Consolas", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txtLog.Location = new System.Drawing.Point(3, 3);
		this.txtLog.Multiline = true;
		this.txtLog.Name = "txtLog";
		this.txtLog.ReadOnly = true;
		this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		this.txtLog.Size = new System.Drawing.Size(581, 256);
		this.txtLog.TabIndex = 7;
		this.txtLog.WordWrap = false;
		this.TabPage2.Controls.Add(this.txtStatus);
		this.TabPage2.Location = new System.Drawing.Point(4, 23);
		this.TabPage2.Name = "TabPage2";
		this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage2.Size = new System.Drawing.Size(587, 248);
		this.TabPage2.TabIndex = 1;
		this.TabPage2.Text = "Status";
		this.TabPage2.UseVisualStyleBackColor = true;
		this.txtStatus.Dock = System.Windows.Forms.DockStyle.Fill;
		this.txtStatus.Location = new System.Drawing.Point(3, 3);
		this.txtStatus.Multiline = true;
		this.txtStatus.Name = "txtStatus";
		this.txtStatus.ReadOnly = true;
		this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		this.txtStatus.Size = new System.Drawing.Size(581, 242);
		this.txtStatus.TabIndex = 8;
		this.txtStatus.WordWrap = false;
		this.TabPage3.Controls.Add(this.txtWarn);
		this.TabPage3.Location = new System.Drawing.Point(4, 23);
		this.TabPage3.Name = "TabPage3";
		this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage3.Size = new System.Drawing.Size(587, 248);
		this.TabPage3.TabIndex = 2;
		this.TabPage3.Text = "Warnings";
		this.TabPage3.UseVisualStyleBackColor = true;
		this.txtWarn.Dock = System.Windows.Forms.DockStyle.Fill;
		this.txtWarn.Location = new System.Drawing.Point(3, 3);
		this.txtWarn.Multiline = true;
		this.txtWarn.Name = "txtWarn";
		this.txtWarn.ReadOnly = true;
		this.txtWarn.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		this.txtWarn.Size = new System.Drawing.Size(581, 242);
		this.txtWarn.TabIndex = 8;
		this.txtWarn.WordWrap = false;
		this.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None;
		this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.文件FToolStripMenuItem, this.EditTSMenu, this.HToolStripMenu });
		this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
		this.MenuStrip1.Name = "MenuStrip1";
		this.MenuStrip1.Size = new System.Drawing.Size(595, 25);
		this.MenuStrip1.TabIndex = 0;
		this.MenuStrip1.Text = "MenuStrip1";
		this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[6] { this.NTSMenu, this.OTSMenu, this.WorkDirMenu, this.添加包含子程序的任务ToolStripMenuItem, this.toolStripSeparator, this.XTSMenu });
		this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
		this.文件FToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
		this.文件FToolStripMenuItem.Text = "文件(&F)";
		this.NTSMenu.Image = (System.Drawing.Image)resources.GetObject("NTSMenu.Image");
		this.NTSMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.NTSMenu.Name = "NTSMenu";
		this.NTSMenu.ShortcutKeys = System.Windows.Forms.Keys.N | System.Windows.Forms.Keys.Control;
		this.NTSMenu.Size = new System.Drawing.Size(207, 22);
		this.NTSMenu.Text = "新建(&N)";
		this.OTSMenu.Image = (System.Drawing.Image)resources.GetObject("OTSMenu.Image");
		this.OTSMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.OTSMenu.Name = "OTSMenu";
		this.OTSMenu.ShortcutKeys = System.Windows.Forms.Keys.O | System.Windows.Forms.Keys.Control;
		this.OTSMenu.Size = new System.Drawing.Size(207, 22);
		this.OTSMenu.Text = "添加inp任务(&O)";
		this.添加包含子程序的任务ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.btn1InpNFor, this.btnNInp1For, this.btnNInpNFor });
		this.添加包含子程序的任务ToolStripMenuItem.Name = "添加包含子程序的任务ToolStripMenuItem";
		this.添加包含子程序的任务ToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
		this.添加包含子程序的任务ToolStripMenuItem.Text = "添加包含子程序的任务";
		this.btn1InpNFor.Name = "btn1InpNFor";
		this.btn1InpNFor.Size = new System.Drawing.Size(156, 22);
		this.btn1InpNFor.Text = "1 inp + N for";
		this.btnNInp1For.Name = "btnNInp1For";
		this.btnNInp1For.Size = new System.Drawing.Size(156, 22);
		this.btnNInp1For.Text = "N inp + 1 for";
		this.btnNInpNFor.Name = "btnNInpNFor";
		this.btnNInpNFor.Size = new System.Drawing.Size(156, 22);
		this.btnNInpNFor.Text = "N inp + N for";
		this.toolStripSeparator.Name = "toolStripSeparator";
		this.toolStripSeparator.Size = new System.Drawing.Size(204, 6);
		this.XTSMenu.Name = "XTSMenu";
		this.XTSMenu.Size = new System.Drawing.Size(207, 22);
		this.XTSMenu.Text = "退出(&X)";
			this.WorkDirMenu.Name = "WorkDirMenu";
			this.WorkDirMenu.Size = new System.Drawing.Size(207, 22);
			this.WorkDirMenu.Text = "设置工作目录(&W)...";
		this.EditTSMenu.Name = "EditTSMenu";
		this.EditTSMenu.Size = new System.Drawing.Size(44, 21);
		this.EditTSMenu.Text = "设置";
		this.HToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.AboutTSMenu });
		this.HToolStripMenu.Name = "HToolStripMenu";
		this.HToolStripMenu.Size = new System.Drawing.Size(61, 21);
		this.HToolStripMenu.Text = "帮助(&H)";
		this.AboutTSMenu.Name = "AboutTSMenu";
		this.AboutTSMenu.Size = new System.Drawing.Size(125, 22);
		this.AboutTSMenu.Text = "关于(&A)...";
		this.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None;
		this.ToolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[6] { this.BtnStart, this.ToolStripSeparator1, this.BtnStop, this.ToolStripSeparator2, this.btnScheduled, this.lblScheduledInfo });
		this.ToolStrip2.Location = new System.Drawing.Point(3, 25);
		this.ToolStrip2.Name = "ToolStrip2";
		this.ToolStrip2.Size = new System.Drawing.Size(144, 25);
		this.ToolStrip2.TabIndex = 2;
		this.BtnStart.BackColor = System.Drawing.Color.FromArgb(128, 255, 128);
		this.BtnStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
		this.BtnStart.Image = (System.Drawing.Image)resources.GetObject("BtnStart.Image");
		this.BtnStart.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.BtnStart.Name = "BtnStart";
		this.BtnStart.Size = new System.Drawing.Size(36, 22);
		this.BtnStart.Text = "开始";
		this.ToolStripSeparator1.Name = "ToolStripSeparator1";
		this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
		this.BtnStop.BackColor = System.Drawing.Color.Red;
		this.BtnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
		this.BtnStop.Enabled = false;
		this.BtnStop.Image = (System.Drawing.Image)resources.GetObject("BtnStop.Image");
		this.BtnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.BtnStop.Name = "BtnStop";
		this.BtnStop.Size = new System.Drawing.Size(36, 22);
		this.BtnStop.Text = "停止";
		this.ToolStripSeparator2.Name = "ToolStripSeparator2";
		this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 25);
		this.btnScheduled.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
		this.btnScheduled.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
		this.btnScheduled.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.btnScheduled.Name = "btnScheduled";
		this.btnScheduled.Size = new System.Drawing.Size(36, 22);
		this.btnScheduled.Text = "定时";
		this.lblScheduledInfo.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
		this.lblScheduledInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.lblScheduledInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
		this.lblScheduledInfo.Name = "lblScheduledInfo";
		this.lblScheduledInfo.Size = new System.Drawing.Size(12, 22);
		this.lblScheduledInfo.Text = " ";
		this.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None;
		this.ToolStrip1.Location = new System.Drawing.Point(438, 25);
		this.ToolStrip1.Name = "ToolStrip1";
		this.ToolStrip1.Size = new System.Drawing.Size(43, 25);
		this.ToolStrip1.TabIndex = 1;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(595, 591);
		base.Controls.Add(this.ToolStripContainer1);
		base.Controls.Add(this.StatusStrip1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "Form1";
		this.Text = "Abaqus Job";
		this.DGVMenu.ResumeLayout(false);
		this.StatusStrip1.ResumeLayout(false);
		this.StatusStrip1.PerformLayout();
		this.ToolStripContainer1.ContentPanel.ResumeLayout(false);
		this.ToolStripContainer1.TopToolStripPanel.ResumeLayout(false);
		this.ToolStripContainer1.TopToolStripPanel.PerformLayout();
		this.ToolStripContainer1.ResumeLayout(false);
		this.ToolStripContainer1.PerformLayout();
		this.SplitContainer2.Panel1.ResumeLayout(false);
		this.SplitContainer2.Panel2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.SplitContainer2).EndInit();
		this.SplitContainer2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.dgvJobs).EndInit();
		this.TabpageN.ResumeLayout(false);
		this.TabPage1.ResumeLayout(false);
		this.TabPage1.PerformLayout();
		this.TabPage2.ResumeLayout(false);
		this.TabPage2.PerformLayout();
		this.TabPage3.ResumeLayout(false);
		this.TabPage3.PerformLayout();
		this.MenuStrip1.ResumeLayout(false);
		this.MenuStrip1.PerformLayout();
		this.ToolStrip2.ResumeLayout(false);
		this.ToolStrip2.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
