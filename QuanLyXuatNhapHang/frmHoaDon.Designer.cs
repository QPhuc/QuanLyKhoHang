namespace QuanLyXuatNhapHang
{
    partial class frmHoaDon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thanhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHD
            // 
            this.dgvHD.AllowUserToAddRows = false;
            this.dgvHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHD.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column8,
            this.Column7});
            this.dgvHD.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvHD.Location = new System.Drawing.Point(13, 135);
            this.dgvHD.MultiSelect = false;
            this.dgvHD.Name = "dgvHD";
            this.dgvHD.ReadOnly = true;
            this.dgvHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHD.Size = new System.Drawing.Size(853, 300);
            this.dgvHD.TabIndex = 0;
            this.dgvHD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHD_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "STT";
            this.Column1.HeaderText = "Số Thứ Tự";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaHD_Nhap_Xuat";
            this.Column2.HeaderText = "Mã Hóa Đơn";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MANV";
            this.Column3.HeaderText = "Mã Nhân Vien";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MaKH";
            this.Column4.HeaderText = "Mã Khách Hàng";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MACT";
            this.Column5.HeaderText = "Mã Công Ty";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ngay";
            this.Column6.HeaderText = "Ngày lập";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "thanhtien";
            this.Column8.HeaderText = "Tổng Thành Tiền";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "thanhtoan";
            this.Column7.HeaderText = "Thanh Toan";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thanhToánToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 26);
            // 
            // thanhToánToolStripMenuItem
            // 
            this.thanhToánToolStripMenuItem.Name = "thanhToánToolStripMenuItem";
            this.thanhToánToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.thanhToánToolStripMenuItem.Text = "Thanh Toán";
            this.thanhToánToolStripMenuItem.Click += new System.EventHandler(this.thanhToánToolStripMenuItem_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNhap.Location = new System.Drawing.Point(606, 54);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(116, 23);
            this.btnNhap.TabIndex = 1;
            this.btnNhap.UseVisualStyleBackColor = false;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnXuat.Location = new System.Drawing.Point(606, 91);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(116, 23);
            this.btnXuat.TabIndex = 2;
            this.btnXuat.UseVisualStyleBackColor = false;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(741, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = ": Hóa Đơn Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(741, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = ": Hóa Đơn Xuất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(277, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tổng Hóa Đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "*Lưu ý: Double Click để xem chi tiết Hóa Đơn";
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(122, 82);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(125, 20);
            this.txtTK.TabIndex = 8;
            this.txtTK.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tìm Hóa Đơn:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(10, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "        ";
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 437);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.dgvHD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHoaDon";
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHD;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thanhToánToolStripMenuItem;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}