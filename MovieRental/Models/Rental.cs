using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRental.Models
{
    public class Rental
    {
        

        public int Id { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime? ReturnDate { get; set; }

        public Customer Customer { get; set; }

        public Movie Movie { get; set; }


    }
}