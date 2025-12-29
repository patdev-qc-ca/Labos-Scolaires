using Exercice1_Aerorport.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exercice1_Aerorport.Controllers
{
    public class ControlleurClient : Controller
    {
        public IActionResult CreerClient(Passager passager)
        {
            return View();
        }
    }
}
