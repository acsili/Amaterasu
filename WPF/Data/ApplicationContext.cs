using Amaterasu.Data.DatabaseEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;

namespace Amaterasu.Data;


public class ApplicationContext : DbContext
{
    public DbSet<Password> Passwords { get; set; } = null!;
    public DbSet<Word> Words { get; set; } = null!;
    
    public ApplicationContext() => Database.EnsureCreated();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string ConnectionString = File.ReadAllText("ConnectionString.txt");
        optionsBuilder.UseNpgsql(ConnectionString);
    }
}

    

