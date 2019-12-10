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
    public partial class PreExamForm : Form
    {
        public PreExamForm()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnStartExam_Click(object sender, EventArgs e)
        {
            ExamScreen exam = new ExamScreen();
            this.Hide();
            exam.ShowDialog();
        }
    }
}
