using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DoanhThuBLL
    {
        DoanhThuDAL doanhThuDAL;
        public DoanhThuBLL()
        {
            doanhThuDAL = new DoanhThuDAL();
        }
        public DataTable GetDoanhThu(DateTime tuNgay, DateTime denNgay)
        {
            return doanhThuDAL.GetDoanhThu(tuNgay, denNgay);
        }
        public string TongTienDT(DateTime tuNgay, DateTime denNgay)
        {
            return doanhThuDAL.TongTienDT(tuNgay, denNgay);
        }
    }
}
