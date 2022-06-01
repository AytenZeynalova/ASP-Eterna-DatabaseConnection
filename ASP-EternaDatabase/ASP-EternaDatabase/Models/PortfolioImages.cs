using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_EternaDatabase.Models
{
    public class PortfolioImages
    {
        public int Id { get; set; }
        public int PortfolioId { get; set; }
        public string Image { get; set; }

        public Portfolio Portfolio { get; set; }


    }
}
