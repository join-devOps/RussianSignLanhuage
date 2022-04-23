using SignLanguage.Core;
using SignLanguage.MVVM.Model;

namespace SignLanguage.MVVM.ViewModel
{
    class MainViewModel : CorePropertyChanged
    {
        private readonly ModelClass model;

        IniFile INI = new IniFile("config.ini");
        public CoreRelayCommand HomeViewCommand { get; }
        public CoreRelayCommand RussianAlphabetViewCommand { get; }
        public CoreRelayCommand WordsViewCommand { get; }
        public CoreRelayCommand TestViewCommand { get; }
        public CoreRelayCommand SettingViewCommand { get; }
        public CoreRelayCommand FactsViewCommand { get; }
        public CoreRelayCommand SupportViewCommand { get; }

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
            set => SetProperty(ref _currentView, value);
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
                SetProperty(ref getSettingColor, value);
                OnPropertyChanged("GetSetting");
            }
        }

        private string searchText;
        public string SearchText
        {
            get => searchText;
            set => SetProperty(ref searchText, value);
        }

        public MainViewModel(ModelClass model)
        {
            this.model = model;
            model.ValueChanged += ModelValueChanged;
            model.AllValueChanged();

            GetSettingColor = INI.ReadINI("DefaultSetting", "Color");

            if (GetSettingColor == "Dark")
                (App.Current as App).ChangeSkin(Skin.Dark);
            else
                (App.Current as App).ChangeSkin(Skin.Snow);

            HomeVm = new HomeViewModel();
            RussianAlphabetVm = new RussianAlphabetViewModel(model);
            WordsVm = new WordsViewModel(model);
            TestVm = new TestViewModel();
            SettingVm = new SettingViewModel();
            FactsVm = new FactsViewModel();
            SupportVm = new SupportViewModel();
            CurrentView = HomeVm;

            HomeViewCommand = new CoreRelayCommand(o =>
            {
                CurrentView = HomeVm;
                CurrentHeader = "Избранное";
            });

            RussianAlphabetViewCommand = new CoreRelayCommand(o =>
            {
                CurrentView = RussianAlphabetVm;
                CurrentHeader = "Алфавит";
            });

            WordsViewCommand = new CoreRelayCommand(o =>
            {
                CurrentView = WordsVm;
                CurrentHeader = "Слова";
            });

            TestViewCommand = new CoreRelayCommand(o =>
            {
                CurrentView = TestVm;
                CurrentHeader = "Тест";
            });

            SettingViewCommand = new CoreRelayCommand(o =>
            {
                CurrentView = SettingVm;
                CurrentHeader = "Настройки";
            });

            FactsViewCommand = new CoreRelayCommand(o =>
            {
                CurrentView = FactsVm;
                CurrentHeader = "Факты";
            });

            SupportViewCommand = new CoreRelayCommand(o =>
            {
                CurrentView = SupportVm;
                CurrentHeader = "Поддержка";
            });
        }

        private void ModelValueChanged(object sender, string valueName, object oldValue, object newValue)
        {
            switch (valueName)
            {
                case nameof(ModelClass.StringValue): SearchText = (string)newValue; break;
            }
        }

        protected override void PropertyNewValue<T>(ref T fieldProperty, T newValue, string propertyName)
        {
            base.PropertyNewValue(ref fieldProperty, newValue, propertyName);

            switch (propertyName)
            {
                case nameof(SearchText): model.SendValue(nameof(ModelClass.StringValue), SearchText); break;
            }
        }
    }
}