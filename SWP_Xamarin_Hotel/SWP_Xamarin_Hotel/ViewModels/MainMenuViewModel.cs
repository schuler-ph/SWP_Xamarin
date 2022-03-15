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

        public ICommand CmdNavigateRegister => new Command(NavigateRegister);

        private async void NavigateRegister()
        {
            RegisterView view = new RegisterView();
            await Application.Current.MainPage.Navigation.PushModalAsync(view);
        }
    }
}
