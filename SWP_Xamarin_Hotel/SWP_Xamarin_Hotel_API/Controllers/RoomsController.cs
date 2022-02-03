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
        public List<Bills_Rooms> GetRooms()
        {
            // return this._context.Rooms.ToList();
            return this._context.Bills_Rooms.Include("Room").ToList();
        }
        /*
        [Route("freeRooms")]
        [HttpGet]
        public List<Bills_Rooms> GetFreeRooms()
        {
        }*/
    }
}
