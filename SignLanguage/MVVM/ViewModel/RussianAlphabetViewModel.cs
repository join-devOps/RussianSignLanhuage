using SignLanguage.Core;
using SignLanguage.MVVM.Model;
using SignLanguage.MVVM.Model.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace SignLanguage.MVVM.ViewModel
{
    class RussianAlphabetViewModel : CorePropertyChanged, IUser
    {
        private readonly ModelClass model;

        private byte GetMaxCount
        {
            get => (byte)RusAlphabetList.rusAlphabets.Count();
        }

        public bool IsDev
        {
            get => User.isDev;
            set
            {
                User.isDev = value;
                OnPropertyChanged("IsDev");
                OnPropertyChanged("GetChangeImage");
            }
        }
        
        public List<RusAlphabet> GetWord
        {
            get => RusAlphabetList.rusAlphabets.ToList();
        }

        private RusAlphabet getImage;
        public RusAlphabet GetImage
        {
            get => getImage;
            set
            {
                getImage = value;
                OnPropertyChanged("GetImage");
            }
        }

        private byte getSelectedIndex;
        public byte GetSelectedIndex
        {
            get => getSelectedIndex;
            set
            {
                SetProperty(ref getSelectedIndex, value);
                OnPropertyChanged("HideButtonNext");
                OnPropertyChanged("HideButtonBack");
            }
        }

        private CoreRelayCommand backCommand;
        public CoreRelayCommand BackCommand
        {
            get => backCommand ?? (backCommand = new CoreRelayCommand(o => { GetSelectedIndex--; } ));
        }

        private CoreRelayCommand nextCommand;
        public CoreRelayCommand NextCommand
        {
            get => nextCommand ?? (nextCommand = new CoreRelayCommand(o => { GetSelectedIndex++; } ));
        }

        public Visibility HideButtonNext
        {
            get => (GetSelectedIndex == GetMaxCount - 1) ? Visibility.Hidden : Visibility.Visible;
        }

        public Visibility HideButtonBack
        {
            get => (GetSelectedIndex == 0) ? Visibility.Hidden : Visibility.Visible;
        }

        public Visibility GetChangeImage
        {
            get => IsDev == true ? Visibility.Visible : Visibility.Hidden;
        }

        public RussianAlphabetViewModel(ModelClass model)
        {
            this.model = model;
            GetSelectedIndex = 0;
        }
    }
}