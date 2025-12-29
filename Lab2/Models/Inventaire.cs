using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Laboratoire2.Models
{
    public class Inventaire
    {
        public int ID { get; set; }
        public List<Vetement> Vetement { get; set; }

    }
}
