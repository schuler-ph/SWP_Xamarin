using SWP_Xamarin_Hotel.Models;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace SWP_Xamarin_Hotel.Services
{
    internal interface IGuestService
    {
        Task AddGuest(Guest guest);

        Task RemoveGuest(Guest guest);

        Task<Guest> GetGuest(string passport);

        Task<ObservableCollection<Guest>> GetAllGuests();

        Task SaveGuest(Guest guest);
    }
}
