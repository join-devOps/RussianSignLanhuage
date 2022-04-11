using SignLanguage.Core;
using SignLanguage.MVVM.Model;
using SignLanguage.MVVM.Model.Interface;
using System.Globalization;
using System.Threading;

namespace SignLanguage.MVVM.ViewModel
{
    class SettingViewModel : ObservableObject, IUser
    {
        private IniFile INI = new IniFile("config.ini");

        private RelayCommand commandDark;
        public RelayCommand CommandDark
        {
            get => commandDark ?? (commandDark = new RelayCommand(o =>
            {
                (App.Current as App).ChangeSkin(Skin.Dark);
                INI.Write("DefaultSetting", "Color", "Dark");
            }));
        }

        private RelayCommand commandSnow;
        public RelayCommand CommandSnow
        {
            get => commandSnow ?? (commandSnow = new RelayCommand(o =>
            {
                (App.Current as App).ChangeSkin(Skin.Snow);
                INI.Write("DefaultSetting", "Color", "Snow");
            }));
        }

        private RelayCommand commandDev;
        public RelayCommand CommandDev
        {
            get => commandDev ?? (commandDev = new RelayCommand(o=>
            {
                if (!IsDev)
                    IsDev = true;
                else IsDev = false;
            }));
        }

        private RelayCommand commandRu;
        public RelayCommand CommandRu
        {
            get => commandRu ?? (commandRu = new RelayCommand(o =>
            {
                INI.Write("DefaultSetting", "Language", "RU");
            }));
        }

        private RelayCommand commandEn;
        public RelayCommand CommandEn
        {
            get => commandEn ?? (commandEn = new RelayCommand(o =>
            {
                INI.Write("DefaultSetting", "Language", "EN");
            }));
        }

        public string GetContentDev
        {
            get => IsDev ? "Разработчик" : "Пользователь";
        }
         
        public bool IsDev
        {
            get => User.isDev;
            set
            {
                User.isDev = value;
                OnPropertyChanged("IsDev");
                OnPropertyChanged("GetLanguage");
                OnPropertyChanged("GetContentDev");
            }
        }

        private string getSetting;
        public string GetSetting
        {
            get => getSetting;
            set
            {
                getSetting = value;
                OnPropertyChanged("GetSetting");
                OnPropertyChanged("CommandDark");
                OnPropertyChanged("CommandSnow");
                OnPropertyChanged("SettingViewModel");
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

        public SettingViewModel()
        {
            GetSetting = INI.ReadINI("DefaultSetting", "Color");

            if (GetSetting == "Dark" || GetSetting == null)
                (App.Current as App).ChangeSkin(Skin.Dark);
            else 
                (App.Current as App).ChangeSkin(Skin.Snow);

            //if (GetSettingLanguage == "EN")
            //    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            //else
            //    Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU");
        }
    }
}