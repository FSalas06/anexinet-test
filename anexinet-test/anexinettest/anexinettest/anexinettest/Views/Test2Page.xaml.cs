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
    public partial class Test2Page : ContentPage
    {
        private Test2ViewModel _viewModel;

        public Test2Page()
        {
            InitializeComponent();
            BindingContext = _viewModel = new Test2ViewModel();
        }
    }
}