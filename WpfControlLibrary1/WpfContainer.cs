using System;
using System.Windows.Forms;

namespace WpfControlLibrary1
{
    public static class WpfContainer
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

        public static void DisplayIntegratedWpfUc(this IWpfContainer wpfContainer, Form form, string text)
        {
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
