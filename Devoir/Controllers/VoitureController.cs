using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using Devoir.Models;

namespace Devoir.Controllers
{
    
    public class VoitureController : Controller
    {


        //liste de voitures;



        // GET: Voiture
        
        public ActionResult Liste()
        {
                return View(ListeVoiture.CarList);
            
        }


        //Ajout voiture
        
        public ActionResult Ajouter(Voiture v)
        {
            if (ModelState.IsValid) {
                ListeVoiture.CarList.Add(v);
                return RedirectToAction("Ajouter", "Voiture");
            }

            return View();

        }

        //Modifier voiture 
        
        public ActionResult Modifier(Voiture voiture1)
        {

            foreach (Voiture voiture in ListeVoiture.CarList)
            {
                if (voiture.Id == voiture1.Id)
                {
                    if (ModelState.IsValid) { 
                    voiture.Matricule = voiture1.Matricule;
                    voiture.Marque = voiture1.Marque;
                    voiture.Prix = voiture1.Prix;
                        return RedirectToAction("Liste", "Voiture");
                    }
                }

            }
            return View();
        }

        //Supprimer voiture
        public ActionResult Supprimer(Voiture V)
        { 
               
            ListeVoiture.CarList.Remove(V);
            return View();
        }





    }
}