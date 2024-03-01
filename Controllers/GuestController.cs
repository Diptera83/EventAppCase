using EventAppCase.Models;
using LinqToDB;
using Microsoft.AspNetCore.Mvc;

namespace EventAppCase.Controllers
{
    public class GuestController : Controller
    {
        private readonly EventContext _context;

        public GuestController(EventContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GuestList()
        {
            var guests = await _context.Guests.ToListAsync();
            return View(guests);
        }

        public IActionResult CreateGuest()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateGuest(Guest _guest)
        {
            _context.Guests.Add(_guest);
            await _context.SaveChangesAsync();
            return RedirectToAction("GuestList", "Guest");

        }
    }
}
