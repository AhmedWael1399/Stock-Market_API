using StockMarketApi.Models;

namespace StockMarketApi.Interfaces
{
    public interface IPortofolioRepository
    {
        Task<List<Stock>> GetUserPortofolio(AppUser user);
        Task<PortofolioUserStock> CreatePortofolio(PortofolioUserStock portofolio);
        Task<PortofolioUserStock> DeletePortofolio(AppUser appUser, string symbol);
    }
}
