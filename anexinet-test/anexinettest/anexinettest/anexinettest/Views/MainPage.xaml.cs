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
	public partial class MainPage : ContentPage
	{
        private MainViewModel _viewmodel;

		public MainPage ()
		{
			InitializeComponent ();
            BindingContext = _viewmodel = new MainViewModel();
		}
	}
}