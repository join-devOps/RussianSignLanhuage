using SignLanguage.Core;
using System.Windows;

namespace SignLanguage.MVVM.ViewModel
{
    class FactsViewModel : CorePropertyChanged
    {
        private CoreRelayCommand showDuel;
        public CoreRelayCommand ShowDuel
        {
            get => showDuel ?? (showDuel = new CoreRelayCommand(o => 
            {
                GetItem = 0;
            }));
        }

        private CoreRelayCommand showFact;
        public CoreRelayCommand ShowFact
        {
            get => showFact ?? (showFact = new CoreRelayCommand(o =>
            {
                GetItem = 1;
            }));
        }

        private CoreRelayCommand showHelp;
        public CoreRelayCommand ShowHelp
        {
            get => showHelp ?? (showHelp = new CoreRelayCommand(o =>
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
