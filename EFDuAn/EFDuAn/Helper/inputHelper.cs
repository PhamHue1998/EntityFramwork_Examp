using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFDuAn.Helper
{
    enum inputType
    {
        ThemNhanVien,ThemNhanVienVaoDuAn,SuaDuAn,XoaNhanVien,TinhLuong
    }
    class inputHelper
    {
        public static int InputInt(string msg, string err, int minValue = int.MinValue, int maxValue = int.MaxValue)
        {
            int ret;
            bool ok;
            do
            {
                Console.Write(msg);
                string str = Console.ReadLine();
                ok = int.TryParse(str, out ret);
                if (!ok)
                {
                    Console.WriteLine(err);
                }
            } while (!ok);
            return ret;
        }
        public static string InputString(string msg, string err, int minLenght, int maxLength)
        {
            string str;
            bool ok;
            do
            {
                Console.Write(msg);
                str = Console.ReadLine();
                ok = str.Length >= minLenght && str.Length <= maxLength;

                if (!ok)
                {
                    Console.WriteLine(err);
                }
            } while (!ok);
            return str;
        }
        public static string NhapTen(string msg, string err)
        {
            string name = "";
            bool ok;
            string hoTen;
            do
            {
                Console.Write(msg);
                hoTen = Console.ReadLine().Trim().ToLower();
                while (hoTen.Contains("  "))
                {
                    hoTen = hoTen.Replace("  ", " ");
                }
                string[] arrStr = hoTen.Split(' ');
                for (int i = 0; i < arrStr.Length; i++)
                {
                    name += arrStr[i].First().ToString().ToUpper() + arrStr[i].Substring(1) + " ";
                }
                ok = name.Split(' ').Length >= 2 && name.Length <= 20;
                if (!ok)
                {
                    Console.WriteLine(err);
                }
            } while (!ok);
            return name;
        }
    }
}
