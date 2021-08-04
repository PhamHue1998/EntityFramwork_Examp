using EFKhoaHocs.Entities;
using EFKhoaHocs.Helper;
using EFKhoaHocs.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFKhoaHocs.Service
{
    class KhoaHocService : IKhoaHocService
    {
        QliKhoaHocDbContext qliKhoaHocDbContext;
        public KhoaHocService()
        {
            qliKhoaHocDbContext = new QliKhoaHocDbContext();
        }
        public errType ThemNgayVaoKhoaHoc(KhoaHoc khoaHoc)
        {
            KhoaHoc khoaHoc1 = qliKhoaHocDbContext.KhoaHocs.SingleOrDefault(x => x.Id == khoaHoc.Id);
            if (khoaHoc1 == null)
            {
                return errType.KhongTonTaiKhoaHoc;
            }
            int ngay = khoaHoc1.NgayKetThuc.Subtract(khoaHoc1.NgayBatDau).Days;
            if (ngay >= 15)
            {
                return errType.SoNgayToiDa;
            }
            else
            {
                khoaHoc1.NgayKetThuc = khoaHoc1.NgayKetThuc.AddDays(1);
                qliKhoaHocDbContext.SaveChanges();
                return errType.ThanhCong;
            }
        }

        public errType TinhDoanhThuTheoThang()
        {
            int thang = inputHelper.InputInt("nhap thang: ", "Loi!");
            int nam = inputHelper.InputInt("Nhap nam: ", "Loi");
            List<KhoaHoc> dsKhoaHoc = qliKhoaHocDbContext.KhoaHocs.Where(x => x.NgayBatDau.Month == thang && x.NgayBatDau.Year == nam).ToList();
            double doanhthu = 0;
            for (int i = 0; i < dsKhoaHoc.Count(); i++)
            {
                doanhthu += qliKhoaHocDbContext.hocViens.Where(x => x.KhoaHocID == dsKhoaHoc[i].Id).Count() * dsKhoaHoc[i].HocPhi;
            }
            Console.WriteLine($"Doanh thu thang {thang} la {doanhthu}");
            return errType.ThanhCong;
        }

        public errType XoaKhoaHoc(KhoaHoc khoaHoc)
        {
            KhoaHoc khoaHoc1 = qliKhoaHocDbContext.KhoaHocs.SingleOrDefault(x => x.Id == khoaHoc.Id);
            if (khoaHoc1 == null)
            {
                return errType.KhongTonTaiKhoaHoc;
            }
            else
            {
                var dsHocVien = qliKhoaHocDbContext.hocViens.Where(x => x.KhoaHocID == khoaHoc.Id).ToList();
                dsHocVien.ForEach(x => qliKhoaHocDbContext.hocViens.Remove(x));
                qliKhoaHocDbContext.SaveChanges();
                var ngayhoc = qliKhoaHocDbContext.ngayHocs.Where(x => x.KhoaHocID == khoaHoc.Id).ToList();
                ngayhoc.ForEach(x => qliKhoaHocDbContext.ngayHocs.Remove(x));
                qliKhoaHocDbContext.SaveChanges();
                qliKhoaHocDbContext.Remove(khoaHoc1);
                qliKhoaHocDbContext.SaveChanges();
                return errType.ThanhCong;
            }
        }
    }
}
