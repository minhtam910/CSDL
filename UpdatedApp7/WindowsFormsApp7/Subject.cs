using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp7
{
    public partial class Subject : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string selectedConn, maCS;
        string maMH, tenMH;
        public Subject(String conn, string maCS)
        {
            this.selectedConn = conn;
            this.maCS = maCS;
            InitializeComponent();
            FillData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(!txtMaMon.Text.Equals(""))
            {
                try
                {
                    conn = new SqlConnection(selectedConn);
                    conn.Open();
                    SqlParameter p = new SqlParameter("@MaMH", maMH);
                    string select = "select MaMH, TenMH from MonHoc where MaMH = @MaMH";
                    cmd = new SqlCommand(select, conn);
                    cmd.Parameters.Add(p);
                    var dataAdapter = new SqlDataAdapter(cmd);
                    var commandBuilder = new SqlCommandBuilder(dataAdapter);
                    var ds = new DataSet();
                    dataAdapter.Fill(ds);
                    dataMonHoc.ReadOnly = true;
                    dataMonHoc.DataSource = ds.Tables[0];
                }
                catch
                {
                    MessageBox.Show("Lỗi trong quá trình tìm kiếm!");
                }
            }
            else
                MessageBox.Show("Nhập mã môn học để tìm kiếm!");


        }

        private void txtMaMon_TextChanged(object sender, EventArgs e)
        {
            if (txtMaMon.Text.Equals("") || txtTenMon.Text.Equals(""))
                btnAdd.Enabled = false;
            else
                btnAdd.Enabled = true;
            maMH = txtMaMon.Text;
        }

        private void txtTenMon_TextChanged(object sender, EventArgs e)
        {
            tenMH = txtTenMon.Text;
        }

        private void dataMonHoc_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataMonHoc.SelectedRows)
            {
                tenMH = row.Cells[1].Value.ToString();
                maMH = row.Cells[0].Value.ToString();
            }
        }
        private void resetForm()
        {
            txtMaMon.Text = "";
            txtTenMon.Text = "";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(selectedConn);
            conn.Open();
            SqlParameter p1 = new SqlParameter("@MaMH", maMH);
            SqlParameter p2 = new SqlParameter("@TenMH", tenMH);
            SqlParameter[] p = { p1, p2 };
            string insert = "EXEC sp_CHECKTHENINSERTMONHOC @MaMH,@TenMH";
            cmd = new SqlCommand(insert, conn);
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.InsertCommand = cmd;
                da.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công");
                cmd.Parameters.AddRange(p);
                resetForm();
            }
            catch
            {
                MessageBox.Show("Lỗi khi thêm!");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(selectedConn);
            conn.Open();
            SqlParameter p = new SqlParameter("@MaMH", maMH);
            string del = "exec sp_DELMONHOC @MaMH";
            cmd = new SqlCommand(del, conn);
            cmd.Parameters.Add(p);
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.InsertCommand = cmd;
                da.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
                resetForm();

            }
            catch
            {
                MessageBox.Show("Lỗi khi xóa thông tin");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        void FillData()
        {
            conn = new SqlConnection(selectedConn);
            conn.Open();
            string select = "select MaMH, TenMH from MonHoc";
            cmd = new SqlCommand(select, conn);
            var dataAdapter = new SqlDataAdapter(cmd);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataMonHoc.ReadOnly = true;
            dataMonHoc.DataSource = ds.Tables[0];
        }
    }
}
