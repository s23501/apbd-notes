using Microsoft.AspNetCore.Mvc;

namespace apbd_notes.Controllers
{
    public class EndPointNameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
