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
            ViewBag.Movie = Movies_SeenController.lstMovies; //this will bring in the movies as a dynamic dropdown
            return View();
        }

        [HttpPost] //this is the add review post method which checks if the info is valid before adding
        public ActionResult AddReview(MovieReview myReviews)
        {
            myReviews.ReviewID = lstReviews.Count() + 1; //autogenerator for count for the ID
            if (ModelState.IsValid)
            {
                lstReviews.Add(myReviews);
                return RedirectToAction("DisplayReviews");
            }
            else
            {
                return View(myReviews);
            }
        }

        //the get and post EditReview methods
        [HttpGet]
        public ActionResult EditReview(int iReview)
        {
            MovieReview oReview = lstReviews.Find(x => x.ReviewID == iReview);

            return View(oReview);
        }

        [HttpPost]
        public ActionResult EditReview(MovieReview myModel) 
        {
            var obj = lstReviews.FirstOrDefault(x => x.ReviewID == myModel.ReviewID);
            if (obj != null)
            {
                obj.Review = myModel.Review;
                obj.MovieTitle = myModel.MovieTitle;
            }

            return View("DisplayReviews", lstReviews);
        }
    }
}