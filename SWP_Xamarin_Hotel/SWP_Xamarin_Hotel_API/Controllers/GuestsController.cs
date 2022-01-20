﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SWP_Xamarin_Hotel_API.Models;
using SWP_Xamarin_Hotel_API.Models.DB;

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
            return this._context.Guests.Include("address").ToList();
        }
    }
}