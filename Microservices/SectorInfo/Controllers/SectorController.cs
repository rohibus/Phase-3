using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SectorInfo.Models;
using SectorInfo.Repositories;

namespace SectorInfo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SectorController : ControllerBase
    {
        public ISectorInterface _repo = new ISectorInterface();
        [HttpGet]
        [Route("getall/{sectorname}")]
        public IActionResult GetAll(String sectorname)
        {
            List<CompanyEntity> l = _repo.getsector(sectorname);
            return Ok(l);
        }

        [HttpGet]
        [Route("sectorprice/{sectorname}")]
        public IActionResult GetSector(String sectorname)
        {
            decimal l = _repo.price(sectorname);
            return Ok(l);
        }

        [HttpGet]
        [Route("sectorpriceToFrom/{sectorname}/{d1}/{d2}/{t1}/{t2}")]
        public IActionResult FromTo(string sectorname, DateTime d1, DateTime d2, TimeSpan t1, TimeSpan t2)
        {
            decimal l = _repo.FromToPrice(sectorname,d1,d2,t1,t2);
            return Ok(l);
        }

        [HttpGet]
        [Route("sectorpriceToFromList/{sectorname}/{d1}/{d2}/{t1}/{t2}")]
        public IActionResult FromToList(string sectorname, DateTime d1, DateTime d2, TimeSpan t1, TimeSpan t2)
        {
            List<decimal> l = _repo.FromToPriceList(sectorname, d1, d2, t1, t2);
            return Ok(l);
        }
    }
}
