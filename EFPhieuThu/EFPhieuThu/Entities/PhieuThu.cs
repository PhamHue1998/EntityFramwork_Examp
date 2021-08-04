using EFPhieuThu.Helper;
using EFPhieuThu.Migrations;
using EFPhieuThu.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFPhieuThu.Entities
{
    class PhieuThu
    {
        public int Id { get; set; }
        public DateTime NgayLap { get; set; }
        public string NhanVienLap { get; set; }
        public string GhiChu { get; set; }
        public double ThanhTien { get; set; }
        public virtual IEnumerable<ChiTietPhieuThu> ChiTietPhieuThus { get; set; }

        public PhieuThu()
        {

        }

        public PhieuThu(inputType inputType)
        {
            if (inputType == inputType.ThemPhieuThu)
            {
                Id = inputHelper.InputInt("Nhap ma phieu thu id:", "loi");
            }
            if (inputType == inputType.XoaPhieuThu)
            {
                Id = inputHelper.InputInt("Nhap id", "Loi");
            }
            if (inputType == inputType.LayThongTinPhieuThuTheoThoiGian) 
            {

                NgayLap = inputHelper.NhapNgay("Nhap ngay", "loi");
            }
            if (inputType == inputType.ThemDSChiTietChoPhieuThu)
            {
                Id = inputHelper.InputInt("Nhap ma Id", "Loi");
            }
        }
    }
}
