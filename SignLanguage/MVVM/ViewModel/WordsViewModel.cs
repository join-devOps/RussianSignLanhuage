using System.Collections.Generic;
using SignLanguage.MVVM.Model;
using SignLanguage.Core;
using System;
using System.Linq;
using System.Windows;

namespace SignLanguage.MVVM.ViewModel
{
    class WordsViewModel : ObservableObject
    {
        private RelayCommand showCollege;
        public RelayCommand ShowCollege
        {
            get => showCollege ?? (showCollege = new RelayCommand(o => { SetLearning = 0; }));
        }

        private RelayCommand showFamily;
        public RelayCommand ShowFamily
        {
            get => showFamily ?? (showFamily = new RelayCommand(o => { SetLearning = 1; }));
        }

        private RelayCommand showLearning;
        public RelayCommand ShowLearning
        {
            get => showLearning ?? (showLearning = new RelayCommand(o => { SetLearning = 2; }));
        }

        private RelayCommand showSoftware;
        public RelayCommand ShowSoftware
        {
            get => showSoftware ?? (showSoftware = new RelayCommand(o => { SetLearning = 3; }));
        }

        private RelayCommand backCommand;
        public RelayCommand BackCommand
        {
            get => backCommand ?? (backCommand = new RelayCommand(o => { GetSelectedIndex--; }));
        }

        private RelayCommand nextCommand;
        public RelayCommand NextCommand
        {
            get => nextCommand ?? (nextCommand = new RelayCommand(o => { GetSelectedIndex++; }));
        }

        public string GetContent
        {
            get
            {
                if (SetLearning == 0)
                    return "Колледж";
                if (SetLearning == 1)
                    return "Семья";
                if (SetLearning == 2)
                    return "Для начинающих";
                if (SetLearning == 3)
                    return "Разработчик ПО";
                else
                    return "Выберите тему";
            }
        }

        private byte setLearning;
        public byte SetLearning
        {
            get => setLearning;
            set
            {
                setLearning = value;
                OnPropertyChanged("CollegeFamily");
                OnPropertyChanged("GetFamily");
                OnPropertyChanged("GetCollege");
                OnPropertyChanged("GetLearning");
                OnPropertyChanged("GetSoftware");
                OnPropertyChanged("GetContent");
                OnPropertyChanged("GetMedia");
            }
        }

        public Visibility GetCollege
        {
            get => SetLearning == 0 ? Visibility.Visible : Visibility.Collapsed;
        }

        public Visibility GetFamily
        {
            get => SetLearning == 1 ? Visibility.Visible : Visibility.Collapsed;
        }

        public Visibility GetLearning
        {
            get => SetLearning == 2 ? Visibility.Visible : Visibility.Collapsed;
        }

        public Visibility GetSoftware
        {
            get => SetLearning == 3 ? Visibility.Visible : Visibility.Collapsed;
        }

        //public Visibility HideButtonNext
        //{
        //    get => (GetSelectedIndex == GetMaxCount - 1) ? Visibility.Hidden : Visibility.Visible;
        //}

        public Visibility HideButtonBack
        {
            get => (GetSelectedIndex == 0) ? Visibility.Hidden : Visibility.Visible;
        }

        public List<Words> WordsCollege
        {
            get => WordsList.wordsCollege.ToList();
        }

        public List<Words> WordsFamily
        {
            get => WordsList.wordsFamily.ToList();
        }

        public List<Words> WordsLearning
        {
            get => WordsList.wordsLearning.ToList();
        }

        public List<Words> WordsSoftware
        {
            get => WordsList.wordsSoftware.ToList();
        }

        private Words getMedia;
        public Words GetMedia
        {
            get => getMedia;
            set
            {
                getMedia = value;
                OnPropertyChanged("GetMedia");
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
            }
        }
    }
}