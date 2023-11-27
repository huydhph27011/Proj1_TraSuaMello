using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraSuaMello._1.DAL.IRepositories;
using TraSuaMello._1.DAL.Models;
using TraSuaMello._1.DAL.Repositories;
using TraSuaMello._2.BUS.IServices;
using TraSuaMello._2.BUS.ViewModels;

namespace TraSuaMello._2.BUS.Services
{
    public class HoaDonService : IHoaDonService
    {
        IHoaDonRepository _ihd;
        IVoucherRepository _voucherRepository;
        INhanVienRepository _nhanVienRepository;
        IBanRepository _banRepository;
        public HoaDonService()
        {
            _ihd = new HoaDonRepository();
            _voucherRepository = new VoucherRepository();
            _nhanVienRepository = new NhanVienRepository();
            _banRepository = new BanRepository();
        }
        public string Add(HoaDon kh)
        {
            throw new NotImplementedException();
        }

        public string Delete(string ma)
        {
            throw new NotImplementedException();
        }

        public List<HoaDonView> GetAll()
        {
            var list = (from a in _ihd.GetHoaDons()
                   join b in _nhanVienRepository.GetNhanViens() on a.MaNhanVien equals b.MaNhanVien
                   join c in _voucherRepository.GetVouchers() on a.MaVoucher equals c.MaGiamGia
                   join d in _banRepository.GetBans() on a.MaBan equals d.SoBan
                   select new HoaDonView
                   {
                       SoBan = d.SoBan,
                       MaHoaDon = a.MaHoaDon,
                       HinhThuThanhToan = a.HinhThuThanhToan,
                       MaVoucher = c.MaGiamGia,
                       NgayLap = a.NgayLap,
                       TenNV = b.Name,
                       ThanhTien = a.ThanhTien,
                   }).ToList();
            return list;
        }

        public HoaDon GetHoaDonByName(string name)
        {
            throw new NotImplementedException();
        }

        public string Update(HoaDon kh)
        {
            throw new NotImplementedException();
        }
    }
}
