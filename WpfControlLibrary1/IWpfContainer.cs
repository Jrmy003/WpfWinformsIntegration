using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace WpfControlLibrary1
{
    public interface IWpfContainer
    {
        ElementHost ElementHost { get; }
        Control This { get; }
    }
}
