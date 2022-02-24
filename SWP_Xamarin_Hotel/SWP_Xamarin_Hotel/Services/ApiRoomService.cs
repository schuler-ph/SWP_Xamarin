using Newtonsoft.Json;
using SWP_Xamarin_Hotel.Models;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace SWP_Xamarin_Hotel.Services
{
    internal class ApiRoomService : IRoomService
    {
        private readonly HttpClient _client;

        public ApiRoomService()
        {
            this._client = new HttpClient();
        }


        public Task AddRoom(Room room)
        {
            throw new NotImplementedException();
        }

        public async Task<ObservableCollection<Room>> GetAllRooms()
        {
            try
            {
                HttpResponseMessage response = await _client.GetAsync(Constants.RoomsUrl);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    Debug.WriteLine(content);
                    return JsonConvert.DeserializeObject<ObservableCollection<Room>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return null;
        }

        private string buildFreeRoomUrl(DateTime startDate, DateTime endDate)
        {
            string url = Constants.FreeRoomsUrl;
            url += "/";
            url += startDate.ToString("yyyy-MM-dd");
            url += "/";
            url += endDate.ToString("yyyy-MM-dd");
            return url;
        }

        public async Task<ObservableCollection<Room>> GetAllFreeRooms(DateTime startDate, DateTime endDate)
        {
            string url = buildFreeRoomUrl(startDate, endDate);

            try
            {
                HttpResponseMessage response = await _client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<ObservableCollection<Room>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return null;
        }


        public Task<Room> GetRoom(int roomId)
        {
            throw new NotImplementedException();
        }

        public Task RemoveRoom(Room room)
        {
            throw new NotImplementedException();
        }

        public Task SaveRoom(Room room)
        {
            throw new NotImplementedException();
        }
    }
}
