using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace anexinettest.ViewModels
{
    public abstract class BaseViewModel : MvvmHelpers.BaseViewModel
    {
        public void PushAsync(Page page)
        {
            Application.Current.MainPage.Navigation.PushAsync(page);
        }
    }
}
