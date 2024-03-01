using System.ComponentModel.DataAnnotations;

namespace EventAppCase.Models
{
    public class Guest
    {

        [Key] public int GuestId { get; set; }
        public string? GuestName { get; set; }
        public string? GuestSurname { get; set; }
        public string? GuestMail { get; set; }

        public string GuestAdSoyad
        {
            get
            {
                return this.GuestName + " " + GuestSurname;
            }
        }


    }
}
