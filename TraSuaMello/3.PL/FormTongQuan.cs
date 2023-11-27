
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TraSuaMello._3.PL;

namespace QuanLyTraSuaGocha
{
    //Thêm một dòng comment
    public partial class FormTongQuan : Form
    {
        //Class chức năng add Đơn
        public static class Don
        {
            public static Panel panel;
            private static int x_Loc = 40, y_Loc = 20, id_Don = 0;
            private static List<Panel> lst_pnDon = new List<Panel>();
            private static Panel createDon()
            {
                //Tạo button Don
                Button bt = new Button();
                bt.Size = new Size(150, 150);
                //Tạo panel Đơn
                Panel pn = new Panel();
                pn.AutoSize = true;
                pn.BackColor = Color.Gainsboro;
                pn.Size = bt.Size;
                pn.BackColor = Color.Transparent;

                //Tạo text đơn
                Label lbDon = new Label();
                lbDon.Text = "Đơn " + (id_Don+1);
                lbDon.Location = new Point(60, 60);
                lbDon.BackColor = Color.Gainsboro;
                lbDon.AutoSize = true;

                //Tạo check box cho đơn
                CheckBox chbx = new CheckBox();
                chbx.Text = "";
                chbx.BackColor = Color.Gainsboro;
                chbx.Location = new Point(17, 17);
                chbx.AutoSize = true;
                chbx.Name = "chbxDon";
                
                //Thêm button vào panel
                pn.Controls.Add(bt);
                pn.Controls.Add(chbx);
                pn.Controls.Add(lbDon);
                chbx.BringToFront();
                lbDon.BringToFront();

                return pn;

            }
            public static void LoadDon()
            {
                x_Loc = 40; y_Loc = 20; id_Don = 0;
                
                foreach(var don in lst_pnDon)
                {
                   
                    panel.Controls.Add(don);
                    don.Location = new Point(x_Loc, y_Loc);
                    id_Don++;
                    x_Loc += 160;
                    if(id_Don % 4 == 0 && id_Don != 0)
                    {
                        x_Loc = 40;
                        y_Loc += 160;
                    }
                                       
                }

            }
            public static void AddDonToPn()
            {
                panel.AutoScrollPosition = new Point(0, 0);
                Panel pnDon = createDon();
                panel.Controls.Add(pnDon);
                pnDon.Location = new Point(x_Loc, y_Loc);
                x_Loc += 160;
                id_Don++;
                lst_pnDon.Add(pnDon);
                if (id_Don % 4 == 0 && id_Don != 0)
                {
                    x_Loc = 40;
                    y_Loc += 160;
                }
                panel.AutoScrollPosition = new Point(0, panel.Size.Height);
            }
            public static void HoanThanhDon()
            {
                
                List<Panel> removeList = new List<Panel>();
                foreach (Panel pnDon in panel.Controls)
                {
                    CheckBox chbx = (pnDon.Controls.Find("chbxDon", false).FirstOrDefault() as CheckBox);
                    if (chbx.Checked)
                        removeList.Add(pnDon);
                }
                foreach(Panel pnDon in removeList)
                {
                    panel.Controls.Remove(pnDon);
                    lst_pnDon.Remove(pnDon);
                }

                LoadDon();

            }
        }
        Size iconSize = new Size(30, 30);
        Size DanhSachSize = new Size(464, 153);
        Point BillIconLocation = new Point(13, 17);
        Point DanhSachLocation = new Point(163, 73);
        Point SoKhachTheoBanLocation = new Point(355, 31);


        //Hàm cập nhật số đơn đang phục vụ
        public void CapNhatSoDonDangPhucVu()
        {
            lbSoDonDangPhucVu.Text = pnHop.Controls.Count.ToString();
        }

        //Hàm cập nhật số khách hàng
        public void CapNhatSoKhachHang()
        {

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            Don.panel = pnHop;
            Don.AddDonToPn();
        }
        private void btXong_Click(object sender, EventArgs e)
        {
            Don.panel = pnHop;
            Don.HoanThanhDon();
        }




        public FormTongQuan()
        {
            InitializeComponent();

        }





        private void FormTongQuan_Load(object sender, EventArgs e)
        {
            CapNhatSoDonDangPhucVu();
            CapNhatSoKhachHang();
        }



        private void btXoa_Click(object sender, EventArgs e)
        {

        }

        private void lbHeading_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pnHop_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
