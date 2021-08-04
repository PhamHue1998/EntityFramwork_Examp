using EFLopHocs.Entities;
using EFLopHocs.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFLopHocs.Service
{
    interface IHocSinhService
    {
        public errType ThemHocSinh(HocSinh hocSinh);
        public errType SuaThongTinHocSinh(HocSinh hocSinh);
        public errType XoaHocSinh(HocSinh hocSinh);
        public errType ChuyenLop(HocSinh hocSinh);
    }
}
