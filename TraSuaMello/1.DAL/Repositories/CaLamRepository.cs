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
    public class CaLamRepository : ICaLamRepository
    {
        ShopDbContext _dbContext;
        public CaLamRepository()
        {
            _dbContext = new ShopDbContext();
        }
        public bool Add(CaLam ban)
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

        public bool GetCaLamById(int id)
        {
            throw new NotImplementedException();
        }

        public List<CaLam> GetCaLams()
        {
            return _dbContext.caLams.ToList();
        }

        public bool Update(CaLam ban)
        {
            _dbContext.Update(ban);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
