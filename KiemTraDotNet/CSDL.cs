using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace KiemTraDotNet
{
    class CSDL
    {
        public DataTable DSSV { get; set; }
        public DataTable SVDH { get; set; }
        public DataTable SVCD { get; set; }
        public DataTable SVBH { get; set; }
        private static CSDL _instance;
        public static CSDL Instance
        {
            get
            {
                if (_instance == null) _instance = new CSDL();
                return _instance;
            }
            private set { }
        }
        private CSDL()
        {
            DSSV = new DataTable();

            DSSV.Columns.AddRange(new DataColumn[]
                {
                    new DataColumn("MSSV", typeof(int)),
                    new DataColumn("HoTen", typeof(string)),
                    new DataColumn("DiaChi", typeof(string)),
                    new DataColumn("DienThoai", typeof(string)),
                    new DataColumn("NgaySinh", typeof(DateTime)),
                    new DataColumn("NienKhoa", typeof(string))
                });
            //Day la sinh vien dai hoc
            DataRow drsv1 = DSSV.NewRow();
            drsv1["MSSV"] = 101;
            drsv1["HoTen"] = "NVA";
            drsv1["DiaChi"] = "Trung Nu Vuong";
            drsv1["NgaySinh"] = new DateTime(2001, 8, 2);
            drsv1["NienKhoa"] = "2018-2022";
            DSSV.Rows.Add(drsv1);

            DataRow drsv2 = DSSV.NewRow();
            drsv2["MSSV"] = 102;
            drsv2["HoTen"] = "NVB";
            drsv2["DiaChi"] = "Hoang Dieu";
            drsv2["NgaySinh"] = new DateTime(2001, 1, 1);
            drsv2["NienKhoa"] = "2020-2024";
            DSSV.Rows.Add(drsv2);

            DataRow drsv3 = DSSV.NewRow();
            drsv3["MSSV"] = 103;
            drsv3["HoTen"] = "NVC";
            drsv3["DiaChi"] = "Trung Nu Vuong";
            drsv3["NgaySinh"] = new DateTime(2001, 8, 2);
            drsv3["NienKhoa"] = "2018-2022";
            DSSV.Rows.Add(drsv3);

            DataRow drsv4 = DSSV.NewRow();
            drsv4["MSSV"] = 104;
            drsv4["HoTen"] = "NVD";
            drsv4["DiaChi"] = "Hoang Dieu";
            drsv4["NgaySinh"] = new DateTime(2001, 1, 1);
            drsv4["NienKhoa"] = "2020-2024";
            DSSV.Rows.Add(drsv4);

            //day la sinh vien bang hai
            DataRow drsv5 = DSSV.NewRow();
            drsv5["MSSV"] = 105;
            drsv5["HoTen"] = "NVE";
            drsv5["DiaChi"] = "Trung Nu Vuong";
            drsv5["NgaySinh"] = new DateTime(2001, 8, 2);
            drsv5["NienKhoa"] = "2018-2022";
            DSSV.Rows.Add(drsv5);

            DataRow drsv6 = DSSV.NewRow();
            drsv6["MSSV"] = 106;
            drsv6["HoTen"] = "NVF";
            drsv6["DiaChi"] = "Hoang Dieu";
            drsv6["NgaySinh"] = new DateTime(2001, 1, 1);
            drsv6["NienKhoa"] = "2020-2024";
            DSSV.Rows.Add(drsv6);

            //day la sinh vien cao dang
            DataRow drsv7 = DSSV.NewRow();
            drsv7["MSSV"] = 107;
            drsv7["HoTen"] = "NVG";
            drsv7["DiaChi"] = "Hoang Dieu";
            drsv7["NgaySinh"] = new DateTime(2001, 1, 1);
            drsv7["NienKhoa"] = "2020-2024";
            DSSV.Rows.Add(drsv7);

            //day la cac chuyen nganh dai hoc
            SVDH = new DataTable();
            SVDH.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("MSSV", typeof(int)),
                new DataColumn("ChuyenNganh", typeof(string))
            });

            DataRow drdh = SVDH.NewRow();
            drdh["MSSV"] = 101;
            drdh["ChuyenNganh"] = "CNPM";
            SVDH.Rows.Add(drdh);

            DataRow drdh1 = SVDH.NewRow();
            drdh1["MSSV"] = 102;
            drdh1["ChuyenNganh"] = "HTTT";
            SVDH.Rows.Add(drdh1);

            DataRow drdh3 = SVDH.NewRow();
            drdh3["MSSV"] = 103;
            drdh3["ChuyenNganh"] = "Mang May Tinh";
            SVDH.Rows.Add(drdh3);

            DataRow drdh4 = SVDH.NewRow();
            drdh4["MSSV"] = 104;
            drdh4["ChuyenNganh"] = "He thong nhung";
            SVDH.Rows.Add(drdh4);

            //day la bang hai
            SVBH = new DataTable();
            SVBH.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("MSSV", typeof(int)),
                new DataColumn("Bang1", typeof(string)),
                new DataColumn("DonVi", typeof(string))
            });
            DataRow drbh1 = SVBH.NewRow();
            drbh1["MSSV"] = 105;
            drbh1["Bang1"] = "Bang 1 lan 1";
            drbh1["DonVi"] = "Bach Khoa";
            SVBH.Rows.Add(drbh1);

            DataRow drbh2 = SVBH.NewRow();
            drbh2["MSSV"] = 105;
            drbh2["Bang1"] = "Bang 1 lan 2";
            drbh2["DonVi"] = "Su Pham";
            SVBH.Rows.Add(drbh2);

            //day la cao dang
            SVCD = new DataTable();
            SVCD.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("MSSV", typeof(int))
            });
            DataRow drcd1 = SVCD.NewRow();
            drcd1["MSSV"] = 105;
            SVCD.Rows.Add(drcd1);

            DataRow drcd2 = SVCD.NewRow();
            drcd2["MSSV"] = 105;
            SVCD.Rows.Add(drcd2);
        }
        public void EditDataRowSV(SinhVien s)
        { }
        public void AddDataRowSV(SinhVien s)
        {
            DataRow dr = DSSV.NewRow();
            dr["MSSV"] = s.MSSV;
            dr["HoTen"] = s.HoTen;
            dr["DiaChi"] = s.DiaChi;
            dr["DienThoai"] = s.DienThoai;
            dr["NgaySinh"] = Convert.ToDateTime(s.NgaySinh);
            dr["NienKhoa"] = s.NienKhoa;
            DSSV.Rows.Add(dr);
        }
        public void DeleteDataRowSV(string MSSV)
        { }
        public void SortSV(string Sort)
        { }
    }
}
