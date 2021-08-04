using EFDuAn.View;
using System;

namespace EFDuAn
{
    class Program
    {
        static void Main(string[] args)
        {
            DuAnView duAnView = new DuAnView();
            duAnView.Menu();
            Console.ReadKey();
        }
    }
}
