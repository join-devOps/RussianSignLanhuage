using SignLanguage.Core;

namespace SignLanguage.MVVM.Model
{
    class User : ObservableObject
    {
        public static bool isDev { get; set; } = false;
    }
}