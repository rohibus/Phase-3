using StockMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.Repositories.Admin
{
    public class IAdminInterface : AdminInterface
    {
        private StockMarketContext db;

        public IAdminInterface()
        {
            db =new StockMarketContext();
        }
        public void add(UserEntity u)
        {
            db.UserEntity.Add(u);
            db.SaveChanges();
        }

        public bool check(UserEntity u1)
        {
            UserEntity cUser = db.UserEntity.FirstOrDefault(i => i.Username == u1.Username && i.Password == u1.Password && i.UserType == u1.UserType);

            if (cUser == null)

                return false;

            return true;
        }

        public List<UserEntity> GetAll()
        {
            //return db.UserEntity.ToList();
            return db.UserEntity.Where(x => x.UserType == "Admin").ToList();
        }
    }
}
