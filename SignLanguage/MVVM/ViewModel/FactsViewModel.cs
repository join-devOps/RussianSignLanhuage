using SignLanguage.Core;
using System.Windows;

namespace SignLanguage.MVVM.ViewModel
{
    class FactsViewModel : ObservableObject
    {
        private RelayCommand showDuel;
        public RelayCommand ShowDuel
        {
            get => showDuel ?? (showDuel = new RelayCommand(o => 
            {
                GetItem = 0;
            }));
        }

        private RelayCommand showFact;
        public RelayCommand ShowFact
        {
            get => showFact ?? (showFact = new RelayCommand(o =>
            {
                GetItem = 1;
            }));
        }

        private RelayCommand showHelp;
        public RelayCommand ShowHelp
        {
            get => showHelp ?? (showHelp = new RelayCommand(o =>
            {
                GetItem = 2;
            }));
        }

        

        private byte getItem;
        public byte GetItem
        {
            get => getItem;
            set
            {
                getItem = value;
                OnPropertyChanged("GetItem");
                OnPropertyChanged("GetDuel");
                OnPropertyChanged("GetFact");
                OnPropertyChanged("GetHelp");
            }
        }

        public Visibility GetDuel
        {
            get => GetItem == 0 ? Visibility.Visible : Visibility.Collapsed;
        }

        public Visibility GetFact
        {
            get => GetItem == 1 ? Visibility.Visible : Visibility.Collapsed;
        }

        public Visibility GetHelp
        {
            get => GetItem == 2 ? Visibility.Visible : Visibility.Collapsed;
        }
    }
}
