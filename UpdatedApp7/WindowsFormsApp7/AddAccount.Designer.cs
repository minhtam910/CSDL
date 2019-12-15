namespace WindowsFormsApp7
{
    partial class AddAccount
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkTruong = new System.Windows.Forms.CheckBox();
            this.checkCS1 = new System.Windows.Forms.CheckBox();
            this.checkCS2 = new System.Windows.Forms.CheckBox();
            this.checkSV = new System.Windows.Forms.CheckBox();
            this.checkGV = new System.Windows.Forms.CheckBox();
            this.btn_CreateAcc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(147, 58);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(275, 22);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(147, 89);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(275, 22);
            this.txtPass.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thêm tài khoản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Loại tài khoản";
            // 
            // checkTruong
            // 
            this.checkTruong.AutoSize = true;
            this.checkTruong.Location = new System.Drawing.Point(30, 161);
            this.checkTruong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkTruong.Name = "checkTruong";
            this.checkTruong.Size = new System.Drawing.Size(76, 21);
            this.checkTruong.TabIndex = 6;
            this.checkTruong.Text = "Trường";
            this.checkTruong.UseVisualStyleBackColor = true;
            this.checkTruong.CheckedChanged += new System.EventHandler(this.CheckTruong_CheckedChanged);
            // 
            // checkCS1
            // 
            this.checkCS1.AutoSize = true;
            this.checkCS1.Location = new System.Drawing.Point(147, 161);
            this.checkCS1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkCS1.Name = "checkCS1";
            this.checkCS1.Size = new System.Drawing.Size(78, 21);
            this.checkCS1.TabIndex = 7;
            this.checkCS1.Text = "Cơ sở 1";
            this.checkCS1.UseVisualStyleBackColor = true;
            this.checkCS1.CheckedChanged += new System.EventHandler(this.CheckCS1_CheckedChanged);
            // 
            // checkCS2
            // 
            this.checkCS2.AutoSize = true;
            this.checkCS2.Location = new System.Drawing.Point(258, 161);
            this.checkCS2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkCS2.Name = "checkCS2";
            this.checkCS2.Size = new System.Drawing.Size(78, 21);
            this.checkCS2.TabIndex = 8;
            this.checkCS2.Text = "Cơ sở 2";
            this.checkCS2.UseVisualStyleBackColor = true;
            this.checkCS2.CheckedChanged += new System.EventHandler(this.CheckCS2_CheckedChanged);
            // 
            // checkSV
            // 
            this.checkSV.AutoSize = true;
            this.checkSV.Location = new System.Drawing.Point(147, 204);
            this.checkSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkSV.Name = "checkSV";
            this.checkSV.Size = new System.Drawing.Size(88, 21);
            this.checkSV.TabIndex = 9;
            this.checkSV.Text = "Sinh viên";
            this.checkSV.UseVisualStyleBackColor = true;
            this.checkSV.CheckedChanged += new System.EventHandler(this.CheckSV_CheckedChanged);
            // 
            // checkGV
            // 
            this.checkGV.AutoSize = true;
            this.checkGV.Location = new System.Drawing.Point(30, 204);
            this.checkGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkGV.Name = "checkGV";
            this.checkGV.Size = new System.Drawing.Size(90, 21);
            this.checkGV.TabIndex = 10;
            this.checkGV.Text = "Giáo viên";
            this.checkGV.UseVisualStyleBackColor = true;
            this.checkGV.CheckedChanged += new System.EventHandler(this.CheckGV_CheckedChanged);
            // 
            // btn_CreateAcc
            // 
            this.btn_CreateAcc.Location = new System.Drawing.Point(300, 242);
            this.btn_CreateAcc.Name = "btn_CreateAcc";
            this.btn_CreateAcc.Size = new System.Drawing.Size(113, 42);
            this.btn_CreateAcc.TabIndex = 11;
            this.btn_CreateAcc.Text = "Tạo tài khoản";
            this.btn_CreateAcc.UseVisualStyleBackColor = true;
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 314);
            this.Controls.Add(this.btn_CreateAcc);
            this.Controls.Add(this.checkGV);
            this.Controls.Add(this.checkSV);
            this.Controls.Add(this.checkCS2);
            this.Controls.Add(this.checkCS1);
            this.Controls.Add(this.checkTruong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddAccount";
            this.Text = ".";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkTruong;
        private System.Windows.Forms.CheckBox checkCS1;
        private System.Windows.Forms.CheckBox checkCS2;
        private System.Windows.Forms.CheckBox checkSV;
        private System.Windows.Forms.CheckBox checkGV;
        private System.Windows.Forms.Button btn_CreateAcc;
    }
}