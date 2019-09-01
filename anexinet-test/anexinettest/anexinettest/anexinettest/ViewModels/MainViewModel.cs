using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace anexinettest.ViewModels
{
    public class MainViewModel
    {
        #region private properties
        #endregion

        #region public properties
        public ICommand Test1Command { get; private set; }
        #endregion

        #region public methods
        public MainViewModel()
        {
            Test1Command = new Command(Test1CommandExecute);
        }
        #endregion

        #region private methods

        private void Test1CommandExecute()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
