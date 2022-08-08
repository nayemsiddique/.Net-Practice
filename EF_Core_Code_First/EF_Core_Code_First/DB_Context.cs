using EF_Core_Code_First.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_Code_First
{
    public class DB_Context:DbContext
    {
        public DB_Context(DbContextOptions<DB_Context>options):base(options)
        {
        }

        public  DbSet<Org> Orgs { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Gender> Genders { get; set; }

        public DbSet<UserType> UserTypes { get; set; }
    }
}
