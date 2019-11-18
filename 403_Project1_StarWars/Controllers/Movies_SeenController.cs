﻿using _403_Project1_StarWars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _403_Project1_StarWars.Controllers
{
    public class Movies_SeenController : Controller
    {
        //this will be the list of seen movies by the user
        public static List<SeenMovies> lstMovies = new List<SeenMovies>();

        // GET: Movies_Seen
        public ActionResult DisplayMovies()
        {
            return View(lstMovies);
        }

        [HttpGet] //this is the add movie get method
        public ActionResult AddMovie()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddMovie(SeenMovies myMovies)
        {
            myMovies.MovieID = lstMovies.Count() + 1;
            if (ModelState.IsValid)
            {
                lstMovies.Add(myMovies);
                return RedirectToAction("DisplayMovies");
            }
            else
            {
                return View(myMovies);
            }
        }

        //add get and post EditMovie methods
    }
}