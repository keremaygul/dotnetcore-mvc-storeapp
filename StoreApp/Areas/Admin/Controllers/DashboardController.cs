using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace StoreApp.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        [Area("Admin")]
        [Authorize(Roles = "Admin")]

        public IActionResult Index()
        {
            TempData["info"] = $"Welcome back, {DateTime.Now.ToShortTimeString()}";
            return View();
        }
    }
}