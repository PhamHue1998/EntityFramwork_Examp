using EFPhieuThu.Entities;
using EFPhieuThu.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFPhieuThu.IService
{
    interface IChiTietPhieuThuService
    {
        public errType ThemNhieuChiTietPhieuThu(PhieuThu phieuThu);
    }
}
