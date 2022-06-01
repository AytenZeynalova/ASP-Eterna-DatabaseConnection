using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_EternaDatabase.Models
{
    public class Portfolio
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Client { get; set; }
        public DateTime Date { get; set; }
        public string Desc { get; set; }
        public string MainImage { get; set; }
        public Category Category { get; set; }
    }
}
