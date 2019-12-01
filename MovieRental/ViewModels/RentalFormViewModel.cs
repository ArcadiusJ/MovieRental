using MovieRental.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRental.ViewModels
{
    public class RentalFormViewModel
    {

        public Rental Rental { get; set; }

        [Required]
        [Display(Name = "Customer")]
        public Customer Customer { get; set; }
        public List<Customer> Customers { get; set; }

        [Required]
        [Display(Name = "Movie")]
        public Movie Movie { get; set; }
        public List<Movie> Movies { get; set; }

        [Required]
        [Display(Name = "Return Date")]
        public DateTime ReturnDate { get; set; }

  
        public RentalFormViewModel()
        {
            ReturnDate = DateTime.Today.AddDays(7);
            
        }

        public RentalFormViewModel(Rental rental)
        {
            
        }
    }
}