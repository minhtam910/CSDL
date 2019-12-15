namespace WindowsFormsApp7
{
    partial class SVMenu
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
            this.btnPre = new System.Windows.Forms.Button();
            this.btnExam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bạn đang đăng nhập bằng tài khoản SINH VIÊN\r\n";
            // 
            // btnPre
            // 
            this.btnPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnPre.Location = new System.Drawing.Point(73, 119);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(75, 23);
            this.btnPre.TabIndex = 1;
            this.btnPre.Text = "Chuẩn bị thi";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.BtnPre_Click);
            // 
            // btnExam
            // 
            this.btnExam.Location = new System.Drawing.Point(265, 119);
            this.btnExam.Name = "btnExam";
            this.btnExam.Size = new System.Drawing.Size(75, 23);
            this.btnExam.TabIndex = 2;
            this.btnExam.Text = "Thi";
            this.btnExam.UseVisualStyleBackColor = true;
            // 
            // SVMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExam);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.label1);
            this.Name = "SVMenu";
            this.Text = "SVMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnExam;
    }
}