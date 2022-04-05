using SignLanguage.Core;
using SignLanguage.MVVM.Model;
using SignLanguage.MVVM.Model.Interface;

namespace SignLanguage.MVVM.ViewModel
{
    class SettingViewModel : ObservableObject, IUser
    {
        private RelayCommand commandDark;
        public RelayCommand CommandDark
        {
            get => commandDark ?? (commandDark = new RelayCommand(o=>
            {
                (App.Current as App).ChangeSkin(Skin.Dark);
            }));
        }

        private RelayCommand commandSnow;
        public RelayCommand CommandSnow
        {
            get => commandSnow ?? (commandSnow = new RelayCommand(o =>
            {
                (App.Current as App).ChangeSkin(Skin.Snow);
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
    }
}