using Microsoft.EntityFrameworkCore;
using StockMarketApi.Configuration;
using StockMarketApi.Interfaces;
using StockMarketApi.Models;

namespace StockMarketApi.Repository
{
    public class PortofolioRepository : IPortofolioRepository
    {
        private readonly StockMarketDbContext _context;
        public PortofolioRepository(StockMarketDbContext context)
        {
            _context = context;
        }

        public async Task<PortofolioUserStock> CreatePortofolio(PortofolioUserStock portofolio)
        {
            await _context.Portofolios.AddAsync(portofolio);
            await _context.SaveChangesAsync();
            return portofolio;
        }

        public async Task<PortofolioUserStock> DeletePortofolio(AppUser appUser, string symbol)
        {
            var portofolioModel = await _context.Portofolios.FirstOrDefaultAsync(x => x.AppUserId == appUser.Id && x.Stock.Symbol.ToLower() == symbol.ToLower());

            if (portofolioModel == null) return null;

            _context.Portofolios.Remove(portofolioModel);
            await _context.SaveChangesAsync();
            return portofolioModel;
        }

        public async Task<List<Stock>> GetUserPortofolio(AppUser user)
        {
            return await _context.Portofolios.Where(u => u.AppUserId == user.Id)
                .Select(stock => new Stock
                {
                    Id = stock.StockId,
                    Symbol = stock.Stock.Symbol,
                    CompanyName = stock.Stock.CompanyName,
                    Purchase = stock.Stock.Purchase,
                    LastDiv = stock.Stock.LastDiv,
                    Industry = stock.Stock.Industry,
                    MarketCap = stock.Stock.MarketCap
                }).ToListAsync();
        }
    }
}
