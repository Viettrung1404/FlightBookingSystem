using Microsoft.AspNetCore.Mvc;

namespace FlightBookingWeb.Controllers
{
    public class BookingTicketController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string Book()
        {
            return "Booking Ticket";
        }
    }
}
