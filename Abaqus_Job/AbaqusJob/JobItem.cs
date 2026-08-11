using System;
using System.Collections.Generic;
using System.IO;
using AbaqusJob.My;

namespace AbaqusJob;

public class JobItem
{
	private List<string> _warnings;

	public string FilePath { get; set; }

	public string USubPath { get; set; }

	public string _OutputDir { get; set; }

	public string OutputDir
	{
		get
		{
			string wd = MySettingsProperty.Settings.WorkingDirectory;
			if (!string.IsNullOrEmpty(wd) && Directory.Exists(wd))
				return wd;
			if (!string.IsNullOrEmpty(_OutputDir))
				return _OutputDir;
			return Path.GetDirectoryName(FilePath) ?? ".";
		}
		set
		{
			_OutputDir = value;
		}
	}

	public string JobName { get; set; }

	public string TaskType { get; set; }

	public string SolverType { get; set; }

	public string OldJobName { get; set; }

	public string Status { get; set; }

	public string LatestLog { get; set; }

	public bool CompletedDetected { get; set; }

	public string OdbPath
	{
		get
		{
			string dir = OutputDir;
			string name = JobName;
			if (string.IsNullOrEmpty(name))
				name = Path.GetFileNameWithoutExtension(FilePath);
			return Path.Combine(dir, name + ".odb");
		}
	}

	public List<string> Warnings => _warnings;

	public List<string> UniqueWarnings
	{
		get
		{
			HashSet<string> hashSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
			List<string> list = new List<string>();
			foreach (string warning in _warnings)
			{
				if (hashSet.Add(warning))
				{
					list.Add(warning);
				}
			}
			return list;
		}
	}

	public JobItem(string filePath)
	{
		USubPath = "";
		OutputDir = "";
		TaskType = "Full analysis";
		SolverType = "Auto";
		OldJobName = "";
		Status = "等待";
		LatestLog = "";
		CompletedDetected = false;
		_warnings = new List<string>();
		FilePath = filePath;
		JobName = Path.GetFileNameWithoutExtension(filePath);
		OutputDir = Path.GetDirectoryName(filePath);
	}

	public JobItem(string filePath, string uSubPath)
	{
		USubPath = "";
		OutputDir = "";
		TaskType = "Full analysis";
		SolverType = "Auto";
		OldJobName = "";
		Status = "等待";
		LatestLog = "";
		CompletedDetected = false;
		_warnings = new List<string>();
		FilePath = filePath;
		USubPath = uSubPath;
		JobName = Path.GetFileNameWithoutExtension(filePath);
		OutputDir = Path.GetDirectoryName(filePath);
	}

	public JobItem(string filePath, string uSubPath, string jobName)
	{
		USubPath = "";
		OutputDir = "";
		TaskType = "Full analysis";
		SolverType = "Auto";
		OldJobName = "";
		Status = "等待";
		LatestLog = "";
		CompletedDetected = false;
		_warnings = new List<string>();
		FilePath = filePath;
		USubPath = uSubPath;
		JobName = jobName;
		OutputDir = Path.GetDirectoryName(filePath);
		TaskType = "Full analysis";
		SolverType = "Auto";
	}

	public void AddWarnings(IEnumerable<string> newWarnings)
	{
		_warnings.AddRange(newWarnings);
	}
}
