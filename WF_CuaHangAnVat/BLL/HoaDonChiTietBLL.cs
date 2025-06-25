using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HoaDonChiTietBLL
    {
        HoaDonChiTietDAL hoaDonChiTietDAL;
        public HoaDonChiTietBLL()
        {
            hoaDonChiTietDAL = new HoaDonChiTietDAL();
        }
        public bool ThemHoaDonChiTiet(string masp, string madon, int soluong, double thanhtien)
        {
            return hoaDonChiTietDAL.ThemHDChiTiet(masp, madon, soluong, thanhtien);
        }
        public DataTable LayThongTinCTHD(string madon)
        {
            return hoaDonChiTietDAL.LayTTChiTiet(madon);
        }
        public bool XoaHDChiTiet(string masp, string madon)
        {
            return hoaDonChiTietDAL.XoaHDChiTiet(masp, madon);
        }
        public bool CapNhatHDChiTiet(string maspCU, string madon, int soluong, double thanhtien, string maspnew)
        {
            return hoaDonChiTietDAL.CapNhatHDChiTiet(maspCU, madon, soluong, thanhtien, maspnew);
        }
    }
}
