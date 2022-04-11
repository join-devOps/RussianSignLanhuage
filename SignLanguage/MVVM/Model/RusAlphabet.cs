using System;
using System.Collections.Generic;
using System.Windows.Media.Imaging;

namespace SignLanguage.MVVM.Model
{
    class RusAlphabet
    {
        public char Letter { get; set; }
        public BitmapImage Image { get; set; }
    }

    class RusAlphabetList
    {
        public static List<RusAlphabet> rusAlphabets = new List<RusAlphabet>() { new RusAlphabet() { Letter = 'А', Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/0.jpg")) },
                                                                          new RusAlphabet() { Letter = 'Б', Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/1.jpg")) },
                                                                          new RusAlphabet() { Letter = 'В', Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/2.jpg")) },
                                                                          new RusAlphabet() { Letter = 'Г', Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/3.jpg")) },
                                                                          new RusAlphabet() { Letter = 'Д', Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/4.jpg")) },
                                                                          new RusAlphabet() { Letter = 'Е', Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/5.jpg")) },
                                                                          new RusAlphabet() { Letter = 'Ё', Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/6.jpg")) },
                                                                          new RusAlphabet() { Letter = 'Ж', Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/7.jpg")) },
                                                                          new RusAlphabet() { Letter = 'З', Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/8.jpg")) },
                                                                          new RusAlphabet() { Letter = 'И', Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/9.jpg")) },
                                                                          new RusAlphabet() { Letter = 'Й', Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/10.jpg")) },
                                                                          new RusAlphabet() { Letter = 'К', Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/11.jpg")) },
                                                                          new RusAlphabet() { Letter = 'Л', Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/12.jpg")) },
                                                                          new RusAlphabet() { Letter = 'М', Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/13.jpg")) },
                                                                          new RusAlphabet() { Letter = 'Н', Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/14.jpg")) },
                                                                          new RusAlphabet() { Letter = 'О', Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/15.jpg")) },
                                                                          new RusAlphabet() { Letter = 'П', Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/16.jpg")) },
                                                                          new RusAlphabet() { Letter = 'Р', Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/17.jpg")) },
                                                                          new RusAlphabet() { Letter = 'С', Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/18.jpg")) },
                                                                          new RusAlphabet() { Letter = 'Т', Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/19.jpg")) },
                                                                          new RusAlphabet() { Letter = 'У', Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/20.jpg")) },
                                                                          new RusAlphabet() { Letter = 'Ф', Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/21.jpg")) },
                                                                          new RusAlphabet() { Letter = 'Х', Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/22.jpg")) },
                                                                          new RusAlphabet() { Letter = 'Ц', Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/23.jpg")) },
                                                                          new RusAlphabet() { Letter = 'Ч', Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/24.jpg")) },
                                                                          new RusAlphabet() { Letter = 'Ш', Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/25.jpg")) },
                                                                          new RusAlphabet() { Letter = 'Щ', Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/26.jpg")) },
                                                                          new RusAlphabet() { Letter = 'Ъ', Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/27.jpg")) },
                                                                          new RusAlphabet() { Letter = 'Ы', Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/28.jpg")) },
                                                                          new RusAlphabet() { Letter = 'Ь', Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/29.jpg")) },
                                                                          new RusAlphabet() { Letter = 'Э', Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/30.jpg")) },
                                                                          new RusAlphabet() { Letter = 'Ю', Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/31.jpg")) },
                                                                          new RusAlphabet() { Letter = 'Я', Image = new BitmapImage( new Uri("pack://application:,,,/SignLanguage.Images;component/Images/32.jpg")) }};
    }
}