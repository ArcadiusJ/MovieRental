using MovieRental.Models;
using MovieRental.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace MovieRental.Controllers
{
    public class RentalsController : Controller
    {

        private ApplicationDbContext _context;

        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: MovieRental
        public ActionResult Index()
        {
            var model = new RentalFormViewModel();

            model.Customers = _context.Customers.ToList();

            model.Movies = _context.Movies.ToList();


            return View("RentalForm", model);
        }

        [HttpPost]
        public ActionResult Save(Rental rental)
        {


            

            _context.SaveChanges();

            return RedirectToAction("Index", "Rentals");
        }
    }
}