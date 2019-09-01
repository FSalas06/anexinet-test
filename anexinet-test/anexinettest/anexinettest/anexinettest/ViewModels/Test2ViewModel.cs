using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace anexinettest.ViewModels
{
    public class Test2ViewModel : BaseViewModel
    {
        private string _minutesDifferenceText;
        private DateTime _firstDate;
        private DateTime _lastDate;

        public string MinutesDifferenceText
        {
            get { return _minutesDifferenceText; }
            set { SetProperty(ref _minutesDifferenceText, value); }
        }

        public DateTime FirstDate
        {
            get { return _firstDate; }
            set { SetProperty(ref _firstDate, value); }
        }

        public DateTime LastDate
        {
            get { return _lastDate; }
            set { SetProperty(ref _lastDate, value); }
        }

        public ICommand GetDifferenceCommand { get; private set; }

        public Test2ViewModel()
        {
            GetDifferenceCommand = new Command(GetDifferenceCommandExecute);
            DateTime dt = DateTime.UtcNow.Date;
            FirstDate = dt;
            LastDate = dt;
        }

        private void GetDifferenceCommandExecute()
        {
            try
            {
                if (FirstDate != null || LastDate != null)
                {
                    TimeSpan ts = new TimeSpan();
                    ts = LastDate.Subtract(FirstDate);

                    MinutesDifferenceText = $"The time in minutes between {FirstDate.Date} and {LastDate.Date} = {ts.TotalMinutes}";
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine("An Error :" + ex.Message);
                MinutesDifferenceText = "An Error occurs :( ";
            }
        }
    }
}
