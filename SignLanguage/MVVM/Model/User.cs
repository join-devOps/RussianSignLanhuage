using SignLanguage.Core;

namespace SignLanguage.MVVM.Model
{
    class User : CorePropertyChanged
    {
        public static bool isDev { get; set; } = false;
    }
}