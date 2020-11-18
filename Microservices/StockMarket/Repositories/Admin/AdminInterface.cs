using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket.Models;

namespace StockMarket.Repositories.Admin
{
    public interface AdminInterface
    {
        public void add(UserEntity u);
        public bool check(UserEntity u1);
        public List<UserEntity> GetAll();
    }
}
