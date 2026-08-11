using System.Windows.Forms;

namespace AbaqusJob;

public class ToolStripCheckBox : ToolStripControlHost
{
	public CheckBox CheckBoxControl => (CheckBox)base.Control;

	public ToolStripCheckBox()
		: base(new CheckBox())
	{
		base.Width = 120;
	}
}
