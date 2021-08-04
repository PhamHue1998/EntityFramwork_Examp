using EFKhoaHocs.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFKhoaHocs.Entities
{
    class HocVien
    {
        public int Id { get; set; }
        public int KhoaHocID { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string QueQuan { get; set; }
        public string DiaChi { get; set; }
        public string Sdt { get; set; }
        public virtual KhoaHoc KhoaHoc { get; set; }
        public HocVien() { }
        public HocVien(inputType inputType)
        {
            if (inputType == inputType.SuaThongTinHocVien)
            {
                Id = inputHelper.InputInt("Nhap Id hoc vien can sua: ", "Loi");
                KhoaHocID = inputHelper.InputInt("Nhap Id khoa hoc: ", "Loi");
                HoTen = inputHelper.InputNhapten("Nhap ten hoc vien: ", "Loi");
                NgaySinh = inputHelper.NhapNgay("Nhap ngay sinh: ", "Loi");
                QueQuan = inputHelper.InputString("Nhap que quan: ", "Loi",1,50);
                DiaChi = inputHelper.InputString("Nhap dia chi: ", "Loi", 1, 50);
                Sdt = inputHelper.InputString("Nhap sdt: ","Loi", 1, 10);
            }
            if (inputType == inputType.TimKiemHocvien)
            {
                HoTen = inputHelper.InputNhapten("Nhap ten hoc vien: ", "Loi");
                KhoaHocID = inputHelper.InputInt("Nhap Id khoa hoc: ", "Loi");
            }
        }
    }
}
