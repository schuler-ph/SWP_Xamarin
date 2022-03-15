	using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin_App1.Models;
using Xamarin_App1.Models.common;
using Xamarin_App1.Views;
using BindingBase = Xamarin_App1.Models.common.BindingBase;

namespace Xamarin_App1.ViewModels
{
    internal class PersonViewModel : BindingBase
    {
        private bool _personDataOK = true;

        private int _personId;
        private string _firstname;
        private string _lastname;
        private Gender _gender;
        private decimal _salary;
        private DateTime _birthday;


        public int PersonId { 
            get { return this._personId; } 
            set { 
                this._personId = value;
                this.RaisePropertyChanged(nameof(PersonId));
            }
        }
        public string Firstname
        {
            get { return this._firstname; }
            set
            {
                this._firstname = value;
                this.RaisePropertyChanged(nameof(Firstname));
            }
        }
        public string Lastname
        {
            get { return this._lastname; }
            set
            {
                if (value == null || value.Trim().Length < 3)
                {
                    this._personDataOK = false;
                }
                else
                {
                    this._lastname = value;
                    this.RaisePropertyChanged(nameof(Lastname));
                    this._personDataOK = true;
                }
            }
        }
        public Gender Gender
        {
            get { return this._gender; }
            set
            {
                this._gender = value;
                this.RaisePropertyChanged(nameof(Gender));
            }
        }
        public decimal Salary
        {
            get { return this._salary; }
            set
            {
                this._salary = value;
                this.RaisePropertyChanged(nameof(Salary));
            }
        }
        public DateTime Birthday
        {
            get { return this._birthday; }
            set
            {
                this._birthday = value;
                this.RaisePropertyChanged(nameof(Birthday));
            }
        }


        public ICommand CommandSaveUserData => new Command(SavePersonData);

        public ICommand CmdShowAllPeople => new Command(ShowAllPeople);

        private async void ShowAllPeople()
        {
            //neue View anzeigen

            PeopleView peopleView = new PeopleView();

            // die neue View am Navigation-Stack ablegen
            await Application.Current.MainPage.Navigation.PushModalAsync(peopleView);
        }

        private void SavePersonData()
        {
            // Eingabedaten überprüfen

            // Personendaten in einer DB abspeichern

            return;
        }
    }
}
