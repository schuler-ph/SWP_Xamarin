
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SWP_Xamarin_Hotel.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RoomDetails : ContentPage
    {
        public RoomDetails(Room room)
        {
            InitializeComponent();
        }
    }
}