using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Company.Models;

namespace Company.Repositories
{
    public interface CompanyInterface
    {
        public IpodetailsEntity getCompanyIPO(decimal StockCode);
        public CompanyEntity getCompanydetails(decimal Stockcode);
        public decimal FromToPrice(decimal Stockcode, DateTime d1, DateTime d2, TimeSpan t1, TimeSpan t2);

        public void addCompany(CompanyEntity c);
        public void updateCompany(CompanyEntity c);

        public void addIPO(IpodetailsEntity c);
        public List<IpodetailsEntity> getipo();

        public List<decimal> FromToPriceList(decimal Stockcode, DateTime d1, DateTime d2, TimeSpan t1, TimeSpan t2);
    }
}
