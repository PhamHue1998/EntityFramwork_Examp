using EFDuAn.Entities;
using EFDuAn.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDuAn.IService
{
    interface INhanVienService
    {
        public errType ThemNhanVien(NhanVien nhanVien);       
        public errType XoaNhanVien(NhanVien nhanVien);
        public void TinhLuong(NhanVien nhanVien);
    }
}
