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
    public class VoucherRepository : IVoucherRepository
    {
        ShopDbContext _dbContext;
        public VoucherRepository()
        {
            _dbContext = new ShopDbContext();
        }
        public bool Add(Voucher vc)
        {
            _dbContext.Add(vc);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(string ma)
        {
            _dbContext.Remove(ma);
            _dbContext.SaveChanges();
            return true;
        }

        public bool GetVoucherById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Voucher> GetVouchers()
        {
            return _dbContext.vouchers.ToList();
        }

        public bool Update(Voucher vc)
        {
            _dbContext.Update(vc);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
