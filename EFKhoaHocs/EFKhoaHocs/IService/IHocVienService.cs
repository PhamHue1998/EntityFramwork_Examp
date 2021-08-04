using EFKhoaHocs.Entities;
using EFKhoaHocs.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFKhoaHocs.IService
{
    interface IHocVienService
    {
        public errType SuaHocVien(HocVien hocVien);
        public errType TimKiemHocVien(HocVien hocVien);
    }
}
