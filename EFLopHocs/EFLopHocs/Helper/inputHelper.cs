using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFLopHocs.Helper
{
    enum inputType
    {
        ThemHocSinh,SuaThongTinHocSinh,XoaHocSinh,ChuyenLop,HienThi
    }
    class inputHelper
    {
        public static int InputInt(string msg,string err, int minValue=int.MinValue,int maxValue = int.MaxValue)
        {
            int so;
            bool ok;
            do
            {
                Console.WriteLine(msg);
                string str = Console.ReadLine();
                ok = int.TryParse(str, out so);
                if (!ok)
                {
                    Console.WriteLine(err);
                }
            } while (!ok);
            return so;
        }
        public static string InputString(string msg,string err,int minLength,int maxLength)
        {
            string str;
            bool ok;
            do
            {
                Console.WriteLine(msg);
                str = Console.ReadLine();
                ok = str.Length >= minLength && str.Length <= maxLength;
                if (!ok)
                {
                    Console.WriteLine(err);
                }
            } while (!ok);
            return str;
        }
        public static string InputNhapTen(string msg,string err,int minLength,int maxLength)
        {
            string ten = "";
            bool ok;
            string hoTen;
            do
            {
                Console.WriteLine(msg);
                hoTen = Console.ReadLine().Trim().ToLower();
                while (hoTen.Contains("  "))
                {
                    hoTen = hoTen.Replace("  ", " ");
                }
                string[] arrStr = hoTen.Split(' ');
                for (int i = 0; i < arrStr.Length; i++)
                {
                    ten += arrStr[i].First().ToString().ToUpper() + arrStr[i].Substring(1) + " ";
                }
                ok = ten.Split(' ').Length >= 2 && ten.Length <= 20;
                if (!ok)
                {
                    Console.WriteLine(err);
                }
            } while (!ok);
            return ten;
        }
        public static DateTime InputNhapNgayThang(string msg,string err)
        {
            DateTime date;
            string str;
            bool ok;
            do
            {
                Console.WriteLine(msg);
                str = Console.ReadLine();
                ok = DateTime.TryParse(str, out date);
                if (!ok)
                {
                    Console.WriteLine(err);
                }
            } while (!ok);
            return date;
        }
    }
}
