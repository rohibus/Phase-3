using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Company.Models;
using Company.Repositories;

namespace Company.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        public ICompanyInterface _repo = new ICompanyInterface();
        [HttpGet]
        [Route("getIPO/{Stockcode}")]
        public IActionResult getIPOdetails(decimal Stockcode)
        {
            IpodetailsEntity l = _repo.getCompanyIPO(Stockcode);
            return Ok(l);
        }

        [HttpGet]
        [Route("getCompany/{Stockcode}")]
        public IActionResult getCompany(decimal Stockcode)
        {
            CompanyEntity l = _repo.getCompanydetails(Stockcode);
            return Ok(l);
        }

        [HttpGet]
        [Route("CompanypriceToFrom/{sectorcode}/{d1}/{d2}/{t1}/{t2}")]
        public IActionResult FromTo(Decimal Sectorcode, DateTime d1, DateTime d2, TimeSpan t1, TimeSpan t2)
        {
            decimal l = _repo.FromToPrice(Sectorcode, d1, d2, t1, t2);
            return Ok(l);
        }


        [HttpGet]
        [Route("CompanypriceToFromList/{sectorcode}/{d1}/{d2}/{t1}/{t2}")]
        public IActionResult FromToList(Decimal Sectorcode, DateTime d1, DateTime d2, TimeSpan t1, TimeSpan t2)
        {
           List<decimal> l = _repo.FromToPriceList(Sectorcode, d1, d2, t1, t2);
            return Ok(l);
        }
        //[HttpPost]
        //[Route("addcompany")]
        //public IActionResult addcompany(CompanyEntity c)
        //{​​
        //    _repo.addCompany(c);
        //    return Ok("Company Added");
        //}​​
        [HttpPost]
        [Route("addcompany")]
        public IActionResult addcompany(CompanyEntity c)
        {
            _repo.addCompany(c);
            return Ok("Company Added");
        }
        [HttpPut]
        [Route("updatecompany")]
        public IActionResult updatecompany(CompanyEntity c)
        {
            _repo.updateCompany(c);
            return Ok("Company updated");
        }

        [HttpPost]
        [Route("addIPO")]
        public IActionResult addIPO(IpodetailsEntity c)
        {
            _repo.addIPO(c);
            return Ok("IPO Added");
        }


        [HttpGet]
        [Route("getipo")]
        public IActionResult getipo()
        {
            List<IpodetailsEntity> l = _repo.getipo();
            return Ok(l);
        }
    }
}
