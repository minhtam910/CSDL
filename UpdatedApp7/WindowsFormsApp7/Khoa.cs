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
    public partial class Khoa : Form
    {
        string selectedConn;/*
        string connMain = "Data Source=.\\SERVER_TTN_MAIN;Initial Catalog=QL_TTN;Integrated Security=True";
        string conn1 = "Data Source=.\\SERVER1_TTN;Initial Catalog=QL_TTN;Integrated Security=True";
        string conn2 = "Data Source=.\\SERVER_TTN2;Initial Catalog=QL_TTN;Integrated Security=True";*/
        private SqlConnection conn;
        private SqlCommand cmd;
        string tenKhoa, maKhoa, newKhoa, newMaKhoa;
        string tenLop, maLop, newLop, newMaLop;
        string MaSo, Ho, Ten, DiaChi, HocVi;
        private string maCS;
        int type = 1, haveInDb;
        DateTime NgaySinh;

        private void FillDataKhoa()
        {
            conn = new SqlConnection(selectedConn);
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                cmd = new SqlCommand("select TenKH,MaKH from Khoa", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                cbKhoa.DisplayMember = "TenKH";
                cbKhoa.ValueMember = "MaKH";
                cbKhoa.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi két nối database!");
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        private void FillDataLop(string tenKH)
        {
            conn = new SqlConnection(selectedConn);
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                SqlParameter p = new SqlParameter("@TenKH", tenKhoa);
                string select = "select TenLop,MaLop from Lop l join Khoa k on l.MaKH = k.MaKH where k.TenKH = @TenKH";
                cmd = new SqlCommand(select, conn);
                cmd.Parameters.Add(p);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                cbLop.DisplayMember = "TenLop";
                cbLop.ValueMember = "MaLop";
                cbLop.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi két nối database!");
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            tenKhoa = this.cbKhoa.GetItemText(this.cbKhoa.SelectedItem);
            FillDataLop(tenKhoa);
            maKhoa = cbKhoa.SelectedValue.ToString();
        }
        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            tenLop = this.cbLop.GetItemText(this.cbLop.SelectedItem);
            maLop = cbLop.SelectedValue.ToString();
        }
        public Khoa(String connection, string maCS)
        {
            this.selectedConn = connection;
            this.maCS = maCS;
            InitializeComponent();
            FillDataKhoa();
        }

        private void Khoa_Load(object sender, EventArgs e)
        {
            
        }

        private void CheckIsSinhVien_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckIsSinhVien.Checked == true)
                type = 0;
            if (!CheckIsSinhVien.Checked == true)
                type = 1;
            lbDegree.Visible = !lbDegree.Visible;
            txtDegree.Visible = !txtDegree.Visible;

            lbAddress.Visible = !lbAddress.Visible;
            txtAdress.Visible = !txtAdress.Visible;
            lbDate.Visible = !lbDate.Visible;
            txtBirthDay.Visible = !txtBirthDay.Visible;
        }

        private void LbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckNewKhoa_CheckedChanged(object sender, EventArgs e)
        {
            lbNewKhoa.Visible = !lbNewKhoa.Visible;          
            txtNewKhoa.Visible = !txtNewKhoa.Visible;
            lbMaKhoa.Visible = !lbMaKhoa.Visible;
            txtMaKhoa.Visible = !txtMaKhoa.Visible;
            btnAddKhoa.Visible = !btnAddKhoa.Visible;
        }

        private void CheckNewLop_CheckedChanged(object sender, EventArgs e)
        {
            lbNewLop.Visible = !lbNewLop.Visible;
            txtNewLop.Visible = !txtNewLop.Visible;
            lbMaLop.Visible = !lbMaLop.Visible;
            txtMaLop.Visible = !txtMaLop.Visible;
            btnAddLop.Visible = !btnAddLop.Visible;
        }

        private void TxtMaKhoa_TextChanged(object sender, EventArgs e)
        {
            newMaKhoa = txtMaKhoa.Text;
            if (txtMaKhoa.Text.Equals(""))
            {
                txtNewKhoa.Enabled = false;
                btnAddKhoa.Enabled = false;
            }               
            else
                txtNewKhoa.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMaSo.Enabled = true;
            txtMaSo.Text = "";
            txtHo.Text = "";
            txtAdress.Text = "";
            txtName.Text = "";
            txtDegree.Text = "";
            txtBirthDay.Text = "";
            btnDel.Enabled = false;
            btnChange.Enabled = false;
            btnCancel.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NgaySinh = Convert.ToDateTime(txtBirthDay.Text);
            conn = new SqlConnection(selectedConn);
            conn.Open();
            SqlParameter p1 = new SqlParameter("@maso", MaSo);
            SqlParameter p2 = new SqlParameter("@Ho", Ho);
            SqlParameter p3 = new SqlParameter("@Ten", Ten);
            SqlParameter p4 = new SqlParameter("@NgaySinh", NgaySinh);
            SqlParameter p5 = new SqlParameter("@DiaChi", DiaChi);
            SqlParameter p6 = new SqlParameter("@MaLop", maLop);
            SqlParameter p7 = new SqlParameter("@MaKhoa", maKhoa);
            SqlParameter p8 = new SqlParameter("@HocVi", HocVi);
            SqlParameter[] p = { p1, p2, p3, p4, p5, p6, p7, p8 };
            string insert = "";
            if (type == 0)
                 insert = "EXEC sp_CHECKTHENINSERTSINHVIEN @maso,@Ho,@Ten,@NgaySinh,@DiaChi,@MaLop";
            if (type == 1)
                insert = "EXEC sp_CHECKTHENINSERTGIAOVIEN @maso,@Ho,@Ten,@HocVi,@MaKhoa";
            cmd = new SqlCommand(insert, conn);
            cmd.Parameters.AddRange(p);
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.InsertCommand = cmd;
                da.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công");
                resetForm();

            }
            catch
            {
                MessageBox.Show("Lỗi khi thêm thông tin");
            }
        }

        private void txtBirthDay_TextChanged(object sender, EventArgs e)
        {
           // NgaySinh = Convert.ToDateTime(txtBirthDay.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(selectedConn);
            conn.Open();
            string select = "";
            SqlParameter p1 = new SqlParameter("@ms", MaSo);
            if (type == 0)
                select = "EXEC sp_CHECKIFSINHVIENEXIST @ms";
            if (type == 1)
                select = "EXEC sp_CHECKIFGIAOVIENEXIST @ms";
            cmd = new SqlCommand(select, conn);
            cmd.Parameters.Add(p1);
            /*
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string str = dt.Rows[0][0].ToString();*/
            string result = Convert.ToString(cmd.ExecuteScalar());
            haveInDb = Int32.Parse(result);
            if (haveInDb == 0)
            {
                MessageBox.Show("Chưa có thông tin trong database, điền đầy đủ thông tin để thêm mới");
                btnAdd.Enabled = true;  
            }
                        
            if (haveInDb == 1)
            {
                SqlParameter p2 = new SqlParameter("@ms", MaSo);
                if (type == 0)
                {
                    select = "select * from SinhVien s join Lop l on s.MaLop = l.MaLop join Khoa k on k.MaKH = l.MaKH where MaSV like @ms";
                    cmd = new SqlCommand(select, conn);
                    cmd.Parameters.Add(p2);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            txtHo.Text = (reader["Ho"].ToString());
                            txtName.Text = (reader["Ten"].ToString());
                            txtAdress.Text = (reader["DiaChi"].ToString());
                            string bd = (reader["NgaySinh"].ToString());
                            string[] str2 = bd.Split();
                            txtBirthDay.Text = str2[0];
                            string tenLopLoadDb = (reader["TenLop"].ToString());
                            string tenKhoaLoadDb = (reader["TenKH"].ToString());
                            try
                            {
                                cbKhoa.SelectedIndex = cbKhoa.FindStringExact(tenKhoaLoadDb);
                                cbLop.SelectedIndex = cbLop.FindStringExact(tenLopLoadDb);
                                btnDel.Enabled = true;
                                btnChange.Enabled = true;
                                txtMaSo.Enabled = false;
                                btnCancel.Visible = true;
                            }
                            catch
                            {
                                MessageBox.Show("Sinh viên bạn tìm kiếm không có ở cơ sở này");
                                txtHo.Text = "";
                                txtName.Text = "";
                                txtAdress.Text ="";
                                txtBirthDay.Text = "";
                                txtMaSo.Text = "";
                                cbKhoa.SelectedIndex = 0;
                                cbLop.SelectedIndex = 0;
                            }
                        }
                    }
                }
                if(type == 1)
                {
                    select = "select * from Giaovien g join Khoa k on g.MaKH = k.MaKH where MaGV like @ms";
                    cmd = new SqlCommand(select, conn);
                    cmd.Parameters.Add(p2);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            txtHo.Text = (reader["Ho"].ToString());
                            txtName.Text = (reader["Ten"].ToString());
                            txtDegree.Text = (reader["HocVi"].ToString());
                            string tenKhoaLoadDb = (reader["TenKH"].ToString());
                            try
                            {
                                cbKhoa.SelectedIndex = cbKhoa.FindStringExact(tenKhoaLoadDb);
                                cbLop.SelectedIndex = 0;
                                btnDel.Enabled = true;
                                btnChange.Enabled = true;
                                btnCancel.Visible = true;
                                txtMaSo.Enabled = false;
                                btnCancel.Visible = true;
                            }
                            catch
                            {
                                MessageBox.Show("Giáo viên bạn tìm kiếm không có ở cơ sở này");
                                txtHo.Text = "";
                                txtName.Text = "";
                                txtDegree.Text = "";
                                txtMaSo.Text = "";
                                cbKhoa.SelectedIndex = 0;
                                cbLop.SelectedIndex = 0;
                            }
                        }
                    }
                }
            }
            
            conn.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(selectedConn);
            conn.Open();
            SqlParameter p1 = new SqlParameter("@maso", MaSo);
            string delete = "";
            if (type == 0)
                delete = "EXEC sp_DELSINHVIEN @maso";
            if (type == 1)
                delete = "EXEC sp_DELGIAOVIEN @maso";
            cmd = new SqlCommand(delete, conn);
            cmd.Parameters.Add(p1);
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
                MessageBox.Show("Lỗi trong quá trình xóa");
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            NgaySinh = Convert.ToDateTime(txtBirthDay.Text);
            conn = new SqlConnection(selectedConn);
            conn.Open();
            string update = "";
            SqlParameter p1 = new SqlParameter("@maso", MaSo);
            SqlParameter p2 = new SqlParameter("@Ho", Ho);
            SqlParameter p3 = new SqlParameter("@Ten", Ten);
            SqlParameter p4 = new SqlParameter("@HocVi", HocVi);
            SqlParameter p5 = new SqlParameter("@NgaySinh", NgaySinh);
            SqlParameter p6 = new SqlParameter("@DiaChi", DiaChi);
            SqlParameter p7 = new SqlParameter("@MaLop", maLop);
            SqlParameter p8 = new SqlParameter("@MaKH", maKhoa);
            SqlParameter[] p = { p1, p2, p3, p4, p5, p6, p7, p8 };
            if (type == 0)
            {
                update = "EXEC sp_UPDATEINFO 0,@maso,@Ho,@Ten,@HocVi,@NgaySinh,@DiaChi,@Malop,@MaKH";
            }
            if (type == 1)
            {
                update = "EXEC sp_UPDATEINFO 1,@maso,@Ho,@Ten,@HocVi,@NgaySinh,@DiaChi,@Malop,@MaKH";
            }
            cmd = new SqlCommand(update, conn);
            cmd.Parameters.AddRange(p);
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.InsertCommand = cmd;
                da.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Chỉnh sửa thành công");
                resetForm();

            }
            catch
            {
                MessageBox.Show("Lỗi khi sửa thông tin");
            }

        }

        private void btnAddKhoa_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(selectedConn);
            conn.Open();
            SqlParameter p1 = new SqlParameter("@MaKH", newMaKhoa);
            SqlParameter p2 = new SqlParameter("@TenKH", newKhoa);
            SqlParameter p3 = new SqlParameter("@MaCS", maCS);
            SqlParameter[] p = { p1, p2, p3 };
            string insert = "EXEC sp_CHECKTHENINSERTKHOA @MaKH, @TenKH, @MaCS";
            cmd = new SqlCommand(insert, conn);
            cmd.Parameters.AddRange(p);
            SqlDataAdapter da = new SqlDataAdapter();
            da.InsertCommand = cmd;
            da.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("Thêm thành công");
            FillDataKhoa();
            txtMaKhoa.Text = "";
            txtNewKhoa.Text = "";
            CheckNewKhoa.Checked = false;
        }

        private void btnAddLop_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(selectedConn);
            conn.Open();
            SqlParameter p1 = new SqlParameter("@MaLop", newMaLop);
            SqlParameter p2 = new SqlParameter("@TenLop", newLop);
            SqlParameter p3 = new SqlParameter("@MaKH", maKhoa);
            SqlParameter[] p = { p1, p2, p3 };
            string insert = "EXEC sp_CHECKTHENINSERTLOP @MaLop, @TenLop, @MaKH";
            cmd = new SqlCommand(insert, conn);
            cmd.Parameters.AddRange(p);
            SqlDataAdapter da = new SqlDataAdapter();
            da.InsertCommand = cmd;
            da.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("Thêm thành công");
            FillDataKhoa();
            txtMaLop.Text = "";
            txtNewLop.Text = "";
            checkNewLop.Checked = false;
        }

        private void txtHo_TextChanged(object sender, EventArgs e)
        {
            Ho = txtHo.Text;
        }

        private void txtAdress_TextChanged(object sender, EventArgs e)
        {
            DiaChi = txtAdress.Text;
        }

        private void txtDegree_TextChanged(object sender, EventArgs e)
        {
            HocVi = txtDegree.Text;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            Ten = txtName.Text;
        }

        private void TxtMaLop_TextChanged(object sender, EventArgs e)
        {
            newMaLop = txtMaLop.Text;
            if (txtMaLop.Text.Equals(""))
            {
                txtNewLop.Enabled = false;
                btnAddLop.Enabled = false;
            }   
            else
                txtNewLop.Enabled = true;
        }

        private void TxtNewKhoa_TextChanged(object sender, EventArgs e)
        {
            newKhoa = txtNewKhoa.Text;
            if (txtNewKhoa.Text.Equals(""))
                btnAddKhoa.Enabled = false;
            else
                btnAddKhoa.Enabled = true;
        }

        private void TxtNewLop_TextChanged(object sender, EventArgs e)
        {
            newLop = txtNewLop.Text;
            if (txtNewLop.Text.Equals(""))
                btnAddLop.Enabled = false;
            else
                btnAddLop.Enabled = true;
        }

        private void TxtMaSo_TextChanged(object sender, EventArgs e)
        {
            if (txtMaSo.Text.Equals(""))
            {
                btnSearch.Enabled = false;
            }
            if (!txtMaSo.Text.Equals(""))
            {
                btnSearch.Enabled = true;
            }
            MaSo = txtMaSo.Text;
        }
        private void resetForm()
        {
            txtMaSo.Enabled = true;
            txtMaSo.Text = "";
            txtHo.Text = "";
            txtAdress.Text = "";
            txtName.Text = "";
            txtDegree.Text = "";
            txtBirthDay.Text = "";
            btnSearch.Enabled = true;
            btnAdd.Enabled = false;
            btnDel.Enabled = false;
            btnChange.Enabled = false;
            btnCancel.Visible = false;
        }
    }
}
