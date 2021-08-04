using EFPhieuThu.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFPhieuThu
{
    class QliPhieuThu:DbContext
    {
        public DbSet<PhieuThu> phieuThus { get; set; }
        public DbSet<ChiTietPhieuThu> chiTietPhieus { get; set; }
        public DbSet<LoaiNguyenLieu> loaiNguyenLieus { get; set; }
        public DbSet<NguyenLieu> nguyenLieus { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source= DESKTOP-H8LIBFP\\SQLEXPRESS;initial catalog = EFPhieuThu; integrated security = sspi");
        }
    }
}
