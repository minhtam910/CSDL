using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp7
{
    public partial class Info : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string selectedConn, maCS;
        string lookingInfo = "";

        private void TxtChoose_TextChanged(object sender, EventArgs e)
        {
            lookingInfo = txtChoose.Text;
        }

        void FillData(string lookingInfo)
        {
            conn = new SqlConnection(selectedConn);
            conn.Open();
            string select = "";
            if (lookingInfo.Equals(""))
                select = "select TenCS, DiaChi from CoSo";
            if (lookingInfo.Equals("Khoa"))
                select = "select MaKH,TenKH from Khoa";
            if (lookingInfo.Equals("MonHoc"))
                select = "select MaMH,TenMH from MonHoc";
            if (lookingInfo.Equals("SinhVien"))
                select = "select * from SinhVien";
            if (lookingInfo.Equals("GiaoVien"))
                select = "select * from Giaovien";
            cmd = new SqlCommand(select, conn);
            var dataAdapter = new SqlDataAdapter(cmd);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataInfo.ReadOnly = true;
            dataInfo.DataSource = ds.Tables[0];
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            FillData(lookingInfo);
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            this.Hide();
            lg.ShowDialog();
        }

        public Info(string selectedConn, string maCS)
        {
            this.selectedConn = selectedConn;
            this.maCS = maCS;
            InitializeComponent();
            FillData("");
        }
    }
}
