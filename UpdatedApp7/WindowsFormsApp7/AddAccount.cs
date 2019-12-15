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
    public partial class AddAccount : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string selectedConn,maCS;
        string username, pass, role;
        int tag = -1;

        private void CheckTruong_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTruong.Checked == true)
            {
                checkCS1.Checked = false;
                checkCS2.Checked = false;
                checkGV.Checked = false;
                checkSV.Checked = false;
                tag = 0;
                role = "TRUONG";
            }
        }

        private void CheckCS1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCS1.Checked == true)
            {
                checkTruong.Checked = false;
                checkCS2.Checked = false;
                checkGV.Checked = false;
                checkSV.Checked = false;
                tag = 1;
                role = "COSO_X";
            }
        }

        private void CheckCS2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCS2.Checked == true)
            {
                checkCS1.Checked = false;
                checkTruong.Checked = false;
                checkGV.Checked = false;
                checkSV.Checked = false;
                tag = 2;
                role = "COSO_X";
            }
        }

        private void CheckGV_CheckedChanged(object sender, EventArgs e)
        {
            if (checkGV.Checked == true)
            {
                checkCS1.Checked = false;
                checkTruong.Checked = false;
                checkCS2.Checked = false;
                checkSV.Checked = false;
                tag = 4;
                role = "GIAOVIEN";
            }
        }

        void resetForm()
        {
            txtPass.Text = "";
            txtUsername.Text = "";
            checkCS1.Checked = false;
            checkCS2.Checked = false;
            checkTruong.Checked = false;
            checkSV.Checked = false;
            checkGV.Checked = false;
        }

        private void btn_CreateAcc_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(selectedConn);
            conn.Open();
            SqlParameter p1 = new SqlParameter("@lgname", username);
            SqlParameter p2 = new SqlParameter("@pass", pass);
            SqlParameter p3 = new SqlParameter("@username", username);
            SqlParameter p4 = new SqlParameter("@role", role);
            SqlParameter p5 = new SqlParameter("@tag", tag);
            SqlParameter[] p = { p1, p2, p3, p4, p5 };
            string insert = "EXEC sp_CREATELOGIN @lgname,@pass,@username,@role,@tag";
            cmd = new SqlCommand (insert,conn);
            cmd.Parameters.AddRange(p);
            SqlDataAdapter da = new SqlDataAdapter();
            da.InsertCommand = cmd;
            da.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("Thêm thành công");
            resetForm();

        }

        private void CheckSV_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSV.Checked == true)
            {
                checkCS1.Checked = false;
                checkTruong.Checked = false;
                checkCS2.Checked = false;
                checkGV.Checked = false;
                tag = 3;
                role = "SINHVIEN";
            }

        }

        public AddAccount(String selectedConn, string maCS)
        {
            this.selectedConn = selectedConn;
            this.maCS = maCS;
            InitializeComponent();
        }
    }
}
