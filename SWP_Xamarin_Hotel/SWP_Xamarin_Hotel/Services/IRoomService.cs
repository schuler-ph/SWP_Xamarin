using SWP_Xamarin_Hotel.Models;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace SWP_Xamarin_Hotel.Services
{
    internal interface IRoomService
    {
        Task AddRoom(Room room);

        Task RemoveRoom(Room room);

        Task<Room> GetRoom(int roomId);

        Task<ObservableCollection<Room>> GetAllRooms();

        Task SaveRoom(Room room);
    }
}
