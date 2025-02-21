using Microsoft.EntityFrameworkCore;

namespace TechLibrary.Api.Infraestructure;

public class TechLibraryDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=C:\\Users\\diogo\\OneDrive\\Área de Trabalho\\TechLibraryDb.db");
    }
}

