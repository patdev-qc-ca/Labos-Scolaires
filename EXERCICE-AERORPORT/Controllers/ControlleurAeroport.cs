using Microsoft.AspNetCore.Mvc;

namespace Exercice1_Aerorport.Controllers
{
    public class ControlleurAeroport : Controller
    {
        public IActionResult ReserverVoiture()
        {
            return View();
        }
    }
}
