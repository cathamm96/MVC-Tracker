using Microsoft.EntityFrameworkCore;
using MVCmovietracker.Models;

public class Context : DbContext
{
   public Context() : base(){}
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to sqlite database
        options.UseSqlite(@"Data Source=test.db");
    }
   public DbSet<Movies>? Movie { get; set; }
   public DbSet<Watched>? Watched { get; set; }
}