using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gymkhana.Models;

namespace Gymkhana.Controllers
{
    public class GymController : Controller
    {
        public static ibm_portalEntities db = new ibm_portalEntities();
        // GET: Gym
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }

        public ActionResult contact()
        {
            GymContact gym = new GymContact();
            return View(gym);
        }

        [HttpPost]
        public ActionResult contact(FormCollection collection)
        {
            try
            {
                GymkhanaTable gym = new GymkhanaTable();
                if (ModelState.IsValid)
                {
                    gym.Name = Request.Form["Name"];
                    
                    gym.email = Request.Form["email"];
                    gym.subject = Request.Form["subject"];
                    gym.message = Request.Form["message"];
                   


                    db.GymkhanaTables.Add(gym);
                    db.SaveChanges();
                    ModelState.Clear();
                    ViewBag.Message = "Registration successful!";
                    return View();
                }

                else
                {
                    return View();
                }
            }

            catch
            {
                return View();
            }

        }

    }
}
    

