using DBClassLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace DBClassLibrary
{
    public class TrackerContext : DbContext
    {
        //public DbSet<User> UsersTable { get; set; }
        //public DbSet<Analyst> AnalystTable { get; set; }

        public DbSet<Header> HeaderTable { get; set; }

        public DbSet<SymbolConfig> SymbolConfigTable { get; set; }

        public DbSet<Quotes> QuotesTable { get; set; }

        //public DbSet<Personalization> PersonalizationTable { get; set; }

        //public DbSet<Roles> RolesTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-7LJ7HTPU\SQLEXPRESS;Initial Catalog=StockTrackerDb;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Uri uri = new Uri("https://yh-finance.p.rapidapi.com/market/v2/get-quotes?region=US&symbols=AMD%2CIBM%2CAAPL");

            //modelBuilder.Entity<Header>().HasData(new Header
            //{
            //    Key = "ed8bbc525fmshe7f2ca46e69c3ffp179016jsne9ad147cd3e0",
            //    Host = "yh-finance.p.rapidapi.com",
            //    URL = uri
            //});


        }
    }
}