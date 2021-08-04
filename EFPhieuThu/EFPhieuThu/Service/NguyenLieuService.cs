using EFPhieuThu.Entities;
using EFPhieuThu.Helper;
using EFPhieuThu.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFPhieuThu.Service
{
    class NguyenLieuService : INguyenLieuService
    {
        private QliPhieuThu qliPhieuThu { get; }
        public NguyenLieuService()
        {
            qliPhieuThu = new QliPhieuThu();
        }
        public errType ThemNguyenLieu(NguyenLieu nguyenLieu)
        {
            NguyenLieu nguyenLieu1 = qliPhieuThu.nguyenLieus.SingleOrDefault(x => x.Id == nguyenLieu.Id);
            if (nguyenLieu1 != null)
            {
                return errType.DaTonTai;
            }
            else
            {
                NguyenLieu nguyenLieu2 = new NguyenLieu();
                nguyenLieu2.Id = 0;
                nguyenLieu2.LoaiNguyenLieuId = nguyenLieu.LoaiNguyenLieuId;
                nguyenLieu2.TenNguyenLieu = nguyenLieu.TenNguyenLieu;
                nguyenLieu2.GiaBan = nguyenLieu.GiaBan;
                nguyenLieu2.DonViTinh = nguyenLieu.DonViTinh;
                nguyenLieu2.SoLuongKho = nguyenLieu.SoLuongKho;
                qliPhieuThu.nguyenLieus.Add(nguyenLieu2);
                qliPhieuThu.SaveChanges();
                return errType.ThanhCong;
            }
        }
    }
}
