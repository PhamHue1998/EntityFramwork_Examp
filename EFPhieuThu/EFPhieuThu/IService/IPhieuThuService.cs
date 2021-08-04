using EFPhieuThu.Entities;
using EFPhieuThu.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFPhieuThu.IService
{
    interface IPhieuThuService
    {
        public errType ThemPhieuThu(PhieuThu phieuThu);
        public errType XoaPhieuThu(PhieuThu phieuThu);
        public errType LayThongTinPhieuThuTheoThoiGian(PhieuThu phieuThu);
    }
}
