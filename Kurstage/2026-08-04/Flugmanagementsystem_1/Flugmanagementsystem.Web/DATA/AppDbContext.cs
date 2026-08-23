using Flugmanagementsystem.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Flugmanagementsystem.Web.Data;

public class AppDbContext : DbContext
{
    public DbSet<Flug> Fluege => Set<Flug>();

    public DbSet<Kunde> Kunden => Set<Kunde>();

    public DbSet<Buchung> Buchungen => Set<Buchung>();

    public DbSet<Gepaeckstueck> Gepaeckstuecke => Set<Gepaeckstueck>();

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
}