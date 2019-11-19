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
            ViewBag.Movies = Movies_SeenController.lstMovies; //this will bring the entered movies over in a dropdown
            return View();
        }

        [HttpPost] //this is the add rating post method which checks if the info is valid before adding
        public ActionResult AddRating(ActorRating myRating)
        {
            
            if (ModelState.IsValid)
            {
                lstRatings.Add(myRating);
                return RedirectToAction("DisplayRatings");
            }
            else
            {
                return View(myRating);
            }
        }

        //these are the get and post edit methods for the Actor Ratings
        [HttpGet] 
        public ActionResult EditRating(string initials)
        {
            ActorRating oRating = lstRatings.Find(x => x.ActorCode == initials);

            return View(oRating);
        }

        [HttpPost]
        public ActionResult EditRating(ActorRating myModel) 
        {
            var obj = lstRatings.FirstOrDefault(x => x.ActorCode == myModel.ActorCode);
            if (obj != null)
            {
                obj.FirstName = myModel.FirstName;
                obj.LastName = myModel.LastName;
                obj.MovieTitle = myModel.MovieTitle;
                obj.Rating = myModel.Rating;
            }

            return View("DisplayRatings", lstRatings);
        }
        
    }
}