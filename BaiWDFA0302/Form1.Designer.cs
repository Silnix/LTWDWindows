namespace BaiWDFA0302
{
    partial class CalculatorForm
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
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.button0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSqrt = new System.Windows.Forms.Button();
            this.buttonMR = new System.Windows.Forms.Button();
            this.buttonMPlus = new System.Windows.Forms.Button();
            this.buttonPosNeg = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // textBox_Result
            this.textBox_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBox_Result.Location = new System.Drawing.Point(12, 12);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(260, 38);
            this.textBox_Result.TabIndex = 0;
            this.textBox_Result.Text = "0";
            this.textBox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // button0
            this.button0.Location = new System.Drawing.Point(69, 225);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(50, 50);
            this.button0.TabIndex = 1;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button_Click);

            // button1
            this.button1.Location = new System.Drawing.Point(13, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);

            // button2
            this.button2.Location = new System.Drawing.Point(69, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);

            // button3
            this.button3.Location = new System.Drawing.Point(125, 169);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 4;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);

            // button4
            this.button4.Location = new System.Drawing.Point(13, 113);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 5;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);

            // button5
            this.button5.Location = new System.Drawing.Point(69, 113);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 6;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);

            // button6
            this.button6.Location = new System.Drawing.Point(125, 113);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 50);
            this.button6.TabIndex = 7;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);

            // button7
            this.button7.Location = new System.Drawing.Point(13, 57);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 50);
            this.button7.TabIndex = 8;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);

            // button8
            this.button8.Location = new System.Drawing.Point(69, 57);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 50);
            this.button8.TabIndex = 9;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);

            // button9
            this.button9.Location = new System.Drawing.Point(125, 57);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(50, 50);
            this.button9.TabIndex = 10;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);

            // buttonAdd
            this.buttonAdd.Location = new System.Drawing.Point(181, 57);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(50, 50);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.operator_Click);

            // buttonSubtract
            this.buttonSubtract.Location = new System.Drawing.Point(181, 113);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(50, 50);
            this.buttonSubtract.TabIndex = 12;
            this.buttonSubtract.Text = "-";
            this.buttonSubtract.UseVisualStyleBackColor = true;
            this.buttonSubtract.Click += new System.EventHandler(this.operator_Click);

            // buttonMultiply
            this.buttonMultiply.Location = new System.Drawing.Point(181, 169);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(50, 50);
            this.buttonMultiply.TabIndex = 13;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.operator_Click);

            // buttonDivide
            this.buttonDivide.Location = new System.Drawing.Point(181, 225);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(50, 50);
            this.buttonDivide.TabIndex = 14;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.operator_Click);

            // buttonEquals
            this.buttonEquals.Location = new System.Drawing.Point(237, 169);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(50, 106);
            this.buttonEquals.TabIndex = 15;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = true;
            this.buttonEquals.Click += new System.EventHandler(this.button_Equals_Click);

            // buttonClear
            this.buttonClear.Location = new System.Drawing.Point(237, 57);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(50, 106);
            this.buttonClear.TabIndex = 16;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.button_Clear_Click);

            // buttonSqrt
            this.buttonSqrt.Location = new System.Drawing.Point(13, 225);
            this.buttonSqrt.Name = "buttonSqrt";
            this.buttonSqrt.Size = new System.Drawing.Size(50, 50);
            this.buttonSqrt.TabIndex = 17;
            this.buttonSqrt.Text = "Sqrt";
            this.buttonSqrt.UseVisualStyleBackColor = true;
            this.buttonSqrt.Click += new System.EventHandler(this.button_Sqrt_Click);

            // buttonMR
            this.buttonMR.Location = new System.Drawing.Point(13, 281);
            this.buttonMR.Name = "buttonMR";
            this.buttonMR.Size = new System.Drawing.Size(50, 50);
            this.buttonMR.TabIndex = 18;
            this.buttonMR.Text = "MR";
            this.buttonMR.UseVisualStyleBackColor = true;
            this.buttonMR.Click += new System.EventHandler(this.button_MR_Click);

            // buttonMPlus
            this.buttonMPlus.Location = new System.Drawing.Point(69, 281);
            this.buttonMPlus.Name = "buttonMPlus";
            this.buttonMPlus.Size = new System.Drawing.Size(50, 50);
            this.buttonMPlus.TabIndex = 19;
            this.buttonMPlus.Text = "M+";
            this.buttonMPlus.UseVisualStyleBackColor = true;
            this.buttonMPlus.Click += new System.EventHandler(this.button_MPlus_Click);

            // buttonPosNeg
            this.buttonPosNeg.Location = new System.Drawing.Point(125, 281);
            this.buttonPosNeg.Name = "buttonPosNeg";
            this.buttonPosNeg.Size = new System.Drawing.Size(50, 50);
            this.buttonPosNeg.TabIndex = 20;
            this.buttonPosNeg.Text = "+/-";
            this.buttonPosNeg.UseVisualStyleBackColor = true;
            this.buttonPosNeg.Click += new System.EventHandler(this.button_PosNeg_Click);

            // CalculatorForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 343);
            this.Controls.Add(this.buttonPosNeg);
            this.Controls.Add(this.buttonMPlus);
            this.Controls.Add(this.buttonMR);
            this.Controls.Add(this.buttonSqrt);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonSubtract);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.textBox_Result);
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSqrt;
        private System.Windows.Forms.Button buttonMR;
        private System.Windows.Forms.Button buttonMPlus;
        private System.Windows.Forms.Button buttonPosNeg;
    }
}