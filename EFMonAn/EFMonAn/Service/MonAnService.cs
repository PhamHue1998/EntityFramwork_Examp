using EFMonAn.Entities;
using EFMonAn.Helper;
using EFMonAn.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace EFMonAn.Service
{
    class MonAnService : IMonAn
    {
        QuanLiDbContext quanLiDbContext { get; }
        public MonAnService()
        {
            quanLiDbContext = new QuanLiDbContext();
        }

      

        public errType TimKiemMonAnTheoTenVaNgLieu(string TenMonAn,string TenNguyenLieu)
        {
            MonAn monAn = quanLiDbContext.monAns.SingleOrDefault(x => x.TenMon == TenMonAn);
            NguyenLieu nguyenLieu = quanLiDbContext.nguyenLieus.SingleOrDefault(x => x.TenNguyenLieu == TenNguyenLieu);
            if (monAn == null)
            {
                return errType.KTonTaiMonAn;
            }
            if (nguyenLieu == null)
            {
                return errType.KTonTaiNguyenLieu;
            }
            var lstcongThuc = quanLiDbContext.congThucs.Where(x => x.MonAnId == monAn.Id && x.NguyenLieuId == nguyenLieu.Id).ToList();
            // trong list k ton tai phan tu nao=> so luong ptu cua list = 0
            if (lstcongThuc.Count() == 0)
            {
                return errType.KTonTaiMonAn;
            }
            else
            {
                Console.WriteLine($" Ma mon an {monAn.Id} , ma loai mon an {monAn.LoaiMonAnId}, ten mon {monAn.TenMon}, co nguyen lieu {monAn.CachLam}");
                return errType.ThanhCong;
            }
        }
    }
}
