using EFMonAn.Entities;
using EFMonAn.Helper;
using EFMonAn.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFMonAn.Service
{
    class LoaiMonAnService : ILoaiMonAn
    {
        QuanLiDbContext quanLiDbContext { get; }
        public LoaiMonAnService()
        {
            quanLiDbContext = new QuanLiDbContext();
        }
        public errType XoaLoaiMonAn(LoaiMonAn loaiMonAn)
        {
            LoaiMonAn loaiMonAn1 = quanLiDbContext.loaiMonAns.SingleOrDefault(x => x.Id == loaiMonAn.Id);
            if (loaiMonAn1 == null)
            {
                return errType.KhongTonTaiLoaiMonAn;
            }
            else
            {
                quanLiDbContext.loaiMonAns.Remove(loaiMonAn1);
                quanLiDbContext.SaveChanges();
                return errType.ThanhCong;
            }
        }
        public errType ThemMonAn(MonAn monAn) //Them mot mon an vao loai mon an da ton tai
        {

            LoaiMonAn loaiMonAn1 = quanLiDbContext.loaiMonAns.SingleOrDefault(x => x.Id == monAn.LoaiMonAnId);
            if (loaiMonAn1 == null)
            {
                return errType.KhongTonTaiLoaiMonAn;
            }
            else
            {
                monAn.Id = 0;
                quanLiDbContext.monAns.Add(monAn);
                quanLiDbContext.SaveChanges();
                return errType.ThanhCong;
            }

        }
    }
}
