using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_App1.ViewModels;

namespace Xamarin_App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PeopleView : ContentPage
    {
        private PeopleViewModel _vm = new PeopleViewModel();

        public PeopleView()
        { 
            InitializeComponent();
            this.BindingContext = this._vm;
        }
    }
}