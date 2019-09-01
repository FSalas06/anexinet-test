using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Input;
using Xamarin.Forms;

namespace anexinettest.ViewModels
{
    public class Test1ViewModel : BaseViewModel
    {
        private string _vowelsText;

        public string VowelsText
        {
            get { return _vowelsText; }
            set { SetProperty(ref _vowelsText, value); }
        }

        public ICommand VowelsTextCommand { get; private set; }

        public Test1ViewModel()
        {
            VowelsTextCommand = new Command<string>(VowelsTextCommandExecute);
        }

        private void VowelsTextCommandExecute(string obj)
        {
            if(string.IsNullOrEmpty(obj))
            {
                VowelsText = "Please instert a value";
            }
            else
            {
                VowelsText = $"Number of vowels: {CountVowels(obj)}";
            }
            
        }

        private int CountVowels(string somestring)
        {
            try
            {
                string str = Regex.Replace(somestring.ToLower(), @"s", "");
                int v = 0;
                foreach(var s in str)
                {
                    if (s.Equals('a') || s.Equals('e') || s.Equals('i') || s.Equals('o') || s.Equals('o'))
                    {
                        v++;
                    }
                }
                return v;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("An Error : " + ex.Message);
                return 0;
            }
        }
    }
}
