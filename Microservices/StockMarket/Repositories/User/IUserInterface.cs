using StockMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.Repositories.User
{
    public class IUserInterface : UserInterface
    {
        private StockMarketContext db;
        public IUserInterface()
        {
            db = new StockMarketContext();
        }
        public void add(UserEntity u)
        {
            db.UserEntity.Add(u);
            db.SaveChanges();
        }

        public bool check(UserEntity u)
        {
            UserEntity cUser = db.UserEntity.FirstOrDefault(i => i.Username == u.Username && i.Password == u.Password && i.UserType == u.UserType);

            if (cUser == null)

                return false;

            return true;
        }

        public List<UserEntity> GetAll()
        {
            //return db.UserEntity.ToList();
            return db.UserEntity.Where(x => x.UserType == "User").ToList();

        }
    }
}
