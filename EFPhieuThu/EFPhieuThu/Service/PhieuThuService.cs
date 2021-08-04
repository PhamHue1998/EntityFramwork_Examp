using EFPhieuThu.Entities;
using EFPhieuThu.Helper;
using EFPhieuThu.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFPhieuThu.Service
{
    class PhieuThuService : IPhieuThuService
    {
        private QliPhieuThu qliPhieuThu { get; }
        public PhieuThuService()
        {
            qliPhieuThu = new QliPhieuThu();
        }
        public void LayDanhSachSanPham(PhieuThu phieuThu)
        {
            // lay ra nhieu chi tiet phieu
            List<ChiTietPhieuThu> dsSanPham = qliPhieuThu.chiTietPhieus.Where(x => x.PhieuThuId == phieuThu.Id).ToList();
            
            foreach (var item in dsSanPham)
            {
                // lay ra nguyen lieu trong chi tiet phieu
                NguyenLieu nguyenLieu = qliPhieuThu.nguyenLieus.Find(item.NguyenLieuId);
                LoaiNguyenLieu loaiNguyenLieu = qliPhieuThu.loaiNguyenLieus.Find(nguyenLieu.LoaiNguyenLieuId);
                Console.WriteLine($"Nguyen lieu {nguyenLieu.TenNguyenLieu} va la loai nguyen lieu {loaiNguyenLieu.TenLoaiNguyenLieu}");
            }
        }
        public errType LayThongTinPhieuThuTheoThoiGian(PhieuThu phieuThu)
        {
            if (qliPhieuThu.phieuThus.Any(x => x.NgayLap == phieuThu.NgayLap))
                //dsPT=1;PTs=2
            {
                List<PhieuThu> dsPhieuThu = qliPhieuThu.phieuThus.Where(x => x.NgayLap == phieuThu.NgayLap).ToList();
                foreach (var item in dsPhieuThu)
                {                  
                  Console.WriteLine($"Phieu thu co id {item.Id} ngay lap {item.NgayLap} nhan vien {item.NhanVienLap} thanh tien {item.ThanhTien}");
                  LayDanhSachSanPham(item);
                }
                return errType.ThanhCong;
            }
            else
            {
                return errType.KhongTonTaiPhieuThu;
            }
        }

        public errType ThemPhieuThu(PhieuThu phieuThu)
        {
            PhieuThu phieuThu1 = qliPhieuThu.phieuThus.SingleOrDefault(x => x.Id == phieuThu.Id);
            if (phieuThu1 == null)
            {
                return errType.KhongTonTaiPhieuThu;
            }
            else
            {
                phieuThu.Id = 0;
                qliPhieuThu.phieuThus.Add(phieuThu);
                qliPhieuThu.SaveChanges();
                ChiTietPhieuThuService chiTietPhieuThuService = new ChiTietPhieuThuService();
                return chiTietPhieuThuService.ThemNhieuChiTietPhieuThu(phieuThu);
            }

        }

        public errType XoaPhieuThu(PhieuThu phieuThu)
        {
            PhieuThu phieuThu1 = qliPhieuThu.phieuThus.SingleOrDefault(x => x.Id == phieuThu.Id);
            if (phieuThu1 == null)
            {
                return errType.KhongTonTaiPhieuThu;
            }
            else
            {
                qliPhieuThu.phieuThus.Remove(phieuThu1);
                qliPhieuThu.SaveChanges();
                return errType.ThanhCong;
            }
        }
    }
}
