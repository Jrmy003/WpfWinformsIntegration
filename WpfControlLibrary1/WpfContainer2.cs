//using System;
//using System.Windows;
//using System.Windows.Forms;

//namespace WpfControlLibrary1
//{
//    public static class WpfContainer2
//    {
//        public static void DisplayPopupWpfTest<V,VM>(string text)
//            where VM : IViewModel
//            where V : Window, new()
//        {
//            var window = new V();
//            var vm = window.DataContext as VM;
//            if (vm == null)
//                throw new InvalidOperationException("blabla");

//            vm.StringValue = text;
//            window.Show();
//        }

//        public static void DisplayIntegratedWpfUc2(this IWpfContainer wpfContainer, Form form, string text)
//        {
//            var uc = new UserControl1();
//            var vm = uc.DataContext as TestViewModel;
//            if (vm == null)
//                throw new InvalidOperationException("blabla");

//            vm.Test = text;
//            wpfContainer.ElementHost.Child = uc;
//            form.Controls.Add(wpfContainer.This);
//        }
//    }
//}
