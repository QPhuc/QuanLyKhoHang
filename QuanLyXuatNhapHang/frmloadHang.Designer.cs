namespace QuanLyXuatNhapHang
{
    partial class frmloadHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmloadHang));
            this.grp = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTIm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMH = new System.Windows.Forms.Label();
            this.btnAC = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grp
            // 
            this.grp.Controls.Add(this.dataGridView1);
            this.grp.Location = new System.Drawing.Point(10, 140);
            this.grp.Name = "grp";
            this.grp.Size = new System.Drawing.Size(282, 150);
            this.grp.TabIndex = 0;
            this.grp.TabStop = false;
            this.grp.Text = "Mã và tên hàng";
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
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(276, 131);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên hàng";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnTIm
            // 
            this.btnTIm.Image = ((System.Drawing.Image)(resources.GetObject("btnTIm.Image")));
            this.btnTIm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTIm.Location = new System.Drawing.Point(217, 47);
            this.btnTIm.Name = "btnTIm";
            this.btnTIm.Size = new System.Drawing.Size(75, 23);
            this.btnTIm.TabIndex = 3;
            this.btnTIm.Text = "Tìm kiếm";
            this.btnTIm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTIm.UseVisualStyleBackColor = true;
            this.btnTIm.Click += new System.EventHandler(this.btnTIm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(59, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tìm Kiếm mã Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã Hàng:";
            // 
            // txtMH
            // 
            this.txtMH.AutoSize = true;
            this.txtMH.Location = new System.Drawing.Point(122, 93);
            this.txtMH.Name = "txtMH";
            this.txtMH.Size = new System.Drawing.Size(10, 13);
            this.txtMH.TabIndex = 6;
            this.txtMH.Text = "-";
            // 
            // btnAC
            // 
            this.btnAC.Image = ((System.Drawing.Image)(resources.GetObject("btnAC.Image")));
            this.btnAC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAC.Location = new System.Drawing.Point(218, 83);
            this.btnAC.Name = "btnAC";
            this.btnAC.Size = new System.Drawing.Size(75, 23);
            this.btnAC.TabIndex = 7;
            this.btnAC.Text = "Xác Nhận";
            this.btnAC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAC.UseVisualStyleBackColor = true;
            this.btnAC.Click += new System.EventHandler(this.btnAC_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmloadHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 302);
            this.Controls.Add(this.btnAC);
            this.Controls.Add(this.txtMH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTIm);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmloadHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm Mã Hàng";
            this.Load += new System.EventHandler(this.frmloadHang_Load);
            this.grp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnTIm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtMH;
        private System.Windows.Forms.Button btnAC;
        private System.Windows.Forms.Timer timer1;
    }
}