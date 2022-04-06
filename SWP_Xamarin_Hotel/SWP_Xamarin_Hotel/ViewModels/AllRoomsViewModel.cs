using SWP_Xamarin_Hotel.Models;
using SWP_Xamarin_Hotel.Services;
using SWP_Xamarin_Hotel.Views;
using System;
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

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        private readonly ApiRoomService _api = new ApiRoomService();

        public AllRoomsViewModel()
        {
            this._rooms = new ObservableCollection<Room>();
            this.StartDate = new DateTime(2022, 01, 01);
            this.EndDate = new DateTime(2022, 02, 05);
        }

        public ICommand CmdLoadRooms => new Command(LoadRooms);
        private async void LoadRooms() { Rooms = await _api.GetAllRooms(); }

        public ICommand CmdLoadFreeRooms => new Command(LoadFreeRooms);
        private async void LoadFreeRooms() { Rooms = await _api.GetAllFreeRooms(StartDate, EndDate); }

        public ICommand CmdNavigateBack => new Command(NavigateBack);
        private async void NavigateBack() { await Application.Current.MainPage.Navigation.PopModalAsync(); }

        public ICommand CmdNavigateDetails => new Command(async (int id) =>
        {
            ApiRoomService _api = new ApiRoomService();
            Room room = await _api.GetSingleRoom(roomId);
            RoomDetailsView view = new RoomDetailsView(room);
            await Application.Current.MainPage.Navigation.PushModalAsync(view);
        });

    }
}
