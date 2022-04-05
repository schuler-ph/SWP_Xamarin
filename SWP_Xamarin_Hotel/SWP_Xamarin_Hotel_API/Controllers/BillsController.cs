using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SWP_Xamarin_Hotel_API.Models;
using SWP_Xamarin_Hotel_API.Models.DB;

namespace SWP_Xamarin_Hotel_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillsController : ControllerBase
    {
        private HotelContext _context = new HotelContext();

        [Route("byRoom/{roomId}")]
        [HttpGet]
        public List<Bills_Rooms> GetReservationsForRoom(int roomId)
        {
            var query1 = from br in _context.Bills_Rooms
                         where br.Room.RoomId == roomId
                         select br;

            return _context.Bills_Rooms.Where(br => br.Room.RoomId == roomId)
                .Include("Room").Include("Bill").Include("Bill.Guest").Select(br => br).ToList();

            return query1.ToList();
        }
    }
}
