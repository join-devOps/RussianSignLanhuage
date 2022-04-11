using SignLanguage.Core;
using System.Globalization;
using System.Threading;

namespace SignLanguage.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        IniFile INI = new IniFile("config.ini");
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand RussianAlphabetViewCommand { get; set; }
        public RelayCommand WordsViewCommand { get; set; }
        public RelayCommand TestViewCommand { get; set; }
        public RelayCommand SettingViewCommand { get; set; }
        public RelayCommand FactsViewCommand { get; set; }
        public RelayCommand SupportViewCommand { get; set; }

        public HomeViewModel HomeVm { get; set; }
        public RussianAlphabetViewModel RussianAlphabetVm { get; set; }
        public WordsViewModel WordsVm { get; set; }
        public TestViewModel TestVm { get; set; }
        public SettingViewModel SettingVm { get; set; }
        public FactsViewModel FactsVm { get; set; }

        public SupportViewModel SupportVm { get; set; }

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

        private string getSettingColor;
        public string GetSettingColor
        {
            get => getSettingColor;
            set
            {
                getSettingColor = value;
                OnPropertyChanged("GetSetting");
            }
        }

        private string getSettingLanguage;
        public string GetSettingLanguage
        {
            get => getSettingLanguage;
            set
            {
                getSettingLanguage = value;
                OnPropertyChanged("GetSettingLanguage");
            }
        }

        public MainViewModel()
        {
            GetSettingColor = INI.ReadINI("DefaultSetting", "Color");
            GetSettingLanguage = INI.ReadINI("DefaultSetting", "Language");

            if (GetSettingColor == "Dark")
                (App.Current as App).ChangeSkin(Skin.Dark);
            else
                (App.Current as App).ChangeSkin(Skin.Snow);

            //if (GetSettingLanguage == "EN")
            //    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            //else
            //    Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU");

            HomeVm = new HomeViewModel();
            RussianAlphabetVm = new RussianAlphabetViewModel();
            WordsVm = new WordsViewModel();
            TestVm = new TestViewModel();
            SettingVm = new SettingViewModel();
            FactsVm = new FactsViewModel();
            SupportVm = new SupportViewModel();
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

            SupportViewCommand = new RelayCommand(o =>
            {
                CurrentView = SupportVm;
                CurrentHeader = "Поддержка";
            });
        }
    }
}