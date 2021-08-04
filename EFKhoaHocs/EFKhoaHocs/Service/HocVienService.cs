using EFKhoaHocs.Entities;
using EFKhoaHocs.Helper;
using EFKhoaHocs.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace EFKhoaHocs.Service
{
    class HocVienService : IHocVienService
    {
        private QliKhoaHocDbContext qliKhoaHocDbContext;
        public HocVienService()
        {
            qliKhoaHocDbContext = new QliKhoaHocDbContext();
        }
        public errType SuaHocVien(HocVien hocVien)
        {
            HocVien hocVien1 = qliKhoaHocDbContext.hocViens.SingleOrDefault(x => x.Id == hocVien.Id);
            KhoaHoc khoaHoc = qliKhoaHocDbContext.KhoaHocs.SingleOrDefault(x => x.Id == hocVien.KhoaHocID);
            if (hocVien1 == null)
            {
                return errType.KhongTonTaiHocVien;
            }
            if (khoaHoc==null)
            {
                return errType.KhongTonTaiKhoaHoc;
            }
            else
            {
                hocVien1.HoTen = hocVien.HoTen;
                hocVien1.NgaySinh = hocVien.NgaySinh;
                hocVien1.QueQuan = hocVien.QueQuan;
                hocVien1.DiaChi = hocVien.DiaChi;
                hocVien1.Sdt = hocVien.Sdt;
                qliKhoaHocDbContext.SaveChanges();
                return errType.ThanhCong;
            }
        }

        public errType TimKiemHocVien(HocVien hocVien)
        {
            HocVien hocVien1 = qliKhoaHocDbContext.hocViens.SingleOrDefault(x => x.HoTen.Contains(hocVien.HoTen) && x.KhoaHocID == hocVien.KhoaHocID);
            if (hocVien1 == null)
            {
                return errType.KhongTonTaiHocVien;
            }
            else
            {
                Console.WriteLine($"Hoc vien can tim co id la {hocVien1.Id} ten la {hocVien1.HoTen} dang ki khoa hoc {hocVien1.KhoaHocID}");
                return errType.ThanhCong;
            }
        }
    }
}
