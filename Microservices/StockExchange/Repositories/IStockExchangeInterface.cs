using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockExchange.Models;

namespace StockExchange.Repositories
{
    public class IStockExchangeInterface : StockExchangeInterface
    {
        public StockMarketContext db = new StockMarketContext();
        public void addStockExchange(StockExchangeEntity s)
        {
            db.StockExchangeEntity.Add(s);
            db.SaveChanges();
        }

        public List<StockExchangeEntity> getall()
        {
            return db.StockExchangeEntity.ToList();
        }

    }
}
