using CommunityToolkit.Mvvm.ComponentModel;

namespace WpfControlLibrary1
{
    public class TestViewModel : ObservableObject, IViewModel
    {
        private TestModel _model;
        private string _stringValue;
        private int _integerValue;

        public TestModel Model
        {
            get { return _model; }
            set { SetProperty(ref _model, value); }
        }

        public string Test
        {
            get { return _stringValue; }
            set { SetProperty(ref _stringValue, value); }
        }

        public string StringValue
        {
            get { return _stringValue; }
            set { SetProperty(ref _stringValue, value); }
        }

        public int IntegerValue
        {
            get { return _integerValue; }
            set { SetProperty(ref _integerValue, value); }
        }

        public TestViewModel() 
        {
            
        }
    }
}
