using EFDuAn.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDuAn
{
    class QuanLiDuAnDbContext: DbContext
    {
        public DbSet<DuAn> duAns { get; set; }
        public DbSet<NhanVien> nhanViens { get; set; }
        public DbSet<PhanCong> phanCongs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = DESKTOP-H8LIBFP\\SQLEXPRESS;initial catalog = EFDuAn; integrated security=sspi;");
        }
    }
}
