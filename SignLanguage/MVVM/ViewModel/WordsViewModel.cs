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
        List<Words> wordsCollege = new List<Words>() { new Words() { Title = "Колледж", Media = new Uri("pack://application:,,,/SignLanguage.Images;component/Images/0.jpg") },
                                                       new Words() { Title = "Группа", Media = new Uri("pack://application:,,,/SignLanguage.Images;component/Images/0.jpg") },
                                                       new Words() { Title = "Курс", Media = new Uri("pack://application:,,,/SignLanguage.Images;component/Images/0.jpg") },
                                                       new Words() { Title = "Руководитель(-ница)", Media = new Uri("pack://application:,,,/SignLanguage.Images;component/Images/0.jpg") },
                                                       new Words() { Title = "Я учусь на 4 курсе", Media = new Uri("pack://application:,,,/SignLanguage.Images;component/Images/0.jpg") }};

        List<Words> wordsFamily = new List<Words>() { new Words() { Title = "Мама", Media = new Uri("Media/Family/Mom.MOV", UriKind.Relative) },
                                                       new Words() { Title = "Отец", Media = new Uri("Media/Family/Dad.MOV", UriKind.Relative) },
                                                       new Words() { Title = "Бабушка", Media = new Uri("Media/Family/Grandmom.MOV", UriKind.Relative) },
                                                       new Words() { Title = "Дед", Media = new Uri("Media/Family/GrandDad.MOV", UriKind.Relative) },
                                                       new Words() { Title = "Брат", Media = new Uri("Media/Family/Bro.MOV", UriKind.Relative) },
                                                       new Words() { Title = "Сестра", Media = new Uri("Media/Family/Sis.MOV", UriKind.Relative) }};

        private RelayCommand showFamily;
        public RelayCommand ShowFamily
        {
            get => showFamily ?? (showFamily = new RelayCommand(o => { CollegeFamily = false; }));
        }

        private RelayCommand showCollege;
        public RelayCommand ShowCollege
        {
            get => showCollege ?? (showCollege = new RelayCommand(o => { CollegeFamily = true; }));
        }

        public string GetContent
        {
            get => CollegeFamily ? "Колледж" : "Семья";
        }

        private bool collegeFamily = false;
        public bool CollegeFamily
        {
            get => collegeFamily;
            set
            {
                collegeFamily = value;
                OnPropertyChanged("CollegeFamily");
                OnPropertyChanged("GetFamily");
                OnPropertyChanged("GetCollege");
                OnPropertyChanged("GetContent");
                OnPropertyChanged("GetMedia");
            }
        }

        public Visibility GetFamily
        {
            get => CollegeFamily == false ? Visibility.Visible : Visibility.Collapsed;
        }

        public Visibility GetCollege
        {
            get => CollegeFamily == true ? Visibility.Visible : Visibility.Collapsed;
        }

        public List<Words> WordsCollege
        {
            get => wordsCollege.ToList();
        }

        public List<Words> WordsFamily
        {
            get => wordsFamily.ToList();
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