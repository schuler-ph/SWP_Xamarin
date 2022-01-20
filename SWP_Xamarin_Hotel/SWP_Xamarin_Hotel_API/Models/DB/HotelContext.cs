using Microsoft.EntityFrameworkCore;

namespace SWP_Xamarin_Hotel_API.Models.DB
{
    public class HotelContext : DbContext
    {
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Guests_Addresses> Guests_Addresses { get; set; }

        public DbSet<Bill> Bills { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Bills_Rooms> Bills_Rooms { get;}

        public DbSet<AdditionalService> AdditionalServices { get; set; }
        public DbSet<Bills_AdditionalServices> Bills_AdditionalServices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost;database=swp_xamarin_hotel;user=root;password=root");
        }
    }
}
