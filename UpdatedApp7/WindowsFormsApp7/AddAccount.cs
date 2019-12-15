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
        string username, pass;

        private void CheckTruong_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTruong.Checked == true)
            {
                checkCS1.Checked = false;
                checkCS2.Checked = false;
                checkGV.Checked = false;
                checkSV.Checked = false;
                tag = 0;
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
            }
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
            }

        }

        int tag = -1;
        public AddAccount(String selectedConn, string maCS)
        {
            this.selectedConn = selectedConn;
            this.maCS = maCS;
            InitializeComponent();
        }
    }
}
