
using Microsoft.AspNetCore.Mvc;

namespace LibraryProject.Controllers
{
    
    public class BookTypeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}