# AbaqusJob — C# WinForms + Python Hybrid Batch Simulation & ODB Post-Processing Tool

![AbaqusJob](https://img.shields.io/badge/version-0.1.0-blue) ![.NET](https://img.shields.io/badge/.NET%20Framework-4.8-purple) ![Python](https://img.shields.io/badge/Python-2.7%20%7C%203.x-green) ![Abaqus](https://img.shields.io/badge/Abaqus-2017%2B-orange)

AbaqusJob is a hybrid automation tool that combines a **C# WinForms GUI** (job submission, real-time STA/DAT monitoring, restartjoin ODB merge) with a **Python post-processing engine** (ODB extraction → JSON → Excel report). Designed for CAE engineers who need to run dozens of parametric Abaqus simulations without babysitting the command line.

## Key Features

| Feature | Description |
|---------|-------------|
| **Drag & Drop Batch Submit** | Drag INP files into the GUI, set parallel count, click Start |
| **Real-time STA/DAT Monitor** | Structured progress (Step→Increment→Attempt) + classified warnings (7 categories) |
| **Auto ODB Extraction** | Each job completion triggers `post_process.py` → `job_result.json` |
| **Excel Batch Report** | All JSONs aggregated into `batch_report.xlsx` with conditional formatting |
| **One-Click ODB Merge** | Select 2 completed jobs → right-click → Merge ODB → `abaqus restartjoin` |
| **Working Directory** | File → Set Working Directory (Ctrl+W) — all output in one place |
| **Multi-Select** | Ctrl/Shift click for batch operations |
| **CAE Plugin** | Copy 4 files to `abaqus_plugins` for Abaqus/CAE menu integration |

## Project Structure

```
Python版/
├── Abaqus_Job/                    # C# Source (VS 2022, .NET 4.8 WinForms)
│   ├── AbaqusJob.csproj
│   ├── AbaqusJob/
│   │   ├── Form1.cs               # Main window (~4200 lines)
│   │   ├── Form1.WorkDirMenu.cs   # Partial class: WorkDir + MergeODB handlers
│   │   ├── JobItem.cs             # Job data model
│   │   ├── SettingsForm.cs        # Settings panel
│   │   ├── ScheduleSetupForm.cs   # Scheduled start
│   │   ├── AutoShutdownDialog.cs  # Auto shutdown countdown
│   │   └── My/                    # VB.NET compatibility layer
│   ├── Properties/AssemblyInfo.cs
│   ├── app.ico
│   └── final_patch.py / add_workdir.py  # Build helper scripts
│
├── result_config.csv              # ODB extraction config
├── load_cases.csv                 # Load case definitions
└── 使用说明.md                     # Chinese user manual
```

> **Note**: Deployed `python/` directory (BAT, scripts, config) lives alongside `AbaqusJob.exe` in the release output.

## Quick Start

### Option A: Pre-built EXE (Windows)

1. Copy `Abaqus_Job/bin/Release/net48/` to your working folder
2. Ensure `python/` subdirectory is at the same level as `AbaqusJob.exe`
3. Edit `python/abaqus_job_config.json` — set `abaqus_path`
4. Double-click `AbaqusJob.exe`, drag INP files, click Start

### Option B: Build from Source

```bash
cd Abaqus_Job
dotnet build AbaqusJob.csproj -c Release
```

Requires: .NET SDK 8.0+, .NET Framework 4.8 (built into Windows 10/11)

### Option C: Python CLI (Linux/HPC — no GUI)

```bash
# Single ODB extraction
abaqus python post_process.py --odb job.odb --config result_config.csv

# Batch report
python batch_report.py --results-dir . --format excel
```

## Post-Processing Pipeline

```
Job Complete
  → EnablePostProcess? 
    → run_postprocess.bat → abaqus python post_process.py 
      → job_result.json

All Jobs Complete
  → run_postprocess.bat --report → python batch_report.py 
    → batch_report.xlsx (conditional formatting)
```

## Abaqus/CAE Plugin

Copy to `C:\Users\<username>\abaqus_plugins\`:
- `my_plugin.py` — menu registration
- `CreateJob.py` — job creation/submission
- `autoload.py` — model generation from CSV
- `autoresult.py` — ODB extraction GUI

Shows 6 buttons in **Plugins** menu: CreateJob, CreateInp, CreateRun, RunJob, autoload, autoresult.

## Requirements

| Component | Dependency |
|-----------|-----------|
| C# GUI | .NET Framework 4.8 (Windows built-in) |
| Python CLI | Abaqus Python 2.7 (for `odbAccess`) |
| Excel Report | System Python 3.x + `pip install openpyxl` |
| ODB Merge | Abaqus `restartjoin` command |

## FAQ

**Q: Python script says "odbAccess not available"**  
A: Must run via `abaqus python`, not system Python.

**Q: Excel report says "openpyxl not installed"**  
A: `pip install openpyxl`

**Q: Log shows Chinese garbled characters**  
A: Known display issue with Abaqus Python 2.7 encoding. Does not affect functionality.

## Author


[GitHub: Aihebinkele](https://github.com/Aihebinkele)
