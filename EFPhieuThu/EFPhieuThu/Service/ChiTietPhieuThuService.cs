using EFPhieuThu.Entities;
using EFPhieuThu.Helper;
using EFPhieuThu.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace EFPhieuThu.Service
{
    class ChiTietPhieuThuService : IChiTietPhieuThuService
    {
        QliPhieuThu qliPhieuThu { get; }
        public ChiTietPhieuThuService()
        {
            qliPhieuThu = new QliPhieuThu();
        }
        
        public errType ThemNhieuChiTietPhieuThu(PhieuThu phieuThu)
        {
            char c;
            PhieuThu phieuThu1 = qliPhieuThu.phieuThus.SingleOrDefault(x => x.Id == phieuThu.Id);
            if (phieuThu1 == null)
            {
                return errType.KhongTonTaiPhieuThu;
            }
            else
            {
                ChiTietPhieuThu ct1 = new ChiTietPhieuThu(inputType.ThemDSChiTietChoPhieuThu);
                NguyenLieu nguyenLieu = qliPhieuThu.nguyenLieus.SingleOrDefault(x => x.Id == ct1.NguyenLieuId);
                if (nguyenLieu == null)
                {
                    return errType.KhongTonTaiNguyenLieu;
                }
                
                else
                {
                  
                    do
                    { 
                        Console.WriteLine("Them chi tiet phieu nua k? \n" +
                            "1 = y\n" +
                            "2 = n");
                        c = Console.ReadKey().KeyChar;
                        switch (c)
                        {
                            case '1':
                                {
                                    ct1.PhieuThuId = phieuThu.Id;
                                    ct1.Id = 0;
                                    qliPhieuThu.chiTietPhieus.Add(ct1);
                                    qliPhieuThu.SaveChanges();
                                    nguyenLieu.SoLuongKho = nguyenLieu.SoLuongKho - ct1.SoLuongBan;
                                    qliPhieuThu.SaveChanges();
                                    phieuThu.ThanhTien += nguyenLieu.GiaBan * ct1.SoLuongBan;
                                    qliPhieuThu.SaveChanges();
                                    errHelper.log(errType.ThanhCong);

                                    Console.ReadKey();
                                    return ThemNhieuChiTietPhieuThu(phieuThu);
                                }
                            case '2':
                                break;
                        }
                        
                    } while (c!='2');
                    return errType.ThanhCong;
                }
            }
        }
        
    }
}
