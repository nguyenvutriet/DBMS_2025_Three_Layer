using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhuyenMaiBLL
    {
        KhuyenMaiDAL khuyenMaiDAL;
        public KhuyenMaiBLL()
        {
            khuyenMaiDAL = new KhuyenMaiDAL();
        }
        public DataTable GetList()
        {
            return khuyenMaiDAL.getListKM();
        }
        public bool ThemKM(string maKM, string tenChuongTrinh, string ngayBatDau, string ngayKetThuc)
        {
            return khuyenMaiDAL.themKhuyenMai(maKM, tenChuongTrinh, ngayBatDau, ngayKetThuc);
        }
        public bool SuaKM(string maKM, string tenChuongTrinh, string ngayBatDau, string ngayKetThuc)
        {
            return khuyenMaiDAL.suaKhuyenMai(maKM, tenChuongTrinh, ngayBatDau, ngayKetThuc);
        }
        public bool XoaKM(string tenChuongTrinh)
        {
            return khuyenMaiDAL.xoaKhuyenMai(tenChuongTrinh);
        }
        public string LayTenChuongTrinh(string maKM)
        {
            return khuyenMaiDAL.LayTenChuongTrinh(maKM);
        }
        public string LayMaKM(string tenChuongTrinh)
        {
            return khuyenMaiDAL.LayMaChuongTrinh(tenChuongTrinh);
        }
    }
}
