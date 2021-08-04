using EFKhoaHocs.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFKhoaHocs.Entities
{
    class KhoaHoc
    {
        public int Id { get; set; }
        public string TenKhoaHoc { get; set; }
        public string MoTa { get; set; }
        public double HocPhi { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public virtual IEnumerable<HocVien> HocViens { get; set; }
        public KhoaHoc()
        {

        }
        public KhoaHoc(inputType inputType)
        {
            if (inputType == inputType.XoaKhoaHoc)
            {
                Id = inputHelper.InputInt("Nhap Id", "Loi");
            }
            if (inputType == inputType.DoanhThuTheoThang)
            {
                Id = inputHelper.InputInt("Nhap Id", "Loi");
            }
            if (inputType == inputType.ThemNgayHocVaoKhoaHoc)
            {
                Id = inputHelper.InputInt("Nhap Id", "Loi");
            }
        }

    }
}
