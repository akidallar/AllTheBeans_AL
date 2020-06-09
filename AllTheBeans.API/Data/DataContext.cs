using AllTheBeans.API.Models;
using Microsoft.EntityFrameworkCore;

namespace AllTheBeans.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<Value> Values { get; set; }
    }
}