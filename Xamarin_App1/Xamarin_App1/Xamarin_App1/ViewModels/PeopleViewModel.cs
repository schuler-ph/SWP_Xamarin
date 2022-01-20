using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin_App1.Models;

namespace Xamarin_App1.ViewModels
{
    public class PeopleViewModel : Models.common.BindingBase
    {
        // wir benötigen eine Listen für die Personen
        // statt List, ... wird ObservableCollection<Typ> verwendet
        // ObservableCollection ... aktualisiert automatisch beim hinzufügen, entfernen oder ändern
        //    vorhandener Datensätze

        /// Vorsicht: wird eine neue Liste der ObservableCollection zugewiesen, dann
        /// wird diese nicht automatisch aktualisiert (in der View angezeigt)

        private ObservableCollection<Person> _people;

        // Lösung: nun kann der ObservableCollection auch eine neue ObservableCollection zugewiesen werden
        public ObservableCollection<Person> People
        {
            get { return this._people; }
            set { 
                this._people = value;
                this.RaisePropertyChanged(nameof(People));
            }
        }

        public PeopleViewModel()
        {
            LoadPeople();
        }


        private void LoadPeople()
        {
            // Personen werden normalerweise aus der Datenbank geladen

            this.People = new ObservableCollection<Person>()
            {
                new Person() { PersonId = 1, Firstname="Philipp", Lastname="Schuler",
                    Gender=Gender.male, Birthday=new DateTime(2003, 05, 13), Salary=3494.23m },

                new Person() { PersonId = 2, Firstname="Moritz", Lastname="Laichner",
                    Gender=Gender.male, Birthday=new DateTime(2003, 08, 21), Salary=9523.21m },

                new Person() { PersonId = 3, Firstname="Anselm", Lastname="Schmidt",
                    Gender=Gender.male, Birthday=new DateTime(2002, 06, 01), Salary=92342.12m },

                new Person() { PersonId = 4, Firstname="Simon", Lastname="Zangerle",
                    Gender=Gender.male, Birthday=new DateTime(2002, 07, 02), Salary=84.34m },
            };
        }

        public ICommand CmdNavigateBack => new Command(NavigateBack);

        private async void NavigateBack()
        {
            await Application.Current.MainPage.Navigation.PopModalAsync();
        }

        public ICommand CmdAddNewPerson => new Command(NewPerson);

        private void NewPerson()
        {
            this.People.Add(new Person
            { PersonId = 5, Firstname = "Nimit", Lastname = "Singh", Salary = 23.0m, Birthday = new DateTime(2001, 10, 10), Gender = Gender.male });
        }
    }
}
