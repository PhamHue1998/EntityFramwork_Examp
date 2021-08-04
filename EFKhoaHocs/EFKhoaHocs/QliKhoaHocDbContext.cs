using EFKhoaHocs.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFKhoaHocs
{
    class QliKhoaHocDbContext:DbContext
    {
        public DbSet<NgayHoc> ngayHocs { get; set; }
        public DbSet<KhoaHoc> KhoaHocs { get; set; }
        public DbSet<HocVien> hocViens { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source= DESKTOP-H8LIBFP\\SQLEXPRESS;initial catalog = EFKhoaHoc; integrated security = sspi");
        }
    }
}
