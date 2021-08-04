using EFDuAn.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDuAn.Entities
{
    class PhanCong
    {
        public int Id { get; set; }
        public int NhanVienId { get; set; }
        public int DuAnId { get; set; }
        public double SoGioLam { get; set; }
        public PhanCong()
        {

        }
        public virtual NhanVien NhanVien { get; set; }
        public virtual DuAn DuAn { get; set; }
        public PhanCong(inputType inputType)
        {
            if (inputType == inputType.ThemNhanVienVaoDuAn)
            {
                NhanVienId = inputHelper.InputInt("Nhap id nhan vien: ", "Loi!");
                DuAnId = inputHelper.InputInt("Nhap ma du an: ", "Loi!");
                SoGioLam = inputHelper.InputInt("Nhap so gio lam: ", "Loi!");
            }
        }
    }

}
