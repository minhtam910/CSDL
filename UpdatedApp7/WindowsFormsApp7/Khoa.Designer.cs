namespace WindowsFormsApp7
{
    partial class Khoa
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
            this.CheckNewKhoa = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewKhoa = new System.Windows.Forms.TextBox();
            this.lbNewKhoa = new System.Windows.Forms.Label();
            this.btnAddKhoa = new System.Windows.Forms.Button();
            this.btnAddLop = new System.Windows.Forms.Button();
            this.lbNewLop = new System.Windows.Forms.Label();
            this.txtNewLop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkNewLop = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CheckIsSinhVien = new System.Windows.Forms.CheckBox();
            this.txtMaSo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbDegree = new System.Windows.Forms.Label();
            this.txtDegree = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.lbExit = new System.Windows.Forms.Label();
            this.lbMaKhoa = new System.Windows.Forms.Label();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.lbMaLop = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.txtBirthDay = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CheckNewKhoa
            // 
            this.CheckNewKhoa.AutoSize = true;
            this.CheckNewKhoa.Location = new System.Drawing.Point(48, 76);
            this.CheckNewKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.CheckNewKhoa.Name = "CheckNewKhoa";
            this.CheckNewKhoa.Size = new System.Drawing.Size(91, 17);
            this.CheckNewKhoa.TabIndex = 0;
            this.CheckNewKhoa.Text = "Tạo khoa mới";
            this.CheckNewKhoa.UseVisualStyleBackColor = true;
            this.CheckNewKhoa.CheckedChanged += new System.EventHandler(this.CheckNewKhoa_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Khoa:";
            // 
            // txtNewKhoa
            // 
            this.txtNewKhoa.Enabled = false;
            this.txtNewKhoa.Location = new System.Drawing.Point(302, 72);
            this.txtNewKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewKhoa.Name = "txtNewKhoa";
            this.txtNewKhoa.Size = new System.Drawing.Size(121, 20);
            this.txtNewKhoa.TabIndex = 3;
            this.txtNewKhoa.Visible = false;
            this.txtNewKhoa.TextChanged += new System.EventHandler(this.TxtNewKhoa_TextChanged);
            // 
            // lbNewKhoa
            // 
            this.lbNewKhoa.AutoSize = true;
            this.lbNewKhoa.Location = new System.Drawing.Point(247, 75);
            this.lbNewKhoa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNewKhoa.Name = "lbNewKhoa";
            this.lbNewKhoa.Size = new System.Drawing.Size(54, 13);
            this.lbNewKhoa.TabIndex = 4;
            this.lbNewKhoa.Text = "Khoa mới:";
            this.lbNewKhoa.Visible = false;
            // 
            // btnAddKhoa
            // 
            this.btnAddKhoa.Enabled = false;
            this.btnAddKhoa.Location = new System.Drawing.Point(471, 49);
            this.btnAddKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddKhoa.Name = "btnAddKhoa";
            this.btnAddKhoa.Size = new System.Drawing.Size(63, 19);
            this.btnAddKhoa.TabIndex = 5;
            this.btnAddKhoa.Text = "Thêm";
            this.btnAddKhoa.UseVisualStyleBackColor = true;
            this.btnAddKhoa.Visible = false;
            this.btnAddKhoa.Click += new System.EventHandler(this.btnAddKhoa_Click);
            // 
            // btnAddLop
            // 
            this.btnAddLop.Enabled = false;
            this.btnAddLop.Location = new System.Drawing.Point(471, 103);
            this.btnAddLop.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddLop.Name = "btnAddLop";
            this.btnAddLop.Size = new System.Drawing.Size(63, 19);
            this.btnAddLop.TabIndex = 11;
            this.btnAddLop.Text = "Thêm";
            this.btnAddLop.UseVisualStyleBackColor = true;
            this.btnAddLop.Visible = false;
            this.btnAddLop.Click += new System.EventHandler(this.btnAddLop_Click);
            // 
            // lbNewLop
            // 
            this.lbNewLop.AutoSize = true;
            this.lbNewLop.Location = new System.Drawing.Point(248, 130);
            this.lbNewLop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNewLop.Name = "lbNewLop";
            this.lbNewLop.Size = new System.Drawing.Size(47, 13);
            this.lbNewLop.TabIndex = 10;
            this.lbNewLop.Text = "Lớp mới:";
            this.lbNewLop.Visible = false;
            // 
            // txtNewLop
            // 
            this.txtNewLop.Enabled = false;
            this.txtNewLop.Location = new System.Drawing.Point(302, 130);
            this.txtNewLop.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewLop.Name = "txtNewLop";
            this.txtNewLop.Size = new System.Drawing.Size(121, 20);
            this.txtNewLop.TabIndex = 9;
            this.txtNewLop.Visible = false;
            this.txtNewLop.TextChanged += new System.EventHandler(this.TxtNewLop_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lớp:";
            // 
            // checkNewLop
            // 
            this.checkNewLop.AutoSize = true;
            this.checkNewLop.Location = new System.Drawing.Point(48, 130);
            this.checkNewLop.Margin = new System.Windows.Forms.Padding(2);
            this.checkNewLop.Name = "checkNewLop";
            this.checkNewLop.Size = new System.Drawing.Size(81, 17);
            this.checkNewLop.TabIndex = 6;
            this.checkNewLop.Text = "Tạo lớp mới";
            this.checkNewLop.UseVisualStyleBackColor = true;
            this.checkNewLop.CheckedChanged += new System.EventHandler(this.CheckNewLop_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Thông tin cá nhân:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Thông tin Khoa/Lớp:";
            // 
            // CheckIsSinhVien
            // 
            this.CheckIsSinhVien.AutoSize = true;
            this.CheckIsSinhVien.Location = new System.Drawing.Point(343, 162);
            this.CheckIsSinhVien.Margin = new System.Windows.Forms.Padding(2);
            this.CheckIsSinhVien.Name = "CheckIsSinhVien";
            this.CheckIsSinhVien.Size = new System.Drawing.Size(83, 17);
            this.CheckIsSinhVien.TabIndex = 14;
            this.CheckIsSinhVien.Text = "Là sinh viên";
            this.CheckIsSinhVien.UseVisualStyleBackColor = true;
            this.CheckIsSinhVien.CheckedChanged += new System.EventHandler(this.CheckIsSinhVien_CheckedChanged);
            // 
            // txtMaSo
            // 
            this.txtMaSo.Location = new System.Drawing.Point(91, 192);
            this.txtMaSo.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaSo.Name = "txtMaSo";
            this.txtMaSo.Size = new System.Drawing.Size(131, 20);
            this.txtMaSo.TabIndex = 15;
            this.txtMaSo.TextChanged += new System.EventHandler(this.TxtMaSo_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 194);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Mã số:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 229);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Họ:";
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(91, 227);
            this.txtHo.Margin = new System.Windows.Forms.Padding(2);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(131, 20);
            this.txtHo.TabIndex = 17;
            this.txtHo.TextChanged += new System.EventHandler(this.txtHo_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(247, 229);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Tên:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(292, 227);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(131, 20);
            this.txtName.TabIndex = 19;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(46, 262);
            this.lbAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(43, 13);
            this.lbAddress.TabIndex = 22;
            this.lbAddress.Text = "Địa chỉ:";
            this.lbAddress.Visible = false;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(91, 259);
            this.txtAdress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(131, 20);
            this.txtAdress.TabIndex = 21;
            this.txtAdress.Visible = false;
            this.txtAdress.TextChanged += new System.EventHandler(this.txtAdress_TextChanged);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(232, 262);
            this.lbDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(57, 13);
            this.lbDate.TabIndex = 24;
            this.lbDate.Text = "Ngày sinh:";
            this.lbDate.Visible = false;
            // 
            // lbDegree
            // 
            this.lbDegree.AutoSize = true;
            this.lbDegree.Location = new System.Drawing.Point(247, 194);
            this.lbDegree.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDegree.Name = "lbDegree";
            this.lbDegree.Size = new System.Drawing.Size(41, 13);
            this.lbDegree.TabIndex = 26;
            this.lbDegree.Text = "Học vị:";
            // 
            // txtDegree
            // 
            this.txtDegree.Location = new System.Drawing.Point(292, 192);
            this.txtDegree.Margin = new System.Windows.Forms.Padding(2);
            this.txtDegree.Name = "txtDegree";
            this.txtDegree.Size = new System.Drawing.Size(131, 20);
            this.txtDegree.TabIndex = 25;
            this.txtDegree.TextChanged += new System.EventHandler(this.txtDegree_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(471, 162);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(63, 20);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(471, 183);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(63, 20);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Enabled = false;
            this.btnDel.Location = new System.Drawing.Point(471, 207);
            this.btnDel.Margin = new System.Windows.Forms.Padding(2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(63, 20);
            this.btnDel.TabIndex = 30;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnChange
            // 
            this.btnChange.Enabled = false;
            this.btnChange.Location = new System.Drawing.Point(471, 231);
            this.btnChange.Margin = new System.Windows.Forms.Padding(2);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(63, 20);
            this.btnChange.TabIndex = 31;
            this.btnChange.Text = "Sửa";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // lbExit
            // 
            this.lbExit.AutoSize = true;
            this.lbExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExit.Location = new System.Drawing.Point(529, 7);
            this.lbExit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(18, 18);
            this.lbExit.TabIndex = 32;
            this.lbExit.Text = "X";
            this.lbExit.Click += new System.EventHandler(this.LbExit_Click);
            // 
            // lbMaKhoa
            // 
            this.lbMaKhoa.AutoSize = true;
            this.lbMaKhoa.Location = new System.Drawing.Point(248, 52);
            this.lbMaKhoa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaKhoa.Name = "lbMaKhoa";
            this.lbMaKhoa.Size = new System.Drawing.Size(52, 13);
            this.lbMaKhoa.TabIndex = 34;
            this.lbMaKhoa.Text = "Mã khoa:";
            this.lbMaKhoa.Visible = false;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(302, 50);
            this.txtMaKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(121, 20);
            this.txtMaKhoa.TabIndex = 33;
            this.txtMaKhoa.Visible = false;
            this.txtMaKhoa.TextChanged += new System.EventHandler(this.TxtMaKhoa_TextChanged);
            // 
            // lbMaLop
            // 
            this.lbMaLop.AutoSize = true;
            this.lbMaLop.Location = new System.Drawing.Point(248, 108);
            this.lbMaLop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaLop.Name = "lbMaLop";
            this.lbMaLop.Size = new System.Drawing.Size(42, 13);
            this.lbMaLop.TabIndex = 36;
            this.lbMaLop.Text = "Mã lớp:";
            this.lbMaLop.Visible = false;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(302, 106);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(121, 20);
            this.txtMaLop.TabIndex = 35;
            this.txtMaLop.Visible = false;
            this.txtMaLop.TextChanged += new System.EventHandler(this.TxtMaLop_TextChanged);
            // 
            // cbKhoa
            // 
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(91, 51);
            this.cbKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(131, 21);
            this.cbKhoa.TabIndex = 37;
            this.cbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbKhoa_SelectedIndexChanged);
            // 
            // cbLop
            // 
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(91, 106);
            this.cbLop.Margin = new System.Windows.Forms.Padding(2);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(131, 21);
            this.cbLop.TabIndex = 38;
            this.cbLop.SelectedIndexChanged += new System.EventHandler(this.cbLop_SelectedIndexChanged);
            // 
            // txtBirthDay
            // 
            this.txtBirthDay.Location = new System.Drawing.Point(292, 256);
            this.txtBirthDay.Margin = new System.Windows.Forms.Padding(2);
            this.txtBirthDay.Name = "txtBirthDay";
            this.txtBirthDay.Size = new System.Drawing.Size(131, 20);
            this.txtBirthDay.TabIndex = 39;
            this.txtBirthDay.Visible = false;
            this.txtBirthDay.TextChanged += new System.EventHandler(this.txtBirthDay_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(471, 255);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(63, 20);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Khoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(556, 304);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtBirthDay);
            this.Controls.Add(this.cbLop);
            this.Controls.Add(this.cbKhoa);
            this.Controls.Add(this.lbMaLop);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.lbMaKhoa);
            this.Controls.Add(this.txtMaKhoa);
            this.Controls.Add(this.lbExit);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lbDegree);
            this.Controls.Add(this.txtDegree);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaSo);
            this.Controls.Add(this.CheckIsSinhVien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddLop);
            this.Controls.Add(this.lbNewLop);
            this.Controls.Add(this.txtNewLop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkNewLop);
            this.Controls.Add(this.btnAddKhoa);
            this.Controls.Add(this.lbNewKhoa);
            this.Controls.Add(this.txtNewKhoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckNewKhoa);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Khoa";
            this.Text = "Khoa";
            this.Load += new System.EventHandler(this.Khoa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckNewKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewKhoa;
        private System.Windows.Forms.Label lbNewKhoa;
        private System.Windows.Forms.Button btnAddKhoa;
        private System.Windows.Forms.Button btnAddLop;
        private System.Windows.Forms.Label lbNewLop;
        private System.Windows.Forms.TextBox txtNewLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkNewLop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox CheckIsSinhVien;
        private System.Windows.Forms.TextBox txtMaSo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbDegree;
        private System.Windows.Forms.TextBox txtDegree;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label lbExit;
        private System.Windows.Forms.Label lbMaKhoa;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.Label lbMaLop;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.TextBox txtBirthDay;
        private System.Windows.Forms.Button btnCancel;
    }
}