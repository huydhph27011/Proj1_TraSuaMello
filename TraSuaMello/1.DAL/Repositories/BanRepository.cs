using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraSuaMello._1.DAL.Context;
using TraSuaMello._1.DAL.Models;

namespace TraSuaMello._1.DAL.IRepositories
{
    public class BanRepository : IBanRepository
    {
        private ShopDbContext _dbContext;
        public BanRepository()
        {
            _dbContext = new ShopDbContext();
        }
        public bool Add(Ban ban)
        {
            _dbContext.Add(ban);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(string ma)
        {
            _dbContext.Remove(ma);
            _dbContext.SaveChanges();
            return true;
        }

        public bool GetBanById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Ban> GetBans()
        {
            return _dbContext.bans.ToList();
        }

        public bool Update(Ban ban)
        {
            _dbContext.Update(ban);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
