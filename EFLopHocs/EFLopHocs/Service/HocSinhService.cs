using EFLopHocs.Entities;
using EFLopHocs.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFLopHocs.Service
{
    class HocSinhService : IHocSinhService
    {
        private QuanLiDbContext quanLiDbContext { get; }

        //phần này bị thiếu
        public HocSinhService()
        {
            quanLiDbContext = new QuanLiDbContext();
        }

        public errType ChuyenLop(HocSinh hocSinh)
        {
            HocSinh hocSinh1 = quanLiDbContext.HocSinhs.SingleOrDefault(x => x.Id == hocSinh.Id);
            //Lop lop1 = quanLiDbContext.Lops.SingleOrDefault(x => x.Id == lop.Id);
            if (hocSinh1 == null)
            {
                return errType.KhongTonTaiHocSinh;
            }
            //if (lop1 == null)
            //{
            //    return errType.KhongTonTaiLop;
            //}
            else
            {
                hocSinh1.Id = hocSinh.Id;
                hocSinh1.LopID = hocSinh.LopID;
                quanLiDbContext.HocSinhs.Update(hocSinh1);
                quanLiDbContext.SaveChanges();
                return errType.ThanhCong;
            }
        }

        public errType SuaThongTinHocSinh(HocSinh hocSinh)
        {
            HocSinh hocSinh1 = quanLiDbContext.HocSinhs.SingleOrDefault(x => x.Id == hocSinh.Id);
            if (hocSinh1 == null)
            {
                return errType.KhongTonTaiHocSinh;
            }
            else
            {
                hocSinh1.HoTen = hocSinh.HoTen;
                hocSinh1.NgaySinh = hocSinh.NgaySinh;
                hocSinh1.QueQuan = hocSinh.QueQuan;
                hocSinh1.LopID = hocSinh.LopID;
                quanLiDbContext.HocSinhs.Update(hocSinh1);
                quanLiDbContext.SaveChanges();
                return errType.ThanhCong;
            }
        }

        public errType ThemHocSinh(HocSinh hocSinh)
        {
            HocSinh hocSinh1 = quanLiDbContext.HocSinhs.SingleOrDefault(x => x.Id == hocSinh.Id);
            if (hocSinh1 == null)
            {
                //chấp nhận
                hocSinh.Id = 0;
                quanLiDbContext.HocSinhs.Add(hocSinh);
                quanLiDbContext.SaveChanges();
                return errType.ThanhCong;
            }
            else
            {
                return errType.DaTonTai;
            }
        }

        public errType XoaHocSinh(HocSinh hocSinh)
        {
            HocSinh hocSinh1 = quanLiDbContext.HocSinhs.SingleOrDefault(x => x.Id == hocSinh.Id);
            if (hocSinh1 == null)
            {
                return errType.KhongTonTaiHocSinh;
            }
            else
            {
                quanLiDbContext.HocSinhs.Remove(hocSinh1);
                quanLiDbContext.SaveChanges();
                return errType.ThanhCong;
            }
        }
        public errType HienThi()
        {
            IEnumerable<HocSinh> dsHocSinh = quanLiDbContext.HocSinhs.AsQueryable();
            foreach (var item in dsHocSinh)
            {
                Console.WriteLine($"{item.HoTen}");
            }
            return errType.ThanhCong;

        }
    }
}
