using EFMonAn.Entities;
using EFMonAn.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFMonAn.IService
{
    interface ILoaiMonAn
    {
        public errType XoaLoaiMonAn(LoaiMonAn loaiMonAn);
        public errType ThemMonAn(MonAn monAn);
    }
}
