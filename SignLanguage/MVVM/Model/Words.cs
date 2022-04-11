using System;
using System.Collections.Generic;

namespace SignLanguage.MVVM.Model
{
    class Words
    {
        public string Title { get; set; }
        public System.Uri Media { get; set; }
    }

    class WordsList
    {
        public static List<Words> wordsCollege = new List<Words>() {  new Words() { Title = "Колледж",                Media = new Uri("Media/College/1.wmv",          UriKind.Relative) },
                                                        new Words() { Title = "Группа",                 Media = new Uri("Media/College/2.wmv",          UriKind.Relative) },
                                                        new Words() { Title = "Курс",                   Media = new Uri("Media/College/3.wmv",          UriKind.Relative) },
                                                        new Words() { Title = "Руководитель(-ница)",    Media = new Uri("Media/College/4.wmv",          UriKind.Relative) },
                                                        new Words() { Title = "Я учусь на 4 курсе",     Media = new Uri("Media/College/5.wmv",          UriKind.Relative) }};

        public static List<Words> wordsFamily = new List<Words>() {   new Words() { Title = "Мама",                   Media = new Uri("Media/Family/Mom.wmv",         UriKind.Relative) },
                                                        new Words() { Title = "Отец",                   Media = new Uri("Media/Family/Dad.wmv",         UriKind.Relative) },
                                                        new Words() { Title = "Бабушка",                Media = new Uri("Media/Family/Grandmom.wmv",    UriKind.Relative) },
                                                        new Words() { Title = "Дед",                    Media = new Uri("Media/Family/GrandDad.wmv",    UriKind.Relative) },
                                                        new Words() { Title = "Брат",                   Media = new Uri("Media/Family/Bro.wmv",         UriKind.Relative) },
                                                        new Words() { Title = "Сестра",                 Media = new Uri("Media/Family/Sis.wmv",         UriKind.Relative) }};

        public static List<Words> wordsLearning = new List<Words>() { new Words() { Title = "Как вас зовут?",         Media = new Uri("Media/Studying/1.wmv",         UriKind.Relative) },
                                                        new Words() { Title = "Сколько вам лет?",       Media = new Uri("Media/Studying/2.wmv",         UriKind.Relative) },
                                                        new Words() { Title = "До свидания",            Media = new Uri("Media/Studying/3.wmv",         UriKind.Relative) },
                                                        new Words() { Title = "Поддерживаю",            Media = new Uri("Media/Studying/4.wmv",         UriKind.Relative) }};

        public static List<Words> wordsSoftware = new List<Words>() { new Words() { Title = "Приложение",             Media = new Uri("Media/Software/1.wmv",          UriKind.Relative) },
                                                        new Words() { Title = "Сборка",                 Media = new Uri("Media/Software/2.wmv",          UriKind.Relative) },
                                                        new Words() { Title = "Тестирование",           Media = new Uri("Media/Software/3.wmv",          UriKind.Relative) },
                                                        new Words() { Title = "Документация",           Media = new Uri("Media/Software/4.wmv",          UriKind.Relative) },
                                                        new Words() { Title = "Установить",             Media = new Uri("Media/Software/5.wmv",          UriKind.Relative) },
                                                        new Words() { Title = "Баг",                    Media = new Uri("Media/Software/6.wmv",          UriKind.Relative) }};
    }
}