using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraSuaMello._1.DAL.Context;
using TraSuaMello._1.DAL.IRepositories;
using TraSuaMello._1.DAL.Models;

namespace TraSuaMello._1.DAL.Repositories
{
    public class TraSuaRepository : ITraSuaRepository
    {
        ShopDbContext _dbContext;
        public bool Add(TraSua ts)
        {
            _dbContext.Add(ts);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(string ma)
        {
            _dbContext.Remove(ma);
            _dbContext.SaveChanges();
            return true;
        }

        public bool GetTraSuaById(int id)
        {
            throw new NotImplementedException();
        }

        public List<TraSua> GetTraSuas()
        {
            return _dbContext.traSuas.ToList();
        }

        public bool Update(TraSua ts)
        {
            _dbContext.Update(ts);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
