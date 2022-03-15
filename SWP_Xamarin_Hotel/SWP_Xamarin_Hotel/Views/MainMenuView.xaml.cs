using SWP_Xamarin_Hotel.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SWP_Xamarin_Hotel.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMenuView : ContentPage
    {
        private MainMenuViewModel _vm = new MainMenuViewModel();

        public MainMenuView()
        {
            InitializeComponent();
            this.BindingContext = _vm;
        }
    }
}