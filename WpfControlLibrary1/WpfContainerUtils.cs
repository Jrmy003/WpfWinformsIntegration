using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace WpfControlLibrary1
{
    public static class WpfContainerUtils
    {
        public static void DisplayPopupWpfTest(string text)
        {
            var window = new Window1();
            var vm = window.DataContext as TestViewModel;
            if (vm == null)
                throw new InvalidOperationException("blabla");

            vm.Test = text;
            window.Show();
        }

        public static void DisplayIntegratedWpfUc(Form form, string text, int width, int height, int x, int y)
        {
            var wpfContainer = new UcWpfIntegration();
            wpfContainer.Size = new Size(width - 194, height);
            wpfContainer.Location = new Point(x, y);
            var uc = new UserControl1();
            var vm = uc.DataContext as TestViewModel;
            if (vm == null)
                throw new InvalidOperationException("blabla");

            vm.Test = text;
            wpfContainer.ElementHost.Child = uc;
            form.Controls.Add(wpfContainer.This);
        }
    }
}
