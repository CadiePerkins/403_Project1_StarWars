using _403_Project1_StarWars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _403_Project1_StarWars.Controllers
{
    public class Movie_ReviewsController : Controller
    {
        //this is the list of movie reviews
        public static List<MovieReview> lstReviews = new List<MovieReview>();

        // GET: Movie_Reviews
        public ActionResult DisplayReviews()
        {
            return View(lstReviews);
        }

        [HttpGet] //this is the add review get method
        public ActionResult AddReview()
        {
            return View();
        }

        //[HttpPost]
        //add post AddReview method

        //add get and post EditReview methods
    }
}