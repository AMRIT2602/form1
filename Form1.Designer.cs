namespace form1
{
    partial class Form1
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
            this.lbl_firstnumber = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.lbl_secondnumber = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbl_result = new System.Windows.Forms.Label();
            this.Subtract = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_firstnumber
            // 
            this.lbl_firstnumber.AutoSize = true;
            this.lbl_firstnumber.Location = new System.Drawing.Point(333, 85);
            this.lbl_firstnumber.Name = "lbl_firstnumber";
            this.lbl_firstnumber.Size = new System.Drawing.Size(83, 17);
            this.lbl_firstnumber.TabIndex = 0;
            this.lbl_firstnumber.Text = "first number";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(464, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(201, 315);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 2;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lbl_secondnumber
            // 
            this.lbl_secondnumber.AutoSize = true;
            this.lbl_secondnumber.Location = new System.Drawing.Point(311, 145);
            this.lbl_secondnumber.Name = "lbl_secondnumber";
            this.lbl_secondnumber.Size = new System.Drawing.Size(106, 17);
            this.lbl_secondnumber.TabIndex = 3;
            this.lbl_secondnumber.Text = "second number";
            this.lbl_secondnumber.Click += new System.EventHandler(this.Label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(464, 145);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(464, 198);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 5;
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(320, 203);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(48, 17);
            this.lbl_result.TabIndex = 6;
            this.lbl_result.Text = "Result";
            this.lbl_result.Click += new System.EventHandler(this.Lbl_result_Click);
            // 
            // Subtract
            // 
            this.Subtract.Location = new System.Drawing.Point(340, 315);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(75, 23);
            this.Subtract.TabIndex = 7;
            this.Subtract.Text = "Subtract";
            this.Subtract.UseVisualStyleBackColor = true;
            this.Subtract.Click += new System.EventHandler(this.Subtract_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(444, 315);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(75, 23);
            this.divide.TabIndex = 8;
            this.divide.Text = "divide";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(579, 315);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(75, 23);
            this.multiply.TabIndex = 9;
            this.multiply.Text = "multiply";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(689, 315);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 10;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbl_secondnumber);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_firstnumber);
            this.Name = "Form1";
            this.Text = "form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_firstnumber;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label lbl_secondnumber;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Button Subtract;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button clear;
    }
}

