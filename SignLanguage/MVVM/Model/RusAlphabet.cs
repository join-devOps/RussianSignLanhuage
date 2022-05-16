using System;
using System.Collections.Generic;
using System.Windows.Media.Imaging;

namespace SignLanguage.MVVM.Model
{
    class RusAlphabet
    {
        public string Title { get; set; }
        public BitmapImage Image { get; set; }
    }

    class RusAlphabetList
    {
        public static List<RusAlphabet> rusAlphabets = new List<RusAlphabet>() { new RusAlphabet() { Title = "А", Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/0.jpg")) },
                                                                          new RusAlphabet() { Title = "Б", Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/1.jpg")) },
                                                                          new RusAlphabet() { Title = "В", Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/2.jpg")) },
                                                                          new RusAlphabet() { Title = "Г", Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/3.jpg")) },
                                                                          new RusAlphabet() { Title = "Д", Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/4.jpg")) },
                                                                          new RusAlphabet() { Title = "Е", Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/5.jpg")) },
                                                                          new RusAlphabet() { Title = "Ё", Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/6.jpg")) },
                                                                          new RusAlphabet() { Title = "Ж", Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/7.jpg")) },
                                                                          new RusAlphabet() { Title = "З", Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/8.jpg")) },
                                                                          new RusAlphabet() { Title = "И", Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/9.jpg")) },
                                                                          new RusAlphabet() { Title = "Й", Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/10.jpg")) },
                                                                          new RusAlphabet() { Title = "К", Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/11.jpg")) },
                                                                          new RusAlphabet() { Title = "Л", Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/12.jpg")) },
                                                                          new RusAlphabet() { Title = "М", Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/13.jpg")) },
                                                                          new RusAlphabet() { Title = "Н", Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/14.jpg")) },
                                                                          new RusAlphabet() { Title = "О", Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/15.jpg")) },
                                                                          new RusAlphabet() { Title = "П", Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/16.jpg")) },
                                                                          new RusAlphabet() { Title = "Р", Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/17.jpg")) },
                                                                          new RusAlphabet() { Title = "С", Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/18.jpg")) },
                                                                          new RusAlphabet() { Title = "Т", Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/19.jpg")) },
                                                                          new RusAlphabet() { Title = "У", Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/20.jpg")) },
                                                                          new RusAlphabet() { Title = "Ф", Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/21.jpg")) },
                                                                          new RusAlphabet() { Title = "Х", Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/22.jpg")) },
                                                                          new RusAlphabet() { Title = "Ц", Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/23.jpg")) },
                                                                          new RusAlphabet() { Title = "Ч", Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/24.jpg")) },
                                                                          new RusAlphabet() { Title = "Ш", Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/25.jpg")) },
                                                                          new RusAlphabet() { Title = "Щ", Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/26.jpg")) },
                                                                          new RusAlphabet() { Title = "Ъ", Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/27.jpg")) },
                                                                          new RusAlphabet() { Title = "Ы", Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/28.jpg")) },
                                                                          new RusAlphabet() { Title = "Ь", Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/29.jpg")) },
                                                                          new RusAlphabet() { Title = "Э", Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/30.jpg")) },
                                                                          new RusAlphabet() { Title = "Ю", Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/31.jpg")) },
                                                                          new RusAlphabet() { Title = "Я", Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/32.jpg")) }};
    }
}