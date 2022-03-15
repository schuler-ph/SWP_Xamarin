using SWP_Xamarin_Hotel.Models;
using SWP_Xamarin_Hotel.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SWP_Xamarin_Hotel.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterView : ContentPage
    {
        private RegisterViewModel _vm = new RegisterViewModel();

        public RegisterView()
        {
            InitializeComponent();

            _vm.CurrentGuest = new Guest("7IB", "Magnus", "Carlsen", new DateTime(1995, 1, 1));

            this.BindingContext = _vm;
        }
    }
}