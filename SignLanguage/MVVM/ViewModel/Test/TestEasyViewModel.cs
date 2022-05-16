using SignLanguage.Core;
using SignLanguage.Math;
using SignLanguage.MVVM.Model;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace SignLanguage.MVVM.ViewModel.Test
{
    class TestEasyViewModel : CorePropertyChanged
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

        public string GetChar
        {
            get => RusAlphabetList.rusAlphabets[SelectChar].Title;
        }

        private byte _SelectChar = 0;
        public byte SelectChar
        {
            get => _SelectChar;
            set
            {
                SetProperty(ref _SelectChar, value);
                OnPropertyChanged("GetChar");
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
                ResultList.Add(new ResultExcel() { Title = GetChar.ToString(), ResultBool = false });
                
                if (SelectChar == 32)
                {
                    IsHidde = true;
                    SumResult = sumRes();
                    SumResultWithPercent = sumResWithPerc();
                }
                else
                    SelectChar++;
            }));
        }

        private CoreRelayCommand _NextCommand;
        public CoreRelayCommand NextCommand
        {
            get => _NextCommand ?? (_NextCommand = new CoreRelayCommand(o =>
            {
                ResultList.Add(new ResultExcel() { Title = GetChar.ToString(), ResultBool = true });

                if (SelectChar == 32)
                {
                    IsHidde = true;
                    SumResult = sumRes();
                    SumResultWithPercent = sumResWithPerc();
                }
                else
                    SelectChar++;
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
    }
}