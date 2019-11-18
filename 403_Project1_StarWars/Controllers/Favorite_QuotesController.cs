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
            return View();
        }

        //[HttpPost] 
        //add post AddQuote method


        //add get and post EditQuote methods
    }
}