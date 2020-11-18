using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockExchange.Models;

namespace StockExchange.Repositories
{
    public class IStockExchangeCompany : StockExchangeCompanyInterface
    {
        public StockMarketContext db = new StockMarketContext();
        public List<CompanyEntity> getall()
        {
            return db.CompanyEntity.ToList();
        }

        //public List<CompanyEntity> getCompanylist(decimal a)
        //{
        //    // throw new NotImplementedException();
        //    decimal b;
        //    var v = db.CompanyEntity.First(i => i.ListedStockExchange == a);
        //    CompanyEntity c = (CompanyEntity)v;
        //    b = c.ListedStockExchange;
        //    return db.CompanyEntity.Where(x => x.ListedStockExchange == b).ToList();
        //}

        public List<CompanyEntity> getCompanylist(string SEname)
        {
            //var v1=db.StockExchangeEntity.FirstOrDefault(i=>i.StockExchange==SEname);
            //StockExchangeEntity s1 = (StockExchangeEntity)v1;
            //decimal a = s1.Seid;
            //List<CompanyEntity> l= db.CompanyEntity.Where(x => x.ListedStockExchange == a).ToList();
            //return l;

            var Sid = db.StockExchangeEntity.Where(i => i.StockExchange == SEname).Select(j => j.Seid).FirstOrDefault();
            List<CompanyEntity> l = db.CompanyEntity.Where(x => x.ListedStockExchange == Sid).ToList();
            return l;
        }
    }
}
