using EFMonAn.Entities;
using EFMonAn.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFMonAn.IService
{
    interface IMonAn
    {
       
        public errType TimKiemMonAnTheoTenVaNgLieu(string TenMonAn,string TenNgLieu);
    }
}
