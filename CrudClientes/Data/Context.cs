using CrudClientes.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudClientes.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) 
        :base(options)
        {
        
        }
        public DbSet<Cliente> Clientes { get; set; }


    }
}
