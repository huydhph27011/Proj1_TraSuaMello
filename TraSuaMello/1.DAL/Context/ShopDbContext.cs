using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraSuaMello._1.DAL.Models;

namespace TraSuaMello._1.DAL.Context
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext()
        {

        }

        public ShopDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=TraSuaMello;Persist Security Info=True;User ID=huydhph27011;Password=666888");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<CaLam> caLams { get; set; }
        public DbSet<ChucVu> chucVus { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<HoaDonChiTiet> hoaDonChiTiets { get; set; }
        public DbSet<KhachHang> khachHangs { get; set; }
        public DbSet<LichLamViec> lichLamViecs { get; set; }
        public DbSet<Membership> memberships { get; set; }
        public DbSet<NgayLV> NgayLVs { get; set; }
        public DbSet<NhanVien> nhanViens { get; set; }
        public DbSet<TaiKhoan> taiKhoans { get; set; }
        public DbSet<Topping> toppings { get; set; }
        public DbSet<TraSua> traSuas { get; set; }
        public DbSet<Voucher> vouchers { get; set; }
        public DbSet<Ban> bans { get; set; }


    }
}
