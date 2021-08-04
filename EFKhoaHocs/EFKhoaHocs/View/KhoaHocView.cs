using EFKhoaHocs.Entities;
using EFKhoaHocs.Helper;
using EFKhoaHocs.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFKhoaHocs.View
{
    class KhoaHocView
    {
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("" +
                "Quan li Khoa Hoc\n+" +
                "1.Them ngay hoc\n" +
                "2.Sua thong tin hoc vien\n" +
                "3.Xoa khoa hoc\n" +
                "4.Tim kiem hoc vien\n" +
                "5.Tinh doanh thu theo thang\n" +
                "6.Thoat");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();
            DoAction(c);
        }
        private void DoAction(char c)
        {
            KhoaHocService khoaHocService = new KhoaHocService();
            HocVienService hocVienService = new HocVienService();
            switch (c)
            {
                case '1':
                    {
                        errHelper.log(khoaHocService.ThemNgayVaoKhoaHoc(new KhoaHoc(inputType.ThemNgayHocVaoKhoaHoc)));
                    }
                    break;
                case '2':
                    {
                        errHelper.log(hocVienService.SuaHocVien(new HocVien(inputType.SuaThongTinHocVien)));
                    }
                    break;
                case '3':
                    {
                        errHelper.log(khoaHocService.XoaKhoaHoc(new KhoaHoc(inputType.XoaKhoaHoc)));
                    }
                    break;
                case '4':
                    {
                        errHelper.log(hocVienService.TimKiemHocVien(new HocVien(inputType.TimKiemHocvien)));
                    }
                    break;
                case '5':
                    {
                        errHelper.log(khoaHocService.TinhDoanhThuTheoThang());
                    }
                    break;
            }
            Console.ReadKey();
            Menu();
        }
    }
}
