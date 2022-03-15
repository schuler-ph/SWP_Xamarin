using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SWP_Xamarin_Hotel_API.Models;
using SWP_Xamarin_Hotel_API.Models.DB;
using System.Diagnostics;

namespace SWP_Xamarin_Hotel_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestsController : ControllerBase
    {
        private HotelContext _context = new HotelContext();

        [HttpGet]
        public List<Guest> GetGuests()
        {
            return this._context.Guests.ToList();
        }

        [HttpPost]
        [Route("register")]
        public void Register(Guest guest)
        {
            this._context.Guests.Add(guest);

            try
            {
                this._context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                Debug.WriteLine("Diese Passnummer existiert bereits.");
            }
        }
    }
}
