using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraSuaMello._1.DAL.Models;

namespace TraSuaMello._1.DAL.IRepositories
{
    public interface IHDCTRepository
    {
        public List<HoaDonChiTiet> GetHDCTs();
        public bool GetHDCTById(int id);
        public bool Add(HoaDonChiTiet hdct);
        public bool Delete(string ma);
        public bool Update(HoaDonChiTiet hdct);
    }
}
