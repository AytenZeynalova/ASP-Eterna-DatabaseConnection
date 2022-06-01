using ASP_EternaDatabase.DAL;
using ASP_EternaDatabase.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_EternaDatabase.Controllers
{
    public class PortfolioController : Controller
    {

        private readonly AppDbContext _context;

        public PortfolioController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            PortfolioViewModel portfolioViewModel = new PortfolioViewModel {
                Portfolios = _context.Portfolios.Include(x=>x.Category).ToList(),
                Categories =_context.Categories.ToList(),
                PortfolioImages = _context.PortfolioImages.ToList()
            };
            return View(portfolioViewModel);
        }
    }
}
