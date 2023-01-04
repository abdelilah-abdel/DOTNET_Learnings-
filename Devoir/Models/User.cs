using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Devoir.Models
{
    public class User
    {
        [Required(ErrorMessage = "Requiered field")]
        public string name { get; set; }
        [Required(ErrorMessage = "Requiered field")]
        public string username { get; set; }
        [Required(ErrorMessage = "Requiered field")]
        public string password { get; set; }


    }
}