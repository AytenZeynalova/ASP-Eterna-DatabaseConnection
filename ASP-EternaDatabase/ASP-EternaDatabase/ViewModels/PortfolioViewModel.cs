using ASP_EternaDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_EternaDatabase.ViewModels
{
    public class PortfolioViewModel
    {
        public List<Portfolio> Portfolios;
        public List<Category> Categories;
        public List<PortfolioImages> PortfolioImages;
    }
}
