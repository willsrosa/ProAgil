using Microsoft.EntityFrameworkCore;
using ProjetoAgil.WebAPI.Model;

namespace ProjetoAgil.WebAPI.Data
{
    public class DataContext : DbContext
    {
      public  DataContext(DbContextOptions<DataContext> options) : base (options){} 
      public DbSet<Evento> Eventos { get; set; }

    }

}