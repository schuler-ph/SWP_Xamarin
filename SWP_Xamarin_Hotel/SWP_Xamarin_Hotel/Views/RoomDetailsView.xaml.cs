
using SWP_Xamarin_Hotel.Models;
using SWP_Xamarin_Hotel.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SWP_Xamarin_Hotel.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RoomDetailsView : ContentPage
    {
        RoomDetailsViewModel _vm = new RoomDetailsViewModel();

        public RoomDetailsView(Room room)
        {
            InitializeComponent();
            _vm.Room = room;
            _vm.PrevRoom = room;
            this.BindingContext = _vm;
        }
    }
}