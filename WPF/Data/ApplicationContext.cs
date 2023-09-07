using Amaterasu.Data.DatabaseEntities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Amaterasu.Data;


public class ApplicationContext : DbContext
{
    readonly string ConnectionString = "Host=localhost;Port=5432;Database=AmaterasuDb;Username=postgres;Password=54321";
    public DbSet<Word> Words { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(ConnectionString);
    }
}

    

