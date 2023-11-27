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
    public class TaiKhoanRepository : ITaiKhoanRepository
    {
        ShopDbContext _dbContext;
        public TaiKhoanRepository()
        {
            _dbContext = new ShopDbContext();
        }
        public bool Add(TaiKhoan ban)
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

        public bool GetTaiKhoanById(int id)
        {
            throw new NotImplementedException();
        }

        public List<TaiKhoan> GetTaiKhoans()
        {
            return _dbContext.taiKhoans.ToList();
        }

        public bool Update(TaiKhoan ban)
        {
            _dbContext.Update(ban);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
