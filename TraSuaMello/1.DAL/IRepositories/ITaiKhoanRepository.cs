using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraSuaMello._1.DAL.Models;

namespace TraSuaMello._1.DAL.IRepositories
{
    public interface ITaiKhoanRepository
    {
        public List<TaiKhoan> GetTaiKhoans();
        public bool GetTaiKhoanById(int id);
        public bool Add(TaiKhoan ban);
        public bool Delete(string ma);
        public bool Update(TaiKhoan ban);
    }
}
