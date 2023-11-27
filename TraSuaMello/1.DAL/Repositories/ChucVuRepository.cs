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
    public class ChucVuRepository : IChucVuRepository
    {
        ShopDbContext _dbContext;
        public ChucVuRepository()
        {
            _dbContext = new ShopDbContext();
        }
        public bool Add(ChucVu cv)
        {
            _dbContext.Add(cv);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(string ma)
        {
            _dbContext.Remove(ma);
            _dbContext.SaveChanges();
            return true;
        }

        public bool GetChucVuById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ChucVu> GetChucVus()
        {
           return _dbContext.chucVus.ToList();
        }

        public bool Update(ChucVu cv)
        {
            _dbContext.Update(cv);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
