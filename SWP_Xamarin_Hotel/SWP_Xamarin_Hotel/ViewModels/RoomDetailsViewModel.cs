using SWP_Xamarin_Hotel.Models;
using System.Windows.Input;
using Xamarin.Forms;

using BindingBase = SWP_Xamarin_Hotel.Models.Common.BindingBase;

namespace SWP_Xamarin_Hotel.ViewModels
{
    internal class RoomDetailsViewModel : BindingBase
    {
        private Room _room;
        public Room Room
        {
            get { return _room; }
            set { _room = value; this.RaisePropertyChanged(nameof(Room)); }
        }

        public RoomDetailsViewModel()
        {

        }

        public ICommand CmdNavigateBack => new Command(async () =>
        {
            await Application.Current.MainPage.Navigation.PopModalAsync();
        });
    }
}
