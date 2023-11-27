using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TraSuaMello.Migrations
{
    public partial class Reload : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bans",
                columns: table => new
                {
                    MaBan = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoBan = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bans", x => x.MaBan);
                });

            migrationBuilder.CreateTable(
                name: "chucVus",
                columns: table => new
                {
                    MaChucVu = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenChucVu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chucVus", x => x.MaChucVu);
                });

            migrationBuilder.CreateTable(
                name: "memberships",
                columns: table => new
                {
                    MaMember = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NgayDangKi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_memberships", x => x.MaMember);
                });

            migrationBuilder.CreateTable(
                name: "NgayLVs",
                columns: table => new
                {
                    Ngay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaCa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NgayLVs", x => x.Ngay);
                });

            migrationBuilder.CreateTable(
                name: "nhanViens",
                columns: table => new
                {
                    MaNhanVien = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TienLuong = table.Column<double>(type: "float", nullable: false),
                    MaChucVu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChucVuMaChucVu = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nhanViens", x => x.MaNhanVien);
                    table.ForeignKey(
                        name: "FK_nhanViens_chucVus_ChucVuMaChucVu",
                        column: x => x.ChucVuMaChucVu,
                        principalTable: "chucVus",
                        principalColumn: "MaChucVu");
                });

            migrationBuilder.CreateTable(
                name: "khachHangs",
                columns: table => new
                {
                    MaKhachHang = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaMember = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MembershipMaMember = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_khachHangs", x => x.MaKhachHang);
                    table.ForeignKey(
                        name: "FK_khachHangs_memberships_MembershipMaMember",
                        column: x => x.MembershipMaMember,
                        principalTable: "memberships",
                        principalColumn: "MaMember",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "caLams",
                columns: table => new
                {
                    MaCa = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BatDau = table.Column<bool>(type: "bit", nullable: false),
                    KetThuc = table.Column<bool>(type: "bit", nullable: false),
                    NgayLVNgay = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_caLams", x => x.MaCa);
                    table.ForeignKey(
                        name: "FK_caLams_NgayLVs_NgayLVNgay",
                        column: x => x.NgayLVNgay,
                        principalTable: "NgayLVs",
                        principalColumn: "Ngay",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "lichLamViecs",
                columns: table => new
                {
                    MaLich = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ngay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NhanVienMaNhanVien = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NgayLVNgay = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lichLamViecs", x => x.MaLich);
                    table.ForeignKey(
                        name: "FK_lichLamViecs_NgayLVs_NgayLVNgay",
                        column: x => x.NgayLVNgay,
                        principalTable: "NgayLVs",
                        principalColumn: "Ngay",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_lichLamViecs_nhanViens_NhanVienMaNhanVien",
                        column: x => x.NhanVienMaNhanVien,
                        principalTable: "nhanViens",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "taiKhoans",
                columns: table => new
                {
                    MaTaiKhoan = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenTaiKhoan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NhanVienMaNhanVien = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_taiKhoans", x => x.MaTaiKhoan);
                    table.ForeignKey(
                        name: "FK_taiKhoans_nhanViens_NhanVienMaNhanVien",
                        column: x => x.NhanVienMaNhanVien,
                        principalTable: "nhanViens",
                        principalColumn: "MaNhanVien");
                });

            migrationBuilder.CreateTable(
                name: "vouchers",
                columns: table => new
                {
                    MaGiamGia = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    ThoiHan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    GiaTri = table.Column<float>(type: "real", nullable: false),
                    MaNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NhanVienMaNhanVien = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vouchers", x => x.MaGiamGia);
                    table.ForeignKey(
                        name: "FK_vouchers_nhanViens_NhanVienMaNhanVien",
                        column: x => x.NhanVienMaNhanVien,
                        principalTable: "nhanViens",
                        principalColumn: "MaNhanVien");
                });

            migrationBuilder.CreateTable(
                name: "HoaDons",
                columns: table => new
                {
                    MaHoaDon = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NgayLap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThanhTien = table.Column<double>(type: "float", nullable: false),
                    MaKhachHang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaVoucher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HinhThuThanhToan = table.Column<int>(type: "int", nullable: false),
                    MaBan = table.Column<int>(type: "int", nullable: false),
                    BanMaBan = table.Column<int>(type: "int", nullable: false),
                    NhanVienMaNhanVien = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    VoucherMaGiamGia = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    KhachHangMaKhachHang = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDons", x => x.MaHoaDon);
                    table.ForeignKey(
                        name: "FK_HoaDons_bans_BanMaBan",
                        column: x => x.BanMaBan,
                        principalTable: "bans",
                        principalColumn: "MaBan",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDons_khachHangs_KhachHangMaKhachHang",
                        column: x => x.KhachHangMaKhachHang,
                        principalTable: "khachHangs",
                        principalColumn: "MaKhachHang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDons_nhanViens_NhanVienMaNhanVien",
                        column: x => x.NhanVienMaNhanVien,
                        principalTable: "nhanViens",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDons_vouchers_VoucherMaGiamGia",
                        column: x => x.VoucherMaGiamGia,
                        principalTable: "vouchers",
                        principalColumn: "MaGiamGia",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hoaDonChiTiets",
                columns: table => new
                {
                    MaHDCT = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaHoaDon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaTraSua = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaTopping = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoaDonMaHoaDon = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDonChiTiets", x => x.MaHDCT);
                    table.ForeignKey(
                        name: "FK_hoaDonChiTiets_HoaDons_HoaDonMaHoaDon",
                        column: x => x.HoaDonMaHoaDon,
                        principalTable: "HoaDons",
                        principalColumn: "MaHoaDon",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "toppings",
                columns: table => new
                {
                    MaTopping = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoaDonChiTietsMaHDCT = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_toppings", x => x.MaTopping);
                    table.ForeignKey(
                        name: "FK_toppings_hoaDonChiTiets_HoaDonChiTietsMaHDCT",
                        column: x => x.HoaDonChiTietsMaHDCT,
                        principalTable: "hoaDonChiTiets",
                        principalColumn: "MaHDCT");
                });

            migrationBuilder.CreateTable(
                name: "traSuas",
                columns: table => new
                {
                    MaTraSua = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Loai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    Gia = table.Column<double>(type: "float", nullable: false),
                    HoaDonChiTietsMaHDCT = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_traSuas", x => x.MaTraSua);
                    table.ForeignKey(
                        name: "FK_traSuas_hoaDonChiTiets_HoaDonChiTietsMaHDCT",
                        column: x => x.HoaDonChiTietsMaHDCT,
                        principalTable: "hoaDonChiTiets",
                        principalColumn: "MaHDCT");
                });

            migrationBuilder.CreateIndex(
                name: "IX_caLams_NgayLVNgay",
                table: "caLams",
                column: "NgayLVNgay");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonChiTiets_HoaDonMaHoaDon",
                table: "hoaDonChiTiets",
                column: "HoaDonMaHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_BanMaBan",
                table: "HoaDons",
                column: "BanMaBan");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_KhachHangMaKhachHang",
                table: "HoaDons",
                column: "KhachHangMaKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_NhanVienMaNhanVien",
                table: "HoaDons",
                column: "NhanVienMaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_VoucherMaGiamGia",
                table: "HoaDons",
                column: "VoucherMaGiamGia");

            migrationBuilder.CreateIndex(
                name: "IX_khachHangs_MembershipMaMember",
                table: "khachHangs",
                column: "MembershipMaMember");

            migrationBuilder.CreateIndex(
                name: "IX_lichLamViecs_NgayLVNgay",
                table: "lichLamViecs",
                column: "NgayLVNgay");

            migrationBuilder.CreateIndex(
                name: "IX_lichLamViecs_NhanVienMaNhanVien",
                table: "lichLamViecs",
                column: "NhanVienMaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_nhanViens_ChucVuMaChucVu",
                table: "nhanViens",
                column: "ChucVuMaChucVu");

            migrationBuilder.CreateIndex(
                name: "IX_taiKhoans_NhanVienMaNhanVien",
                table: "taiKhoans",
                column: "NhanVienMaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_toppings_HoaDonChiTietsMaHDCT",
                table: "toppings",
                column: "HoaDonChiTietsMaHDCT");

            migrationBuilder.CreateIndex(
                name: "IX_traSuas_HoaDonChiTietsMaHDCT",
                table: "traSuas",
                column: "HoaDonChiTietsMaHDCT");

            migrationBuilder.CreateIndex(
                name: "IX_vouchers_NhanVienMaNhanVien",
                table: "vouchers",
                column: "NhanVienMaNhanVien");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "caLams");

            migrationBuilder.DropTable(
                name: "lichLamViecs");

            migrationBuilder.DropTable(
                name: "taiKhoans");

            migrationBuilder.DropTable(
                name: "toppings");

            migrationBuilder.DropTable(
                name: "traSuas");

            migrationBuilder.DropTable(
                name: "NgayLVs");

            migrationBuilder.DropTable(
                name: "hoaDonChiTiets");

            migrationBuilder.DropTable(
                name: "HoaDons");

            migrationBuilder.DropTable(
                name: "bans");

            migrationBuilder.DropTable(
                name: "khachHangs");

            migrationBuilder.DropTable(
                name: "vouchers");

            migrationBuilder.DropTable(
                name: "memberships");

            migrationBuilder.DropTable(
                name: "nhanViens");

            migrationBuilder.DropTable(
                name: "chucVus");
        }
    }
}
