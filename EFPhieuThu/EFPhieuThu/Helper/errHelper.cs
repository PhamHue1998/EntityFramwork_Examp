using System;
using System.Collections.Generic;
using System.Text;

namespace EFPhieuThu.Helper
{
    enum errType
    {
        KhongTonTaiNguyenLieu,KhongTonTaiPhieuThu,DaTonTai,ThanhCong
    }
    class errHelper
    {
        public static void log(errType errType)
        {
            switch (errType)
            {
                case errType.KhongTonTaiNguyenLieu:
                    Console.WriteLine("K ton tai nguyen lieu");
                    break;
                case errType.KhongTonTaiPhieuThu:
                    Console.WriteLine("K ton tai phieu thu");
                    break;
                case errType.DaTonTai:
                    Console.WriteLine("Da ton tai");
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
