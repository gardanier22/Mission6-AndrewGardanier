using AndrewGardanier_Mission_6.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection.Metadata.Ecma335;

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
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

            return View("MovieForm", new MovieInfo());
        }

        [HttpPost]
        public IActionResult MovieForm(MovieInfo response)
        {
            if (ModelState.IsValid)
            {
                _context.MovieInfo.Add(response); //Add record to the database
                _context.SaveChanges();


                return View("ThankYou", response);
            }
            else
            {
                ViewBag.Categories = _context.Categories
                    .OrderBy(x => x.CategoryName)
                    .ToList();

                return View(response);
            }
        }
        public IActionResult WaitList()
        {
            // Linq
            var movieInformation = _context.MovieInfo.Include(mi => mi.Category).ToList();

            return View(movieInformation);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.MovieInfo
                .Single(x => x.MovieID == id);

            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

            return View("MovieForm", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(MovieInfo updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();

            return RedirectToAction("WaitList");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.MovieInfo
                .Single(x => x.MovieID == id);

            return View(recordToDelete);


        }

        [HttpPost]
        public IActionResult Delete(MovieInfo record)
        {
            _context.MovieInfo.Remove(record);
            _context.SaveChanges();

            return RedirectToAction("WaitList");

        }

    }
}
