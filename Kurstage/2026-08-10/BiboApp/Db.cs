using Microsoft.EntityFrameworkCore;

public class Db : DbContext
{
    public Db(DbContextOptions<Db> options) : base(options)
    {
    }

    public DbSet<Buch> Bücher { get; set; }

    public DbSet<Autor> Autoren { get; set; }

    public DbSet<Exemplar> Exemplare { get; set; }
}
