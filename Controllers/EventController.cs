using EventAppCase.Models;
using LinqToDB;
using Microsoft.AspNetCore.Mvc;


namespace EventAppCase.Controllers
{
    public class EventController : Controller
    {
        private readonly EventContext _context;

        public EventController(EventContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Apply()
        {
            return View();
        }




        public IActionResult CreateEvent()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateEvent(Event _event)
        {
            _context.Events.Add(_event);
            await _context.SaveChangesAsync();
            return RedirectToAction("EventList", "Event");

        }


        [HttpGet]
        public async Task<IActionResult> EventList()
        {
            var events = await _context.Events.ToListAsync();
            return View(events);
        }

        public async Task<IActionResult> EventDetail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            var myDetail = await _context.Events.FindAsync(id);

            if (myDetail == null)
            {
                return NotFound();
            }

            return View(myDetail);

        }


    }
}
