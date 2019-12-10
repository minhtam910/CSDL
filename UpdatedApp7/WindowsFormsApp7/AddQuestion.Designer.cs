namespace WindowsFormsApp7
{
    partial class AddQuestion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listMonHoc = new System.Windows.Forms.ListView();
            this.DegreeACheck = new System.Windows.Forms.CheckBox();
            this.DegreeCCheck = new System.Windows.Forms.CheckBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.ansCCheck = new System.Windows.Forms.CheckBox();
            this.ansBCheck = new System.Windows.Forms.CheckBox();
            this.ansACheck = new System.Windows.Forms.CheckBox();
            this.ansDCheck = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.DegreeBCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã môn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trình độ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nội dung câu hỏi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đáp án A:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 174);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Đáp án B:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 216);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Đáp án C:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 260);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Đáp án D:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 304);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Đáp án đúng:";
            // 
            // listMonHoc
            // 
            this.listMonHoc.Location = new System.Drawing.Point(66, 30);
            this.listMonHoc.Margin = new System.Windows.Forms.Padding(2);
            this.listMonHoc.Name = "listMonHoc";
            this.listMonHoc.Size = new System.Drawing.Size(187, 22);
            this.listMonHoc.TabIndex = 8;
            this.listMonHoc.UseCompatibleStateImageBehavior = false;
            this.listMonHoc.SelectedIndexChanged += new System.EventHandler(this.listMonHoc_SelectedIndexChanged);
            // 
            // DegreeACheck
            // 
            this.DegreeACheck.AutoSize = true;
            this.DegreeACheck.Location = new System.Drawing.Point(68, 58);
            this.DegreeACheck.Margin = new System.Windows.Forms.Padding(2);
            this.DegreeACheck.Name = "DegreeACheck";
            this.DegreeACheck.Size = new System.Drawing.Size(33, 17);
            this.DegreeACheck.TabIndex = 9;
            this.DegreeACheck.Text = "A";
            this.DegreeACheck.UseVisualStyleBackColor = true;
            this.DegreeACheck.CheckedChanged += new System.EventHandler(this.DegreeACheck_CheckedChanged);
            // 
            // DegreeCCheck
            // 
            this.DegreeCCheck.AutoSize = true;
            this.DegreeCCheck.Location = new System.Drawing.Point(222, 58);
            this.DegreeCCheck.Margin = new System.Windows.Forms.Padding(2);
            this.DegreeCCheck.Name = "DegreeCCheck";
            this.DegreeCCheck.Size = new System.Drawing.Size(33, 17);
            this.DegreeCCheck.TabIndex = 11;
            this.DegreeCCheck.Text = "C";
            this.DegreeCCheck.UseVisualStyleBackColor = true;
            this.DegreeCCheck.CheckedChanged += new System.EventHandler(this.DegreeCCheck_CheckedChanged);
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(17, 105);
            this.txtNoiDung.Margin = new System.Windows.Forms.Padding(2);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(236, 20);
            this.txtNoiDung.TabIndex = 12;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(17, 149);
            this.txtA.Margin = new System.Windows.Forms.Padding(2);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(236, 20);
            this.txtA.TabIndex = 13;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(19, 191);
            this.txtB.Margin = new System.Windows.Forms.Padding(2);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(234, 20);
            this.txtB.TabIndex = 14;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(17, 232);
            this.txtC.Margin = new System.Windows.Forms.Padding(2);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(236, 20);
            this.txtC.TabIndex = 15;
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(17, 276);
            this.txtD.Margin = new System.Windows.Forms.Padding(2);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(236, 20);
            this.txtD.TabIndex = 16;
            // 
            // ansCCheck
            // 
            this.ansCCheck.AutoSize = true;
            this.ansCCheck.Location = new System.Drawing.Point(156, 326);
            this.ansCCheck.Margin = new System.Windows.Forms.Padding(2);
            this.ansCCheck.Name = "ansCCheck";
            this.ansCCheck.Size = new System.Drawing.Size(33, 17);
            this.ansCCheck.TabIndex = 19;
            this.ansCCheck.Text = "C";
            this.ansCCheck.UseVisualStyleBackColor = true;
            this.ansCCheck.CheckedChanged += new System.EventHandler(this.AnsCCheck_CheckedChanged);
            // 
            // ansBCheck
            // 
            this.ansBCheck.AutoSize = true;
            this.ansBCheck.Location = new System.Drawing.Point(87, 326);
            this.ansBCheck.Margin = new System.Windows.Forms.Padding(2);
            this.ansBCheck.Name = "ansBCheck";
            this.ansBCheck.Size = new System.Drawing.Size(33, 17);
            this.ansBCheck.TabIndex = 18;
            this.ansBCheck.Text = "B";
            this.ansBCheck.UseVisualStyleBackColor = true;
            this.ansBCheck.CheckedChanged += new System.EventHandler(this.AnsBCheck_CheckedChanged);
            // 
            // ansACheck
            // 
            this.ansACheck.AutoSize = true;
            this.ansACheck.Location = new System.Drawing.Point(17, 326);
            this.ansACheck.Margin = new System.Windows.Forms.Padding(2);
            this.ansACheck.Name = "ansACheck";
            this.ansACheck.Size = new System.Drawing.Size(33, 17);
            this.ansACheck.TabIndex = 17;
            this.ansACheck.Text = "A";
            this.ansACheck.UseVisualStyleBackColor = true;
            this.ansACheck.CheckedChanged += new System.EventHandler(this.AnsACheck_CheckedChanged);
            // 
            // ansDCheck
            // 
            this.ansDCheck.AutoSize = true;
            this.ansDCheck.Location = new System.Drawing.Point(222, 326);
            this.ansDCheck.Margin = new System.Windows.Forms.Padding(2);
            this.ansDCheck.Name = "ansDCheck";
            this.ansDCheck.Size = new System.Drawing.Size(34, 17);
            this.ansDCheck.TabIndex = 20;
            this.ansDCheck.Text = "D";
            this.ansDCheck.UseVisualStyleBackColor = true;
            this.ansDCheck.CheckedChanged += new System.EventHandler(this.AnsDCheck_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(275, -1);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "X";
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Enabled = false;
            this.btnAddQuestion.Location = new System.Drawing.Point(197, 348);
            this.btnAddQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(56, 19);
            this.btnAddQuestion.TabIndex = 22;
            this.btnAddQuestion.Text = "Thêm";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // DegreeBCheck
            // 
            this.DegreeBCheck.AutoSize = true;
            this.DegreeBCheck.Location = new System.Drawing.Point(145, 58);
            this.DegreeBCheck.Margin = new System.Windows.Forms.Padding(2);
            this.DegreeBCheck.Name = "DegreeBCheck";
            this.DegreeBCheck.Size = new System.Drawing.Size(33, 17);
            this.DegreeBCheck.TabIndex = 23;
            this.DegreeBCheck.Text = "B";
            this.DegreeBCheck.UseVisualStyleBackColor = true;
            this.DegreeBCheck.CheckedChanged += new System.EventHandler(this.DegreeBCheck_CheckedChanged);
            // 
            // AddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(275, 378);
            this.Controls.Add(this.DegreeBCheck);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ansDCheck);
            this.Controls.Add(this.ansCCheck);
            this.Controls.Add(this.ansBCheck);
            this.Controls.Add(this.ansACheck);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.DegreeCCheck);
            this.Controls.Add(this.DegreeACheck);
            this.Controls.Add(this.listMonHoc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddQuestion";
            this.Text = "AddQuestion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView listMonHoc;
        private System.Windows.Forms.CheckBox DegreeACheck;
        private System.Windows.Forms.CheckBox DegreeCCheck;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.CheckBox ansCCheck;
        private System.Windows.Forms.CheckBox ansBCheck;
        private System.Windows.Forms.CheckBox ansACheck;
        private System.Windows.Forms.CheckBox ansDCheck;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.CheckBox DegreeBCheck;
    }
}