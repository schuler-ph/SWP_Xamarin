using SWP_Xamarin_Hotel.Models;
using SWP_Xamarin_Hotel.Services;
using System.Windows.Input;
using Xamarin.Forms;
using BindingBase = SWP_Xamarin_Hotel.Models.Common.BindingBase;

namespace SWP_Xamarin_Hotel.ViewModels
{
    internal class RegisterViewModel : BindingBase
    {
        // str passport, str fn, str ln, date bday
        public Guest CurrentGuest { get; set; }


        private readonly ApiGuestService _api = new ApiGuestService();

        public ICommand CmdSubmit => new Command(Submit);

        private async void Submit()
        {
            await _api.AddGuest(CurrentGuest);
        }

        public ICommand CmdNavigateBack => new Command(NavigateBack);
        private async void NavigateBack() { await Application.Current.MainPage.Navigation.PopModalAsync(); }
    }
}
