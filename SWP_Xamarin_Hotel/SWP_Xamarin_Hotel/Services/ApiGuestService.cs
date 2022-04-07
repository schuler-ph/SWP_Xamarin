using Newtonsoft.Json;
using SWP_Xamarin_Hotel.Models;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace SWP_Xamarin_Hotel.Services
{
    internal class ApiGuestService : IGuestService
    {
        private readonly HttpClient _client;

        public ApiGuestService()
        {
            _client = new HttpClient();
        }


        public async Task AddGuest(Guest guest)
        {
            try
            {
                string json = JsonConvert.SerializeObject(guest);
                Debug.WriteLine(json);
                StringContent content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _client.PostAsync(Constants.RegisterUrl, content);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return;
        }

        public async Task<ObservableCollection<Guest>> GetAllGuests()
        {
            try
            {
                HttpResponseMessage response = await _client.GetAsync(Constants.GuestsUrl);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    Debug.WriteLine(content);
                    return JsonConvert.DeserializeObject<ObservableCollection<Guest>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return null;
        }

        public async Task<ObservableCollection<Address>> GetGuestsAddresses(string passportNumber)
        {
            try
            {
                HttpResponseMessage response = await _client.GetAsync(Constants.GuestsUrl + "/addresses/" + passportNumber);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    Debug.WriteLine(content);
                    return JsonConvert.DeserializeObject<ObservableCollection<Address>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return null;
        }

        public Task<Guest> GetGuest(string passport)
        {
            throw new System.NotImplementedException();
        }

        public Task RemoveGuest(Guest guest)
        {
            throw new System.NotImplementedException();
        }

        public Task SaveGuest(Guest guest)
        {
            throw new System.NotImplementedException();
        }
    }
}
