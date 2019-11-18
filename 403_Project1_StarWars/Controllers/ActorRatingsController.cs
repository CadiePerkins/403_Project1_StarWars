using _403_Project1_StarWars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _403_Project1_StarWars.Controllers
{
    public class ActorRatingsController : Controller
    {
        //this is the list of actor ratings
        public static List<ActorRating> lstRatings = new List<ActorRating>();

        // GET: Actor_Ratings
        public ActionResult DisplayRatings()
        {
            return View(lstRatings);
        }

        [HttpGet] //this is the add rating get method
        public ActionResult AddRating()
        {
            return View();
        }

        //[HttpPost]
        //insert post addRating method


        //create get and post EditRating methods here
    }
}