using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket.Models;

namespace StockMarket.Repositories.User
{
   public  interface UserInterface
    {
        public void add(UserEntity u);
        public bool check(UserEntity u1);
        public List<UserEntity> GetAll();
    }
}
