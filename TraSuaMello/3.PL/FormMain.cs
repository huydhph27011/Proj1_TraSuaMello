using QuanLyTraSuaGocha;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TraSuaMello._3.PL
{
    public partial class FormMain : Form
    {
        private Form? currentFormChild;
        public FormMain()
        {
            InitializeComponent();
            //Thêm sự kiện đổi màu cho mỗi menuItem khi click vào
            foreach(ToolStripMenuItem item in menuStripSideBar.Items)
            {
                item.Click += sidebarMenuItem_changeColor;
            }
            
        }

        //Hàm đổi màu menuItem sang đỏ khi click vào
        private void sidebarMenuItem_changeColor(object? sender, EventArgs e)
        {
            foreach(ToolStripMenuItem menuItem in menuStripSideBar.Items)
            {
                menuItem.BackColor = Color.Black;
            }
            (sender as ToolStripMenuItem).BackColor = Color.Red;
        }

        //Hàm mở form tương ứng khi click vào mỗi mục side bar
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnBody.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();

        }
        
        private void TongQuanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTongQuan formTongQuan = new FormTongQuan();
            OpenChildForm(formTongQuan);
            
        }
        private void DatMonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoiMon formGoiMon = new FormGoiMon();
            OpenChildForm(formGoiMon);
            
        }

        private void NguyenLieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLyNguyenLieu formNL = new FormQuanLyNguyenLieu();
            OpenChildForm(formNL);
            
        }

        private void QuanLyThongTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLyThongTinKhachHang form = new FormQuanLyThongTinKhachHang();
            OpenChildForm(form);

        }

        private void DangKyThanhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDangKyMembership formDangKyMembership = new FormDangKyMembership();
            OpenChildForm(formDangKyMembership);
        
        }

        private void QuanLyMembershipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLyMembership formQLMembership = new FormQuanLyMembership();
            OpenChildForm(formQLMembership);
         
        }

        private void QuanLyCouponToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLyCoupon formQuanLyCoupon = new FormQuanLyCoupon();
            OpenChildForm(formQuanLyCoupon);
            
        }

        private void QuanLyTaiChinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLyTaiChinh formQuanLyTaiChinh = new FormQuanLyTaiChinh();
            OpenChildForm(formQuanLyTaiChinh);
     
        }


        private void frmHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLyHoaDon formQLHD = new FormQuanLyHoaDon();
            OpenChildForm(formQLHD);
         
        }

        private void QuanLyThongTinCaNhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLyThongTinCaNhan formQuanLyThongTinCaNhan = new FormQuanLyThongTinCaNhan();
            OpenChildForm(formQuanLyThongTinCaNhan);
          
            
        }

        private void TuyenDungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTuyenDung formTuyenDung = new FormTuyenDung();
            OpenChildForm(formTuyenDung);
        }

        private void PhanCongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPhanCong formPhanCong = new FormPhanCong();
            OpenChildForm(formPhanCong);
        }

        private void ChamCongToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormChamCong formChamCong = new FormChamCong();
            OpenChildForm(formChamCong);
        }

        private void TaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLyTaiKhoan formQuanLyTaiKhoan = new FormQuanLyTaiKhoan();
            OpenChildForm(formQuanLyTaiKhoan);
        }

        

        
    }
}
