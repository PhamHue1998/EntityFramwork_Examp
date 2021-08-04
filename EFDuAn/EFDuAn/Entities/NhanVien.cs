using EFDuAn.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDuAn.Entities
{
    class NhanVien
    {
        public int Id{ get; set; }
        public string HoTen { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi{get;set;}
        public string Email { get; set; }
        public  int HeSoLuong { get; set; }
        public NhanVien()
        {

        }
        public virtual IEnumerable<PhanCong> PhanCongs { get; set; }
        public NhanVien(inputType inputType)
        {
            if (inputType == inputType.ThemNhanVien)
            {
                Id = inputHelper.InputInt("Nhap id: ", "Loi!");
                HoTen = inputHelper.NhapTen("Nhap ten nhan vien: ", "Loi!");
                SoDienThoai = inputHelper.InputString("Nhap so dien thoai: ", "Loi", 1, 10);
                Email = inputHelper.InputString("Nhap email: ", "Loi", 1, 10);
                HeSoLuong = inputHelper.InputInt("Nhap he so luong: ", "Loi");
            }
            else if (inputType == inputType.XoaNhanVien)
            {
                Id = inputHelper.InputInt("Nhap id:", "Loi!");
            }
            else if (inputType == inputType.TinhLuong)
            {
                Id = inputHelper.InputInt("Nhap id:", "Loi!");
            }
        }
    }
}
