using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace WpfControlLibrary1
{
    public partial class UcWpfIntegration : UserControl, IWpfContainer
    {
        public UcWpfIntegration()
        {
            InitializeComponent();
        }

        public ElementHost ElementHost => elementHost1;
        public Control This => this;
    }
}
