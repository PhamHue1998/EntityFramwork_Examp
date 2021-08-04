using EFMonAn.Entities;
using EFMonAn.Helper;
using EFMonAn.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFMonAn.View
{
    class MonAnView
    {
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("" +
                "-----Quan li he thong mon an-----\n" +
                "1.Them mot mon an thuoc loai mon an da ton tai:\n" +
                "2.Them cong thuc cho mon an\n" +
                "3.Xoa mot loai mon an\n" +
                "4.Tim Kiem mon an theo ten va nguyen lieu\n" +
                "5.Thoat");
            char c = Console.ReadKey().KeyChar;
                Console.WriteLine();
                DoAction(c);
        }
        private void DoAction(char c)
        {
            LoaiMonAnService loaiMonAnService = new LoaiMonAnService();
            MonAnService monAnService = new MonAnService();
            CongThucService congThucService = new CongThucService();
            switch (c)
            {
                case '1':
                    {
                        errHelper.log(loaiMonAnService.ThemMonAn(new MonAn(inputType.ThemMonAn)));
                    }
                    break;
                case '2':
                    {
                        errHelper.log(congThucService.ThemCT(new CongThuc(inputType.ThemCT)));
                    }
                    break;
                case '3':
                    {
                        errHelper.log(loaiMonAnService.XoaLoaiMonAn(new LoaiMonAn(inputType.XoaMotLoaiMonAn)));
                    }
                    break;
                case '4':
                    {
                        Console.WriteLine("Nhap ten mon an: ");
                        string TenMonAn = Console.ReadLine();
                        Console.WriteLine("Nhap ten nguyen lieu: ");
                        string TenNguyenLieu = Console.ReadLine();
                        errHelper.log(monAnService.TimKiemMonAnTheoTenVaNgLieu(TenMonAn,TenNguyenLieu));
                    }
                    break;
                case '5':
                    break;
            }
            Console.ReadKey();
            Menu();
        }
    }
}
