using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SWP_Xamarin_Hotel_API.Models;
using SWP_Xamarin_Hotel_API.Models.DB;

namespace SWP_Xamarin_Hotel_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private HotelContext _context = new HotelContext();

        [HttpGet]
        public List<Room> GetRooms()
        {
            return this._context.Rooms.ToList();
        }
        
        [Route("freeRooms")]
        [HttpGet]
        public List<Room> GetFreeRooms()
        {
            List<Room> rooms = this._context.Rooms.ToList();
            List<Bills_Rooms> bills_rooms = this._context.Bills_Rooms.ToList();

            List<Room> freeRooms = new List<Room>();
            DateTime currentDate = DateTime.Now;
            bool roomFree;

            foreach(Room r in rooms)
            {
                roomFree = true;

                foreach(Bills_Rooms br in bills_rooms)
                {
                    if (br.Room.RoomId != r.RoomId) continue;
                    if (br.BeginReservation < currentDate && currentDate < br.EndReservation) roomFree = false;
                }

                if (roomFree) freeRooms.Add(r);
            }

            return freeRooms;
        }
    }
}
