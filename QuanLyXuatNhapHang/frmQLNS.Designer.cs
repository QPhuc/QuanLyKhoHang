namespace QuanLyXuatNhapHang
{
    partial class frmQLNS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLNS));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.đổiPassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpNV = new System.Windows.Forms.GroupBox();
            this.txtngay = new System.Windows.Forms.DateTimePicker();
            this.btnID = new System.Windows.Forms.Button();
            this.txtMNV = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.txtchucvu = new System.Windows.Forms.TextBox();
            this.txtluong = new System.Windows.Forms.TextBox();
            this.txtHSL = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnchen = new System.Windows.Forms.Button();
            this.ptb = new System.Windows.Forms.PictureBox();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.grpNV.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(8, 321);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(827, 173);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaNV";
            this.Column1.HeaderText = "Mã Nhân Viên";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ID";
            this.Column2.HeaderText = "ID Nhân Viên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TenNV";
            this.Column3.HeaderText = "Tên Nhân Viên";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DiaChi";
            this.Column4.HeaderText = "Địa Chỉ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SDT";
            this.Column5.HeaderText = "Số Điện Thoại";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "HSL";
            this.Column6.HeaderText = "Hệ Số Lương";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "luongcanban";
            this.Column7.HeaderText = "Lương Căn Bản";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "ngayvaolam";
            this.Column8.HeaderText = "Ngày Vào Làm";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "chucvu";
            this.Column9.HeaderText = "Chức Vụ";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiPassToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(147, 26);
            // 
            // đổiPassToolStripMenuItem
            // 
            this.đổiPassToolStripMenuItem.Name = "đổiPassToolStripMenuItem";
            this.đổiPassToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.đổiPassToolStripMenuItem.Text = "Đổi Mật Khẩu";
            this.đổiPassToolStripMenuItem.Click += new System.EventHandler(this.đổiPassToolStripMenuItem_Click);
            // 
            // grpNV
            // 
            this.grpNV.BackColor = System.Drawing.Color.Transparent;
            this.grpNV.Controls.Add(this.txtngay);
            this.grpNV.Controls.Add(this.btnID);
            this.grpNV.Controls.Add(this.txtMNV);
            this.grpNV.Controls.Add(this.txtSDT);
            this.grpNV.Controls.Add(this.txtDC);
            this.grpNV.Controls.Add(this.txtchucvu);
            this.grpNV.Controls.Add(this.txtluong);
            this.grpNV.Controls.Add(this.txtHSL);
            this.grpNV.Controls.Add(this.txtTen);
            this.grpNV.Controls.Add(this.txtID);
            this.grpNV.Controls.Add(this.label10);
            this.grpNV.Controls.Add(this.label6);
            this.grpNV.Controls.Add(this.label7);
            this.grpNV.Controls.Add(this.label8);
            this.grpNV.Controls.Add(this.label9);
            this.grpNV.Controls.Add(this.label5);
            this.grpNV.Controls.Add(this.label4);
            this.grpNV.Controls.Add(this.label3);
            this.grpNV.Controls.Add(this.label2);
            this.grpNV.Location = new System.Drawing.Point(12, 45);
            this.grpNV.Name = "grpNV";
            this.grpNV.Size = new System.Drawing.Size(652, 199);
            this.grpNV.TabIndex = 1;
            this.grpNV.TabStop = false;
            this.grpNV.Text = "chi tiết nhân viên";
            // 
            // txtngay
            // 
            this.txtngay.CustomFormat = "dd/MM/yyyy";
            this.txtngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtngay.Location = new System.Drawing.Point(459, 25);
            this.txtngay.Name = "txtngay";
            this.txtngay.Size = new System.Drawing.Size(180, 20);
            this.txtngay.TabIndex = 4;
            this.txtngay.ValueChanged += new System.EventHandler(this.txtngay_ValueChanged);
            // 
            // btnID
            // 
            this.btnID.Image = ((System.Drawing.Image)(resources.GetObject("btnID.Image")));
            this.btnID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnID.Location = new System.Drawing.Point(226, 19);
            this.btnID.Name = "btnID";
            this.btnID.Size = new System.Drawing.Size(68, 25);
            this.btnID.TabIndex = 9;
            this.btnID.Text = "Tạo ID";
            this.btnID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnID.UseVisualStyleBackColor = true;
            this.btnID.Click += new System.EventHandler(this.btnID_Click);
            // 
            // txtMNV
            // 
            this.txtMNV.Enabled = false;
            this.txtMNV.Location = new System.Drawing.Point(120, 59);
            this.txtMNV.Name = "txtMNV";
            this.txtMNV.Size = new System.Drawing.Size(176, 20);
            this.txtMNV.TabIndex = 0;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(459, 159);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(180, 20);
            this.txtSDT.TabIndex = 7;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(459, 111);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(180, 20);
            this.txtDC.TabIndex = 6;
            // 
            // txtchucvu
            // 
            this.txtchucvu.Location = new System.Drawing.Point(459, 65);
            this.txtchucvu.Name = "txtchucvu";
            this.txtchucvu.Size = new System.Drawing.Size(180, 20);
            this.txtchucvu.TabIndex = 5;
            // 
            // txtluong
            // 
            this.txtluong.Location = new System.Drawing.Point(120, 159);
            this.txtluong.Name = "txtluong";
            this.txtluong.Size = new System.Drawing.Size(176, 20);
            this.txtluong.TabIndex = 3;
            this.txtluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtluong_KeyPress);
            // 
            // txtHSL
            // 
            this.txtHSL.Location = new System.Drawing.Point(120, 125);
            this.txtHSL.Name = "txtHSL";
            this.txtHSL.Size = new System.Drawing.Size(176, 20);
            this.txtHSL.TabIndex = 2;
            this.txtHSL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHSL_KeyPress);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(120, 92);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(176, 20);
            this.txtTen.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(120, 24);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Lương căn bản";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(373, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Số DT:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Dia chi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(373, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Chức vụ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(373, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Ngày vào làm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Hệ Số Lương:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên Nhân Viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã Nhân Viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Nhân Viên:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnchen);
            this.groupBox2.Controls.Add(this.ptb);
            this.groupBox2.Location = new System.Drawing.Point(670, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 199);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "khung hình nhân vien";
            // 
            // btnchen
            // 
            this.btnchen.Image = ((System.Drawing.Image)(resources.GetObject("btnchen.Image")));
            this.btnchen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnchen.Location = new System.Drawing.Point(18, 149);
            this.btnchen.Name = "btnchen";
            this.btnchen.Size = new System.Drawing.Size(124, 30);
            this.btnchen.TabIndex = 0;
            this.btnchen.Text = "chèn hình";
            this.btnchen.UseVisualStyleBackColor = true;
            this.btnchen.Click += new System.EventHandler(this.btnchen_Click);
            // 
            // ptb
            // 
            this.ptb.BackColor = System.Drawing.Color.White;
            this.ptb.Location = new System.Drawing.Point(18, 25);
            this.ptb.Name = "ptb";
            this.ptb.Size = new System.Drawing.Size(124, 108);
            this.ptb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb.TabIndex = 0;
            this.ptb.TabStop = false;
            // 
            // btnADD
            // 
            this.btnADD.Image = ((System.Drawing.Image)(resources.GetObject("btnADD.Image")));
            this.btnADD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnADD.Location = new System.Drawing.Point(131, 257);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(115, 42);
            this.btnADD.TabIndex = 0;
            this.btnADD.Text = "    Thêm Nhân Viên";
            this.btnADD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.Location = new System.Drawing.Point(8, 257);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(117, 42);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "       Load danh sach";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(252, 257);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(117, 42);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa Nhân Viên";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 569);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "hàng chính chủ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "686909-user_people_man_human_head_person-512.png");
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(375, 257);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 42);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmQLNS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(847, 522);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpNV);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQLNS";
            this.Text = "Tổng Quản Lý";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdmin_FormClosing);
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmQLNS_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.grpNV.ResumeLayout(false);
            this.grpNV.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpNV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.TextBox txtchucvu;
        private System.Windows.Forms.TextBox txtluong;
        private System.Windows.Forms.TextBox txtHSL;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnchen;
        private System.Windows.Forms.PictureBox ptb;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtMNV;
        private System.Windows.Forms.Button btnID;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DateTimePicker txtngay;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đổiPassToolStripMenuItem;

    }
}