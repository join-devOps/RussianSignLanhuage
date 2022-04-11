using SignLanguage.Core;
using SignLanguage.MVVM.Model;
using SignLanguage.MVVM.Model.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace SignLanguage.MVVM.ViewModel
{
    class RussianAlphabetViewModel : ObservableObject, IUser
    {
        

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

        private byte getSelectedIndex = 0;
        public byte GetSelectedIndex
        {
            get => getSelectedIndex;
            set
            {
                getSelectedIndex = value;
                OnPropertyChanged("GetSelectedIndex");
                OnPropertyChanged("HideButtonNext");
                OnPropertyChanged("HideButtonBack");
            }
        }

        private RelayCommand backCommand;
        public RelayCommand BackCommand
        {
            get => backCommand ?? (backCommand = new RelayCommand(o => { GetSelectedIndex--; } ));
        }

        private RelayCommand nextCommand;
        public RelayCommand NextCommand
        {
            get => nextCommand ?? (nextCommand = new RelayCommand(o => { GetSelectedIndex++; } ));
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
    }
}