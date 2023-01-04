using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class VoitureController : Controller
    {
        // GET: Voiture/Liste
        public ActionResult ListeVoitures()
        {

            var voiture = new Voiture() { ID = 1, Marque = "Mercedes", Matricule = "143B5", Prix = 455000    };

            return View(voiture);
        }
    }
}