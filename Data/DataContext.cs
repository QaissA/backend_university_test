using BackendTest.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendTest.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<User> Users { get; set; }
    }
}
