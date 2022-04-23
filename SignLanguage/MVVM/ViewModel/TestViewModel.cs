using SignLanguage.Core;
using SignLanguage.MVVM.ViewModel.Test;
using System.Windows;

namespace SignLanguage.MVVM.ViewModel
{
    class TestViewModel : CorePropertyChanged
    {
        public CoreRelayCommand TestEasyCommand { get; }
        public CoreRelayCommand TestMediumCommand { get; }
        public CoreRelayCommand TestHellCommand { get; }

        public TestEasyViewModel TestEasyVm { get; set; }
        public TestMediumViewModel TestMediumVm { get; set; }
        public TestHellViewModel TestHellVm { get; set; }

        private object _CurrentObject;
        public object CurrentObject
        {
            get => _CurrentObject;
            set => SetProperty(ref _CurrentObject, value);
        }

        private bool _IsVisible = true;
        public bool IsVisible
        {
            get => _IsVisible;
            set
            {
                SetProperty(ref _IsVisible, value);
                OnPropertyChanged("GetCommandsVisible");
            }
        }

        public Visibility GetCommandsVisible
        {
            get => IsVisible ? Visibility.Visible : Visibility.Collapsed;
        }

        public TestViewModel()
        {
            TestEasyVm = new TestEasyViewModel();
            TestMediumVm = new TestMediumViewModel();
            TestHellVm = new TestHellViewModel();

            TestEasyCommand = new CoreRelayCommand(o => 
            {
                CurrentObject = TestEasyVm;
                IsVisible = false;
            });

            TestMediumCommand = new CoreRelayCommand(o =>
            {
                CurrentObject = TestMediumVm;
                IsVisible = false;
            });

            TestHellCommand = new CoreRelayCommand(o =>
            {
                CurrentObject = TestHellVm;
                IsVisible = false;
            });
        }
    }
}