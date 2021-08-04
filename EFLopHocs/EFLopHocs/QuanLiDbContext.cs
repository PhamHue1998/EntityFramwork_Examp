using EFLopHocs.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFLopHocs
{
    class QuanLiDbContext: DbContext
    {
        public DbSet<HocSinh> HocSinhs { get; set; }
        public DbSet<Lop> Lops { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = DESKTOP-H8LIBFP\SQLEXPRESS; Database = LopHocs; integrated security = SSPI;");
        }
    }
}
