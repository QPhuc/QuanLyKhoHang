namespace QuanLyXuatNhapHang
{
    partial class frmQLHangHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLHangHoa));
            this.grpHH = new System.Windows.Forms.GroupBox();
            this.cmbDVT = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.dateHSD = new System.Windows.Forms.DateTimePicker();
            this.dateNSX = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.txtDG = new System.Windows.Forms.TextBox();
            this.txtTH = new System.Windows.Forms.TextBox();
            this.txtMH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnChen = new System.Windows.Forms.Button();
            this.ptB = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnHuy = new System.Windows.Forms.Button();
            this.grpHH.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptB)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpHH
            // 
            this.grpHH.BackColor = System.Drawing.Color.Transparent;
            this.grpHH.Controls.Add(this.cmbDVT);
            this.grpHH.Controls.Add(this.label5);
            this.grpHH.Controls.Add(this.txtSL);
            this.grpHH.Controls.Add(this.dateHSD);
            this.grpHH.Controls.Add(this.dateNSX);
            this.grpHH.Controls.Add(this.label7);
            this.grpHH.Controls.Add(this.label6);
            this.grpHH.Controls.Add(this.label);
            this.grpHH.Controls.Add(this.txtDG);
            this.grpHH.Controls.Add(this.txtTH);
            this.grpHH.Controls.Add(this.txtMH);
            this.grpHH.Controls.Add(this.label4);
            this.grpHH.Controls.Add(this.label3);
            this.grpHH.Controls.Add(this.label2);
            this.grpHH.Controls.Add(this.label1);
            this.grpHH.Controls.Add(this.groupBox2);
            this.grpHH.Location = new System.Drawing.Point(31, 39);
            this.grpHH.Name = "grpHH";
            this.grpHH.Size = new System.Drawing.Size(785, 248);
            this.grpHH.TabIndex = 0;
            this.grpHH.TabStop = false;
            this.grpHH.Text = "Hàng Hóa";
            // 
            // cmbDVT
            // 
            this.cmbDVT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDVT.FormattingEnabled = true;
            this.cmbDVT.Items.AddRange(new object[] {
            "Thùng",
            "Cái"});
            this.cmbDVT.Location = new System.Drawing.Point(180, 148);
            this.cmbDVT.Name = "cmbDVT";
            this.cmbDVT.Size = new System.Drawing.Size(288, 21);
            this.cmbDVT.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Đơn Vị Tính";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(180, 96);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(336, 20);
            this.txtSL.TabIndex = 1;
            this.txtSL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSL_KeyPress);
            // 
            // dateHSD
            // 
            this.dateHSD.CustomFormat = "dd/MM/yyyy";
            this.dateHSD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateHSD.Location = new System.Drawing.Point(180, 197);
            this.dateHSD.Name = "dateHSD";
            this.dateHSD.Size = new System.Drawing.Size(336, 20);
            this.dateHSD.TabIndex = 5;
            // 
            // dateNSX
            // 
            this.dateNSX.CustomFormat = "dd/MM/yyyy";
            this.dateNSX.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNSX.Location = new System.Drawing.Point(180, 173);
            this.dateNSX.Name = "dateNSX";
            this.dateNSX.Size = new System.Drawing.Size(336, 20);
            this.dateNSX.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Hạn Sử Dụng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ngày Sản Xuất";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(486, 125);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(30, 13);
            this.label.TabIndex = 8;
            this.label.Text = "VND";
            // 
            // txtDG
            // 
            this.txtDG.Location = new System.Drawing.Point(180, 122);
            this.txtDG.Name = "txtDG";
            this.txtDG.Size = new System.Drawing.Size(288, 20);
            this.txtDG.TabIndex = 2;
            this.txtDG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDG_KeyPress);
            // 
            // txtTH
            // 
            this.txtTH.Location = new System.Drawing.Point(180, 70);
            this.txtTH.Name = "txtTH";
            this.txtTH.Size = new System.Drawing.Size(336, 20);
            this.txtTH.TabIndex = 0;
            // 
            // txtMH
            // 
            this.txtMH.Enabled = false;
            this.txtMH.Location = new System.Drawing.Point(180, 44);
            this.txtMH.Name = "txtMH";
            this.txtMH.Size = new System.Drawing.Size(336, 20);
            this.txtMH.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Đơn Giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số Lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Hàng Hóa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã hàng hóa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnChen);
            this.groupBox2.Controls.Add(this.ptB);
            this.groupBox2.Location = new System.Drawing.Point(553, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 209);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hình Hàng";
            // 
            // btnChen
            // 
            this.btnChen.Image = ((System.Drawing.Image)(resources.GetObject("btnChen.Image")));
            this.btnChen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChen.Location = new System.Drawing.Point(53, 178);
            this.btnChen.Name = "btnChen";
            this.btnChen.Size = new System.Drawing.Size(91, 25);
            this.btnChen.TabIndex = 1;
            this.btnChen.Text = "Chèn Hình";
            this.btnChen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChen.UseVisualStyleBackColor = true;
            this.btnChen.Click += new System.EventHandler(this.btnChen_Click);
            // 
            // ptB
            // 
            this.ptB.BackColor = System.Drawing.Color.White;
            this.ptB.Location = new System.Drawing.Point(14, 19);
            this.ptB.Name = "ptB";
            this.ptB.Size = new System.Drawing.Size(187, 142);
            this.ptB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptB.TabIndex = 0;
            this.ptB.TabStop = false;
            // 
            // btnLoad
            // 
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.Location = new System.Drawing.Point(254, 302);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 35);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(360, 302);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 35);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(31, 343);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.61749F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.38251F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(785, 179);
            this.tableLayoutPanel1.TabIndex = 5;
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
            this.Column7,
            this.Column5,
            this.Column6});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(779, 154);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Mahang";
            this.Column1.HeaderText = "Mã Hàng";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Tenhang";
            this.Column2.HeaderText = "Tên Hàng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "soluong";
            this.Column3.HeaderText = "Số Lượng";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "dongia";
            this.Column4.HeaderText = "Đơn Giá ($VND)";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "DVT";
            this.Column7.HeaderText = "Đơn Vị Tính";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NSX";
            this.Column5.HeaderText = "NSX";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "HSD";
            this.Column6.HeaderText = "HSD";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnHuy
            // 
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(466, 302);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 35);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Cancel";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmQLHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(847, 530);
            this.ControlBox = false;
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.grpHH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQLHangHoa";
            this.Text = "Quản Lý Hàng Hóa";
            this.Load += new System.EventHandler(this.frmHangHoa_Load);
            this.grpHH.ResumeLayout(false);
            this.grpHH.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptB)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpHH;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtDG;
        private System.Windows.Forms.TextBox txtTH;
        private System.Windows.Forms.TextBox txtMH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnChen;
        private System.Windows.Forms.PictureBox ptB;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DateTimePicker dateHSD;
        private System.Windows.Forms.DateTimePicker dateNSX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.ComboBox cmbDVT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;

    }
}