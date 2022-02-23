using SWP_Xamarin_Hotel.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SWP_Xamarin_Hotel.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AllRoomsView : ContentPage
    {
        private AllRoomsViewModel _vm = new AllRoomsViewModel();

        public AllRoomsView()
        {
            InitializeComponent();
            this.BindingContext = _vm;
        }
    }
}