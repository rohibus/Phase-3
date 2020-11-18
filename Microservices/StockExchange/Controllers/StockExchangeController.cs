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
    public class StockExchangeController : ControllerBase
    {
        public IStockExchangeInterface _repo = new IStockExchangeInterface();

        [HttpGet]
        [Route("getall")]
        public IActionResult GetAll()
        {
            List<StockExchangeEntity> l = _repo.getall();
            return Ok(l);
        }

        [HttpPost]
        [Route("add")]
        public IActionResult AddSE(StockExchangeEntity s)
        {
            _repo.addStockExchange(s);
            return Ok("Stock Exchange added");
        }


    }
}
