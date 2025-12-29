using Laboratoire2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Laboratoire2.Controllers
{
    public class PaniersController:Controller
    {
        public int IdPanier { get; set; }
        public string NomVetement { get; set; }
        public int QtyCommande { get; set; }
        public Inventaire Inventaire { get; set; }
        public Clients clients { get; set; }
        public IActionResult Index()
        {
            return View();
        }

    }
}
