using EventAppCase.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;


namespace EventAppCase.Controllers
{
    public class SelectedGEController : Controller
    {
        private readonly EventContext _context;

        public SelectedGEController(EventContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var selectedGeValues = await _context.SGuests.Include(x=> x.Guest).Include(x=>x.Event).ToListAsync();
            return View(selectedGeValues);
        }

        public async Task<IActionResult> CreateGE()
        {
            ViewBag.Events = new SelectList(await _context.Events.ToListAsync(),"EventId","EventName");
            ViewBag.Guests= new SelectList(await _context.Guests.ToListAsync(), "GuestId", "GuestAdSoyad");

            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateGE(SelectedGuests model)
        {
            model.SelectedDate = DateTime.Now;
           _context.SGuests.Add(model);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }
    }
}
