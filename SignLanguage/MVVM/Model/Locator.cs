using SignLanguage.Core;
using SignLanguage.MVVM.ViewModel;

namespace SignLanguage.MVVM.Model
{
    class Locator : CorePropertyChanged
    {
        private readonly ModelClass model = new ModelClass();
        public MainViewModel MainVM { get; }
        public RussianAlphabetViewModel RusAlphabetVM { get; }
        public WordsViewModel RusWordsVM { get; }

        public Locator()
        {
            MainVM = new MainViewModel(model);
            RusAlphabetVM = new RussianAlphabetViewModel(model);
            RusWordsVM = new WordsViewModel(model);
        }
    }
}