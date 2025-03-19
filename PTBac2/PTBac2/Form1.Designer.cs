namespace PTBac2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.a_tb = new System.Windows.Forms.TextBox();
            this.b_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.c_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.result_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.solve_bt = new System.Windows.Forms.Button();
            this.earse_bt = new System.Windows.Forms.Button();
            this.exit_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(2, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHƯƠNG TRÌNH BẬC 2";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập A:";
            // 
            // a_tb
            // 
            this.a_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a_tb.Location = new System.Drawing.Point(202, 111);
            this.a_tb.Name = "a_tb";
            this.a_tb.Size = new System.Drawing.Size(220, 26);
            this.a_tb.TabIndex = 2;
            // 
            // b_tb
            // 
            this.b_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_tb.Location = new System.Drawing.Point(202, 161);
            this.b_tb.Name = "b_tb";
            this.b_tb.Size = new System.Drawing.Size(220, 26);
            this.b_tb.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhập B:";
            // 
            // c_tb
            // 
            this.c_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_tb.Location = new System.Drawing.Point(202, 221);
            this.c_tb.Name = "c_tb";
            this.c_tb.Size = new System.Drawing.Size(220, 26);
            this.c_tb.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(116, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nhập C:";
            // 
            // result_tb
            // 
            this.result_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_tb.Location = new System.Drawing.Point(202, 265);
            this.result_tb.Multiline = true;
            this.result_tb.Name = "result_tb";
            this.result_tb.ReadOnly = true;
            this.result_tb.Size = new System.Drawing.Size(220, 50);
            this.result_tb.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(116, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Kết quả:";
            // 
            // solve_bt
            // 
            this.solve_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solve_bt.Location = new System.Drawing.Point(78, 335);
            this.solve_bt.Name = "solve_bt";
            this.solve_bt.Size = new System.Drawing.Size(104, 34);
            this.solve_bt.TabIndex = 9;
            this.solve_bt.Text = "&Giải";
            this.solve_bt.UseVisualStyleBackColor = true;
            this.solve_bt.Click += new System.EventHandler(this.solve_bt_Click);
            // 
            // earse_bt
            // 
            this.earse_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.earse_bt.Location = new System.Drawing.Point(236, 335);
            this.earse_bt.Name = "earse_bt";
            this.earse_bt.Size = new System.Drawing.Size(104, 34);
            this.earse_bt.TabIndex = 9;
            this.earse_bt.Text = "&Xóa";
            this.earse_bt.UseVisualStyleBackColor = true;
            this.earse_bt.Click += new System.EventHandler(this.earse_bt_Click);
            // 
            // exit_bt
            // 
            this.exit_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_bt.Location = new System.Drawing.Point(401, 335);
            this.exit_bt.Name = "exit_bt";
            this.exit_bt.Size = new System.Drawing.Size(104, 34);
            this.exit_bt.TabIndex = 9;
            this.exit_bt.Text = "&Thoát";
            this.exit_bt.UseVisualStyleBackColor = true;
            this.exit_bt.Click += new System.EventHandler(this.exit_bt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 381);
            this.Controls.Add(this.exit_bt);
            this.Controls.Add(this.earse_bt);
            this.Controls.Add(this.solve_bt);
            this.Controls.Add(this.result_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.c_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.b_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.a_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Giải phương trình bậc 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox a_tb;
        private System.Windows.Forms.TextBox b_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox c_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox result_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button solve_bt;
        private System.Windows.Forms.Button earse_bt;
        private System.Windows.Forms.Button exit_bt;
    }
}

