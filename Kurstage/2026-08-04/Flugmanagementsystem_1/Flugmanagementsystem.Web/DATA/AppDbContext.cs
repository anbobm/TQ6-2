using Flugmanagementsystem.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Flugmanagementsystem.Web.Data;

/// <summary>
/// Repräsentiert den Datenbankkontext der GermanyFly-Anwendung
/// und ermöglicht den Zugriff auf die Tabellen über Entity Framework Core.
/// </summary>
public class AppDbContext : DbContext
{
    /// <summary>
    /// Ruft die in der Datenbank gespeicherten Flüge ab.
    /// </summary>
    public DbSet<Flug> Fluege => Set<Flug>();

    /// <summary>
    /// Ruft die in der Datenbank gespeicherten Kunden ab.
    /// </summary>
    public DbSet<Kunde> Kunden => Set<Kunde>();

    /// <summary>
    /// Ruft die in der Datenbank gespeicherten Buchungen ab.
    /// </summary>
    public DbSet<Buchung> Buchungen => Set<Buchung>();

    /// <summary>
    /// Ruft die in der Datenbank gespeicherten Gepäckstücke ab.
    /// </summary>
    public DbSet<Gepaeckstueck> Gepaeckstuecke => Set<Gepaeckstueck>();

    /// <summary>
    /// Initialisiert eine neue Instanz des <see cref="AppDbContext"/>.
    /// </summary>
    /// <param name="options">
    /// Die Konfigurationsoptionen für den Datenbankkontext.
    /// </param>
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
}