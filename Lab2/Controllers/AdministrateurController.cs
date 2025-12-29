using Microsoft.AspNetCore.Mvc;
using Laboratoire2.Models;
namespace Laboratoire2.Controllers
{
    public class AdministrateurController:Controller
    {
        public List<Clients> clients = new();
        private ContexteApplication Contexte = new();
        public IActionResult Index()
        {
            return Json( DateTime.Now.ToString()+" Creation utilisateur");
        }
        public IActionResult CreerUtilisateur(String Nom)
        {
            Clients cl = new();
            if (cl.ID ==clients.Count)
            {
                return BadRequest();
            }
            else
            {
                cl.ID = clients.Count+1;
                cl.Nom = Nom;
                clients.Add(cl);
                Contexte.SaveChanges();

                return Json($"\n{DateTime.Now} utilisateur créé");
            }
        }
        public IActionResult ModifierUtilisateur(int ID, String Nom)
        {
            Clients cl = new()
            {
                ID = ID,
                Nom = Nom
            };
            clients.Add(cl);
            Contexte.SaveChanges();
            return Json($"\n{DateTime.Now} utilisateur modifié");
        }
        public IActionResult SupprimerUtilisateur(int ID)
        {
            Clients cl = new();
            if (cl.ID == ID)
            {
                return BadRequest();
            }
            else
            {
                cl.ID = ID;
                clients.Remove(cl);
                Contexte.SaveChanges();
                return Json($"\n{DateTime.Now} utilisateur supprime");
            }
        }
    }
}
