﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TraSuaMello._1.DAL.Context;

#nullable disable

namespace TraSuaMello.Migrations
{
    [DbContext(typeof(ShopDbContext))]
    [Migration("20231127042354_Reload")]
    partial class Reload
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TraSuaMello._1.DAL.Models.Ban", b =>
                {
                    b.Property<int>("MaBan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaBan"), 1L, 1);

                    b.Property<int>("SoBan")
                        .HasColumnType("int");

                    b.HasKey("MaBan");

                    b.ToTable("bans");
                });

            modelBuilder.Entity("TraSuaMello._1.DAL.Models.CaLam", b =>
                {
                    b.Property<string>("MaCa")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("BatDau")
                        .HasColumnType("bit");

                    b.Property<bool>("KetThuc")
                        .HasColumnType("bit");

                    b.Property<DateTime>("NgayLVNgay")
                        .HasColumnType("datetime2");

                    b.HasKey("MaCa");

                    b.HasIndex("NgayLVNgay");

                    b.ToTable("caLams");
                });

            modelBuilder.Entity("TraSuaMello._1.DAL.Models.ChucVu", b =>
                {
                    b.Property<string>("MaChucVu")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TenChucVu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaChucVu");

                    b.ToTable("chucVus");
                });

            modelBuilder.Entity("TraSuaMello._1.DAL.Models.HoaDon", b =>
                {
                    b.Property<string>("MaHoaDon")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("BanMaBan")
                        .HasColumnType("int");

                    b.Property<int>("HinhThuThanhToan")
                        .HasColumnType("int");

                    b.Property<string>("KhachHangMaKhachHang")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("MaBan")
                        .HasColumnType("int");

                    b.Property<string>("MaKhachHang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaNhanVien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaVoucher")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayLap")
                        .HasColumnType("datetime2");

                    b.Property<string>("NhanVienMaNhanVien")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("ThanhTien")
                        .HasColumnType("float");

                    b.Property<string>("VoucherMaGiamGia")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("MaHoaDon");

                    b.HasIndex("BanMaBan");

                    b.HasIndex("KhachHangMaKhachHang");

                    b.HasIndex("NhanVienMaNhanVien");

                    b.HasIndex("VoucherMaGiamGia");

                    b.ToTable("HoaDons");
                });

            modelBuilder.Entity("TraSuaMello._1.DAL.Models.HoaDonChiTiet", b =>
                {
                    b.Property<string>("MaHDCT")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("HoaDonMaHoaDon")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MaHoaDon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaTopping")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaTraSua")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaHDCT");

                    b.HasIndex("HoaDonMaHoaDon");

                    b.ToTable("hoaDonChiTiets");
                });

            modelBuilder.Entity("TraSuaMello._1.DAL.Models.KhachHang", b =>
                {
                    b.Property<string>("MaKhachHang")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaMember")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MembershipMaMember")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaKhachHang");

                    b.HasIndex("MembershipMaMember");

                    b.ToTable("khachHangs");
                });

            modelBuilder.Entity("TraSuaMello._1.DAL.Models.LichLamViec", b =>
                {
                    b.Property<string>("MaLich")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MaNhanVien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Ngay")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayLVNgay")
                        .HasColumnType("datetime2");

                    b.Property<string>("NhanVienMaNhanVien")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("MaLich");

                    b.HasIndex("NgayLVNgay");

                    b.HasIndex("NhanVienMaNhanVien");

                    b.ToTable("lichLamViecs");
                });

            modelBuilder.Entity("TraSuaMello._1.DAL.Models.Membership", b =>
                {
                    b.Property<string>("MaMember")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("NgayDangKi")
                        .HasColumnType("datetime2");

                    b.HasKey("MaMember");

                    b.ToTable("memberships");
                });

            modelBuilder.Entity("TraSuaMello._1.DAL.Models.NgayLV", b =>
                {
                    b.Property<DateTime>("Ngay")
                        .HasColumnType("datetime2");

                    b.Property<string>("MaCa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Ngay");

                    b.ToTable("NgayLVs");
                });

            modelBuilder.Entity("TraSuaMello._1.DAL.Models.NhanVien", b =>
                {
                    b.Property<string>("MaNhanVien")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ChucVuMaChucVu")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaChucVu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TienLuong")
                        .HasColumnType("float");

                    b.HasKey("MaNhanVien");

                    b.HasIndex("ChucVuMaChucVu");

                    b.ToTable("nhanViens");
                });

            modelBuilder.Entity("TraSuaMello._1.DAL.Models.TaiKhoan", b =>
                {
                    b.Property<string>("MaTaiKhoan")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MaNhanVien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NhanVienMaNhanVien")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TenTaiKhoan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaTaiKhoan");

                    b.HasIndex("NhanVienMaNhanVien");

                    b.ToTable("taiKhoans");
                });

            modelBuilder.Entity("TraSuaMello._1.DAL.Models.Topping", b =>
                {
                    b.Property<string>("MaTopping")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Gia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoaDonChiTietsMaHDCT")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaTopping");

                    b.HasIndex("HoaDonChiTietsMaHDCT");

                    b.ToTable("toppings");
                });

            modelBuilder.Entity("TraSuaMello._1.DAL.Models.TraSua", b =>
                {
                    b.Property<string>("MaTraSua")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Gia")
                        .HasColumnType("float");

                    b.Property<string>("HoaDonChiTietsMaHDCT")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Loai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.HasKey("MaTraSua");

                    b.HasIndex("HoaDonChiTietsMaHDCT");

                    b.ToTable("traSuas");
                });

            modelBuilder.Entity("TraSuaMello._1.DAL.Models.Voucher", b =>
                {
                    b.Property<string>("MaGiamGia")
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("GiaTri")
                        .HasColumnType("real");

                    b.Property<string>("MaNhanVien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NhanVienMaNhanVien")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<DateTime>("ThoiHan")
                        .HasColumnType("datetime2");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("MaGiamGia");

                    b.HasIndex("NhanVienMaNhanVien");

                    b.ToTable("vouchers");
                });

            modelBuilder.Entity("TraSuaMello._1.DAL.Models.CaLam", b =>
                {
                    b.HasOne("TraSuaMello._1.DAL.Models.NgayLV", "NgayLV")
                        .WithMany("CaLams")
                        .HasForeignKey("NgayLVNgay")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NgayLV");
                });

            modelBuilder.Entity("TraSuaMello._1.DAL.Models.HoaDon", b =>
                {
                    b.HasOne("TraSuaMello._1.DAL.Models.Ban", "Ban")
                        .WithMany("HoaDons")
                        .HasForeignKey("BanMaBan")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TraSuaMello._1.DAL.Models.KhachHang", "KhachHang")
                        .WithMany("HoaDons")
                        .HasForeignKey("KhachHangMaKhachHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TraSuaMello._1.DAL.Models.NhanVien", "NhanVien")
                        .WithMany("HoaDons")
                        .HasForeignKey("NhanVienMaNhanVien")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TraSuaMello._1.DAL.Models.Voucher", "Voucher")
                        .WithMany()
                        .HasForeignKey("VoucherMaGiamGia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ban");

                    b.Navigation("KhachHang");

                    b.Navigation("NhanVien");

                    b.Navigation("Voucher");
                });

            modelBuilder.Entity("TraSuaMello._1.DAL.Models.HoaDonChiTiet", b =>
                {
                    b.HasOne("TraSuaMello._1.DAL.Models.HoaDon", "HoaDon")
                        .WithMany()
                        .HasForeignKey("HoaDonMaHoaDon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HoaDon");
                });

            modelBuilder.Entity("TraSuaMello._1.DAL.Models.KhachHang", b =>
                {
                    b.HasOne("TraSuaMello._1.DAL.Models.Membership", "Membership")
                        .WithMany("KhachHangs")
                        .HasForeignKey("MembershipMaMember")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Membership");
                });

            modelBuilder.Entity("TraSuaMello._1.DAL.Models.LichLamViec", b =>
                {
                    b.HasOne("TraSuaMello._1.DAL.Models.NgayLV", "NgayLV")
                        .WithMany()
                        .HasForeignKey("NgayLVNgay")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TraSuaMello._1.DAL.Models.NhanVien", "NhanVien")
                        .WithMany("LichLamViecs")
                        .HasForeignKey("NhanVienMaNhanVien")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NgayLV");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("TraSuaMello._1.DAL.Models.NhanVien", b =>
                {
                    b.HasOne("TraSuaMello._1.DAL.Models.ChucVu", "ChucVu")
                        .WithMany("NhanViens")
                        .HasForeignKey("ChucVuMaChucVu");

                    b.Navigation("ChucVu");
                });

            modelBuilder.Entity("TraSuaMello._1.DAL.Models.TaiKhoan", b =>
                {
                    b.HasOne("TraSuaMello._1.DAL.Models.NhanVien", "NhanVien")
                        .WithMany("TaiKhoans")
                        .HasForeignKey("NhanVienMaNhanVien");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("TraSuaMello._1.DAL.Models.Topping", b =>
                {
                    b.HasOne("TraSuaMello._1.DAL.Models.HoaDonChiTiet", "HoaDonChiTiets")
                        .WithMany("Toppings")
                        .HasForeignKey("HoaDonChiTietsMaHDCT");

                    b.Navigation("HoaDonChiTiets");
                });

            modelBuilder.Entity("TraSuaMello._1.DAL.Models.TraSua", b =>
                {
                    b.HasOne("TraSuaMello._1.DAL.Models.HoaDonChiTiet", "HoaDonChiTiets")
                        .WithMany("TraSuas")
                        .HasForeignKey("HoaDonChiTietsMaHDCT");

                    b.Navigation("HoaDonChiTiets");
                });

            modelBuilder.Entity("TraSuaMello._1.DAL.Models.Voucher", b =>
                {
                    b.HasOne("TraSuaMello._1.DAL.Models.NhanVien", "NhanVien")
                        .WithMany("Vouchers")
                        .HasForeignKey("NhanVienMaNhanVien");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("TraSuaMello._1.DAL.Models.Ban", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("TraSuaMello._1.DAL.Models.ChucVu", b =>
                {
                    b.Navigation("NhanViens");
                });

            modelBuilder.Entity("TraSuaMello._1.DAL.Models.HoaDonChiTiet", b =>
                {
                    b.Navigation("Toppings");

                    b.Navigation("TraSuas");
                });

            modelBuilder.Entity("TraSuaMello._1.DAL.Models.KhachHang", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("TraSuaMello._1.DAL.Models.Membership", b =>
                {
                    b.Navigation("KhachHangs");
                });

            modelBuilder.Entity("TraSuaMello._1.DAL.Models.NgayLV", b =>
                {
                    b.Navigation("CaLams");
                });

            modelBuilder.Entity("TraSuaMello._1.DAL.Models.NhanVien", b =>
                {
                    b.Navigation("HoaDons");

                    b.Navigation("LichLamViecs");

                    b.Navigation("TaiKhoans");

                    b.Navigation("Vouchers");
                });
#pragma warning restore 612, 618
        }
    }
}
