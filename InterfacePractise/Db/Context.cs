using Microsoft.EntityFrameworkCore;
using InterfacePractise.Models;

namespace InterfacePractise.Db
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options):base(options) { }
        public DbSet<Company> Companies { get; set; }
    }
}
