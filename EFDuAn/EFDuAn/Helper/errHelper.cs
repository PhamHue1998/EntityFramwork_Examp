using System;
using System.Collections.Generic;
using System.Text;

namespace EFDuAn.Helper
{
    enum errType
    {
        DaTonTai,KhongTonTaiNhanVien,KhongTonTaiDuAn,ThanhCong
    }
    class errHelper
    {
        public static void log(errType errType)
        {
            switch (errType)
            {
                case errType.DaTonTai:
                    Console.WriteLine("Da Ton tai");
                    break;
                case errType.KhongTonTaiNhanVien:
                    Console.WriteLine("Khong ton tai nhan vien");
                    break;
                case errType.KhongTonTaiDuAn:
                    Console.WriteLine("Khong ton tai du an");
                    break;
                case errType.ThanhCong:
                    Console.WriteLine("Thanh Cong");
                    break;
                default:
                    break;
            }
        }
    }
}
