using SWP_Xamarin_Hotel.Models;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace SWP_Xamarin_Hotel.Services
{
    internal interface IBillService
    {
        Task AddBill(Bill bill);

        Task RemoveBill(Bill bill);

        Task<Bill> GetBill(int roomId);

        Task<ObservableCollection<Bill>> GetAllBills();

        Task SaveBill(Bill bill);
    }
}
