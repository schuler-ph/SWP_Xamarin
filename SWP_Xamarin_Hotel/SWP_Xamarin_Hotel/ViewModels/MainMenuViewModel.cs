using SWP_Xamarin_Hotel.Views;
using System.Windows.Input;
using Xamarin.Forms;
using BindingBase = SWP_Xamarin_Hotel.Models.Common.BindingBase;

namespace SWP_Xamarin_Hotel.ViewModels
{
    internal class MainMenuViewModel : BindingBase
    {
        public ICommand CmdNavigateRooms => new Command(NavigateRooms);

        private async void NavigateRooms()
        {
            AllRoomsView view = new AllRoomsView();
            await Application.Current.MainPage.Navigation.PushModalAsync(view);
        }

        public ICommand CmdNavigateGuests => new Command(NavigateGuests);

        private async void NavigateGuests()
        {
            AllGuestsView view = new AllGuestsView();
            await Application.Current.MainPage.Navigation.PushModalAsync(view);
        }
    }
}
