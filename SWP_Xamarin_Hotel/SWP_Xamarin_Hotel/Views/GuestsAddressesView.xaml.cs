
using SWP_Xamarin_Hotel.Models;
using SWP_Xamarin_Hotel.ViewModels;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SWP_Xamarin_Hotel.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GuestsAddressesView : ContentPage
    {
        GuestsAddressesViewModel _vm = new GuestsAddressesViewModel();

        public GuestsAddressesView(ObservableCollection<Address> addresses, string passportNumber)
        {
            InitializeComponent();
            _vm.Addresses = addresses;
            _vm.PassportNumber = passportNumber;
            this.BindingContext = _vm;
        }
    }
}