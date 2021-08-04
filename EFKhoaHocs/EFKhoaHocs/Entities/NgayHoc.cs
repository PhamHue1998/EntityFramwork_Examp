using System;
using System.Collections.Generic;
using System.Text;

namespace EFKhoaHocs.Entities
{
    class NgayHoc
    {
        public int Id { get; set; }
        public int KhoaHocID { get; set; }
        public string NoiDung { get; set; }
        public string GhiChu { get; set; }
        public virtual KhoaHoc KhoaHoc { get; set; }
        public NgayHoc()
        {

        }
    }
}
