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
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void BtnKhoa_Click(object sender, EventArgs e)
        {
            /*Khoa khoa = new Khoa();
            this.Hide();
            khoa.ShowDialog();*/
        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            Subject subject = new Subject();
            this.Hide();
            subject.ShowDialog();
        }
    }
}
