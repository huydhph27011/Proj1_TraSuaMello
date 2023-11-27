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
    public class LichLVRepository : ILichLVRepository
    {
        ShopDbContext _dbContext;
        public LichLVRepository()
        {
            _dbContext = new ShopDbContext();
        }
        public bool Add(LichLamViec llv)
        {
            _dbContext.Add(llv);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(string ma)
        {
            _dbContext.Remove(ma);
            _dbContext.SaveChanges();
            return true;
        }

        public List<LichLamViec> GetLichLVs()
        {
            return _dbContext.lichLamViecs.ToList();
        }

        public bool GetLLVById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(LichLamViec llv)
        {
            _dbContext.Update(llv);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
