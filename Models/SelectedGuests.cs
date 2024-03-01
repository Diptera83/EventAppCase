using System.ComponentModel.DataAnnotations;

namespace EventAppCase.Models
{
    public class SelectedGuests
    {
       [Key] public int Id { get; set; }
        public int GuestId { get; set; }

        public Guest Guest { get; set; } = null!; //joinleme için

        public int EventId { get; set; }

        public Event Event { get; set; } = null!; //joinleme için

        public DateTime SelectedDate { get; set; }
    }
}
