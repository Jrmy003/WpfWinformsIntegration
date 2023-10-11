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
            WpfContainer.DisplayPopupWpfTest(jeanclaude);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var uc = new UcWpfIntegration();
            uc.Size = new Size(Width - 194, Height);
            uc.Location = new Point(194, 0);
            uc.DisplayIntegratedWpfUc(this, "jakituning");
        }

    }
}
