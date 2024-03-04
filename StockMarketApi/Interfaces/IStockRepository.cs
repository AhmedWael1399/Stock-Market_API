using StockMarketApi.Dtos.Stock;
using StockMarketApi.Helpers;
using StockMarketApi.Models;

namespace StockMarketApi.Interfaces
{
    public interface IStockRepository
    {
        Task<List<Stock>> GetStocks(QueryObject query);
        Task<Stock?> GetStockById(int id);
        Task<Stock?> GetBySymbol(string symbol);
        Task<Stock> CreateStock(Stock stockModel);
        Task<Stock?> UpdateStock(int id, UpdateStockRequestDto stockDto);
        Task<Stock?> DeleteStock(int id);
        Task<bool> StockExists(int id);
    }
}
