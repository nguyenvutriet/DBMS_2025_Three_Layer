using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DanhMucBLL
    {
        readonly  DanhMucDAL danhMucDAL;
        public DanhMucBLL()
        {
            danhMucDAL = new DanhMucDAL();
        }
        public DataTable View_DoanhThu()
        {
            return danhMucDAL.View_DoanhThu();
        }
        public DataTable View_SanPham()
        {
            return danhMucDAL.View_SanPham();
        }
        public DataTable View_NhaCungCap()
        {
            return danhMucDAL.View_NhaCungCap();
        }
        public DataTable View_KhuyenMai()
        {
            return danhMucDAL.View_KhuyenMai();
        }
        public DataTable View_TaiKhoan()
        {
            return danhMucDAL.View_TaiKhoan();
        }
    }
}
