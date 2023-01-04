using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class Voiture
    {
        public int ID { get; set; }
        public string Matricule { get; set; }
        public string Marque { get; set; }
        public float Prix { get; set; }
        public DateTime DateAjout { get; set; }
    }
}