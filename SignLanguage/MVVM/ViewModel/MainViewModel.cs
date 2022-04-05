﻿using SignLanguage.Core;

namespace SignLanguage.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand RussianAlphabetViewCommand { get; set; }
        public RelayCommand WordsViewCommand { get; set; }
        public RelayCommand TestViewCommand { get; set; }
        public RelayCommand SettingViewCommand { get; set; }
        public RelayCommand FactsViewCommand { get; set; }

        public HomeViewModel HomeVm { get; set; }
        public RussianAlphabetViewModel RussianAlphabetVm { get; set; }
        public WordsViewModel WordsVm { get; set; }
        public TestViewModel TestVm { get; set; }
        public SettingViewModel SettingVm { get; set; }
        public FactsViewModel FactsVm { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get => _currentView;
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        private string _currentHeader;
        public string CurrentHeader
        {
            get => _currentHeader;
            set
            {
                _currentHeader = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVm = new HomeViewModel();
            RussianAlphabetVm = new RussianAlphabetViewModel();
            WordsVm = new WordsViewModel();
            TestVm = new TestViewModel();
            SettingVm = new SettingViewModel();
            FactsVm = new FactsViewModel();
            CurrentView = HomeVm;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVm;
                CurrentHeader = "Избранное";
            });

            RussianAlphabetViewCommand = new RelayCommand(o =>
            {
                CurrentView = RussianAlphabetVm;
                CurrentHeader = "Алфавит";
            });

            WordsViewCommand = new RelayCommand(o =>
            {
                CurrentView = WordsVm;
                CurrentHeader = "Слова";
            });

            TestViewCommand = new RelayCommand(o =>
            {
                CurrentView = TestVm;
                CurrentHeader = "Тест";
            });

            SettingViewCommand = new RelayCommand(o =>
            {
                CurrentView = SettingVm;
                CurrentHeader = "Настройки";
            });

            FactsViewCommand = new RelayCommand(o =>
            {
                CurrentView = FactsVm;
                CurrentHeader = "Факты";
            });
        }
    }
}