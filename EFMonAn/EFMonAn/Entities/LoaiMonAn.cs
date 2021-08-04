using EFMonAn.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFMonAn.Entities
{
    class LoaiMonAn
    {
        public int Id { get; set; }
        public string TenLoai { get; set; }
        public string MoTa { get; set; }
        public virtual IEnumerable<MonAn> MonAns { get; set; }
        public LoaiMonAn()
        {

        }
        public LoaiMonAn(inputType inputType)
        {
            if (inputType == inputType.XoaMotLoaiMonAn)
            {
                Id = inputHelper.InputInt("Nhap ma Id loai mon an can xoa: ", "Loi");
            }
        }
    }
}
