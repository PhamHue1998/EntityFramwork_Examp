using System;
using System.Collections.Generic;
using System.Text;
using EFLopHocs.Entities;
using EFLopHocs.Helper;
using EFLopHocs.Service;

namespace EFLopHocs.View
{
    class LopHocView
    {
       public void Menu()
       {
            Console.WriteLine("" +
                "Quan Li Hoc Sinh\n" +
                "1.Them hoc sinh\n" +
                "2.Sua hoc sinh\n" +
                "3.Xoa hoc sinh\n" +
                "4.Chuyen lop\n" +
                "5.Thoat\n");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();
            DoAction(c);
       }
        private void DoAction(char c)
        {
            HocSinhService hocSinh = new HocSinhService();
            Lop lop = new Lop();
            switch (c)
            {
                case '1':
                    errHelper.log(hocSinh.ThemHocSinh(new HocSinh(inputType.ThemHocSinh)));
                    break;
                case '2':
                    errHelper.log(hocSinh.SuaThongTinHocSinh(new HocSinh(inputType.SuaThongTinHocSinh)));
                    break;
                case '3':
                    errHelper.log(hocSinh.XoaHocSinh(new HocSinh(inputType.XoaHocSinh)));
                    break;
                case '4':
                    errHelper.log(hocSinh.ChuyenLop(new HocSinh(inputType.ChuyenLop)));
                    break;
                case '5':
                    errHelper.log(hocSinh.HienThi());
                    break;
            }
            Console.ReadKey();
            Menu();
        }
    }
}
