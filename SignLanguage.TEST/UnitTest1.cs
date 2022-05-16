using Microsoft.VisualStudio.TestTools.UnitTesting;
using SignLanguage.Math;
using System.Collections.Generic;
using System.Linq;

namespace SignLanguage.TEST
{
    [TestClass]
    public class ResultMathsWithoutErrors
    {
        private List<bool> _ItemsB;
        public List<bool> ItemsB
        {
            get
            {
                if (_ItemsB == null)
                    return _ItemsB = new List<bool>();

                return _ItemsB;
            }
            
            set => _ItemsB = value;
        }

        [TestMethod]
        public void _Result()
        {
            Assert.AreEqual(_ConstResult, GetResult.GetSum(ItemsB.ToList()));
        }

        [TestMethod]
        public void _resultWithPercent()
        {
            Assert.AreEqual(_ConstResultWithPercent, GetResult.GetPercent(_ConstResult, 5));
        }

        public byte _ConstResultWithPercent
        {
            get => 100;
        }

        public byte _ConstResult
        {
            get => 5;
        }

        /*
         *  ResultMathsWithoutErrors - без ощибок,
         *  Это означает, что все оценки должны быть положительными
         *  Следовательно, что результат должен быть положительным
         *  То есть, результатом является оценка 5, с коэффициентом 1
         */
        public ResultMathsWithoutErrors()
        {
            ItemsB.Add(true);               
            ItemsB.Add(true);
            ItemsB.Add(true);
            ItemsB.Add(true);
            ItemsB.Add(true);
        }
    }

    [TestClass]
    public class ResultMathsWithOneError
    {
        private List<bool> _ItemsB;
        public List<bool> ItemsB
        {
            get
            {
                if (_ItemsB == null)
                    return _ItemsB = new List<bool>();

                return _ItemsB;
            }

            set => _ItemsB = value;
        }

        [TestMethod]
        public void _Result()
        {
            Assert.AreEqual(_ConstResult, GetResult.GetSum(ItemsB.ToList()));
        }

        [TestMethod]
        public void _resultWithPercent()
        {
            Assert.AreEqual(_ConstResultWithPercent, GetResult.GetPercent(_ConstResult, 5));
        }

        public byte _ConstResultWithPercent
        {
            get => 80;
        }

        public byte _ConstResult
        {
            get => 4;
        }

        /*
         *  ResultMathsWithOneError - присутствует одна ошибка,
         *  Вычисляем по формуле: R = итог / количество,
         *  где:    итог = (5 * 4 (true * 4) + 2 * 1 (false * 1))
         *          количество = 5
         *  R = 4
         *  
         *  Коэффициент по формуле: Coff = (Sum / MaxSum) * 100,
         *  где:    Sum     != 0 ,    Итог          , 4
         *          MaxSum  != 0 ,    Высший балл   , 5
         *  Coff =  8 (80 %)
         */
        public ResultMathsWithOneError()
        {
            ItemsB.Add(true );
            ItemsB.Add(true );
            ItemsB.Add(true );
            ItemsB.Add(false);
            ItemsB.Add(true );
        }
    }

    [TestClass]
    public class ResultMathsWithTwoErrors
    {
        private List<bool> _ItemsB;
        public List<bool> ItemsB
        {
            get
            {
                if (_ItemsB == null)
                    return _ItemsB = new List<bool>();

                return _ItemsB;
            }

            set => _ItemsB = value;
        }

        [TestMethod]
        public void _Result()
        {
            Assert.AreEqual(_ConstResult, GetResult.GetSum(ItemsB.ToList()));
        }

        [TestMethod]
        public void _resultWithPercent()
        {
            Assert.AreEqual(_ConstResultWithPercent, GetResult.GetPercent(_ConstResult, 5));
        }

        public byte _ConstResultWithPercent
        {
            get => 60;
        }

        public byte _ConstResult
        {
            get => 3;
        }

