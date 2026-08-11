using Microsoft.EntityFrameworkCore;

public class Db : DbContext
{
    public DbSet<Buch> Bücher { get; set; }

    public DbSet<Autor> Autoren { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=bibo.db");
}