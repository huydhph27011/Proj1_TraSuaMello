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
    public class NgayLVRepository : INgayLVRepository
    {
        ShopDbContext _dbContext;
        public NgayLVRepository()
        {
            _dbContext = new ShopDbContext();
        }
        public bool Add(NgayLV ban)
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

        public bool GetNgayLVById(int id)
        {
            throw new NotImplementedException();
        }

        public List<NgayLV> GetNgayLVs()
        {
            return _dbContext.NgayLVs.ToList();
        }

        public bool Update(NgayLV ban)
        {
            _dbContext.Update(ban);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
