using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace KiemTraDotNet
{
    class CSDL_OOP
    {
        private static CSDL_OOP _instance;
        public static CSDL_OOP Instance
        {
            get
            {
                if (_instance == null) _instance = new CSDL_OOP();
                return _instance;
            }
            private set { }
        }
        public List<SinhVienDaiHoc> GetAllChuyenNganh()
        {
            List<SinhVienDaiHoc> data = new List<SinhVienDaiHoc>();
            foreach (DataRow i in CSDL.Instance.SVDH.Rows)
            {
                data.Add(GetChuyenNganh(i));
            }
            return data;
        }
        public SinhVienDaiHoc GetChuyenNganh(DataRow i)
        {
            return new SinhVienDaiHoc
            {
                MSSV = Convert.ToInt32(i["MSSV"].ToString()),
                ChuyenNganh = i["ChuyenNganh"].ToString()
            };
        }
    }
}
