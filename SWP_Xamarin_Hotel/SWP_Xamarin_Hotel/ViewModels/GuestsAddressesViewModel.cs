using SWP_Xamarin_Hotel.Models;
using SWP_Xamarin_Hotel.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using BindingBase = SWP_Xamarin_Hotel.Models.Common.BindingBase;

namespace SWP_Xamarin_Hotel.ViewModels
{
    internal class GuestsAddressesViewModel : BindingBase
    {
        private ApiGuestService _api = new ApiGuestService();

        private string _passportNumber;

        public string PassportNumber
        {
            get { return _passportNumber; }
            set { _passportNumber = value; this.RaisePropertyChanged(nameof(PassportNumber)); }
        }

        private ObservableCollection<Address> _addresses;
        public ObservableCollection<Address> Addresses
        {
            get { return _addresses; }
            set { _addresses = value; this.RaisePropertyChanged(nameof(Addresses)); }
        }

        public ICommand CmdLoadAddresses => new Command(async () =>
        {
            Addresses = await _api.GetGuestsAddresses(PassportNumber);
        });

        public ICommand CmdNavigateBack => new Command(async () =>
        {
            await Application.Current.MainPage.Navigation.PopModalAsync();
        });
    }
}
