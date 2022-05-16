using SignLanguage.Core;
using SignLanguage.Math;
using SignLanguage.MVVM.Model;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace SignLanguage.MVVM.ViewModel.Test
{
    class TestHellViewModel : CorePropertyChanged
    {
        private List<ResultExcel> _ResultList;
        public List<ResultExcel> ResultList
        {
            get
            {
                if (_ResultList == null)
                    _ResultList = new List<ResultExcel>();

                return _ResultList;
            }
            set
            {
                SetProperty(ref _ResultList, value);
                OnPropertyChanged("SumResult");
            }
        }

        public string GetString
        {
            get
            {
                return WordsList.allWordsList[SelectString].Title;
            }
        }

        public int GetMaxCountString
        {
            get => WordsList.allWordsList.Count - 1;
        }

        private byte _SelectString = 0;
        public byte SelectString
        {
            get => _SelectString;
            set
            {
                SetProperty(ref _SelectString, value);
                OnPropertyChanged("GetString");
            }
        }

        private bool _IsHidde = false;
        public bool IsHidde
        {
            get => _IsHidde;
            set
            {
                SetProperty(ref _IsHidde, value);
                OnPropertyChanged("SetHiddenCommands");
                OnPropertyChanged("SetHiddenResult");
            }
        }

        private CoreRelayCommand _SkipCommand;
        public CoreRelayCommand SkipCommand
        {
            get => _SkipCommand ?? (_SkipCommand = new CoreRelayCommand(o =>
            {
                ResultList.Add(new ResultExcel() { Title = GetString.ToString(), ResultBool = false });

                if (SelectString == GetMaxCountString)
                {
                    IsHidde = true;
                    SumResult = sumRes();
                    SumResultWithPercent = sumResWithPerc();
                }
                else
                    SelectString++;
            }));
        }

        private CoreRelayCommand _NextCommand;
        public CoreRelayCommand NextCommand
        {
            get => _NextCommand ?? (_NextCommand = new CoreRelayCommand(o =>
            {
                ResultList.Add(new ResultExcel() { Title = GetString.ToString(), ResultBool = true });

                if (SelectString == GetMaxCountString)
                {
                    IsHidde = true;
                    SumResult = sumRes();
                    SumResultWithPercent = sumResWithPerc();
                }
                else
                    SelectString++;
            }));
        }

        public Visibility SetHiddenCommands
        {
            get => IsHidde ? Visibility.Collapsed : Visibility.Visible;
        }

        public Visibility SetHiddenResult
        {
            get => IsHidde ? Visibility.Visible : Visibility.Collapsed;
        }

        private string _SumResult;
        public string SumResult
        {
            get => _SumResult;
            set => SetProperty(ref _SumResult, value);
        }

        private string _SumResultWithPercent;
        public string SumResultWithPercent
        {
            get => _SumResultWithPercent;
            set => SetProperty(ref _SumResultWithPercent, value);
        }

        private string sumRes()
        {
            return GetResult.GetSum(ResultList.Select(item => item.ResultBool).ToList()).ToString()
                + " / " + GetResult.GetMaxSum(ResultList.Select(item => item.ResultBool).ToList()).ToString();
        }

        private string sumResWithPerc()
        {
            return GetResult.GetPercent(GetResult.GetSum(ResultList.Select(item => item.ResultBool).ToList()),
                GetResult.GetMaxSum(ResultList.Select(item => item.ResultBool).ToList())) + " %";
        }

        public TestHellViewModel()
        {

        }
    }
}