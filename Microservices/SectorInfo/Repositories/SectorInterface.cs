using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SectorInfo.Models;

namespace SectorInfo.Repositories
{
    public interface SectorInterface
    {
        public List<CompanyEntity> getsector(String sectorname);
        public decimal price(String name);
        public decimal FromToPrice(String sectorname, DateTime d1, DateTime d2, TimeSpan t1, TimeSpan t2);
        public List<decimal> FromToPriceList(String sectorname, DateTime d1, DateTime d2, TimeSpan t1, TimeSpan t2);

    }
}
