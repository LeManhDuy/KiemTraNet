using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTraDotNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getCBB();
        }
        public void getCBB()
        {
            foreach (SinhVienDaiHoc i in CSDL_OOP.Instance.GetAllChuyenNganh())
            {
                cbbUni.Items.Add(new CBBItem
                {
                    Value = i.MSSV,
                    Text = i.ChuyenNganh
                });
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
