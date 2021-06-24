namespace QuanLyXuatNhapHang
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpHT = new System.Windows.Forms.GroupBox();
            this.btnCPass = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.picM = new System.Windows.Forms.PictureBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.QLNS = new System.Windows.Forms.ToolStripMenuItem();
            this.QLH = new System.Windows.Forms.ToolStripMenuItem();
            this.QLXH = new System.Windows.Forms.ToolStripMenuItem();
            this.QLNH = new System.Windows.Forms.ToolStripMenuItem();
            this.QLKH = new System.Windows.Forms.ToolStripMenuItem();
            this.QLCTN = new System.Windows.Forms.ToolStripMenuItem();
            this.HoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.xHD = new System.Windows.Forms.ToolStripMenuItem();
            this.liênHệToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.grpHT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picM)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.HoaDon,
            this.liênHệToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(847, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(625, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tên Nhân Viên:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblName.Location = new System.Drawing.Point(727, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(10, 13);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "-";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(592, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "          ";
            // 
            // grpHT
            // 
            this.grpHT.BackColor = System.Drawing.Color.AliceBlue;
            this.grpHT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpHT.BackgroundImage")));
            this.grpHT.Controls.Add(this.btnCPass);
            this.grpHT.Controls.Add(this.btnLogOut);
            this.grpHT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grpHT.Location = new System.Drawing.Point(628, 25);
            this.grpHT.Name = "grpHT";
            this.grpHT.Size = new System.Drawing.Size(219, 52);
            this.grpHT.TabIndex = 16;
            this.grpHT.TabStop = false;
            this.grpHT.Visible = false;
            // 
            // btnCPass
            // 
            this.btnCPass.Image = ((System.Drawing.Image)(resources.GetObject("btnCPass.Image")));
            this.btnCPass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCPass.Location = new System.Drawing.Point(110, 12);
            this.btnCPass.Name = "btnCPass";
            this.btnCPass.Size = new System.Drawing.Size(103, 31);
            this.btnCPass.TabIndex = 1;
            this.btnCPass.Text = "Đổi Mật Khẩu";
            this.btnCPass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCPass.UseVisualStyleBackColor = true;
            this.btnCPass.Click += new System.EventHandler(this.btnCPass_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(13, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(91, 31);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "Đăng Xuất";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // picM
            // 
            this.picM.Image = ((System.Drawing.Image)(resources.GetObject("picM.Image")));
            this.picM.Location = new System.Drawing.Point(0, 27);
            this.picM.Name = "picM";
            this.picM.Size = new System.Drawing.Size(847, 522);
            this.picM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picM.TabIndex = 11;
            this.picM.TabStop = false;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QLNS,
            this.QLH,
            this.QLXH,
            this.QLNH,
            this.QLKH,
            this.QLCTN});
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(79, 20);
            this.toolStripMenuItem1.Text = "Quản Lý";
            // 
            // QLNS
            // 
            this.QLNS.Image = global::QuanLyXuatNhapHang.Properties.Resources._686909_user_people_man_human_head_person_512;
            this.QLNS.Name = "QLNS";
            this.QLNS.Size = new System.Drawing.Size(221, 22);
            this.QLNS.Text = "Quản Lý Nhân Sự";
            this.QLNS.Click += new System.EventHandler(this.QLNS_Click);
            // 
            // QLH
            // 
            this.QLH.Image = global::QuanLyXuatNhapHang.Properties.Resources.menu_275190_1633302648;
            this.QLH.Name = "QLH";
            this.QLH.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.QLH.Size = new System.Drawing.Size(221, 22);
            this.QLH.Text = "Quản Lý Hàng";
            this.QLH.Click += new System.EventHandler(this.QLH_Click);
            // 
            // QLXH
            // 
            this.QLXH.Image = global::QuanLyXuatNhapHang.Properties.Resources._004390_black_inlay_crystal_clear_bubble_icon_arrows_arrow1_solid_right___Copy;
            this.QLXH.Name = "QLXH";
            this.QLXH.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.QLXH.Size = new System.Drawing.Size(221, 22);
            this.QLXH.Text = "Quản Lý Xuất Hàng";
            this.QLXH.Click += new System.EventHandler(this.QLXH_Click);
            // 
            // QLNH
            // 
            this.QLNH.Image = global::QuanLyXuatNhapHang.Properties.Resources._004390_black_inlay_crystal_clear_bubble_icon_arrows_arrow1_solid_right;
            this.QLNH.Name = "QLNH";
            this.QLNH.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.QLNH.Size = new System.Drawing.Size(221, 22);
            this.QLNH.Text = "Quản Lý Nhập Hàng";
            this.QLNH.Click += new System.EventHandler(this.QLNH_Click);
            // 
            // QLKH
            // 
            this.QLKH.Name = "QLKH";
            this.QLKH.Size = new System.Drawing.Size(221, 22);
            this.QLKH.Text = "Quản Lý Khách Hàng";
            this.QLKH.Click += new System.EventHandler(this.QLKH_Click);
            // 
            // QLCTN
            // 
            this.QLCTN.Name = "QLCTN";
            this.QLCTN.Size = new System.Drawing.Size(221, 22);
            this.QLCTN.Text = "Quản Lý Công Ty Nhập";
            this.QLCTN.Click += new System.EventHandler(this.QLCTN_Click);
            // 
            // HoaDon
            // 
            this.HoaDon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xHD});
            this.HoaDon.Image = ((System.Drawing.Image)(resources.GetObject("HoaDon.Image")));
            this.HoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HoaDon.Name = "HoaDon";
            this.HoaDon.Size = new System.Drawing.Size(59, 20);
            this.HoaDon.Text = "Xem";
            // 
            // xHD
            // 
            this.xHD.Name = "xHD";
            this.xHD.Size = new System.Drawing.Size(148, 22);
            this.xHD.Text = "Xem Hóa Đơn";
            this.xHD.Click += new System.EventHandler(this.xHD_Click);
            // 
            // liênHệToolStripMenuItem
            // 
            this.liênHệToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("liênHệToolStripMenuItem.Image")));
            this.liênHệToolStripMenuItem.Name = "liênHệToolStripMenuItem";
            this.liênHệToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.liênHệToolStripMenuItem.Text = "Liên Hệ";
            this.liênHệToolStripMenuItem.Click += new System.EventHandler(this.liênHệToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 547);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpHT);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picM);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Xuất Nhập Hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpHT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem QLNS;
        private System.Windows.Forms.ToolStripMenuItem QLH;
        private System.Windows.Forms.ToolStripMenuItem QLXH;
        private System.Windows.Forms.ToolStripMenuItem QLNH;
        private System.Windows.Forms.ToolStripMenuItem QLKH;
        private System.Windows.Forms.ToolStripMenuItem QLCTN;
        private System.Windows.Forms.ToolStripMenuItem HoaDon;
        private System.Windows.Forms.ToolStripMenuItem xHD;
        private System.Windows.Forms.PictureBox picM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox grpHT;
        private System.Windows.Forms.Button btnCPass;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem liênHệToolStripMenuItem;
       
    }
}