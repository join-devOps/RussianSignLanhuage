using SignLanguage.MVVM.ViewModel.Test;
using System.Windows.Controls;

namespace SignLanguage.MVVM.View.Test
{
    /// <summary>
    /// Логика взаимодействия для TestEasyView.xaml
    /// </summary>
    public partial class TestEasyView : UserControl
    {
        public TestEasyView()
        {
            InitializeComponent();
            DataContext = new TestEasyViewModel();
        }
    }
}