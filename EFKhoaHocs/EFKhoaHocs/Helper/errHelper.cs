using System;
using System.Collections.Generic;
using System.Text;

namespace EFKhoaHocs.Helper
{
    enum errType
    {
        KhongTonTaiHocVien, KhongTonTaiKhoaHoc, DaTonTai, ThanhCong, SoNgayToiDa
    }
    class errHelper
    {
        public static void log(errType errType)
        {
            switch (errType)
            {
                case errType.KhongTonTaiHocVien:
                    Console.WriteLine("k ton tai hoc vien");
                    break;
                case errType.KhongTonTaiKhoaHoc:
                    Console.WriteLine("k ton tai khoa hoc");
                    break;
                case errType.DaTonTai:
                    Console.WriteLine("da ton tai");
                    break;
                case errType.ThanhCong:
                    Console.WriteLine("Thanh cong");
                    break;
                case errType.SoNgayToiDa:
                    Console.WriteLine("vuot qua so ngay hoc ");
                    break;
                default:
                    break;
            }
        }
    }
}
