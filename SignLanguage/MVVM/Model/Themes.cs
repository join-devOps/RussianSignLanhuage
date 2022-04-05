using System;
using System.Windows;

namespace SignLanguage.MVVM.Model
{
    public class Themes : ResourceDictionary
    {
        private Uri _darkSource;
        private Uri _snowSource;

        public Uri DarkSource
        {
            get { return _darkSource; }
            set
            {
                _darkSource = value;
                UpdateSource();
            }
        }
        public Uri SnowSource
        {
            get { return _snowSource; }
            set
            {
                _snowSource = value;
                UpdateSource();
            }
        }

        public void UpdateSource()
        {
            var val = App.Skin == Skin.Dark ? DarkSource : SnowSource;
            if (val != null && base.Source != val)
                base.Source = val;
        }
    }
}