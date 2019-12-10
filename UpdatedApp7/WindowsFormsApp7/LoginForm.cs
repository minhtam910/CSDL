 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class LoginForm : Form
    {
        string maCoSo;
        private string username;
        private string password;
        string connMain = "Data Source=.\\SERVER_TTN_MAIN;Initial Catalog=QL_TTN;Integrated Security=True";
        string conn1 = "Data Source=.\\SERVER1_TTN;Initial Catalog=QL_TTN;Integrated Security=True";
        string conn2 = "Data Source=.\\SERVER_TTN2;Initial Catalog=QL_TTN;Integrated Security=True";
        string selectedConn = "";
        private SqlConnection conn;
        private SqlCommand cmd;
        public void connectDatabase() {
            conn = new SqlConnection(conn1);
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                cmd = new SqlCommand("select TenCS,MaCS from CoSo",conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                comboBox1.DisplayMember = "TenCS";
                comboBox1.ValueMember = "MaCS";
                comboBox1.DataSource = ds.Tables[0];

            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi két nối database!");
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        public bool checkAccountExist()
        {
            bool hasAccount = true;
            conn = new SqlConnection(connMain);
            conn.Open();
            string select = "select * from Account where ID = @id and Pass = @pass";
            SqlParameter p1 = new SqlParameter("@id", username);
            SqlParameter p2 = new SqlParameter("@pass", password);
            SqlParameter[] p = { p1, p2 };
            cmd = new SqlCommand(select, conn);
            cmd.Parameters.AddRange(p);
            string result = Convert.ToString(cmd.ExecuteScalar());
            if (result.Equals(""))
                hasAccount = false;
            conn.Close();
            MessageBox.Show(" " + hasAccount);
            return hasAccount;
        }

        public void getMaCoSo()
        {
            conn = new SqlConnection(connMain);
            conn.Open();
            SqlParameter p1 = new SqlParameter("@id", username);
            string select = "select MaCoSo from Account a join UserInfo u on a.Maso = u.ID where a.ID = @id";
            cmd = new SqlCommand(select, conn);
            cmd.Parameters.Add(p1);
            string result = Convert.ToString(cmd.ExecuteScalar());
            maCoSo = result;
            MessageBox.Show(" " + maCoSo);
        }

        public LoginForm()
        {
            InitializeComponent();
            connectDatabase();
        }
        
        private void Label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            
            if(checkAccountExist())
            {
                getMaCoSo();
            }
            else
            {
                MessageBox.Show("Sai thông tin!");
            }
            Khoa khoa = new Khoa(maCoSo);
            this.Hide();
            khoa.ShowDialog();
        }

        private void check_CheckedChanged(object sender, EventArgs e)
        {
            if (check.Checked == true)
            {
                comboBox1.Enabled = true;
            }
            if (!check.Checked == true)
            {
                comboBox1.Enabled = false;
                connMain = "";
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            username = txtUsername.Text;
        }

        private void txbPassword_TextChanged(object sender, EventArgs e)
        {
            password = txtPassword.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            maCoSo = comboBox1.SelectedValue.ToString();
            if (maCoSo.Equals("CS1"))
                selectedConn = conn1;
            if (maCoSo.Equals("CS2"))
                selectedConn = conn2;
        }
    }
}
