using CleanArchitecture.Domain;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure
{
    public interface IDBContext
    {
        public DbSet<Movie>? Movies { get; set; }
        public DbSet<Rental>? Rentals { get; set; }
        public DbSet<Member>? Members { get; set; }
        public DbSet<MovieRental>? MovieRentals { get; set; }
        public DbSet<User>? Users { get; set; }
    }
}
