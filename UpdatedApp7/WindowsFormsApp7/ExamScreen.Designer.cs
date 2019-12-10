namespace WindowsFormsApp7
{
    partial class ExamScreen
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.DCheck = new System.Windows.Forms.CheckBox();
            this.CCheck = new System.Windows.Forms.CheckBox();
            this.BCheck = new System.Windows.Forms.CheckBox();
            this.ACheck = new System.Windows.Forms.CheckBox();
            this.QuestionTxt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHandin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbQuest10 = new System.Windows.Forms.Label();
            this.lbQuest8 = new System.Windows.Forms.Label();
            this.lbQuest9 = new System.Windows.Forms.Label();
            this.lbQuest5 = new System.Windows.Forms.Label();
            this.lbQuest6 = new System.Windows.Forms.Label();
            this.lbQuest7 = new System.Windows.Forms.Label();
            this.lbQuest4 = new System.Windows.Forms.Label();
            this.lbQuest3 = new System.Windows.Forms.Label();
            this.lbQuest2 = new System.Windows.Forms.Label();
            this.lbQuest1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DCheck);
            this.panel2.Controls.Add(this.CCheck);
            this.panel2.Controls.Add(this.BCheck);
            this.panel2.Controls.Add(this.ACheck);
            this.panel2.Controls.Add(this.QuestionTxt);
            this.panel2.Location = new System.Drawing.Point(337, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 554);
            this.panel2.TabIndex = 1;
            // 
            // DCheck
            // 
            this.DCheck.AutoSize = true;
            this.DCheck.Location = new System.Drawing.Point(26, 265);
            this.DCheck.Name = "DCheck";
            this.DCheck.Size = new System.Drawing.Size(90, 21);
            this.DCheck.TabIndex = 5;
            this.DCheck.Text = "Đáp án D";
            this.DCheck.UseVisualStyleBackColor = true;
            // 
            // CCheck
            // 
            this.CCheck.AutoSize = true;
            this.CCheck.Location = new System.Drawing.Point(27, 218);
            this.CCheck.Name = "CCheck";
            this.CCheck.Size = new System.Drawing.Size(89, 21);
            this.CCheck.TabIndex = 4;
            this.CCheck.Text = "Đáp án C";
            this.CCheck.UseVisualStyleBackColor = true;
            // 
            // BCheck
            // 
            this.BCheck.AutoSize = true;
            this.BCheck.Location = new System.Drawing.Point(27, 171);
            this.BCheck.Name = "BCheck";
            this.BCheck.Size = new System.Drawing.Size(89, 21);
            this.BCheck.TabIndex = 3;
            this.BCheck.Text = "Đáp án B";
            this.BCheck.UseVisualStyleBackColor = true;
            this.BCheck.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // ACheck
            // 
            this.ACheck.AutoSize = true;
            this.ACheck.Location = new System.Drawing.Point(27, 123);
            this.ACheck.Name = "ACheck";
            this.ACheck.Size = new System.Drawing.Size(89, 21);
            this.ACheck.TabIndex = 2;
            this.ACheck.Text = "Đáp án A";
            this.ACheck.UseVisualStyleBackColor = true;
            // 
            // QuestionTxt
            // 
            this.QuestionTxt.AutoSize = true;
            this.QuestionTxt.Location = new System.Drawing.Point(14, 16);
            this.QuestionTxt.Name = "QuestionTxt";
            this.QuestionTxt.Size = new System.Drawing.Size(56, 17);
            this.QuestionTxt.TabIndex = 1;
            this.QuestionTxt.Text = "Câu hỏi";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHandin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbQuest10);
            this.panel1.Controls.Add(this.lbQuest8);
            this.panel1.Controls.Add(this.lbQuest9);
            this.panel1.Controls.Add(this.lbQuest5);
            this.panel1.Controls.Add(this.lbQuest6);
            this.panel1.Controls.Add(this.lbQuest7);
            this.panel1.Controls.Add(this.lbQuest4);
            this.panel1.Controls.Add(this.lbQuest3);
            this.panel1.Controls.Add(this.lbQuest2);
            this.panel1.Controls.Add(this.lbQuest1);
            this.panel1.Location = new System.Drawing.Point(1, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 554);
            this.panel1.TabIndex = 8;
            // 
            // btnHandin
            // 
            this.btnHandin.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHandin.Location = new System.Drawing.Point(3, 312);
            this.btnHandin.Name = "btnHandin";
            this.btnHandin.Size = new System.Drawing.Size(179, 48);
            this.btnHandin.TabIndex = 11;
            this.btnHandin.Text = "Lưu và tiếp tục";
            this.btnHandin.UseVisualStyleBackColor = true;
            this.btnHandin.Click += new System.EventHandler(this.BtnHandin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Vui lòng chọn câu hỏi và trả lời ";
            // 
            // lbQuest10
            // 
            this.lbQuest10.AutoSize = true;
            this.lbQuest10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbQuest10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbQuest10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuest10.Location = new System.Drawing.Point(11, 248);
            this.lbQuest10.Name = "lbQuest10";
            this.lbQuest10.Size = new System.Drawing.Size(101, 25);
            this.lbQuest10.TabIndex = 9;
            this.lbQuest10.Text = "Câu hỏi 10";
            // 
            // lbQuest8
            // 
            this.lbQuest8.AutoSize = true;
            this.lbQuest8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbQuest8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbQuest8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuest8.Location = new System.Drawing.Point(118, 186);
            this.lbQuest8.Name = "lbQuest8";
            this.lbQuest8.Size = new System.Drawing.Size(91, 25);
            this.lbQuest8.TabIndex = 8;
            this.lbQuest8.Text = "Câu hỏi 8";
            // 
            // lbQuest9
            // 
            this.lbQuest9.AutoSize = true;
            this.lbQuest9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbQuest9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbQuest9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuest9.Location = new System.Drawing.Point(231, 186);
            this.lbQuest9.Name = "lbQuest9";
            this.lbQuest9.Size = new System.Drawing.Size(91, 25);
            this.lbQuest9.TabIndex = 7;
            this.lbQuest9.Text = "Câu hỏi 9";
            // 
            // lbQuest5
            // 
            this.lbQuest5.AutoSize = true;
            this.lbQuest5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbQuest5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbQuest5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuest5.Location = new System.Drawing.Point(118, 123);
            this.lbQuest5.Name = "lbQuest5";
            this.lbQuest5.Size = new System.Drawing.Size(91, 25);
            this.lbQuest5.TabIndex = 6;
            this.lbQuest5.Text = "Câu hỏi 5";
            // 
            // lbQuest6
            // 
            this.lbQuest6.AutoSize = true;
            this.lbQuest6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbQuest6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbQuest6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuest6.Location = new System.Drawing.Point(231, 123);
            this.lbQuest6.Name = "lbQuest6";
            this.lbQuest6.Size = new System.Drawing.Size(91, 25);
            this.lbQuest6.TabIndex = 5;
            this.lbQuest6.Text = "Câu hỏi 6";
            // 
            // lbQuest7
            // 
            this.lbQuest7.AutoSize = true;
            this.lbQuest7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbQuest7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbQuest7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuest7.Location = new System.Drawing.Point(11, 186);
            this.lbQuest7.Name = "lbQuest7";
            this.lbQuest7.Size = new System.Drawing.Size(91, 25);
            this.lbQuest7.TabIndex = 4;
            this.lbQuest7.Text = "Câu hỏi 7";
            // 
            // lbQuest4
            // 
            this.lbQuest4.AutoSize = true;
            this.lbQuest4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbQuest4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbQuest4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuest4.Location = new System.Drawing.Point(11, 123);
            this.lbQuest4.Name = "lbQuest4";
            this.lbQuest4.Size = new System.Drawing.Size(91, 25);
            this.lbQuest4.TabIndex = 3;
            this.lbQuest4.Text = "Câu hỏi 4";
            // 
            // lbQuest3
            // 
            this.lbQuest3.AutoSize = true;
            this.lbQuest3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbQuest3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbQuest3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuest3.Location = new System.Drawing.Point(231, 68);
            this.lbQuest3.Name = "lbQuest3";
            this.lbQuest3.Size = new System.Drawing.Size(91, 25);
            this.lbQuest3.TabIndex = 2;
            this.lbQuest3.Text = "Câu hỏi 3";
            // 
            // lbQuest2
            // 
            this.lbQuest2.AutoSize = true;
            this.lbQuest2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbQuest2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbQuest2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuest2.Location = new System.Drawing.Point(118, 68);
            this.lbQuest2.Name = "lbQuest2";
            this.lbQuest2.Size = new System.Drawing.Size(91, 25);
            this.lbQuest2.TabIndex = 1;
            this.lbQuest2.Text = "Câu hỏi 2";
            // 
            // lbQuest1
            // 
            this.lbQuest1.AutoSize = true;
            this.lbQuest1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbQuest1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbQuest1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuest1.Location = new System.Drawing.Point(11, 68);
            this.lbQuest1.Name = "lbQuest1";
            this.lbQuest1.Size = new System.Drawing.Size(91, 25);
            this.lbQuest1.TabIndex = 0;
            this.lbQuest1.Text = "Câu hỏi 1";
            // 
            // ExamScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 564);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExamScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExamScreen";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox DCheck;
        private System.Windows.Forms.CheckBox CCheck;
        private System.Windows.Forms.CheckBox BCheck;
        private System.Windows.Forms.CheckBox ACheck;
        private System.Windows.Forms.Label QuestionTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbQuest10;
        private System.Windows.Forms.Label lbQuest8;
        private System.Windows.Forms.Label lbQuest9;
        private System.Windows.Forms.Label lbQuest5;
        private System.Windows.Forms.Label lbQuest6;
        private System.Windows.Forms.Label lbQuest7;
        private System.Windows.Forms.Label lbQuest4;
        private System.Windows.Forms.Label lbQuest3;
        private System.Windows.Forms.Label lbQuest2;
        private System.Windows.Forms.Label lbQuest1;
        private System.Windows.Forms.Button btnHandin;
    }
}