using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StockMarketApi.Models;

namespace StockMarketApi.Configuration
{
    public class StockMarketDbContext : IdentityDbContext<AppUser>
    {
        public StockMarketDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<PortofolioUserStock> Portofolios { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedData(modelBuilder);
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<PortofolioUserStock>()
                    .HasKey(p => new { p.AppUserId, p.StockId });
            modelBuilder.Entity<PortofolioUserStock>()
                    .HasOne(A => A.AppUser)
                    .WithMany(p => p.Portofolios)
                    .HasForeignKey(A => A.AppUserId);
            modelBuilder.Entity<PortofolioUserStock>()
                    .HasOne(s => s.Stock)
                    .WithMany(p => p.Portofolios)
                    .HasForeignKey(s => s.StockId);
        }


        private void SeedData(ModelBuilder modelBuilder)
        {
            var stocks = new List<Stock>
            {
                new () { Id = 1, Symbol = "NFLX", CompanyName = "Netflix Inc.", Purchase = 600.00m, LastDiv = 0.00m, Industry = "Entertainment", MarketCap = 250000000000 },
                new () { Id = 2, Symbol = "JNJ", CompanyName = "Johnson & Johnson", Purchase = 150.00m, LastDiv = 4.04m, Industry = "Pharmaceutical", MarketCap = 430000000000 },
                new () { Id = 3, Symbol = "PG", CompanyName = "Procter & Gamble Co.", Purchase = 140.00m, LastDiv = 3.20m, Industry = "Consumer Goods", MarketCap = 340000000000 },
                new () { Id = 4, Symbol = "BRK-A", CompanyName = "Berkshire Hathaway Inc.", Purchase = 420000.00m, LastDiv = 0.00m, Industry = "Conglomerate", MarketCap = 660000000000 },
                new () { Id = 5, Symbol = "NVDA", CompanyName = "NVIDIA Corporation", Purchase = 700.00m, LastDiv = 0.64m, Industry = "Technology", MarketCap = 900000000000 },
                new () { Id = 6, Symbol = "BAC", CompanyName = "Bank of America Corp.", Purchase = 40.00m, LastDiv = 2.24m, Industry = "Finance", MarketCap = 380000000000 }
            };
            modelBuilder.Entity<Stock>().HasData(stocks);

            var comments = new List<Comment>
            {
                new () { Id = 1, Title = "Netflix's New Original Series 1", Content = "Netflix announces the release of its highly anticipated original series.", CreatedOn = DateTime.Now.AddDays(-7), StockId = 1 },
                new () { Id = 2, Title = "Netflix's New Original Series 2", Content = "Excited to watch this series!", CreatedOn = DateTime.Now.AddDays(-6), StockId = 1 },
                new () { Id = 3, Title = "Netflix's New Original Series 3", Content = "I've been waiting for this. Can't wait!", CreatedOn = DateTime.Now.AddDays(-5), StockId = 1 },
                new () { Id = 4, Title = "Netflix's New Original Series 4", Content = "Netflix always delivers quality content.", CreatedOn = DateTime.Now.AddDays(-4), StockId = 1 },
                new () { Id = 5, Title = "Johnson & Johnson's Breakthrough Drug", Content = "Johnson & Johnson unveils a breakthrough drug for treating a rare disease.", CreatedOn = DateTime.Now.AddDays(-10), StockId = 2 },
                new () { Id = 6, Title = "Procter & Gamble's Sustainability Initiative", Content = "Procter & Gamble launches a new sustainability initiative to reduce its environmental footprint.", CreatedOn = DateTime.Now.AddDays(-5), StockId = 3 },
                new () { Id = 7, Title = "Procter & Gamble's Sustainability Initiative 2", Content = "Great initiative by Procter & Gamble!", CreatedOn = DateTime.Now.AddDays(-3), StockId = 3 },
                new () { Id = 8, Title = "Procter & Gamble's Sustainability Initiative 3", Content = "It's about time companies focus on sustainability.", CreatedOn = DateTime.Now.AddDays(-2), StockId = 3 },
                new () { Id = 9, Title = "Berkshire Hathaway's Latest Acquisition", Content = "Berkshire Hathaway acquires a major stake in a leading technology company.", CreatedOn = DateTime.Now.AddDays(-12), StockId = 4 },
                new () { Id = 10, Title = "NVIDIA's New Graphics Card", Content = "NVIDIA unveils its latest graphics card with groundbreaking performance.", CreatedOn = DateTime.Now.AddDays(-3), StockId = 5 },
                new () { Id = 11, Title = "Bank of America's Quarterly Earnings Report", Content = "Bank of America releases its quarterly earnings report, exceeding market expectations.", CreatedOn = DateTime.Now.AddDays(-8), StockId = 6 }
            };
            modelBuilder.Entity<Comment>().HasData(comments);

            List<IdentityRole> roles = new List<IdentityRole>()
            {
                new () { Name = "Admin", NormalizedName = "ADMIN" },
                new () { Name = "User", NormalizedName = "USER" }

            };
            modelBuilder.Entity<IdentityRole>().HasData(roles);
        }
        
    }
}
