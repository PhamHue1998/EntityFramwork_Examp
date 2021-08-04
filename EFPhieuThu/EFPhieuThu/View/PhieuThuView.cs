using EFPhieuThu.Entities;
using EFPhieuThu.Helper;
using EFPhieuThu.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFPhieuThu.View
{
    class PhieuThuView
    {
    
            public void Menu()
            {
                Console.Clear();
                Console.WriteLine("" +
                    "Quan li PhieuThu\n+" +
                    "1.Them nguyen lieu\n" +
                    "2.Them Phieu thu\n" +
                    "3.Xoa phieu thu\n" +
                    "4.Them DS Chi Tiet Phieu\n" +
                    "5.Lay Thong tin phieu thu theo thoi gian\n" +
                    "6.Thoat");
                char c = Console.ReadKey().KeyChar;
                Console.WriteLine();
                DoAction(c);
            }
            private void DoAction(char c)
            {
            NguyenLieuService nguyenLieuService = new NguyenLieuService();
            PhieuThuService phieuThuService = new PhieuThuService();
            ChiTietPhieuThuService chiTietPhieuThuService = new ChiTietPhieuThuService();
            switch (c)
            {
                case '1':
                    {
                        errHelper.log(nguyenLieuService.ThemNguyenLieu(new NguyenLieu(inputType.ThemNguyenLieu)));
                    }
                    break;
                case '2':
                    {
                        errHelper.log(phieuThuService.ThemPhieuThu(new PhieuThu(inputType.ThemPhieuThu)));
                    }
                    break;
                case '3':
                    {
                        errHelper.log(phieuThuService.XoaPhieuThu(new PhieuThu(inputType.XoaPhieuThu)));
                    }
                    break;
                case '4':
                    {
                        errHelper.log(chiTietPhieuThuService.ThemNhieuChiTietPhieuThu(new PhieuThu(inputType.ThemDSChiTietChoPhieuThu)));
                    }
                        break;
                case '5':
                    {
                        errHelper.log(phieuThuService.LayThongTinPhieuThuTheoThoiGian(new PhieuThu(inputType.LayThongTinPhieuThuTheoThoiGian)));
                    }
                    break;
                default:
                    break;
            }
            Console.ReadKey();
                Menu();
            }
        }
    
}
