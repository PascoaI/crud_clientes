using Microsoft.EntityFrameworkCore;
using ClienteCRUD.Models;

namespace ClienteCRUD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
