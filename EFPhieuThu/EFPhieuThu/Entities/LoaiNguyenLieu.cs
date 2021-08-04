using System;
using System.Collections.Generic;
using System.Text;

namespace EFPhieuThu.Entities
{
    class LoaiNguyenLieu
    {
        public int Id { get; set; }
        public string TenLoaiNguyenLieu { get; set; }
        public string MoTa { get; set; }
        public virtual IEnumerable<NguyenLieu> NguyenLieus { get; set; }
        public LoaiNguyenLieu()
        {

        }
    }
}
