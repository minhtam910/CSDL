namespace WindowsFormsApp7
{
    partial class Info
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
            this.dataInfo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChoose = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataInfo
            // 
            this.dataInfo.AllowUserToAddRows = false;
            this.dataInfo.AllowUserToDeleteRows = false;
            this.dataInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataInfo.Location = new System.Drawing.Point(16, 78);
            this.dataInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataInfo.Name = "dataInfo";
            this.dataInfo.ReadOnly = true;
            this.dataInfo.RowHeadersWidth = 51;
            this.dataInfo.Size = new System.Drawing.Size(596, 229);
            this.dataInfo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông tin cần xem";
            // 
            // txtChoose
            // 
            this.txtChoose.Location = new System.Drawing.Point(165, 7);
            this.txtChoose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtChoose.Name = "txtChoose";
            this.txtChoose.Size = new System.Drawing.Size(294, 22);
            this.txtChoose.TabIndex = 2;
            this.txtChoose.TextChanged += new System.EventHandler(this.TxtChoose_TextChanged);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(536, 42);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Xem";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(405, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhập \"Khoa\",\"SinhVien\",\"GiaoVien\",\"MonHoc\" để xem thông tin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(595, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "X\r\n";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 321);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtChoose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataInfo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Info";
            this.Text = "Info";
            ((System.ComponentModel.ISupportInitialize)(this.dataInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChoose;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}