using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockMarket.Models;
using StockMarket.Repositories.Admin;

namespace StockMarket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private AdminInterface repo;
        public AdminController(AdminInterface _repo)
        {
            repo = _repo;
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetProducts()
        {
            List<UserEntity> list = repo.GetAll();
            return Ok(list);
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult Post(UserEntity item)
        {
            repo.add(item);
            return Ok("Record Added");
        }

        [HttpPost]
        [Route("check")]
        public IActionResult check(UserEntity user)
        {
            bool ans = repo.check(user);
            if (ans == true)
                return Ok("Admin logged in");
            return Ok("No Access");
        }

    }
}
