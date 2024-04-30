using Domain.Common;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL;

public class AppDbContext : DbContext
{
    public DbSet<Actor> Actors { get; set; }
    public DbSet<Director> Directors { get; set; }
    public DbSet<Genre> Genres { get; set; } 
    public DbSet<Location> Locations { get; set; } 
    public DbSet<Movie> Movies { get; set; }
    public DbSet<MovieSession> MovieSessions { get; set; }
    public DbSet<Seat> Seats { get; set; }
    public DbSet<TemporaryDiscount> TemporaryDiscounts { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<User> Users { get; set; }
    
    public AppDbContext()
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
        optionsBuilder.UseSqlServer(Constants.DevDbString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Seat>().HasAlternateKey(nameof(Seat.LocationId), nameof(Seat.SeatNumber));
        modelBuilder.Entity<MovieSession>().Property(ms => ms.Price).HasPrecision(18, 2);
        modelBuilder.Entity<Ticket>().Property(ms => ms.TotalPrice).HasPrecision(18, 2);
    }
}