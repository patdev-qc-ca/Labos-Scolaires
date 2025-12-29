using Laboratoire2.Models;
using Microsoft.AspNetCore.Mvc;
namespace Laboratoire2.Controllers
{
    public class GestionClients:Controller
    {
        Paniers panier = new();
        public IActionResult Index()
        {
            return Json( $"\n{DateTime.Now} Commande validée");
        }
        public IActionResult AjouterVetementAuPanier(int IdPanier,int IdVetement)
        {
            return Json($"\n{DateTime.Now} ajouté");
        }
        public IActionResult ModifierVetementAuPanier(int IdPanier, int IdVetement)
        {
            return Json($"\n{DateTime.Now} modifié");
        }
        public IActionResult SupprimerVetementAuPanier(int idPanier, int IdVetement)
        {
            return Json($"\n{DateTime.Now} supprimée");
        }
        public IActionResult FlusherPanier(int idPanier)
        {
            return Json($"\n{DateTime.Now} flushé");
        }


    }
}
