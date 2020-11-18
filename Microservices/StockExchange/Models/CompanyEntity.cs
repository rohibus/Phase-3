using System;
using System.Collections.Generic;

namespace StockExchange.Models
{
    public partial class CompanyEntity
    {
        public int CompanyId { get; set; }
        public decimal Turnover { get; set; }
        public string Ceo { get; set; }
        public string BoardOfDirect { get; set; }
        public decimal ListedStockExchange { get; set; }
        public string Sector { get; set; }
        public string BriefWriteUp { get; set; }
        public string CompanyName { get; set; }
        public decimal Companystockcode { get; set; }

        public virtual StockExchangeEntity ListedStockExchangeNavigation { get; set; }
    }
}
