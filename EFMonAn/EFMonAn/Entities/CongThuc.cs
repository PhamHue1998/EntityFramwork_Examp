using EFMonAn.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFMonAn.Entities
{
    class CongThuc
    {
        public int Id { get; set; }
        public int NguyenLieuId { get; set; }
        public int MonAnId { get; set; }
        public int Soluong { get; set; }
        public string DonViTinh { get; set; }
        public virtual NguyenLieu NguyenLieu { get; set; }
        public virtual MonAn MonAn { get; set; }
        public CongThuc()
        {

        }
        public CongThuc(inputType inputType)
        {
            if (inputType == inputType.ThemCT)
            {
                MonAnId = inputHelper.InputInt("Nhap mon an Id:", "Loi");
                
            }
        }
    }
}
