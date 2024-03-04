namespace StockMarketApi.Models
{
    public class PortofolioUserStock
    {
        public string? AppUserId { get; set; }
        public int StockId { get; set; }
        public AppUser? AppUser { get; set; }
        public Stock? Stock { get; set; }
    }
}
