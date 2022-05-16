using SignLanguage.Core;
using System;
using System.Collections.Generic;

namespace SignLanguage.MVVM.Model
{
    class Words : CorePropertyChanged
    {
        private string _Title;
        public string Title
        {
            get => _Title;
            set => SetProperty(ref _Title, value);
        }

        private Uri _Media;
        public Uri Media
        {
            get => _Media;
            set => SetProperty(ref _Media, value);
        }
    }

    class AllWordsList
    {
        public string Title { get; set; }
    }

    class WordsList
    {
        public static List<Words> wordsCollege = new List<Words>() 
        {  
            new Words() { Title = "Колледж",                Media = new Uri("Media/College/9.wmv",  UriKind.Relative) },
            new Words() { Title = "Группа",                 Media = new Uri("Media/College/2.wmv",  UriKind.Relative) },
            new Words() { Title = "Курс",                   Media = new Uri("Media/College/3.wmv",  UriKind.Relative) },
            new Words() { Title = "Руководитель",           Media = new Uri("Media/College/1.wmv",  UriKind.Relative) },
            new Words() { Title = "Я учусь на 4 курсе",     Media = new Uri("Media/College/5.wmv",  UriKind.Relative) },
            new Words() { Title = "Объясните ещё раз",      Media = new Uri("Media/College/4.wmv",  UriKind.Relative) },
            new Words() { Title = "Извините, я опоздал",    Media = new Uri("Media/College/6.wmv",  UriKind.Relative) },
            new Words() { Title = "Диплом",                 Media = new Uri("Media/College/7.wmv",  UriKind.Relative) },
            new Words() { Title = "Печать",                 Media = new Uri("Media/College/8.wmv",  UriKind.Relative) },
            new Words() { Title = "Учиться",                Media = new Uri("Media/College/10.wmv", UriKind.Relative) },
            new Words() { Title = "Работать",               Media = new Uri("Media/College/11.wmv", UriKind.Relative) },
            new Words() { Title = "Думать",                 Media = new Uri("Media/College/12.wmv", UriKind.Relative) },
            new Words() { Title = "Заболел",                Media = new Uri("Media/College/13.wmv", UriKind.Relative) },
            new Words() { Title = "Сидеть",                 Media = new Uri("Media/College/14.wmv", UriKind.Relative) },
            new Words() { Title = "Заявление",              Media = new Uri("Media/College/15.wmv", UriKind.Relative) },
            new Words() { Title = "Паспорт",                Media = new Uri("Media/College/16.wmv", UriKind.Relative) },
            new Words() { Title = "Подписаться",            Media = new Uri("Media/College/17.wmv", UriKind.Relative) },
            new Words() { Title = "Директор",               Media = new Uri("Media/College/18.wmv", UriKind.Relative) }
        };

        public static List<Words> wordsFamily = new List<Words>() 
        {   
            new Words() { Title = "Мама",    Media = new Uri("Media/Family/6.wmv", UriKind.Relative) },
            new Words() { Title = "Отец",    Media = new Uri("Media/Family/1.wmv", UriKind.Relative) },
            new Words() { Title = "Бабушка", Media = new Uri("Media/Family/2.wmv", UriKind.Relative) },
            new Words() { Title = "Дедушка", Media = new Uri("Media/Family/5.wmv", UriKind.Relative) },
            new Words() { Title = "Брат",    Media = new Uri("Media/Family/3.wmv", UriKind.Relative) },
            new Words() { Title = "Сестра",  Media = new Uri("Media/Family/4.wmv", UriKind.Relative) }
        };

        public static List<Words> wordsLearning = new List<Words>() 
        {
            new Words() { Title = "Здравствуйте",       Media = new Uri("Media/Studying/17.wmv",    UriKind.Relative)   },
            new Words() { Title = "Как вас зовут?",     Media = new Uri("Media/Studying/10.wmv",    UriKind.Relative)   },
            new Words() { Title = "Фамилия",            Media = new Uri("Media/Studying/11.wmv",    UriKind.Relative)   },
            new Words() { Title = "Отчество",           Media = new Uri("Media/Studying/12.wmv",    UriKind.Relative)   },
            new Words() { Title = "Сколько вам лет?",   Media = new Uri("Media/Studying/2.wmv",     UriKind.Relative)   },
            new Words() { Title = "Спасибо",            Media = new Uri("Media/Studying/13.wmv",    UriKind.Relative)   },
            new Words() { Title = "Пожалуйста",         Media = new Uri("Media/Studying/14.wmv",    UriKind.Relative)   },
            new Words() { Title = "Завтра",             Media = new Uri("Media/Studying/15.wmv",    UriKind.Relative)   },
            new Words() { Title = "Сегодня",            Media = new Uri("Media/Studying/16.wmv",    UriKind.Relative)   },
            new Words() { Title = "Поддерживаю",        Media = new Uri("Media/Studying/4.wmv",     UriKind.Relative)   },
            new Words() { Title = "До свидания",        Media = new Uri("Media/Studying/3.wmv",     UriKind.Relative)   }


        };

        public static List<Words> wordsSoftware = new List<Words>() 
        { 
            new Words() { Title = "Приложение",                 Media = new Uri("Media/Software/1.wmv",  UriKind.Relative) },
            new Words() { Title = "Сборка",                     Media = new Uri("Media/Software/9.wmv",  UriKind.Relative) },
            new Words() { Title = "Тестирование (1-ый вар)",    Media = new Uri("Media/Software/3.wmv",  UriKind.Relative) },
            new Words() { Title = "Тестирование (2-ой вар)",    Media = new Uri("Media/Software/10.wmv",  UriKind.Relative) },
            new Words() { Title = "Документация",               Media = new Uri("Media/Software/4.wmv",  UriKind.Relative) },
            new Words() { Title = "Установить",                 Media = new Uri("Media/Software/5.wmv",  UriKind.Relative) },
            new Words() { Title = "Баг",                        Media = new Uri("Media/Software/6.wmv",  UriKind.Relative) }};
        
        public static List<Words> allWordsList = new List<Words>();

    }
}