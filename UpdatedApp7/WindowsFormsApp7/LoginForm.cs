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
        int tag = -1;
        string connMain = "Data Source=.\\SERVER_TTN_MAIN;Initial Catalog=QL_TTN;Integrated Security=True";
        string conn1 = "Data Source=.\\SERVER1_TTN;Initial Catalog=QL_TTN;Integrated Security=True";
        //string conn2 = "Data Source=.\\SERVER_TTN2;Initial Catalog=QL_TTN;Integrated Security=True";
        string conn2 = "Data Source=DESKTOP-05IJJ0L\\SERVER_TTN2;Initial Catalog=QL_TTN;User ID=sa";
        //string conn2 = "Data Source=DESKTOP-05IJJ0L;UID=sa;PWD=123456789;Initial Catalog=QL_TTN";
        string selectedConn = "Data Source=.\\;Initial Catalog=QL_TTN;Integrated Security=True";
        private SqlConnection conn;
        private SqlCommand cmd;

        //Fill comboBox Cơ sở
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
            bool hasAccount = false;
            conn = new SqlConnection(connMain);
            conn.Open();
            string select = "select * from Account where id = @id and pass = @pass";
            SqlParameter p1 = new SqlParameter("@id", username);
            SqlParameter p2 = new SqlParameter("@pass", password);
            SqlParameter[] p = { p1, p2 };
            cmd = new SqlCommand(select, conn);
            cmd.Parameters.AddRange(p);
            string result = Convert.ToString(cmd.ExecuteScalar());
            if (!result.Equals(""))
                hasAccount = true;
            conn.Close();
            return hasAccount;
        }

        public void getTag()
        {
            conn = new SqlConnection(connMain);
            conn.Open();
            SqlParameter p1 = new SqlParameter("@id", username);
            string select = "select tag from Account where ID = @id";
            cmd = new SqlCommand(select, conn);
            cmd.Parameters.Add(p1);
            string result = Convert.ToString(cmd.ExecuteScalar());
            tag = Int32.Parse(result);          
        }

        public void getMaCoSo()
        {
            string select = "";
            if (tag == 3) //Sinh viên
                select = "select k.MaCS from Account a join ((SinhVien s join Lop l on s.MaLop = l.MaLop) join Khoa k on k.MaKH = l.MaKH) on s.MaSV = a.id where s.MaSV = @id";
            if (tag == 4) //Giáo viên
                select = "select k.MaCS from Account a join (Giaovien g join Khoa k on k.MaKH = g.MaKH) on g.MaGV = a.id where g.MaGV = @id";
            conn = new SqlConnection(connMain);
            conn.Open();
            SqlParameter p1 = new SqlParameter("@id", username);
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
                getTag();
                if (tag == 0) //role TRUONG, thì set conntion tùy thuộc cái comboBox người ta chọn
                {

                }
                if (tag == 1) //role CS1, set conn = conn1
                {
                    selectedConn = conn1;
                    Khoa khoa = new Khoa(selectedConn,maCoSo);
                    this.Hide();
                    khoa.ShowDialog();
                }
                if (tag == 2) //role CS2, set conn = conn2
                {
                    selectedConn = conn2;
                    Khoa khoa = new Khoa(selectedConn,maCoSo);
                    this.Hide();
                    khoa.ShowDialog();
                }
                if (tag == 3 || tag == 4)
                {
                    getMaCoSo();
                    if (maCoSo.Equals("CS1"))
                        selectedConn = conn1;
                    else if (maCoSo.Equals("CS2"))
                        selectedConn = conn2;
                }
                    
            }
            else
            {
                MessageBox.Show("Sai thông tin!");
            }
            
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
                selectedConn = "";
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
