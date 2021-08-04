using EFMonAn.Entities;
using EFMonAn.Helper;
using EFMonAn.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFMonAn.Service
{
    class CongThucService : ICongThuc
    {
        QuanLiDbContext quanLiDbContext { get; }
        public CongThucService()
        {
            quanLiDbContext = new QuanLiDbContext();
        }
        public errType ThemCT(CongThuc congThuc)
        {
            MonAn monAn = quanLiDbContext.monAns.SingleOrDefault(x => x.Id == congThuc.MonAnId);
            if (monAn == null)
            {
                return errType.KTonTaiMonAn;
            }
            else
            {
                bool ok;

                do
                {
                    congThuc.NguyenLieuId = inputHelper.InputInt("Nhap nguyen lieu id:", "Loi");
                    NguyenLieu nguyenLieu = quanLiDbContext.nguyenLieus.SingleOrDefault(x => x.Id == congThuc.NguyenLieuId);

                    if (nguyenLieu == null)
                    {
                        return errType.KTonTaiNguyenLieu;
                    }
                    congThuc.Soluong = inputHelper.InputInt("Nhap so luong:", "Loi");
                    congThuc.DonViTinh = inputHelper.InputString("Nhap don vi tinh:", "Loi");
                    congThuc.Id = 0;
                    quanLiDbContext.congThucs.Add(congThuc);
                    quanLiDbContext.SaveChanges();
                    string str = nguyenLieu.TenNguyenLieu + ":" + congThuc.Soluong + " " + congThuc.DonViTinh + "\n";
                    // kiem tra chuoi co rong hay k 
                    if (string.IsNullOrEmpty(monAn.CachLam))//Tra ve true fasle
                    {
                        monAn.CachLam = str;//Neu cach lam rong
                        
                    }
                    else
                    {
                        monAn.CachLam += str;//neu cach lam co chu
                    }
                    quanLiDbContext.Update(monAn);
                    quanLiDbContext.SaveChanges();
                    Console.WriteLine("Co them tiep hay k");
                    Console.WriteLine("1. Co\n" +
                        "2.Khong");
                    char c = Console.ReadKey().KeyChar;
                    if (c == '1')
                    {
                        ok = true;
                    }
                    else
                    {
                        ok = false;
                    }
                } while (ok);
            }
           
            return errType.ThanhCong;
        }
    }
}
