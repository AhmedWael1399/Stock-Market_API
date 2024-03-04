using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StockMarketApi.Extensions;
using StockMarketApi.Interfaces;
using StockMarketApi.Models;

namespace StockMarketApi.Controllers
{
    [Route("api/portofolio")]
    [ApiController]
    public class PortofolioController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IStockRepository _stockRepository;
        private readonly IPortofolioRepository _portofolioRepository;
        public PortofolioController(UserManager<AppUser> userManager, IStockRepository stockRepository, IPortofolioRepository portofolioRepository)
        {
            _userManager = userManager;
            _stockRepository = stockRepository;
            _portofolioRepository = portofolioRepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetUserPortofolio()
        {
            var username = User.GetUsername();
            var appUser = await _userManager.FindByNameAsync(username);
            var userPortofolio = await _portofolioRepository.GetUserPortofolio(appUser);

            return Ok(userPortofolio);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddPortofolio(string symbol)
        {
            var username = User.GetUsername();
            var appUser = await _userManager.FindByNameAsync(username);
            var stock = await _stockRepository.GetBySymbol(symbol);

            if (stock == null) return BadRequest("Stock Not Found");

            var userPortofolio = await _portofolioRepository.GetUserPortofolio(appUser);

            if (userPortofolio.Any(e => e.Symbol.ToLower() == symbol.ToLower())) return BadRequest("Cannot add same stock to portofolio");

            var portofolioModel = new PortofolioUserStock
            {
                StockId = stock.Id,
                AppUserId = appUser.Id,
            };

            await _portofolioRepository.CreatePortofolio(portofolioModel);

            if (portofolioModel == null) return StatusCode(500, "Could not create");
            else return Created();
        }

        [HttpDelete]
        [Authorize]
        public async Task<IActionResult> DeletePortofolio(string symbol)
        {
            var username = User.GetUsername();
            var appUser = await _userManager.FindByNameAsync(username);
            var userPortofolio = await _portofolioRepository.GetUserPortofolio(appUser);

            var filteredStock = userPortofolio.Where(s => s.Symbol.ToLower() == symbol.ToLower()).ToList();

            if (filteredStock.Count() == 1)
            {
                await _portofolioRepository.DeletePortofolio(appUser, symbol);
            }
            else return BadRequest("Stock is not in your portofolio");

            return Ok();
        }
    }
}
