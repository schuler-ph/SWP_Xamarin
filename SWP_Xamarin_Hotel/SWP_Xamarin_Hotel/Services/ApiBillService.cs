using Newtonsoft.Json;
using SWP_Xamarin_Hotel.Models;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace SWP_Xamarin_Hotel.Services
{
    internal class ApiBillService : IBillService
    {
        private readonly HttpClient _client;

        public ApiBillService()
        {
            this._client = new HttpClient();
        }

        public Task AddBill(Bill bill)
        {
            throw new NotImplementedException();
        }


        public async Task<ObservableCollection<Bills_Rooms>> GetAllBillsByRoomId(int roomId)
        {
            try
            {
                HttpResponseMessage response = await _client.GetAsync(Constants.BillsUrl + "/byRoom/" + roomId);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    Debug.WriteLine(content);
                    return JsonConvert.DeserializeObject<ObservableCollection<Bills_Rooms>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return null;
        }

        public Task<ObservableCollection<Bill>> GetAllBills()
        {
            throw new NotImplementedException();
        }

        public Task<Bill> GetBill(int roomId)
        {
            throw new NotImplementedException();
        }

        public Task RemoveBill(Bill bill)
        {
            throw new NotImplementedException();
        }

        public Task SaveBill(Bill bill)
        {
            throw new NotImplementedException();
        }
    }
}
