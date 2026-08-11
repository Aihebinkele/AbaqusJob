using System.Windows.Forms;

namespace AbaqusJob;

public class ToolStripNumericUpDown : ToolStripControlHost
{
	public NumericUpDown NumericUpDownControl => (NumericUpDown)base.Control;

	public ToolStripNumericUpDown()
		: base(new NumericUpDown())
	{
		base.Width = 60;
	}
}
