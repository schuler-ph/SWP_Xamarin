using SWP_Xamarin_Hotel.Services;
using SWP_Xamarin_Hotel.Views;
using System.Windows.Input;
using Xamarin.Forms;

namespace SWP_Xamarin_Hotel.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        public string RoomNumber { get; set; }
        public int NumberOfBeds { get; set; }
        public bool HasKitchen { get; set; }
        public bool HasBalcony { get; set; }
        public bool HasTerrace { get; set; }
        public decimal PricePerNight { get; set; }

        public ICommand CmdNavigateDetails => new Command(async () =>
        {
            ApiRoomService _api = new ApiRoomService();
            Room room = await _api.GetSingleRoom(this.RoomId);
            RoomDetailsView view = new RoomDetailsView(room);
            await Application.Current.MainPage.Navigation.PushModalAsync(view);
        });
    }
}
