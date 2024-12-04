namespace BaiWDFA0301
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
            this.lbKhachHang = new System.Windows.Forms.ListBox();
            this.btXemThongTin = new System.Windows.Forms.Button();
            this.btXoaHet = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbKhachHang
            // 
            this.lbKhachHang.FormattingEnabled = true;
            this.lbKhachHang.Location = new System.Drawing.Point(37, 44);
            this.lbKhachHang.Name = "lbKhachHang";
            this.lbKhachHang.Size = new System.Drawing.Size(399, 212);
            this.lbKhachHang.TabIndex = 14;
            // 
            // btXemThongTin
            // 
            this.btXemThongTin.Location = new System.Drawing.Point(361, 260);
            this.btXemThongTin.Name = "btXemThongTin";
            this.btXemThongTin.Size = new System.Drawing.Size(75, 23);
            this.btXemThongTin.TabIndex = 13;
            this.btXemThongTin.Text = "Thông Tin";
            this.btXemThongTin.UseVisualStyleBackColor = true;
            // 
            // btXoaHet
            // 
            this.btXoaHet.Location = new System.Drawing.Point(280, 260);
            this.btXoaHet.Name = "btXoaHet";
            this.btXoaHet.Size = new System.Drawing.Size(75, 23);
            this.btXoaHet.TabIndex = 12;
            this.btXoaHet.Text = "Xóa Hết";
            this.btXoaHet.UseVisualStyleBackColor = true;
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(199, 260);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 23);
            this.btSua.TabIndex = 11;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(118, 260);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 10;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(37, 260);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 9;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Danh Sách Khách Hàng";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 312);
            this.Controls.Add(this.lbKhachHang);
            this.Controls.Add(this.btXemThongTin);
            this.Controls.Add(this.btXoaHet);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Chương Trình Quản Lý Khách Hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbKhachHang;
        private System.Windows.Forms.Button btXemThongTin;
        private System.Windows.Forms.Button btXoaHet;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label label1;
    }
}

