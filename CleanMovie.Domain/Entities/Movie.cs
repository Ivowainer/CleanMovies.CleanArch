namespace CleanMovie.Domain.Entities
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; } = string.Empty;
        public decimal RentalCost { get; set; }
        public int RentalDuration { get; set; }

        // Many to Many Relationship
        public List<MovieRental> MovieRentals { get; set; }
    }
}