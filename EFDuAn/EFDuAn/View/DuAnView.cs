using EFDuAn.Entities;
using EFDuAn.Helper;
using System;
using System.Collections.Generic;
using System.Text;
using EFDuAn.Service;
using EFDuAn.IService;

namespace EFDuAn.View
{
    class DuAnView
    {
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine(""+
                " Quan Li Du An\n"+
                "1.Them Nhan Vien\n"+
                "2.Them Nhan Vien Vao Du An\n" +
                "3.Xoa Nhan Vien\n" +
                "4.Sua du an\n" +
                "5.Tinh Luong\n" +
                "6. Thoat");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();
            DoAction(c);
            
        }
        private void DoAction(char c)
        {
            NhanVienService nhanVienService = new NhanVienService();
            PhanCongService phanCongService = new PhanCongService();
            DuAnService duAnService = new DuAnService();
            switch (c)
            {
                case '1':
                    errHelper.log(nhanVienService.ThemNhanVien(new NhanVien(inputType.ThemNhanVien)));
                    break;
                case '2':
                    errHelper.log(phanCongService.ThemNhanVienVaoDuAn(new PhanCong(inputType.ThemNhanVienVaoDuAn)));
                    break;
                case '3':
                    errHelper.log(nhanVienService.XoaNhanVien(new NhanVien(inputType.XoaNhanVien)));
                    break;
                case '4':
                    errHelper.log(duAnService.SuaThongTinDuAn(new DuAn(inputType.SuaDuAn)));
                    break;
                case '5':
                    nhanVienService.TinhLuong(new NhanVien(inputType.TinhLuong));
                    break;
                case '6':
                    break;
            }
            Console.ReadKey();
            Menu();
        }
    }
}
