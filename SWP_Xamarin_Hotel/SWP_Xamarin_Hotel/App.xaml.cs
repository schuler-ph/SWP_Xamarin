using SWP_Xamarin_Hotel.Views;
using Xamarin.Forms;

namespace SWP_Xamarin_Hotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AllRoomsView();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
