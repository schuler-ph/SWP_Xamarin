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

        [Route("{roomId}")]
        [HttpGet]
        public Room GetSingleRoom(int roomId)
        {
            return this._context.Rooms.Where(r => r.RoomId == roomId).Select(r => r).ToList()[0];
        }

        [Route("freeRooms/{start}/{end}")]
        [HttpGet]
        public List<Room> GetFreeRooms(string start, string end)
        {
            DateTime startDate = DateTime.Parse(start);
            DateTime endDate = DateTime.Parse(end);

            List<Room> rooms = this._context.Rooms.ToList();
            List<Bills_Rooms> bills_rooms = this._context.Bills_Rooms.ToList();

            List<Room> freeRooms = new List<Room>();
            // DateTime currentDate = DateTime.Now;
            bool roomFree;

            foreach (Room r in rooms)
            {
                roomFree = true;

                foreach (Bills_Rooms br in bills_rooms)
                {
                    if (br.Room.RoomId != r.RoomId) continue;
                    // if (br.BeginReservation < currentDate && currentDate < br.EndReservation) roomFree = false;
                    // if (endDate)


                    // checks if startdate or enddate are inside already existing reservation
                    // r s R e || r s e R || s r e R
                    if ((startDate > br.BeginReservation && startDate < br.EndReservation) ||
                        (endDate > br.BeginReservation && endDate < br.EndReservation)) roomFree = false;

                    // checks if inside start and enddate 
                    // s r R e
                    if (startDate < br.BeginReservation && endDate > br.EndReservation) roomFree = false;
                }

                if (roomFree) freeRooms.Add(r);
            }

            return freeRooms;
        }
    }
}
