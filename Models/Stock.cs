using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace FinShark.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public string CompanyName { get; set; } = string.Empty;
        public string Symbol { get; set; } = string.Empty;
        public string Exchange { get; set; } = string.Empty;
        public string Industry { get; set; } = string.Empty;
        public string Sector { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Currency { get; set; } = string.Empty;
        public string CurrencySymbol { get; set; } = string.Empty;
        
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Dividend{ get; set; }

        public long MarketCap { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>();

    }
}