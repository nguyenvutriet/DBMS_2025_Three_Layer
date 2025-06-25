using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SanPhamBLL
    {
        private SanPhamDAL sanPhamDAL;
        public SanPhamBLL()
        {
            sanPhamDAL = new SanPhamDAL();
        }

        public DataTable getListSanPham()
        {
            return sanPhamDAL.getListSanPham();
        }

        public bool themSanPham(string maSP, string tenSanPham, double giaBan, DateTime hanSuDung, string moTa, int soLuongSP, string maLoaiSanPham)
        {
            return sanPhamDAL.themSanPham(maSP, tenSanPham, giaBan, hanSuDung, moTa, soLuongSP, maLoaiSanPham);
        }
        public bool CapNhatSanPham(string maSP, string tenSanPham, double giaBan, DateTime hanSuDung, string moTa, int soLuongSP, string maLoaiSanPham)
        {
            return sanPhamDAL.CapNhap_SanPham(maSP, tenSanPham, giaBan, hanSuDung, moTa, soLuongSP, maLoaiSanPham);
        }
        public DataTable TimKiemSanpham(string maSP)
        {
            return sanPhamDAL.TimKiemSanPham(maSP);
        }
        public DataTable DanhSLoai_SanPham(string maLoaiSanPham)
        {
            return sanPhamDAL.DanhSachLoai_SanPham(maLoaiSanPham);
        }
        public double GiaBanSanPham(string tenSanPham)
        {
            return sanPhamDAL.GiaBan_SanPham(tenSanPham);
        }
        public bool XoaSanPham(string tenSanPham)
        {
            return sanPhamDAL.XoaSanPham(tenSanPham);
        }
        public string Laymasanpham(string tensanpham)
        {
            return sanPhamDAL.LayMaSanPham(tensanpham);
        }
        public string LayTenSanPham(string masanpham)
        {
            return sanPhamDAL.LayTenSanPham(masanpham);
        }
        public DataTable LayThongTinNCC(string maSanPham)
        {
            return sanPhamDAL.layThongTinNCC(maSanPham);
        }
    }
}
