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
    public class HoaDonRepository : IHoaDonRepository
    {
        ShopDbContext _dbContext;
        public HoaDonRepository()
        {
            _dbContext = new ShopDbContext();
        }
        public bool Add(HoaDon hd)
        {
            _dbContext.Add(hd);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(string ma)
        {
            _dbContext.Remove(ma);
            _dbContext.SaveChanges();
            return true;
        }

        public bool GetHoaDonById(int id)
        {
            throw new NotImplementedException();
        }

        public List<HoaDon> GetHoaDons()
        {
            return _dbContext.HoaDons.ToList();
        }

        public bool Update(HoaDon hd)
        {
            _dbContext.Update(hd);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
