using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraSuaMello._1.DAL.Models;

namespace TraSuaMello._1.DAL.IRepositories
{
    public interface IHoaDonRepository
    {
        public List<HoaDon> GetHoaDons();
        public bool GetHoaDonById(int id);
        public bool Add(HoaDon hd);
        public bool Delete(string ma);
        public bool Update(HoaDon hd);
    }
}
