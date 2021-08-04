using EFPhieuThu.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFPhieuThu.Entities
{
    class NguyenLieu
    { 
        public int Id { get; set; }
        public int LoaiNguyenLieuId { get; set; }
        public string TenNguyenLieu { get; set; }
        public int GiaBan { get; set; }
        public int DonViTinh { get; set; }
        public int SoLuongKho { get; set; }
        public virtual LoaiNguyenLieu LoaiNguyenLieu { get; set; }
        public NguyenLieu()
        {

        }
        public NguyenLieu(inputType inputType)
        {
            if (inputType == inputType.ThemNguyenLieu)
            {
                Id = inputHelper.InputInt("Nhap ma Id:", "Loi");
                LoaiNguyenLieuId = inputHelper.InputInt("Nhap ma loai nglieu","Loi");
                TenNguyenLieu = inputHelper.InputString("Nhap ten nguyen lieu", "Loi", 1, 20);
                GiaBan = inputHelper.InputInt("Nhap gia ban", "Loi");
                DonViTinh = inputHelper.InputInt("Nhap don vi tinh", "Loi");
                SoLuongKho = inputHelper.InputInt("Nhap so luong ", "Loi");
            }
        }
    }
}
