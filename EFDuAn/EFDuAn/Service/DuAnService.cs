using EFDuAn.Entities;
using EFDuAn.Helper;
using EFDuAn.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFDuAn.Service
{
    class DuAnService : IDuAnService
    { 
        private QuanLiDuAnDbContext quanLiDuAnDbContext { get; }
        public DuAnService()
        {
            quanLiDuAnDbContext = new QuanLiDuAnDbContext();
        }
        public errType SuaThongTinDuAn(DuAn duAn)
        {
            DuAn duAn1 = quanLiDuAnDbContext.duAns.SingleOrDefault(x => x.Id == duAn.Id);
            if (duAn1 == null)
            {
               return errType.KhongTonTaiDuAn;
            }
            else
            {
                duAn1.Id = duAn.Id;
                duAn1.TenDuAn = duAn.TenDuAn;
                duAn1.GhiChu = duAn.GhiChu;
                duAn1.MoTa = duAn.MoTa;
                quanLiDuAnDbContext.SaveChanges();
                return errType.ThanhCong;
            }
        }
    }
}
