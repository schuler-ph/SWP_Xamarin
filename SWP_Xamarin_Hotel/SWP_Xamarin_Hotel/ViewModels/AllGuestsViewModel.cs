using SWP_Xamarin_Hotel.Models;
using SWP_Xamarin_Hotel.Services;
using SWP_Xamarin_Hotel.Views;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using Xamarin.Forms;
using BindingBase = SWP_Xamarin_Hotel.Models.Common.BindingBase;

namespace SWP_Xamarin_Hotel.ViewModels
{
    internal class AllGuestsViewModel : BindingBase
    {
        private ObservableCollection<Guest> _guests;
        public ObservableCollection<Guest> Guests
        {
            get { return _guests; }
            set { _guests = value; this.RaisePropertyChanged(nameof(Guests)); }
        }


        private ApiGuestService _api = new ApiGuestService();

        public ICommand CmdLoadGuests => new Command(async () =>
        {
            Guests = await _api.GetAllGuests();
            Debug.WriteLine(Guests.Count);
        });

        public ICommand CmdNavigateAddresses => new Command<string>(async (string passportNumber) =>
        {
            ObservableCollection<Address> addresses = await _api.GetGuestsAddresses(passportNumber);
            Debug.WriteLine(addresses.Count);

            GuestsAddressesView view = new GuestsAddressesView(addresses, passportNumber);
            await Application.Current.MainPage.Navigation.PushModalAsync(view);
        });

        public ICommand CmdNavigateRegister => new Command(async () =>
        {
            RegisterView view = new RegisterView();
            await Application.Current.MainPage.Navigation.PushModalAsync(view);
        });


        public ICommand CmdNavigateBack => new Command(async () =>
        {
            await Application.Current.MainPage.Navigation.PopModalAsync();
        });
    }
}
