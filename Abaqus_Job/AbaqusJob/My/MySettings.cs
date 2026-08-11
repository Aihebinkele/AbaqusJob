using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace AbaqusJob.My;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings defaultInstance = (MySettings)SettingsBase.Synchronized(new MySettings());

	private static bool addedHandler;

	private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());

	public static MySettings Default
	{
		get
		{
			if (!addedHandler)
			{
				object obj = addedHandlerLockObject;
				ObjectFlowControl.CheckForSyncLockOnValueType(obj);
				bool lockTaken = false;
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					if (!addedHandler)
					{
						MyProject.Application.Shutdown += [DebuggerNonUserCode] [EditorBrowsable(EditorBrowsableState.Advanced)] (object sender, EventArgs e) =>
						{
							if (MyProject.Application.SaveMySettingsOnExit)
							{
								MySettingsProperty.Settings.Save();
							}
						};
						addedHandler = true;
					}
				}
				finally
				{
					if (lockTaken)
					{
						Monitor.Exit(obj);
					}
				}
			}
			return defaultInstance;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("C:\\SIMULIA\\Commands\\abaqus.bat")]
	public string AbaqusPath
	{
		get
		{
			return Conversions.ToString(this["AbaqusPath"]);
		}
		set
		{
			this["AbaqusPath"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool CleanLckBeforeStart
	{
		get
		{
			return Conversions.ToBoolean(this["CleanLckBeforeStart"]);
		}
		set
		{
			this["CleanLckBeforeStart"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool CleanLckAfterStop
	{
		get
		{
			return Conversions.ToBoolean(this["CleanLckAfterStop"]);
		}
		set
		{
			this["CleanLckAfterStop"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ByIndex")]
	public string InpRenameMode
	{
		get
		{
			return Conversions.ToString(this["InpRenameMode"]);
		}
		set
		{
			this["InpRenameMode"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("DEFAULT")]
	public string LastUsedEditorPath
	{
		get
		{
			return Conversions.ToString(this["LastUsedEditorPath"]);
		}
		set
		{
			this["LastUsedEditorPath"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool ShowColumn_FilePath
	{
		get
		{
			return Conversions.ToBoolean(this["ShowColumn_FilePath"]);
		}
		set
		{
			this["ShowColumn_FilePath"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool ShowColumn_USubPath
	{
		get
		{
			return Conversions.ToBoolean(this["ShowColumn_USubPath"]);
		}
		set
		{
			this["ShowColumn_USubPath"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool ShowColumn_Status
	{
		get
		{
			return Conversions.ToBoolean(this["ShowColumn_Status"]);
		}
		set
		{
			this["ShowColumn_Status"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ShowColumn_JobName
	{
		get
		{
			return Conversions.ToBoolean(this["ShowColumn_JobName"]);
		}
		set
		{
			this["ShowColumn_JobName"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ShowColumn_OutputDir
	{
		get
		{
			return Conversions.ToBoolean(this["ShowColumn_OutputDir"]);
		}
		set
		{
			this["ShowColumn_OutputDir"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ShowColumn_TaskType
	{
		get
		{
			return Conversions.ToBoolean(this["ShowColumn_TaskType"]);
		}
		set
		{
			this["ShowColumn_TaskType"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ShowColumn_SolverType
	{
		get
		{
			return Conversions.ToBoolean(this["ShowColumn_SolverType"]);
		}
		set
		{
			this["ShowColumn_SolverType"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ShowColumn_OldJobName
	{
		get
		{
			return Conversions.ToBoolean(this["ShowColumn_OldJobName"]);
		}
		set
		{
			this["ShowColumn_OldJobName"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("80")]
	public int MemoryLimit
	{
		get
		{
			return Conversions.ToInteger(this["MemoryLimit"]);
		}
		set
		{
			this["MemoryLimit"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool ShutdownAfterCompletion
	{
		get
		{
			return Conversions.ToBoolean(this["ShutdownAfterCompletion"]);
		}
		set
		{
			this["ShutdownAfterCompletion"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("COMPLETED SUCCESSFULLY")]
	public string CompletionKeyword
	{
		get
		{
			return Conversions.ToString(this["CompletionKeyword"]);
		}
		set
		{
			this["CompletionKeyword"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool AutoScrollOnUpdate
	{
		get
		{
			return Conversions.ToBoolean(this["AutoScrollOnUpdate"]);
		}
		set
		{
			this["AutoScrollOnUpdate"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool AutoScrollOnTabSwitch
	{
		get
		{
			return Conversions.ToBoolean(this["AutoScrollOnTabSwitch"]);
		}
		set
		{
			this["AutoScrollOnTabSwitch"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseRestart
	{
		get
		{
			return Conversions.ToBoolean(this["UseRestart"]);
		}
		set
		{
			this["UseRestart"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool UseRecover
	{
		get
		{
			return Conversions.ToBoolean(this["UseRecover"]);
		}
		set
		{
			this["UseRecover"] = value;
		}
	}
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool EnablePostProcess
		{
			get
			{
				return Conversions.ToBoolean(this["EnablePostProcess"]);
			}
			set
			{
				this["EnablePostProcess"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue(@".\run_postprocess.bat")]
		public string PostProcessBatPath
		{
			get
			{
				return Conversions.ToString(this["PostProcessBatPath"]);
			}
			set
			{
				this["PostProcessBatPath"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string WorkingDirectory
		{
			get
			{
				return Conversions.ToString(this["WorkingDirectory"]);
			}
			set
			{
				this["WorkingDirectory"] = value;
			}
		}


	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	private static void AutoSaveSettings(object sender, EventArgs e)
	{
		if (MyProject.Application.SaveMySettingsOnExit)
		{
			MySettingsProperty.Settings.Save();
		}
	}
}
