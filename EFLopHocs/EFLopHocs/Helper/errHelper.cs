using System;
using System.Collections.Generic;
using System.Text;

namespace EFLopHocs.Helper
{
    enum errType
    {
        KhongTonTaiHocSinh, KhongTonTaiLop, DaTonTai,ThanhCong
    }
    class errHelper
    {
        public static void log(errType errType)
        {
            switch (errType)
            {
                case errType.KhongTonTaiHocSinh:
                    Console.WriteLine("Khong ton tai hoc sinh");
                    break;
                case errType.KhongTonTaiLop:
                    Console.WriteLine("Khong ton tai lop hoc");
                    break;
                case errType.DaTonTai:
                    Console.WriteLine("Da ton tai");
                    break;
                case errType.ThanhCong:
                    Console.WriteLine("Thanh cong");
                    break;
                default:
                    break;
            }
        }
    }
}
