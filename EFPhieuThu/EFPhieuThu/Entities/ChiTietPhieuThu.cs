using EFPhieuThu.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFPhieuThu.Entities
{
    class ChiTietPhieuThu
    {
        public int Id { get; set; }
        public int NguyenLieuId { get; set; }
        public int PhieuThuId { get; set; }
        public int SoLuongBan { get; set; }
        public virtual NguyenLieu NguyenLieu { get; set; }
        public virtual PhieuThu PhieuThu { get; set; }
        public ChiTietPhieuThu()
        {

        }
        public ChiTietPhieuThu(inputType inputType)
        {
            if (inputType == inputType.ThemDSChiTietChoPhieuThu)
            {
                Id = inputHelper.InputInt("Nhap chi tiet id: ", "Loi");
                NguyenLieuId = inputHelper.InputInt("Nhap nglieu id: ", "Loi");
                SoLuongBan = inputHelper.InputInt("Nhap so luong ban: ", "Loi");
            }
        }
    }
}
