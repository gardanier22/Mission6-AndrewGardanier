using AndrewGardanier_Mission_6.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace AndrewGardanier_Mission_6.Controllers
{
    public class HomeController : Controller
    {


        private EnterMovieContext _context;

        public HomeController(EnterMovieContext temp) // Constructor
        {
            _context = temp;

        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GTKJoel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieForm()
        {
            return View("MovieForm");
        }

        [HttpPost]
        public IActionResult MovieForm(MovieInfo response)
        {
            _context.MovieInfo.Add(response); //Add record to the database
            _context.SaveChanges();


            return View("ThankYou", response);
        }
    }
}
