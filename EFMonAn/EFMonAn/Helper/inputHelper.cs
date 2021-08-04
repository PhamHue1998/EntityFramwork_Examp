using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFMonAn.Helper
{
    enum inputType
    {
        ThemMonAn,
        ThemCtMonAn,
        XoaMotLoaiMonAn,
        ThemCT,
        TimKiemMonAnTheoTenVaNgLieu
    }
    class inputHelper
    {
       public static int InputInt(string msg, string err, int minValue=int.MinValue,int maxValue = int.MaxValue)
        {
            int so;
            bool ok;
            do
            {
                Console.WriteLine(msg);
                string str = Console.ReadLine();
                ok = int.TryParse(str, out so);
                ok = ok && so >= minValue && so <= maxValue;
                if (!ok)
                {
                    Console.WriteLine(err);
                }
            } while (!ok);
            return so;
        }
        public static string InputString(string msg,string err,int minLength=int.MinValue,int maxlength = int.MaxValue)
        {
            string str;
            bool ok;
            do
            {
                Console.WriteLine(msg);
                str = Console.ReadLine();
                ok = str.Length >= minLength && str.Length <= maxlength;
                if (!ok)
                {
                    Console.WriteLine(err);
                }
            } while (!ok);
            return str;
        }
        public static string InputNhapTen(string msg,string err)
        {
            string str;
            string ten = "";
            bool ok;
            do
            {
                Console.WriteLine(msg);
                str = Console.ReadLine().Trim().ToLower();
                while (str.Contains("  "))
                {
                    str = str.Replace("  ", " ");
                }
                string[] arrStr = str.Split(' ');
                for (int i = 0; i < arrStr.Length; i++)
                {
                    ten += arrStr[i].First().ToString().ToUpper() + arrStr[i].Substring(1) + " ";
                }
                ok = ten.Length <= 20 && ten.Length >= 1;
                if (!ok)
                {
                    Console.WriteLine(err);
                }
            } while (!ok);
            return ten.Trim();
        }
    }
}
