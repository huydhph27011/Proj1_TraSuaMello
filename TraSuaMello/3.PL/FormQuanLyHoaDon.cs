using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TraSuaMello._2.BUS.IServices;
using TraSuaMello._2.BUS.Services;

namespace TraSuaMello._3.PL
{
    public partial class FormQuanLyHoaDon : Form
    {
        IHoaDonService _hd;
        public FormQuanLyHoaDon()
        {
            InitializeComponent();
            _hd = new HoaDonService();
            LoadData();
        }
        void LoadData()
        {
            int stt = 1;
            dgrid_HoaDon.ColumnCount = 8;
            dgrid_HoaDon.Columns[0].Name = "STT";
            dgrid_HoaDon.Columns[1].Name = "Mã hóa đơn";
            dgrid_HoaDon.Columns[2].Name = "Ngày lập";
            dgrid_HoaDon.Columns[3].Name = "Tổng tiền";
            dgrid_HoaDon.Columns[4].Name = "Mã Voucher";
            dgrid_HoaDon.Columns[5].Name = "Tên nhân viên";
            dgrid_HoaDon.Columns[6].Name = "Hình thức thanh toán";
            dgrid_HoaDon.Columns[7].Name = "Số bàn";
            dgrid_HoaDon.Rows.Clear();
            foreach (var x in _hd.GetAll())
            {
                dgrid_HoaDon.Rows.Add(stt++, x.MaHoaDon, x.NgayLap, x.ThanhTien, x.MaVoucher, x.TenNV, x.HinhThuThanhToan == 1 ? "Chuyển khoản" : "Tiền mặt",x.SoBan);
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

        }

        private void btn_HDCT_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dgrid_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
