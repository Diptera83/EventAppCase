using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace EventAppCase.Models
{
    public class EventContext: DbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<SelectedGuests> SGuests { get; set; }

        public EventContext(DbContextOptions options) : base(options)
        {

        }


    }
}
