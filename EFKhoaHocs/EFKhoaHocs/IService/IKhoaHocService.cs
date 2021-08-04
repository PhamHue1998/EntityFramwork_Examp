using EFKhoaHocs.Entities;
using EFKhoaHocs.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFKhoaHocs.IService
{
    interface IKhoaHocService
    {
        public errType XoaKhoaHoc(KhoaHoc khoaHoc);
        public errType TinhDoanhThuTheoThang();
        public errType ThemNgayVaoKhoaHoc(KhoaHoc khoaHoc);
    }
}
