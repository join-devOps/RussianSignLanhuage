using System.Collections.Generic;
using SignLanguage.MVVM.Model;
using SignLanguage.Core;
using System;
using System.Linq;
using System.Windows;

namespace SignLanguage.MVVM.ViewModel
{
    class WordsViewModel : CorePropertyChanged
    {
        private readonly ModelClass model;

        private CoreRelayCommand showCollege;
        public CoreRelayCommand ShowCollege
        {
            get => showCollege ?? (showCollege = new CoreRelayCommand(o => { SetLearning = 0; }));
        }

        private CoreRelayCommand showFamily;
        public CoreRelayCommand ShowFamily
        {
            get => showFamily ?? (showFamily = new CoreRelayCommand(o => { SetLearning = 1; }));
        }

        private CoreRelayCommand showLearning;
        public CoreRelayCommand ShowLearning
        {
            get => showLearning ?? (showLearning = new CoreRelayCommand(o => { SetLearning = 2; }));
        }

        private CoreRelayCommand showSoftware;
        public CoreRelayCommand ShowSoftware
        {
            get => showSoftware ?? (showSoftware = new CoreRelayCommand(o => { SetLearning = 3; }));
        }

        private CoreRelayCommand backCommand;
        public CoreRelayCommand BackCommand
        {
            get => backCommand ?? (backCommand = new CoreRelayCommand(o => { GetSelectedIndex--; }));
        }

        private CoreRelayCommand nextCommand;
        public CoreRelayCommand NextCommand
        {
            get => nextCommand ?? (nextCommand = new CoreRelayCommand(o => { GetSelectedIndex++; }));
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

        
        public byte GetMaxCount
        {
            get
            {
                if (SetLearning == 1)
                    return (byte)WordsFamily.Count;
                if (SetLearning == 2)
                    return (byte)WordsLearning.Count;
                if (SetLearning == 3)
                    return (byte)WordsSoftware.Count;
                if (SetLearning == 4)
                    return (byte)WordsSoftware.Count;
                else
                    return (byte)WordsCollege.Count;
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

        public Visibility HideButtonNext
        {
            get => (GetSelectedIndex == GetMaxCount - 1) ? Visibility.Hidden : Visibility.Visible;
        }

        public Visibility HideButtonBack
        {
            get => (GetSelectedIndex == 0) ? Visibility.Hidden : Visibility.Visible;
        }

        private List<Words> _wordsList;
        public List<Words> WordsCollege
        {
            get
            {
                List<Words> _WordsList = _wordsList;

                if (SearchText != null)
                    _WordsList = _WordsList.Where(item => item.Title.IndexOf(SearchText, System.StringComparison.OrdinalIgnoreCase) != -1).ToList();

                return _WordsList;
            }
            set
            {
                SetProperty(ref _wordsList, value);
                OnPropertyChanged("SearchText");
            }
        }

        private List<Words> _WordsFamily;
        public List<Words> WordsFamily
        {
            get
            {
                List<Words> _WordsList = _WordsFamily;

                if (SearchText != null)
                    _WordsList = _WordsList.Where(item => item.Title.IndexOf(SearchText, System.StringComparison.OrdinalIgnoreCase) != -1).ToList();

                return _WordsList;
            }
            set
            {
                SetProperty(ref _WordsFamily, value);
                OnPropertyChanged("SearchText");
            }
        }

        private List<Words> _WordsLearning;
        public List<Words> WordsLearning
        {
            get
            {
                List<Words> _WordsList = _WordsLearning;

                if (SearchText != null)
                    _WordsList = _WordsList.Where(item => item.Title.IndexOf(SearchText, System.StringComparison.OrdinalIgnoreCase) != -1).ToList();

                return _WordsList;
            }
            set
            {
                SetProperty(ref _WordsLearning, value);
                OnPropertyChanged("SearchText");
            }
        }

        private List<Words> _WordsSoftware;
        public List<Words> WordsSoftware
        {
            get
            {
                List<Words> _WordsList = _WordsSoftware;

                if (SearchText != null)
                    _WordsList = _WordsList.Where(item => item.Title.IndexOf(SearchText, System.StringComparison.OrdinalIgnoreCase) != -1).ToList();

                return _WordsList;
            }
            set
            {
                SetProperty(ref _WordsSoftware, value);
                OnPropertyChanged("SearchText");
            }
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

        private string searchText;
        public string SearchText
        {
            get => searchText;
            set
            {
                SetProperty(ref searchText, value);
                OnPropertyChanged("WordsCollege");
            }
        }

        public WordsViewModel(ModelClass model)
        {
            this.model = model;
            model.ValueChanged += ModelValueChanged;
            model.AllValueChanged();

            WordsCollege = WordsList.wordsCollege.ToList();
            WordsFamily = WordsList.wordsFamily.ToList();
            WordsLearning = WordsList.wordsLearning.ToList();
            WordsSoftware = WordsList .wordsSoftware.ToList();
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