using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_App1.Views;

namespace Xamarin_App1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PersonDataView();
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
