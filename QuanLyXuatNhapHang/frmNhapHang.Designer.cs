namespace QuanLyXuatNhapHang
{
    partial class frmNhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapHang));
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.grpNH = new System.Windows.Forms.GroupBox();
            this.lblDVT = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSMCT = new System.Windows.Forms.Button();
            this.btnSMH = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDG = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateN = new System.Windows.Forms.DateTimePicker();
            this.txtMHD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvNH = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnADD = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.grpNH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNH)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(688, 230);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 38);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = " Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(607, 230);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 38);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sữa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // grpNH
            // 
            this.grpNH.BackColor = System.Drawing.Color.Transparent;
            this.grpNH.Controls.Add(this.lblDVT);
            this.grpNH.Controls.Add(this.txtSL);
            this.grpNH.Controls.Add(this.label1);
            this.grpNH.Controls.Add(this.btnNew);
            this.grpNH.Controls.Add(this.btnSMCT);
            this.grpNH.Controls.Add(this.btnSMH);
            this.grpNH.Controls.Add(this.label11);
            this.grpNH.Controls.Add(this.label9);
            this.grpNH.Controls.Add(this.txtDG);
            this.grpNH.Controls.Add(this.label10);
            this.grpNH.Controls.Add(this.label7);
            this.grpNH.Controls.Add(this.txtCT);
            this.grpNH.Controls.Add(this.label6);
            this.grpNH.Controls.Add(this.txtMH);
            this.grpNH.Controls.Add(this.label5);
            this.grpNH.Controls.Add(this.dateN);
            this.grpNH.Controls.Add(this.txtMHD);
            this.grpNH.Controls.Add(this.label4);
            this.grpNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNH.Location = new System.Drawing.Point(21, 100);
            this.grpNH.Name = "grpNH";
            this.grpNH.Size = new System.Drawing.Size(793, 125);
            this.grpNH.TabIndex = 41;
            this.grpNH.TabStop = false;
            // 
            // lblDVT
            // 
            this.lblDVT.AutoSize = true;
            this.lblDVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDVT.Location = new System.Drawing.Point(696, 88);
            this.lblDVT.Name = "lblDVT";
            this.lblDVT.Size = new System.Drawing.Size(10, 13);
            this.lblDVT.TabIndex = 49;
            this.lblDVT.Text = "-";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(522, 85);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(168, 20);
            this.txtSL.TabIndex = 4;
            this.txtSL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSL_KeyPress_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(696, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "VND";
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(281, 31);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(82, 20);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "   Thêm Mới";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSMCT
            // 
            this.btnSMCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSMCT.Image = ((System.Drawing.Image)(resources.GetObject("btnSMCT.Image")));
            this.btnSMCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMCT.Location = new System.Drawing.Point(281, 56);
            this.btnSMCT.Name = "btnSMCT";
            this.btnSMCT.Size = new System.Drawing.Size(82, 23);
            this.btnSMCT.TabIndex = 1;
            this.btnSMCT.Text = "    Mã CT";
            this.btnSMCT.UseVisualStyleBackColor = true;
            this.btnSMCT.Click += new System.EventHandler(this.btnSMCT_Click);
            // 
            // btnSMH
            // 
            this.btnSMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSMH.Image = ((System.Drawing.Image)(resources.GetObject("btnSMH.Image")));
            this.btnSMH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMH.Location = new System.Drawing.Point(661, 26);
            this.btnSMH.Name = "btnSMH";
            this.btnSMH.Size = new System.Drawing.Size(84, 23);
            this.btnSMH.TabIndex = 3;
            this.btnSMH.Text = "   Mã Hàng";
            this.btnSMH.UseVisualStyleBackColor = true;
            this.btnSMH.Click += new System.EventHandler(this.btnSMH_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(42, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Mã Hóa Đơn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Ngày Nhập";
            // 
            // txtDG
            // 
            this.txtDG.Enabled = false;
            this.txtDG.Location = new System.Drawing.Point(521, 56);
            this.txtDG.Name = "txtDG";
            this.txtDG.Size = new System.Drawing.Size(169, 20);
            this.txtDG.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(444, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Đơn giá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Mã Công Ty";
            // 
            // txtCT
            // 
            this.txtCT.Enabled = false;
            this.txtCT.Location = new System.Drawing.Point(135, 62);
            this.txtCT.Name = "txtCT";
            this.txtCT.Size = new System.Drawing.Size(140, 20);
            this.txtCT.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(435, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Số Lượng";
            // 
            // txtMH
            // 
            this.txtMH.Enabled = false;
            this.txtMH.Location = new System.Drawing.Point(522, 29);
            this.txtMH.Name = "txtMH";
            this.txtMH.Size = new System.Drawing.Size(133, 20);
            this.txtMH.TabIndex = 33;
            this.txtMH.TextChanged += new System.EventHandler(this.txtMH_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(435, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Mã Hàng";
            // 
            // dateN
            // 
            this.dateN.CustomFormat = "dd/MM/yyyy";
            this.dateN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateN.Location = new System.Drawing.Point(135, 88);
            this.dateN.Name = "dateN";
            this.dateN.Size = new System.Drawing.Size(228, 20);
            this.dateN.TabIndex = 2;
            this.dateN.ValueChanged += new System.EventHandler(this.dateN_ValueChanged);
            // 
            // txtMHD
            // 
            this.txtMHD.Enabled = false;
            this.txtMHD.Location = new System.Drawing.Point(135, 29);
            this.txtMHD.Name = "txtMHD";
            this.txtMHD.Size = new System.Drawing.Size(140, 20);
            this.txtMHD.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, -15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Mã Hóa Đơn";
            // 
            // dgvNH
            // 
            this.dgvNH.AllowUserToAddRows = false;
            this.dgvNH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNH.BackgroundColor = System.Drawing.Color.White;
            this.dgvNH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvNH.Location = new System.Drawing.Point(12, 285);
            this.dgvNH.MultiSelect = false;
            this.dgvNH.Name = "dgvNH";
            this.dgvNH.ReadOnly = true;
            this.dgvNH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNH.Size = new System.Drawing.Size(802, 197);
            this.dgvNH.TabIndex = 39;
            this.dgvNH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dgvNH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaHD_Nhap";
            this.Column1.HeaderText = "Mã Hóa Đơn";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Mahang";
            this.Column2.HeaderText = "Mã hàng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MaCT";
            this.Column3.HeaderText = "Mã Công Ty";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MaNV";
            this.Column4.HeaderText = "Mã Thủ Kho";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "soluong";
            this.Column5.HeaderText = "Số Lượng";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "dongia";
            this.Column6.HeaderText = "Đơn Giá";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "ngaynhap";
            this.Column7.HeaderText = "Ngày Nhập";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "thanhtien";
            this.Column8.HeaderText = "Thanh Tien";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(308, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 26);
            this.label3.TabIndex = 38;
            this.label3.Text = "Phiếu Nhập Hàng";
            // 
            // btnLoad
            // 
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.Location = new System.Drawing.Point(353, 230);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(84, 38);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtTK
            // 
            this.txtTK.Enabled = false;
            this.txtTK.Location = new System.Drawing.Point(103, 74);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(112, 20);
            this.txtTK.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(49, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Thủ Kho";
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(526, 231);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 38);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu HĐ";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.addMoreToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 70);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // addMoreToolStripMenuItem
            // 
            this.addMoreToolStripMenuItem.Name = "addMoreToolStripMenuItem";
            this.addMoreToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.addMoreToolStripMenuItem.Text = "Add More";
            this.addMoreToolStripMenuItem.Click += new System.EventHandler(this.addMoreToolStripMenuItem_Click);
            // 
            // btnADD
            // 
            this.btnADD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnADD.Location = new System.Drawing.Point(443, 231);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(75, 38);
            this.btnADD.TabIndex = 0;
            this.btnADD.Text = "Thêm";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(30, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "     ";
            // 
            // frmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(838, 511);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.grpNH);
            this.Controls.Add(this.dgvNH);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhập Hàng";
            this.Load += new System.EventHandler(this.frmNhapHang_Load);
            this.grpNH.ResumeLayout(false);
            this.grpNH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNH)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox grpNH;
        private System.Windows.Forms.Button btnSMCT;
        private System.Windows.Forms.Button btnSMH;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDG;
        private System.Windows.Forms.TextBox txtCT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateN;
        private System.Windows.Forms.TextBox txtMHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvNH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMoreToolStripMenuItem;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Label lblDVT;
        private System.Windows.Forms.Label label8;
    }
}