        /*
         *  ResultMathsWithTwoErrors - присутствуют две ошибки,
         *  Вычисляем по формуле: R = итог / количество,
         *  где:    итог = (5 * 3 (true * 3) + 2 * 2 (false * 2))
         *          количество = 5
         *  R = 3
         *  
         *  Коэффициент по формуле: Coff = (Sum / MaxSum) * 100,
         *  где:    Sum     != 0 ,    Итог          , 3
         *          MaxSum  != 0 ,    Высший балл   , 5
         *  Coff =  6 (60 %)
         */
        public ResultMathsWithTwoErrors()
        {
            ItemsB.Add(true );
            ItemsB.Add(true );
            ItemsB.Add(false);
            ItemsB.Add(false);
            ItemsB.Add(true );
        }
    }

    [TestClass]
    public class ResultMathsWithThreeErrors
    {
        private List<bool> _ItemsB;
        public List<bool> ItemsB
        {
            get
            {
                if (_ItemsB == null)
                    return _ItemsB = new List<bool>();

                return _ItemsB;
            }

            set => _ItemsB = value;
        }

        [TestMethod]
        public void _Result()
        {
            Assert.AreEqual(_ConstResult, GetResult.GetSum(ItemsB.ToList()));
        }

        public byte _ConstResult
        {
            get => 3;
        }

        /*
         *  ResultMathsWithThreeErrors - присутствуют три ошибки,
         *  Вычисляем по формуле: R = итог / количество,
         *  где:    итог = (5 * 2 (true * 2) + 2 * 3 (false * 3))
         *          количество = 5
         *  R = 3
         */
        public ResultMathsWithThreeErrors()
        {
            ItemsB.Add(true);
            ItemsB.Add(false);
            ItemsB.Add(false);
            ItemsB.Add(false);
            ItemsB.Add(true);
        }
    }

    [TestClass]
    public class ResultMathsWithFothErrors
    {
        private List<bool> _ItemsB;
        public List<bool> ItemsB
        {
            get
            {
                if (_ItemsB == null)
                    return _ItemsB = new List<bool>();

                return _ItemsB;
            }

            set => _ItemsB = value;
        }

        [TestMethod]
        public void _Result()
        {
            Assert.AreEqual(_ConstResult, GetResult.GetSum(ItemsB.ToList()));
        }

        public byte _ConstResult
        {
            get => 2;
        }

        /*
         *  ResultMathsWithFothErrors - присутствуют четыре ошибки,
         *  Вычисляем по формуле: R = итог / количество,
         *  где:    итог = (5 * 1 (true * 1) + 2 * 4 (false * 4))
         *          количество = 5
         *  R = 2
         */
        public ResultMathsWithFothErrors()
        {
            ItemsB.Add(true);
            ItemsB.Add(false);
            ItemsB.Add(false);
            ItemsB.Add(false);
            ItemsB.Add(false);
        }
    }

    [TestClass]
    public class ResultMathsWithMaxErrors
    {
        private List<bool> _ItemsB;
        public List<bool> ItemsB
        {
            get
            {
                if (_ItemsB == null)
                    return _ItemsB = new List<bool>();

                return _ItemsB;
            }

            set => _ItemsB = value;
        }

        [TestMethod]
        public void _Result()
        {
            Assert.AreEqual(_ConstResult, GetResult.GetSum(ItemsB.ToList()));
        }

        public byte _ConstResult
        {
            get => 2;
        }

        /*
         *  ResultMathsWithMaxErrors - присутствуют все ошибки,
         *  Вычисляем по формуле: R = итог / количество,
         *  где:    итог = (5 * 0 (true * 0) + 2 * 5 (false * 5))
         *          количество = 5
         *  R = 2
         */
        public ResultMathsWithMaxErrors()
        {
            ItemsB.Add(false);
            ItemsB.Add(false);
            ItemsB.Add(false);
            ItemsB.Add(false);
            ItemsB.Add(false);
        }
    }
}