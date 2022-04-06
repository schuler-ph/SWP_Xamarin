using SWP_Xamarin_Hotel.Models;
using SWP_Xamarin_Hotel.Services;
using System.Windows.Input;
using Xamarin.Forms;

using BindingBase = SWP_Xamarin_Hotel.Models.Common.BindingBase;

namespace SWP_Xamarin_Hotel.ViewModels
{
    internal class RoomDetailsViewModel : BindingBase
    {
        private ApiRoomService _api = new ApiRoomService();

        private Room _prevRoom;
        public Room PrevRoom
        {
            get { return _prevRoom; }
            set { _prevRoom = value; this.RaisePropertyChanged(nameof(PrevRoom)); }
        }

        private Room _room;
        public Room Room
        {
            get { return _room; }
            set { _room = value; this.RaisePropertyChanged(nameof(Room)); }
        }

        public RoomDetailsViewModel()
        {

        }

        public ICommand CmdSubmit => new Command(async () =>
        {
            await _api.UpdateRoom(Room);
        });

        public ICommand CmdNavigateBack => new Command(async () =>
        {
            await Application.Current.MainPage.Navigation.PopModalAsync();
        });
    }
}
