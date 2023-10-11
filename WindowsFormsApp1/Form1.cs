using System;
using System.Drawing;
using System.Windows.Forms;
using WpfControlLibrary1;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var jeanclaude = "jeanclaude";
            WpfContainerUtils.DisplayPopupWpfTest(jeanclaude);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WpfContainerUtils.DisplayIntegratedWpfUc(this, "jakifendlabise", Width - 194 -200, Height -100, 194,25);
        }

    }
}
