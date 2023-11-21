using CRUD_Intro.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Intro.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Service> Services  { get; set; }
    }





}
