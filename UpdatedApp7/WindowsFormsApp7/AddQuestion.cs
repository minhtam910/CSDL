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
    public partial class AddQuestion : Form
    {

        //private static int givePermission = 0;
        public AddQuestion()
        {
            InitializeComponent();
        }

        private void DegreeACheck_CheckedChanged(object sender, EventArgs e)
        {
            if(DegreeACheck.Checked == true)
            {
                DegreeBCheck.Enabled = false;
                DegreeCCheck.Enabled = false;
            }
            if (!DegreeACheck.Checked == true)
            {
                DegreeBCheck.Enabled = true;
                DegreeCCheck.Enabled = true;
            }
        }

        private void DegreeCCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (DegreeCCheck.Checked == true)
            {
                DegreeBCheck.Enabled = false;
                DegreeACheck.Enabled = false;
            }
            if (!DegreeCCheck.Checked == true)
            {
                DegreeBCheck.Enabled = true;
                DegreeACheck.Enabled = true;
            }
        }

        private void DegreeBCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (DegreeBCheck.Checked == true)
            {
                DegreeACheck.Enabled = false;
                DegreeCCheck.Enabled = false;
            }
            if (!DegreeBCheck.Checked == true)
            {
                DegreeACheck.Enabled = true;
                DegreeCCheck.Enabled = true;
            }
        }

        private void AnsACheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ansACheck.Checked == true)
            {
                ansBCheck.Enabled = false;
                ansCCheck.Enabled = false;
                ansDCheck.Enabled = false;
            }
            if (!ansACheck.Checked == true)
            {
                ansBCheck.Enabled = true;
                ansCCheck.Enabled = true;
                ansDCheck.Enabled = true;
            }
        }

        private void AnsBCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ansBCheck.Checked == true)
            {
                ansACheck.Enabled = false;
                ansCCheck.Enabled = false;
                ansDCheck.Enabled = false;
            }
            if (!ansBCheck.Checked == true)
            {
                ansACheck.Enabled = true;
                ansCCheck.Enabled = true;
                ansDCheck.Enabled = true;
            }
        }

        private void AnsCCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ansCCheck.Checked == true)
            {
                ansBCheck.Enabled = false;
                ansACheck.Enabled = false;
                ansDCheck.Enabled = false;
            }
            if (!ansCCheck.Checked == true)
            {
                ansBCheck.Enabled = true;
                ansACheck.Enabled = true;
                ansDCheck.Enabled = true;
            }
        }

        private void AnsDCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ansDCheck.Checked == true)
            {
                ansBCheck.Enabled = false;
                ansCCheck.Enabled = false;
                ansACheck.Enabled = false;
            }
            if (!ansDCheck.Checked == true)
            {
                ansBCheck.Enabled = true;
                ansCCheck.Enabled = true;
                ansACheck.Enabled = true;
            }
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {

        }

        private void listMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
