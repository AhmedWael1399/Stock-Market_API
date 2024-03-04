using Microsoft.AspNetCore.Identity;

namespace StockMarketApi.Models
{
    public class AppUser : IdentityUser
    {
        public List<PortofolioUserStock>? Portofolios { get; set; } = new List<PortofolioUserStock>();
    }
}
