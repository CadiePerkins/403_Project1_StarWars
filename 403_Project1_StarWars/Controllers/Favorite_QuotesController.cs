using _403_Project1_StarWars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _403_Project1_StarWars.Controllers
{
    public class Favorite_QuotesController : Controller
    {
        //this is the list of quotes
        public static List<FavQuote> lstQuotes = new List<FavQuote>();

        // GET: Favorite_Quotes
        public ActionResult DisplayQuotes()
        {
            return View(lstQuotes);
        }

        [HttpGet] //this is the add quote get method
        public ActionResult AddQuote()
        {
            ViewBag.Movies = Movies_SeenController.lstMovies; //this will bring the entered movies over in a dropdown
            return View();
        }

        [HttpPost] //this is the add quote post method which checks if the info is valid before adding
        public ActionResult AddQuote(FavQuote myQuote)
        {
            myQuote.QuoteID = lstQuotes.Count() + 1;
            if (ModelState.IsValid)
            {
                lstQuotes.Add(myQuote);
                return RedirectToAction("DisplayQuotes");
            }
            else
            {
                return View(myQuote);
            }
        }


        //add get and post EditQuote methods
    }
}