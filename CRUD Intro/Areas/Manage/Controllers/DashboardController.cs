using Microsoft.AspNetCore.Mvc;

namespace CRUD_Intro.Areas.Manage.Controllers
{


    [Area("Manage")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
