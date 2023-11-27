using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraSuaMello._1.DAL.Models;

namespace TraSuaMello._1.DAL.IRepositories
{
    public interface IVoucherRepository
    {
        public List<Voucher> GetVouchers();
        public bool GetVoucherById(int id);
        public bool Add(Voucher vc);
        public bool Delete(string ma);
        public bool Update(Voucher vc);
    }
}
