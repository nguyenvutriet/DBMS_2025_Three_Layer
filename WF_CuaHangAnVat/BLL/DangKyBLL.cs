using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DangKyBLL
    {
        DangKyDAL dangKyDAL;
        public DangKyBLL()
        {
            dangKyDAL = new DangKyDAL();
        }
        public bool LuuThongTin(string hoTen, string SDT, string email, string gioiTinh, string vaiTro, string tenDangNhap, string matKhau)
        {
            return dangKyDAL.LuuThongTinTaiKhoan(hoTen, SDT, email, gioiTinh, vaiTro, tenDangNhap, matKhau);
        }
        public bool HuyThongTin(string hoTen, string SDT)
        {
            return dangKyDAL.HuyThongTin(hoTen, SDT);
        }
        public DataTable LayDanhSach()
        {
            return dangKyDAL.LayDanhSach();
        }
        public DataTable XemTK(string hoTen, string SDT)
        {
            return dangKyDAL.XemTK(hoTen, SDT);
        }
    }
}
