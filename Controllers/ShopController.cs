using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OwnApp.Controllers
{
    public class ShopController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
