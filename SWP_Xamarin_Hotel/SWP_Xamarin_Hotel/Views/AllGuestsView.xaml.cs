using SWP_Xamarin_Hotel.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SWP_Xamarin_Hotel.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AllGuestsView : ContentPage
    {
        AllGuestsViewModel _vm = new AllGuestsViewModel();

        public AllGuestsView()
        {
            InitializeComponent();
            this.BindingContext = _vm;
        }
    }
}