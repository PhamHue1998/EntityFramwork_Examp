using EFDuAn.Entities;
using EFDuAn.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDuAn.IService
{
    interface IDuAnService
    {
        public errType SuaThongTinDuAn(DuAn duAn);
    }
}
