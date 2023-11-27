using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraSuaMello._1.DAL.Models;
using TraSuaMello._2.BUS.ViewModels;

namespace TraSuaMello._2.BUS.IServices
{
    public interface IHoaDonService
    {
        public string Add(HoaDon kh);
        public string Delete(string ma);
        public string Update(HoaDon kh);
        public List<HoaDonView> GetAll();
        public HoaDon GetHoaDonByName(string name);
    }
}
