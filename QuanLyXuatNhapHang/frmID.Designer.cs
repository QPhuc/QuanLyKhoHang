namespace QuanLyXuatNhapHang
{
    partial class frmID
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmID));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtMKR = new System.Windows.Forms.TextBox();
            this.txtPQ = new System.Windows.Forms.TextBox();
            this.rdUS = new System.Windows.Forms.RadioButton();
            this.rdMa = new System.Windows.Forms.RadioButton();
            this.rdAd = new System.Windows.Forms.RadioButton();
            this.grpPQ = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpPQ.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(16, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(223, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật Khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "KT Mật Khảu";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(168, 126);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(94, 20);
            this.txtID.TabIndex = 5;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(121, 171);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(141, 20);
            this.txtMK.TabIndex = 6;
            // 
            // txtMKR
            // 
            this.txtMKR.Location = new System.Drawing.Point(121, 217);
            this.txtMKR.Name = "txtMKR";
            this.txtMKR.Size = new System.Drawing.Size(141, 20);
            this.txtMKR.TabIndex = 7;
            // 
            // txtPQ
            // 
            this.txtPQ.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPQ.Enabled = false;
            this.txtPQ.Location = new System.Drawing.Point(117, 126);
            this.txtPQ.Name = "txtPQ";
            this.txtPQ.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPQ.Size = new System.Drawing.Size(45, 20);
            this.txtPQ.TabIndex = 8;
            this.txtPQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rdUS
            // 
            this.rdUS.AutoSize = true;
            this.rdUS.Location = new System.Drawing.Point(6, 19);
            this.rdUS.Name = "rdUS";
            this.rdUS.Size = new System.Drawing.Size(47, 17);
            this.rdUS.TabIndex = 10;
            this.rdUS.TabStop = true;
            this.rdUS.Text = "User";
            this.rdUS.UseVisualStyleBackColor = true;
            this.rdUS.CheckedChanged += new System.EventHandler(this.rdUS_CheckedChanged);
            // 
            // rdMa
            // 
            this.rdMa.AutoSize = true;
            this.rdMa.Location = new System.Drawing.Point(105, 19);
            this.rdMa.Name = "rdMa";
            this.rdMa.Size = new System.Drawing.Size(67, 17);
            this.rdMa.TabIndex = 11;
            this.rdMa.TabStop = true;
            this.rdMa.Text = "Manager";
            this.rdMa.UseVisualStyleBackColor = true;
            this.rdMa.CheckedChanged += new System.EventHandler(this.rdMa_CheckedChanged);
            // 
            // rdAd
            // 
            this.rdAd.AutoSize = true;
            this.rdAd.Location = new System.Drawing.Point(227, 19);
            this.rdAd.Name = "rdAd";
            this.rdAd.Size = new System.Drawing.Size(54, 17);
            this.rdAd.TabIndex = 12;
            this.rdAd.TabStop = true;
            this.rdAd.Text = "Admin";
            this.rdAd.UseVisualStyleBackColor = true;
            this.rdAd.CheckedChanged += new System.EventHandler(this.rdAd_CheckedChanged);
            // 
            // grpPQ
            // 
            this.grpPQ.Controls.Add(this.rdMa);
            this.grpPQ.Controls.Add(this.rdAd);
            this.grpPQ.Controls.Add(this.rdUS);
            this.grpPQ.Location = new System.Drawing.Point(16, 53);
            this.grpPQ.Name = "grpPQ";
            this.grpPQ.Size = new System.Drawing.Size(303, 50);
            this.grpPQ.TabIndex = 13;
            this.grpPQ.TabStop = false;
            this.grpPQ.Text = "Phân Quyền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(31, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "           ";
            // 
            // frmID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 327);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grpPQ);
            this.Controls.Add(this.txtPQ);
            this.Controls.Add(this.txtMKR);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Tài Khoản";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmID_FormClosing);
            this.Load += new System.EventHandler(this.frmID_Load);
            this.grpPQ.ResumeLayout(false);
            this.grpPQ.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtMKR;
        private System.Windows.Forms.TextBox txtPQ;
        private System.Windows.Forms.RadioButton rdUS;
        private System.Windows.Forms.RadioButton rdMa;
        private System.Windows.Forms.RadioButton rdAd;
        private System.Windows.Forms.GroupBox grpPQ;
        private System.Windows.Forms.Label label4;
    }
}