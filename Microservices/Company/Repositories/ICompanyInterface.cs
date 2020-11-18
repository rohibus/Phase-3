using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Company.Models;

namespace Company.Repositories
{
    public class ICompanyInterface : CompanyInterface
    {
        public StockMarketContext db = new StockMarketContext();

        public void addCompany(CompanyEntity c)
        {
            db.CompanyEntities.Add(c);
            db.SaveChanges();
        }

        public void addIPO(IpodetailsEntity c)
        {
            db.IpodetailsEntities.Add(c);
            db.SaveChanges();
        }

        public decimal FromToPrice(decimal Stockcode, DateTime d1, DateTime d2, TimeSpan t1, TimeSpan t2)
        {
            //decimal d = 0;
            //List<StockPriceEntity> l = db.StockPriceEntities.Where(i => i.CompanyStockCode == Stockcode).ToList();
            //for (int i = 0; i < l.Count(); i++)
            //    d = d + db.StockPriceEntities.Where(j => j.CompanyStockCode == Stockcode && j.Date >= d1 && j.Date <= d2 && j.Time >= t1 && j.Time <= t2).Select(e => e.CurrentPrice).FirstOrDefault();
            //return d / l.Count;

            List<decimal> d;
            d = db.StockPriceEntities.Where(j => j.CompanyStockCode == Stockcode && j.Date >= d1 && j.Date <= d2 && j.Time >= t1 && j.Time <= t2).Select(e => e.CurrentPrice).ToList();
            decimal c = d.Average();
            return c;
        }

        public List<decimal> FromToPriceList(decimal Stockcode, DateTime d1, DateTime d2, TimeSpan t1, TimeSpan t2)
        {

            List<decimal> d;
            d = db.StockPriceEntities.Where(j => j.CompanyStockCode == Stockcode && j.Date >= d1 && j.Date <= d2 && j.Time >= t1 && j.Time <= t2).Select(e => e.CurrentPrice).ToList();
            
            return d;
        }

        public CompanyEntity getCompanydetails(decimal Stockcode)
        {
           
                CompanyEntity i = db.CompanyEntities.FirstOrDefault(i => i.Companystockcode == Stockcode);
                return i;
        }

        public IpodetailsEntity getCompanyIPO(decimal StockCode)
        {
            IpodetailsEntity i = db.IpodetailsEntities.Find(StockCode);
            return i;
        }

        public List<IpodetailsEntity> getipo()
        {
            return db.IpodetailsEntities.ToList();
        }

        public void updateCompany(CompanyEntity c)
        {
            db.CompanyEntities.Update(c);
            db.SaveChanges();
        }
    }
}
