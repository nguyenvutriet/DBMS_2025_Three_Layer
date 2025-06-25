using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HoaDonBLL
    {
        readonly HoaDonDAL hoaDonDAL;
        public HoaDonBLL()
        {
            hoaDonDAL = new HoaDonDAL();
        }
        public DataTable GetlistHD()
        {
            return hoaDonDAL.GetListHD();
        }
        public DataTable TimKienDH(string maDon)
        {
            return hoaDonDAL.TimKiemHoaDon(maDon);
        }
        public bool ThemHD(string maDon, DateTime ngayDat, double tongTien)
        {
            return hoaDonDAL.ThemHoaDonMoi(maDon, ngayDat, tongTien);
        }
        public bool SuaHD(string maDon, DateTime ngayDat, double tongTien)
        {
            return hoaDonDAL.SuaHoaDon(maDon, ngayDat, tongTien);
        }
        public bool XoaHD(string maDon)
        {
            return hoaDonDAL.XoaHoaDon(maDon);
        }
        public DataTable XuatHD(string maDon)
        {
            return hoaDonDAL.XuatHoaDon(maDon);
        }
        public DataTable ThongTinCTHD(string maDon)
        {
            return hoaDonDAL.ThongTinChiTietCuaHoaDon(maDon);
        }
        public string TongTienHoaDonChiTiet(string maDon)
        {
            return hoaDonDAL.TongTienMotHoaDon(maDon);
        }

    }
}
