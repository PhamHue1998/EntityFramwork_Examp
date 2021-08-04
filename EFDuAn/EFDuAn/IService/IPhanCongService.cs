using EFDuAn.Entities;
using EFDuAn.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDuAn.IService
{
    interface IPhanCongService
    {
        public errType ThemNhanVienVaoDuAn(PhanCong phanCong);
    }
}
