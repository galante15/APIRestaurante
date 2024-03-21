using APINinos.Model;
using Microsoft.EntityFrameworkCore;

namespace APINinos.Infraestrutura
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Pratos> Pratos { get; set; }
        public DbSet<Pedidos> Pedidos { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       => optionsBuilder.UseNpgsql(
               "Server=localhost;" +
               "Port=5432;Database=postgres;" +
               "User Id=ricardo;" +
               "Password=1234");
    }
}
