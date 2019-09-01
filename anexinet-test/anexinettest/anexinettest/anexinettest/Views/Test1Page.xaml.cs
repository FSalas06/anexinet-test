using anexinettest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace anexinettest.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Test1Page : ContentPage
	{
        private Test1ViewModel _viewmodel;

        public Test1Page ()
		{
			InitializeComponent ();
            BindingContext = _viewmodel = new Test1ViewModel();
		}
	}
}