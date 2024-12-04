namespace BaiWDFA0402
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.wmpKhungHinh = new AxWMPLib.AxWindowsMediaPlayer();
            this.tbDuongDan = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ChonToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ChonToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ChonToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.giớiThiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.wmpKhungHinh)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wmpKhungHinh
            // 
            this.wmpKhungHinh.Enabled = true;
            this.wmpKhungHinh.Location = new System.Drawing.Point(58, 41);
            this.wmpKhungHinh.Name = "wmpKhungHinh";
            this.wmpKhungHinh.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpKhungHinh.OcxState")));
            this.wmpKhungHinh.Size = new System.Drawing.Size(385, 235);
            this.wmpKhungHinh.TabIndex = 0;
            // 
            // tbDuongDan
            // 
            this.tbDuongDan.Location = new System.Drawing.Point(85, 337);
            this.tbDuongDan.Multiline = true;
            this.tbDuongDan.Name = "tbDuongDan";
            this.tbDuongDan.Size = new System.Drawing.Size(308, 31);
            this.tbDuongDan.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(419, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Chọn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(98, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "Play";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(327, 374);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 31);
            this.button3.TabIndex = 4;
            this.button3.Text = "Stop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.giớiThiệuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(573, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChonToolStripMenuItem2,
            this.ChonToolStripMenuItem3,
            this.ChonToolStripMenuItem4,
            this.toolStripSeparator1,
            this.toolStripMenuItem5});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(45, 20);
            this.toolStripMenuItem1.Text = "Xử lý";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ChonToolStripMenuItem2
            // 
            this.ChonToolStripMenuItem2.Name = "ChonToolStripMenuItem2";
            this.ChonToolStripMenuItem2.Size = new System.Drawing.Size(199, 22);
            this.ChonToolStripMenuItem2.Text = "Chọn tệp tin Film/Nhạc";
            this.ChonToolStripMenuItem2.Click += new System.EventHandler(this.Chọn_Click);
            // 
            // ChonToolStripMenuItem3
            // 
            this.ChonToolStripMenuItem3.Name = "ChonToolStripMenuItem3";
            this.ChonToolStripMenuItem3.Size = new System.Drawing.Size(199, 22);
            this.ChonToolStripMenuItem3.Text = "Xem";
            this.ChonToolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // ChonToolStripMenuItem4
            // 
            this.ChonToolStripMenuItem4.Name = "ChonToolStripMenuItem4";
            this.ChonToolStripMenuItem4.Size = new System.Drawing.Size(152, 22);
            this.ChonToolStripMenuItem4.Text = "Ngừng";
            this.ChonToolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem5.Text = "Thoát";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // giớiThiệuToolStripMenuItem
            // 
            this.giớiThiệuToolStripMenuItem.Name = "giớiThiệuToolStripMenuItem";
            this.giớiThiệuToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.giớiThiệuToolStripMenuItem.Text = "Giới thiệu";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 412);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbDuongDan);
            this.Controls.Add(this.wmpKhungHinh);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Chuong trinh giai tri";
            ((System.ComponentModel.ISupportInitialize)(this.wmpKhungHinh)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmpKhungHinh;
        private System.Windows.Forms.TextBox tbDuongDan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ChonToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ChonToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem ChonToolStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem giớiThiệuToolStripMenuItem;
    }
}

