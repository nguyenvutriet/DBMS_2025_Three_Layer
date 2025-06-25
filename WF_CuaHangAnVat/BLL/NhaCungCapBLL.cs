using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhaCungCapBLL
    {
        NhaCungCapDAL nhacungcapDAL;
        public NhaCungCapBLL()
        {
            nhacungcapDAL = new NhaCungCapDAL();
        }
        public DataTable getListNhaCC()
        {
            return nhacungcapDAL.GetListNCC();
        }
        public bool ThemNhaCungCap(string maNCC, string tenNCC, string diaChi, string email, string sdt)
        {
            return nhacungcapDAL.ThemNhaCungCap(maNCC, tenNCC, diaChi, email, sdt);
        }
        public bool ChinhSuaNCC(string maNCC, string tenNCC, string diaChi, string email, string sdt)
        {
            return nhacungcapDAL.ChinhSuaNhaCungCap(maNCC, tenNCC, diaChi, email, sdt);
        }
        public bool XoaNCC(string tennhacungcap)
        {
            return nhacungcapDAL.XoaNhaCungCap(tennhacungcap);
        }
        public DataTable TimKiemNCC(string maNCC)
        {
            return nhacungcapDAL.TimKiemNhaCungCap(maNCC);
        }
        public bool LienKet(string maSP, string maNCC, int soLuong)
        {
            return nhacungcapDAL.LienKet(maSP, maNCC, soLuong);
        }
        public string GetMaNCC(string tenNCC)
        {
            return nhacungcapDAL.GetMaNCC(tenNCC);
        }
    }
}
