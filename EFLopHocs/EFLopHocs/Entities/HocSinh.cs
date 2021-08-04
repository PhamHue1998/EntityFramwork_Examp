using EFLopHocs.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFLopHocs.Entities
{
    class HocSinh
    {
        public int Id { get; set; }
        public int LopID { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string QueQuan { get; set; }
        public virtual Lop Lop { get; set; }
        public HocSinh() { }
        public HocSinh(inputType inputType)
        {
            switch (inputType)
            {
                case inputType.ThemHocSinh:
                    {
                        Id = inputHelper.InputInt("Nhap ma Id: ", "Loi");
                        HoTen = inputHelper.InputNhapTen("Nhap Ten", "Loi", 1, 20);
                        QueQuan = inputHelper.InputString("Nhap que quan", "Loi", 1, 30);
                        NgaySinh = inputHelper.InputNhapNgayThang("Nhap ngay sinh", "Loi");
                        LopID = inputHelper.InputInt("Nhap ma lop ", "loi");

                    }

                    break;
                case inputType.SuaThongTinHocSinh:
                    {
                        Id = inputHelper.InputInt("Nhap ma id", "Loi");
                        HoTen = inputHelper.InputNhapTen("Nhap Ten", "Loi", 1, 20);
                        QueQuan = inputHelper.InputString("Nhap que quan", "Loi", 1, 30);
                        NgaySinh = inputHelper.InputNhapNgayThang("Nhap ngay sinh", "Loi");
                        LopID = inputHelper.InputInt("Nhap ma lop ", "loi");
                    }
                    break;
                case inputType.XoaHocSinh:
                    {
                        Id = inputHelper.InputInt("Nhap ma id", "Loi");
                    }
                    break;
                case inputType.ChuyenLop:
                    {
                        Id = inputHelper.InputInt("Nhap ma id: ", "Loi");
                        LopID = inputHelper.InputInt("Nhap ma lop ", "loi");
                    }
                    break;
                case inputType.HienThi:
                    {

                    }
                    break;
            }
        }
    }
}
