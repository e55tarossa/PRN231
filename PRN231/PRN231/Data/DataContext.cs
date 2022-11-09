using Microsoft.EntityFrameworkCore;
using PRN231.Models;

namespace PRN231.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Prediction> Predictions { get; set; }        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
