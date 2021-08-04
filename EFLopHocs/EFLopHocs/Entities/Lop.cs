using EFLopHocs.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFLopHocs.Entities
{
    class Lop
    {
        public int Id { get; set; }
        public string TenLop { get; set; }
        public int SiSo { get; set; }
        public virtual IEnumerable<HocSinh> HocSinhs { get; set; }
        public Lop()
        {

        }
        //public Lop(inputType inputType)
        //{
        //    switch (inputType)
        //    {
        //        case inputType.ChuyenLop:
        //            {
        //                Id = inputHelper.InputInt("Nhap ma Id: ", "Loi");
        //                HoTen = inputHelper.InputNhapTen("Nhap Ten", "Loi", 1, 20);
        //                QueQuan = inputHelper.InputString("Nhap que quan", "Loi", 1, 30);
        //                NgaySinh = inputHelper.InputNhapNgayThang("Nhap ngay sinh", "Loi");
        //                LopID = inputHelper.InputInt("Nhap ma lop ", "loi");

        //            }

        //            break;
                
        //    }
        //}
    }
}
