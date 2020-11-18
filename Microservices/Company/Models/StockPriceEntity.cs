using System;
using System.Collections.Generic;

#nullable disable

namespace Company.Models
{
    public partial class StockPriceEntity
    {
        public decimal CompanyStockCode { get; set; }
        public string StockExchange { get; set; }
        public decimal CurrentPrice { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
    }
}
