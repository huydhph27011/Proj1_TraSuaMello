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
    public class KhachHangRepository : IKhachHangRepository
    {
        ShopDbContext _dbContext;
        public KhachHangRepository()
        {
            _dbContext = new ShopDbContext();
        }
        public bool Add(KhachHang kh)
        {
            _dbContext.Add(kh);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(string ma)
        {
            _dbContext.Remove(ma);
            _dbContext.SaveChanges();
            return true;
        }

        public bool GetKhachHangById(int id)
        {
            throw new NotImplementedException();
        }

        public KhachHang GetKhachHangByName(string name)
        {
            return _dbContext.khachHangs.FirstOrDefault(c => c.Ten == name);
        }

        public List<KhachHang> GetKhachHangs()
        {
            return _dbContext.khachHangs.ToList();
        }

        public bool Update(KhachHang kh)
        {
            _dbContext.Update(kh);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
