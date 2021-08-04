using EFMonAn.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFMonAn
{
    class QuanLiDbContext:DbContext
    {
        public DbSet<CongThuc> congThucs { get; set; }
        public DbSet<LoaiMonAn> loaiMonAns { get; set; }
        public DbSet<MonAn> monAns { get; set; }
        public DbSet<NguyenLieu> nguyenLieus { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-H8LIBFP\\SQLEXPRESS; database=EFMonAn;integrated security =SSPI;");
        }
    }
}
