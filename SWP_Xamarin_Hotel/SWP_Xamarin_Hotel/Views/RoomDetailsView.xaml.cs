
using SWP_Xamarin_Hotel.Models;
using SWP_Xamarin_Hotel.ViewModels;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SWP_Xamarin_Hotel.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RoomDetailsView : ContentPage
    {
        RoomDetailsViewModel _vm = new RoomDetailsViewModel();

        public RoomDetailsView(Room room, ObservableCollection<Bills_Rooms> billsRooms)
        {
            InitializeComponent();
            _vm.Room = room;
            _vm.PrevRoom = room;
            _vm.BillsRooms = billsRooms;
            this.BindingContext = _vm;
        }
    }
}