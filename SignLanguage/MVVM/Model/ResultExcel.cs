using SignLanguage.Core;
using System.Windows.Media;

namespace SignLanguage.MVVM.Model
{
    class ResultExcel : CorePropertyChanged
    {
        private string _Title;
        public string Title
        {
            get => _Title;
            set => SetProperty(ref _Title, value);
        }

        private bool _ResultBool;
        public bool ResultBool
        {
            get => _ResultBool;
            set => SetProperty(ref _ResultBool, value);
        }

        public SolidColorBrush Color
        {
            get => !ResultBool ? Brushes.DarkRed : Brushes.LightGreen;
        }
    }
}