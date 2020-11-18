using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockExchange.Models;
using StockExchange.Repositories;

namespace StockExchange.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockExchangeCompanyController : ControllerBase
    {
        public IStockExchangeCompany _repo = new IStockExchangeCompany();

        [HttpGet]
        [Route("getall")]
        public IActionResult GetAll()
        {
            List<CompanyEntity> l = _repo.getall();
            return Ok(l);
        }

        [HttpGet]
        [Route("getcompanylist/{a}")]
        public IActionResult GetCompanyList(String a)
        {
            List<CompanyEntity> l = _repo.getCompanylist(a);
            return Ok(l);
        }


    }
}
