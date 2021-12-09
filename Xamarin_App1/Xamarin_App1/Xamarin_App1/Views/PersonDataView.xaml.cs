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
    public partial class PersonDataView : ContentPage
    {
        private PersonViewModel _vm = new PersonViewModel(); 

        public PersonDataView()
        {
            InitializeComponent();
            _vm.PersonId = 1;
            _vm.Firstname = "Philipp";
            _vm.Lastname = "Schuler";
            _vm.Gender = Models.Gender.male;
            _vm.Salary = 2348.13m;
            _vm.Birthday = new DateTime(2003, 05, 13);

            this.BindingContext = _vm;
        }
    }
}