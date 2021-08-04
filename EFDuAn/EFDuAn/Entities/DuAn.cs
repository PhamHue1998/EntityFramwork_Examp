using EFDuAn.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDuAn.Entities
{
    class DuAn
    {
        public int Id { get; set; }
        public string TenDuAn { get; set; }
        public string MoTa { get; set; }
        public string GhiChu { get; set; }
        public DuAn()
        {

        }
        public virtual IEnumerable<PhanCong> PhanCongs { get; set; }
        public DuAn(inputType inputType)
        {

            if (inputType == inputType.SuaDuAn)
            {
                Id = inputHelper.InputInt("Nhap id = ", "Loi!");
                TenDuAn = inputHelper.InputString("Nhap ten du an: ", "Loi!", 1, 10);
                MoTa = inputHelper.InputString("Sua mo ta: ", "Loi!", 1, 20);
                GhiChu = inputHelper.InputString("Sua ghi chu: ", "Loi!", 1, 20);
            }
        }
    }
}
