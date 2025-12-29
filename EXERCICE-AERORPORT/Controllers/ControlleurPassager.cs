using Exercice1_Aerorport.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Exercice1_Aerorport.Controllers
{
    public class ControlleurPassager : Controller
    {
        List<Passager> liste = new();
        public IActionResult CreerPassager(string localite, int Id , string Nom ,string Prenom ,string CodePostal,int Numero,string Rue , string numPassport)
        {
            Passager passager = new();
            passager.Localitee = localite;
            passager.Id = Id;
            passager.Rue = Rue;
            passager.numPassport = numPassport;
            passager.CodePostal = CodePostal;
            passager.Numero = Numero;
            return View();
        }
    }
}

