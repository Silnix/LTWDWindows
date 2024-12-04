namespace BaiWDFA0303
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtFoodItem = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstFoodItems = new System.Windows.Forms.ListBox();
            this.lstSelectedItems = new System.Windows.Forms.ListBox();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.btnMoveAllRight = new System.Windows.Forms.Button();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.btnMoveAllLeft = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFoodItem
            // 
            this.txtFoodItem.Location = new System.Drawing.Point(13, 13);
            this.txtFoodItem.Name = "txtFoodItem";
            this.txtFoodItem.Size = new System.Drawing.Size(200, 20);
            this.txtFoodItem.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(220, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstFoodItems
            // 
            this.lstFoodItems.FormattingEnabled = true;
            this.lstFoodItems.Location = new System.Drawing.Point(13, 50);
            this.lstFoodItems.Name = "lstFoodItems";
            this.lstFoodItems.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstFoodItems.Size = new System.Drawing.Size(200, 199);
            this.lstFoodItems.TabIndex = 2;
            // 
            // lstSelectedItems
            // 
            this.lstSelectedItems.FormattingEnabled = true;
            this.lstSelectedItems.Location = new System.Drawing.Point(352, 50);
            this.lstSelectedItems.Name = "lstSelectedItems";
            this.lstSelectedItems.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstSelectedItems.Size = new System.Drawing.Size(200, 199);
            this.lstSelectedItems.TabIndex = 3;
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.Location = new System.Drawing.Point(220, 50);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(120, 23);
            this.btnMoveRight.TabIndex = 4;
            this.btnMoveRight.Text = ">";
            this.btnMoveRight.UseVisualStyleBackColor = true;
            this.btnMoveRight.Click += new System.EventHandler(this.btnMoveRight_Click);
            // 
            // btnMoveAllRight
            // 
            this.btnMoveAllRight.Location = new System.Drawing.Point(220, 79);
            this.btnMoveAllRight.Name = "btnMoveAllRight";
            this.btnMoveAllRight.Size = new System.Drawing.Size(120, 23);
            this.btnMoveAllRight.TabIndex = 5;
            this.btnMoveAllRight.Text = ">>";
            this.btnMoveAllRight.UseVisualStyleBackColor = true;
            this.btnMoveAllRight.Click += new System.EventHandler(this.btnMoveAllRight_Click);
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.Location = new System.Drawing.Point(220, 108);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(120, 23);
            this.btnMoveLeft.TabIndex = 6;
            this.btnMoveLeft.Text = "<";
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            this.btnMoveLeft.Click += new System.EventHandler(this.btnMoveLeft_Click);
            // 
            // btnMoveAllLeft
            // 
            this.btnMoveAllLeft.Location = new System.Drawing.Point(220, 137);
            this.btnMoveAllLeft.Name = "btnMoveAllLeft";
            this.btnMoveAllLeft.Size = new System.Drawing.Size(120, 23);
            this.btnMoveAllLeft.TabIndex = 7;
            this.btnMoveAllLeft.Text = "<<";
            this.btnMoveAllLeft.UseVisualStyleBackColor = true;
            this.btnMoveAllLeft.Click += new System.EventHandler(this.btnMoveAllLeft_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Location = new System.Drawing.Point(558, 50);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(75, 23);
            this.btnMoveUp.TabIndex = 8;
            this.btnMoveUp.Text = "Lên";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Location = new System.Drawing.Point(558, 79);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(75, 23);
            this.btnMoveDown.TabIndex = 9;
            this.btnMoveDown.Text = "Xuống";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 261);
            this.Controls.Add(this.btnMoveDown);
            this.Controls.Add(this.btnMoveUp);
            this.Controls.Add(this.btnMoveAllLeft);
            this.Controls.Add(this.btnMoveLeft);
            this.Controls.Add(this.btnMoveAllRight);
            this.Controls.Add(this.btnMoveRight);
            this.Controls.Add(this.lstSelectedItems);
            this.Controls.Add(this.lstFoodItems);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtFoodItem);
            this.Name = "MainForm";
            this.Text = "Chuong Trinh Minh Hoa ListBox";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtFoodItem;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstFoodItems;
        private System.Windows.Forms.ListBox lstSelectedItems;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.Button btnMoveAllRight;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.Button btnMoveAllLeft;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveDown;
    }
}