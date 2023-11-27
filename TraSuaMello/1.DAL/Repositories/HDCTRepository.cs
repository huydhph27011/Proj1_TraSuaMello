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
    public class HDCTRepository : IHDCTRepository
    {
        ShopDbContext _dbContext;
        public HDCTRepository()
        {
            _dbContext = new ShopDbContext();
        }
        public bool Add(HoaDonChiTiet hdct)
        {
            _dbContext.Add(hdct);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(string ma)
        {
            _dbContext.Remove(ma);
            _dbContext.SaveChanges();
            return true;
        }

        public bool GetHDCTById(int id)
        {
            throw new NotImplementedException();
        }

        public List<HoaDonChiTiet> GetHDCTs()
        {
            return _dbContext.hoaDonChiTiets.ToList();
        }

        public bool Update(HoaDonChiTiet hdct)
        {
            _dbContext.Update(hdct);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
