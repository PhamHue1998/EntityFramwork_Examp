using EFMonAn.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFMonAn.Entities
{
    class MonAn
    {
        public int Id { get; set; }
        public int LoaiMonAnId { get; set; }
        public string TenMon { get; set; }
        public int GiaBan { get; set; }
        public string GioiThieu { get; set; }
        public string CachLam { get; set; }
        public virtual LoaiMonAn LoaiMonAn { get; set; }
        public MonAn()
        {

        }
        public MonAn(inputType inputType)
        {
            if (inputType == inputType.ThemMonAn)
            {
                LoaiMonAnId = inputHelper.InputInt("Nhap id loai mon an: ", "Loi");
                TenMon = inputHelper.InputNhapTen("Nhap ten mon an:", "Loi");
                GiaBan = inputHelper.InputInt("Nhap gia ban: ", "Loi");
                GioiThieu = inputHelper.InputString("Gioi thieu: ", "Loi");
            }
           
        }
    }
}
