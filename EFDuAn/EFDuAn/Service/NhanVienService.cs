using EFDuAn.Entities;
using EFDuAn.Helper;
using EFDuAn.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFDuAn.Service
{
    class NhanVienService : INhanVienService
    {
        QuanLiDuAnDbContext quanLiDuAnDbContext { get; }
        public NhanVienService()
        {
            quanLiDuAnDbContext = new QuanLiDuAnDbContext();
        }
        public errType ThemNhanVien(NhanVien nhanVien)
        {
            NhanVien nhanVien1 = quanLiDuAnDbContext.nhanViens.SingleOrDefault(x => x.Id == nhanVien.Id);
            if (nhanVien1 == null)
            {
                nhanVien.Id = 0;
                quanLiDuAnDbContext.nhanViens.Add(nhanVien);
                quanLiDuAnDbContext.SaveChanges();
                return errType.ThanhCong;
            }
            else
            {
                return errType.DaTonTai;
            }
        }

        public void TinhLuong(NhanVien nhanVien)
        {
            NhanVien nhanVien1 = quanLiDuAnDbContext.nhanViens.SingleOrDefault(x => x.Id == nhanVien.Id);
            if (nhanVien1 == null)
            {
                errHelper.log(errType.KhongTonTaiNhanVien);
            }
            else
            {
                double tienluong = nhanVien1.HeSoLuong * 15 * quanLiDuAnDbContext.phanCongs.Where(x => x.Id == nhanVien.Id).Sum(x => x.SoGioLam);
                Console.WriteLine($"Tien luong cua nhan vien{nhanVien.HoTen} la {tienluong}");
            }
        }

        public errType XoaNhanVien(NhanVien nhanVien)
        {
            NhanVien nhanVien1 = quanLiDuAnDbContext.nhanViens.SingleOrDefault(x => x.Id == nhanVien.Id);
            if (nhanVien1 == null)
            {
                return errType.KhongTonTaiNhanVien;
            }
            else
            {
                List<PhanCong> dsphanCong = quanLiDuAnDbContext.phanCongs.Where(x => x.Id == nhanVien.Id).ToList();
                dsphanCong.ForEach(x => quanLiDuAnDbContext.phanCongs.Remove(x));
                quanLiDuAnDbContext.SaveChanges();
                quanLiDuAnDbContext.Remove(nhanVien1);
                quanLiDuAnDbContext.SaveChanges();
                return errType.ThanhCong;
            }
        }
    }
}
