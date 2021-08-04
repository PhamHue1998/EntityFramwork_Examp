using System;
using System.Collections.Generic;
using System.Text;

namespace EFMonAn.Helper
{
    enum errType
    {
        KhongTonTaiLoaiMonAn,KTonTaiNguyenLieu,DaTonTai,KTonTaiMonAn,ThanhCong
    }
    class errHelper
    {
        public static void log(errType errType)
        {
            switch (errType)
            {
                case errType.KhongTonTaiLoaiMonAn:
                    Console.WriteLine("K ton tai loai mon an");
                    break;
                case errType.KTonTaiNguyenLieu:
                    Console.WriteLine("k ton tai nguyen lieu");
                    break;
                case errType.DaTonTai:
                    Console.WriteLine("Da ton tai");
                    break;
                case errType.KTonTaiMonAn:
                    Console.WriteLine("K Ton tai mon an");
                    break;
                case errType.ThanhCong:
                    Console.WriteLine("Thanh Cong !");
                    break;
               
            }
        }
    }
}
