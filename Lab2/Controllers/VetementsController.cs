using Microsoft.EntityFrameworkCore;
using Laboratoire2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Laboratoire2.Controllers
{
    public class VetementsController:Controller
    {
        List<Vetement> vetement = new();
        private ContexteApplication contexte = new();
         public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreerVetement(int IdVetement, string Description, int quantite)
        {
            Vetement vet = new();
            if (IdVetement != 0 && Description != null && quantite != 0)
            {
                vet.ID = IdVetement;
                vet.NomVetement = Description;
                vet.QtyVetement = vet.ResteVetement + quantite;
                vetement.Add(vet);
                contexte.SaveChanges();
                return Json($"\n{Description} Créé.");
            }
            else 
            {
                return BadRequest();

            }
        }
        public IActionResult ModifierItem(int IdVetement, string Description, int quantite)
        {
            return BadRequest();
        }
    }
}
