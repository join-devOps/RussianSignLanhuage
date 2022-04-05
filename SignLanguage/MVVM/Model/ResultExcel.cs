using System.Windows.Media;

namespace SignLanguage.MVVM.Model
{
    class ResultExcel
    {
        public byte ID { get; set; }
        public string Title { get; set; }
        public bool ResultBool { get; set; }
        public SolidColorBrush Color
        {
            get => !ResultBool ? Brushes.DarkRed : Brushes.LightGreen;
        }
    }
}