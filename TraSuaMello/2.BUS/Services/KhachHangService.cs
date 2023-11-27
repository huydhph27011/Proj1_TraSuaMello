using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraSuaMello._1.DAL.IRepositories;
using TraSuaMello._1.DAL.Models;
using TraSuaMello._1.DAL.Repositories;
using TraSuaMello._2.BUS.IServices;

namespace TraSuaMello._2.BUS.Services
{
    public class KhachHangService : IKhachHangService
    {
        IKhachHangRepository _khRepo;
        public KhachHangService()
        {
            _khRepo = new KhachHangRepository();
        }
        public string Add(KhachHang kh)
        {
            try
            {
                if (kh == null)
                {
                    return "Thêm thất bại";
                }
                else
                {
                    var mats = "KH0" + _khRepo.GetKhachHangs().Count;
                    var cus = new KhachHang(){
                        MaKhachHang = mats,
                        DiaChi = kh.DiaChi,
                        SDT = kh.SDT,
                        MaMember = kh.MaMember,
                        Ten = kh.Ten,
                    };
                    if (_khRepo.Add(cus))
                    {
                        return "Thêm thành công";
                    }
                    return "Thêm thất bại";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string Delete(string ma)
        {
            try
            {
                var temp = _khRepo.GetKhachHangs().FirstOrDefault(c => c.MaKhachHang == ma);
                if (true)
                {
                    _khRepo.Delete(temp.MaKhachHang);
                    return "Xóa thành công";
                } return "Xóa thất bại";
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<KhachHang> GetAll()
        {
            return _khRepo.GetKhachHangs();
        }

        public KhachHang GetKhachHangByName(string name)
        {
            return _khRepo.GetKhachHangByName(name);
        }

        public string Update(KhachHang kh)
        {
            try
            {
                var temp = _khRepo.GetKhachHangs().FirstOrDefault(c => c.MaKhachHang == kh.MaKhachHang);
                temp.SDT = kh.SDT;
                temp.Ten = kh.Ten;
                temp.DiaChi = kh.DiaChi;
                if (true)
                {
                    _khRepo.Update(temp);
                    return "Sửa thành công";
                }
                return "Sửa thất bại";

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
