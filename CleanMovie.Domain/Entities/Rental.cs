using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanMovie.Domain.Entities
{
    public class Rental
    {
        public int RentalId { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime RentalExpiry { get; set; }
        public decimal TotalCost { get; set; }

        // One to Many Relationship
        public ICollection<Member> Members { get; set; }

        // Many to Many Relationship
        public List<MovieRental> MovieRentals { get; set; }
    }
}