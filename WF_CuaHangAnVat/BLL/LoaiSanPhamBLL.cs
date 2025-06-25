using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoaiSanPhamBLL
    {
        LoaiSanPhamDAL loaiSP;
        public LoaiSanPhamBLL()
        {
            loaiSP = new LoaiSanPhamDAL();
        }
        public DataTable GetList()
        {
            return loaiSP.GetListLSP();
        }
        public bool ThemLSP(string maLoaiSanPham, string tenLoaiSanPham, string maKM)
        {
            return loaiSP.themLoaiSanPham(maLoaiSanPham, tenLoaiSanPham, maKM);
        }
        public bool SuaLSP(string maLoaiSanPham, string tenLoaiSanPham, string maKM)
        {
            return loaiSP.suaLoaiSanPham(maLoaiSanPham, tenLoaiSanPham, maKM);
        }
        public bool XoaLSP(string tenLoaiSanPham)
        {
            return loaiSP.xoaLoaiSanPham(tenLoaiSanPham);
        }
        public string tenLSP(string maLSP)
        {
            return loaiSP.TenLoaiSP(maLSP);
        }
        public string maLSP(string tenlsp)
        {
            return loaiSP.maLSP(tenlsp);
        }
    }
}
