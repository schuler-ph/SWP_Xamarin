using SWP_Xamarin_Hotel.Models;
using SWP_Xamarin_Hotel.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using BindingBase = SWP_Xamarin_Hotel.Models.Common.BindingBase;

namespace SWP_Xamarin_Hotel.ViewModels
{
    internal class AllRoomsViewModel : BindingBase
    {
        private ObservableCollection<Room> _rooms;

        public ObservableCollection<Room> Rooms
        {
            get { return this._rooms; }
            set
            {
                this._rooms = value;
                this.RaisePropertyChanged(nameof(Rooms));
            }
        }

        private readonly ApiRoomService _api = new ApiRoomService();

        public AllRoomsViewModel()
        {
            this._rooms = new ObservableCollection<Room>();
        }

        public ICommand CmdLoadRooms => new Command(LoadRooms);

        private async void LoadRooms()
        {
            Rooms = await _api.GetAllRooms();
        }

        public ICommand CmdLoadFreeRooms => new Command(LoadFreeRooms);

        private async void LoadFreeRooms()
        {
            Rooms = await _api.GetAllFreeRooms();
        }
    }
}
