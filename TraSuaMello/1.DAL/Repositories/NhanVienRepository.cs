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
    public class NhanVienRepository : INhanVienRepository
    {
        ShopDbContext _dbContext;
        public NhanVienRepository()
        {
            _dbContext = new ShopDbContext();
        }
        public bool Add(NhanVien nv)
        {
            _dbContext.Add(nv);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(string ma)
        {
            _dbContext.Remove(ma);
            _dbContext.SaveChanges();
            return true;
        }

        public bool GetBanById(string ma)
        {
            throw new NotImplementedException();
        }

        public List<NhanVien> GetNhanViens()
        {
            return _dbContext.nhanViens.ToList();
        }

        public bool Update(NhanVien nv)
        {
            _dbContext.Update(nv);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
