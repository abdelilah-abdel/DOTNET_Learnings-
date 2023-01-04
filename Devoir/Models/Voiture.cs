using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace Devoir.Models
{
    public class Voiture
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Requiered field")]
        public string Matricule { get; set; }

        [Required(ErrorMessage = "Requiered field")]
        public string Marque { get; set; }

        [Required(ErrorMessage = "Requiered field")]
        public int Prix { get; set; }

        public DateTime DateAjout;

        


    }
}