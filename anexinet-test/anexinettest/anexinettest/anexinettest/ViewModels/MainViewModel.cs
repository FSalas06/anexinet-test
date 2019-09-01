using anexinettest.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace anexinettest.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        #region private properties
        #endregion

        #region public properties
        public ICommand Test1Command { get; private set; }
        public ICommand Test2Command { get; private set; }
        #endregion

        #region public methods
        public MainViewModel()
        {
            Test1Command = new Command(Test1CommandExecute);
            Test2Command = new Command(Test2CommandExecute);
        }
        #endregion

        #region private methods

        private void Test1CommandExecute()
        {
            PushAsync(new Test1Page());
        }

        private void Test2CommandExecute()
        {
            PushAsync(new Test2Page());
        }
        #endregion
    }
}
