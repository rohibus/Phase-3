using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockExchange.Models;

namespace StockExchange.Repositories
{
    public interface StockExchangeCompanyInterface
    {
        public List<CompanyEntity> getall();
        public List<CompanyEntity> getCompanylist(String a);
    }
}
