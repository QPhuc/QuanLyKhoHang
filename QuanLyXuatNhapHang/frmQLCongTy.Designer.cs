namespace QuanLyXuatNhapHang
{
    partial class frmQLCongTy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLCongTy));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.txtTenDD = new System.Windows.Forms.TextBox();
            this.txtTenCT = new System.Windows.Forms.TextBox();
            this.txtMaCT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemMCT = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtSoDT);
            this.groupBox1.Controls.Add(this.txtTenDD);
            this.groupBox1.Controls.Add(this.txtTenCT);
            this.groupBox1.Controls.Add(this.txtMaCT);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(823, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(530, 66);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(191, 20);
            this.txtDiaChi.TabIndex = 3;
            // 
            // txtSoDT
            // 
            this.txtSoDT.Location = new System.Drawing.Point(530, 23);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(191, 20);
            this.txtSoDT.TabIndex = 2;
            this.txtSoDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoDT_KeyPress);
            // 
            // txtTenDD
            // 
            this.txtTenDD.Location = new System.Drawing.Point(161, 101);
            this.txtTenDD.Name = "txtTenDD";
            this.txtTenDD.Size = new System.Drawing.Size(183, 20);
            this.txtTenDD.TabIndex = 1;
            // 
            // txtTenCT
            // 
            this.txtTenCT.Location = new System.Drawing.Point(161, 61);
            this.txtTenCT.Name = "txtTenCT";
            this.txtTenCT.Size = new System.Drawing.Size(183, 20);
            this.txtTenCT.TabIndex = 0;
            // 
            // txtMaCT
            // 
            this.txtMaCT.Enabled = false;
            this.txtMaCT.Location = new System.Drawing.Point(161, 21);
            this.txtMaCT.Name = "txtMaCT";
            this.txtMaCT.Size = new System.Drawing.Size(183, 20);
            this.txtMaCT.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(453, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa Chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số Điện Thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Đại Diện";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Công Ty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Công Ty";
            // 
            // btnThemMCT
            // 
            this.btnThemMCT.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMCT.Image")));
            this.btnThemMCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMCT.Location = new System.Drawing.Point(12, 217);
            this.btnThemMCT.Name = "btnThemMCT";
            this.btnThemMCT.Size = new System.Drawing.Size(104, 40);
            this.btnThemMCT.TabIndex = 10;
            this.btnThemMCT.Text = "Thêm Mã CTy";
            this.btnThemMCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemMCT.UseVisualStyleBackColor = true;
            this.btnThemMCT.Click += new System.EventHandler(this.btnThemMCT_Click);
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
            this.Column5});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 292);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(823, 194);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaCT";
            this.Column1.HeaderText = "Mã Công Ty";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenCT";
            this.Column2.HeaderText = "Tên Công Ty";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TenNgDaiDien";
            this.Column3.HeaderText = "Tên Đại Diện";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SDT";
            this.Column4.HeaderText = "Số Điện Thoại";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DiaChi";
            this.Column5.HeaderText = "Địa Chỉ";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // frmQLCongTy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(847, 522);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.ControlBox = false;
            this.Controls.Add(this.btnThemMCT);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQLCongTy";
            this.Text = "Quản lý Công Ty";
            this.Load += new System.EventHandler(this.frmQLCongTy_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.TextBox txtTenDD;
        private System.Windows.Forms.TextBox txtTenCT;
        private System.Windows.Forms.TextBox txtMaCT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemMCT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
    }
}