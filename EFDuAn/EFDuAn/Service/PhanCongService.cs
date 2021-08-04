using EFDuAn.Entities;
using EFDuAn.Helper;
using EFDuAn.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace EFDuAn.Service
{
    class PhanCongService : IPhanCongService
    {
        QuanLiDuAnDbContext quanLiDuAnDbContext { get; }
        public PhanCongService()
        {
            quanLiDuAnDbContext = new QuanLiDuAnDbContext();
        }
        public errType ThemNhanVienVaoDuAn(PhanCong phanCong)
        {
            PhanCong phanCong1 = quanLiDuAnDbContext.phanCongs.SingleOrDefault(x => x.Id == phanCong.Id);
            NhanVien nhanVien = quanLiDuAnDbContext.nhanViens.SingleOrDefault(x => x.Id == phanCong.NhanVienId);
            DuAn duAn = quanLiDuAnDbContext.duAns.SingleOrDefault(x => x.Id == phanCong.DuAnId);
            if (nhanVien == null)
            {
                return errType.KhongTonTaiNhanVien;
            }
            if (duAn == null)
            {
                return errType.KhongTonTaiDuAn;
            }
            else
            {
                phanCong.Id = 0;
                quanLiDuAnDbContext.phanCongs.Add(phanCong);
                quanLiDuAnDbContext.SaveChanges();
                return errType.ThanhCong;
            }

        }
    }
}
