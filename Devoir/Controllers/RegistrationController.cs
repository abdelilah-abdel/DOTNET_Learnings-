using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Devoir.Models;

namespace Devoir.Controllers
{

    public class RegistrationController : Controller
    {
        
        //Création d'une liste d'utilisateurs
        static List<User> usersList = new List<User>();
        // Création de l'admin à la liste
        User Admin = new User() { name = "Admin", username = "Admin", password = "Admin123" };
       
       
        
        // GET: Registration
        public ActionResult Registration(User user1)
        {
            

            if (ModelState.IsValid)
            {
                user1.name = Request.Form["name"];

                user1.username = Request.Form["username"];
                TempData["username"] = user1.username;

                user1.password = Request.Form["password"];
                TempData["password"] = user1.password;
                return RedirectToAction("Login", "Registration");
            }
            return View();
        }

        //Login
        public ActionResult Login(User user1)
        {

            //Ajouter l'admin a la liste 
            usersList.Add(Admin);

            if (ModelState.IsValidField("username") && ModelState.IsValidField("password"))
            {
                String username = Request.Form["username"];
                String password = Request.Form["password"];


                if (username == (string)TempData["username"] && password == (string)TempData["password"])
                {
                    TempData["Message"] = "Connected";
                    return RedirectToAction("Ajouter", "Voiture");
                }
                else if (username == "Admin" && password == "Admin123")
                    return RedirectToAction("Ajouter", "Voiture");

                else
                {
                    TempData["Message"] = "Not connected";
                    return RedirectToAction("Login", "Registration");

                }
            }

            return View();
        }
        public ActionResult Acceuil()
        {



            return View();

        }












    }
}