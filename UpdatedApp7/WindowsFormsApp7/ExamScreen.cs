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
    public partial class ExamScreen : Form
    {
        public ExamScreen()
        {
            InitializeComponent();
        }

        private void BtnHandin_Click(object sender, EventArgs e)
        {
            ReviewForm rvf = new ReviewForm();
            this.Hide();
            rvf.ShowDialog();
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
