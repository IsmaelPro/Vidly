using System;
using System.Linq;
using System.Web.Http;
using WebApplication2.Dtos;
using WebApplication2.Models;

namespace Vidly.Controllers.Api
{
    public class RentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }

        public IQueryable<Rental> GetRentals()
        {
            return _context.Rentals;
        }

        [HttpPost]
        public IHttpActionResult CreateNewRentals(RentalDto newRental)
        {
            var customer = _context.Customers.Single(
                c => c.Id == newRental.CustomerId);

            var movies = _context.Movies.Where(
                m => newRental.MovieIds.Contains(m.Id)).ToList();

            
            foreach (var movie in movies)
            {
                if (movie.NumberInStock == 0)
                    return BadRequest("Movie is not available.");

                movie.NumberInStock--;

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();

            return Ok();
        }
    }
}