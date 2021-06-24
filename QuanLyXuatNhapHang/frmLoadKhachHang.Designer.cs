namespace QuanLyXuatNhapHang
{
    partial class frmLoadKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoadKhachHang));
            this.label2 = new System.Windows.Forms.Label();
            this.btnTIm = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grp = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAC = new System.Windows.Forms.Button();
            this.txtMKH = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(38, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tìm kiếm mã Khách Hàng";
            // 
            // btnTIm
            // 
            this.btnTIm.Image = ((System.Drawing.Image)(resources.GetObject("btnTIm.Image")));
            this.btnTIm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTIm.Location = new System.Drawing.Point(220, 78);
            this.btnTIm.Name = "btnTIm";
            this.btnTIm.Size = new System.Drawing.Size(75, 23);
            this.btnTIm.TabIndex = 12;
            this.btnTIm.Text = "Tìm kiếm";
            this.btnTIm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTIm.UseVisualStyleBackColor = true;
            this.btnTIm.Click += new System.EventHandler(this.btnTIm_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên Khách Hàng";
            // 
            // grp
            // 
            this.grp.Controls.Add(this.dataGridView1);
            this.grp.Location = new System.Drawing.Point(17, 162);
            this.grp.Name = "grp";
            this.grp.Size = new System.Drawing.Size(282, 176);
            this.grp.TabIndex = 9;
            this.grp.TabStop = false;
            this.grp.Text = "Mã và tên Khách Hàng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(276, 157);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaKH";
            this.Column1.HeaderText = "Mã Khách Hàng";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenKH";
            this.Column2.HeaderText = "Tên Khách Hàng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // btnAC
            // 
            this.btnAC.Image = ((System.Drawing.Image)(resources.GetObject("btnAC.Image")));
            this.btnAC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAC.Location = new System.Drawing.Point(224, 114);
            this.btnAC.Name = "btnAC";
            this.btnAC.Size = new System.Drawing.Size(75, 23);
            this.btnAC.TabIndex = 16;
            this.btnAC.Text = "Xác Nhận";
            this.btnAC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAC.UseVisualStyleBackColor = true;
            this.btnAC.Click += new System.EventHandler(this.btnAC_Click);
            // 
            // txtMKH
            // 
            this.txtMKH.AutoSize = true;
            this.txtMKH.Location = new System.Drawing.Point(140, 124);
            this.txtMKH.Name = "txtMKH";
            this.txtMKH.Size = new System.Drawing.Size(10, 13);
            this.txtMKH.TabIndex = 15;
            this.txtMKH.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mã Hàng:";
            // 
            // frmLoadKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 350);
            this.Controls.Add(this.btnAC);
            this.Controls.Add(this.txtMKH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTIm);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLoadKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm mã Khách Hàng";
            this.Load += new System.EventHandler(this.frmLoadKhachHang_Load);
            this.grp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTIm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnAC;
        private System.Windows.Forms.Label txtMKH;
        private System.Windows.Forms.Label label3;
    }
}