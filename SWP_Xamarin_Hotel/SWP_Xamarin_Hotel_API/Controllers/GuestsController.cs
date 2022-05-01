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

        [HttpGet]
        [Route("addresses/{passportNumber}")]
        public List<Address> GetAddressesByPassportNumber(string passportNumber)
        {
            Address a = new Address();
            a.StreetName = "Kreuzbicchlstraße";
            a.HouseNumber = "57";
            a.ZipCode = "6112";
            a.City = "Wattens";

            List<Address> addresses = this._context.Addresses
                .Where(ad => ad.StreetName == a.StreetName)
                .Where(ad => ad.HouseNumber == a.HouseNumber)
                .Where(ad => ad.ZipCode == a.ZipCode)
                .Where(ad => ad.City == a.City)
                .ToList();

            foreach (Address address in addresses)
            {
                Debug.WriteLine(address.AddressId);
            }

            return this._context.Guests_Addresses.Where(ga => ga.Guest.PassportNumber == passportNumber)
                .Select(ga => ga.Address).ToList();
        }

        [HttpPost]
        [Route("addresses")]
        public void NewAddress(Address address)
        {
            this._context.Addresses.Add(address);

            try
            {
                this._context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                Debug.WriteLine("Diese Passnummer existiert bereits.");
            }
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
