namespace BTH4_B2
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
            this.msv_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hoten_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nienkhoa_cbox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lop_cbox = new System.Windows.Forms.ComboBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.label6 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.hk1_chkb = new System.Windows.Forms.RadioButton();
            this.hk2_cb = new System.Windows.Forms.RadioButton();
            this.hk3_chkb = new System.Windows.Forms.RadioButton();
            this.hk4_chkb = new System.Windows.Forms.RadioButton();
            this.subject_chklist = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(-1, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG KÝ MÔN HỌC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "MSSV:";
            // 
            // msv_tb
            // 
            this.msv_tb.Location = new System.Drawing.Point(128, 63);
            this.msv_tb.Name = "msv_tb";
            this.msv_tb.Size = new System.Drawing.Size(173, 20);
            this.msv_tb.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ và tên:";
            // 
            // hoten_tb
            // 
            this.hoten_tb.Location = new System.Drawing.Point(128, 103);
            this.hoten_tb.Name = "hoten_tb";
            this.hoten_tb.Size = new System.Drawing.Size(272, 20);
            this.hoten_tb.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Niên khóa";
            // 
            // nienkhoa_cbox
            // 
            this.nienkhoa_cbox.FormattingEnabled = true;
            this.nienkhoa_cbox.Items.AddRange(new object[] {
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010"});
            this.nienkhoa_cbox.Location = new System.Drawing.Point(128, 142);
            this.nienkhoa_cbox.Name = "nienkhoa_cbox";
            this.nienkhoa_cbox.Size = new System.Drawing.Size(193, 21);
            this.nienkhoa_cbox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Lớp";
            // 
            // lop_cbox
            // 
            this.lop_cbox.FormattingEnabled = true;
            this.lop_cbox.Items.AddRange(new object[] {
            "CNTT 46A",
            "CNTT 46B",
            "CNTT 46C",
            "CNTT 46D",
            "CNTT 46E",
            "CNTT 46F"});
            this.lop_cbox.Location = new System.Drawing.Point(128, 183);
            this.lop_cbox.Name = "lop_cbox";
            this.lop_cbox.Size = new System.Drawing.Size(193, 21);
            this.lop_cbox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Học kỳ:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.hk1_chkb);
            this.flowLayoutPanel1.Controls.Add(this.hk2_cb);
            this.flowLayoutPanel1.Controls.Add(this.hk3_chkb);
            this.flowLayoutPanel1.Controls.Add(this.hk4_chkb);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(128, 220);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(290, 27);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // hk1_chkb
            // 
            this.hk1_chkb.AutoSize = true;
            this.hk1_chkb.Location = new System.Drawing.Point(3, 3);
            this.hk1_chkb.Name = "hk1_chkb";
            this.hk1_chkb.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.hk1_chkb.Size = new System.Drawing.Size(58, 17);
            this.hk1_chkb.TabIndex = 0;
            this.hk1_chkb.TabStop = true;
            this.hk1_chkb.Text = "I";
            this.hk1_chkb.UseVisualStyleBackColor = true;
            // 
            // hk2_cb
            // 
            this.hk2_cb.AutoSize = true;
            this.hk2_cb.Location = new System.Drawing.Point(67, 3);
            this.hk2_cb.Name = "hk2_cb";
            this.hk2_cb.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.hk2_cb.Size = new System.Drawing.Size(61, 17);
            this.hk2_cb.TabIndex = 1;
            this.hk2_cb.TabStop = true;
            this.hk2_cb.Text = "II";
            this.hk2_cb.UseVisualStyleBackColor = true;
            // 
            // hk3_chkb
            // 
            this.hk3_chkb.AutoSize = true;
            this.hk3_chkb.Location = new System.Drawing.Point(134, 3);
            this.hk3_chkb.Name = "hk3_chkb";
            this.hk3_chkb.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.hk3_chkb.Size = new System.Drawing.Size(64, 17);
            this.hk3_chkb.TabIndex = 2;
            this.hk3_chkb.TabStop = true;
            this.hk3_chkb.Text = "III";
            this.hk3_chkb.UseVisualStyleBackColor = true;
            // 
            // hk4_chkb
            // 
            this.hk4_chkb.AutoSize = true;
            this.hk4_chkb.Location = new System.Drawing.Point(204, 3);
            this.hk4_chkb.Name = "hk4_chkb";
            this.hk4_chkb.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.hk4_chkb.Size = new System.Drawing.Size(65, 17);
            this.hk4_chkb.TabIndex = 3;
            this.hk4_chkb.TabStop = true;
            this.hk4_chkb.Text = "IV";
            this.hk4_chkb.UseVisualStyleBackColor = true;
            // 
            // subject_chklist
            // 
            this.subject_chklist.FormattingEnabled = true;
            this.subject_chklist.Items.AddRange(new object[] {
            "LT Windows",
            "LT Internet",
            "Mạng máy tính",
            "UML"});
            this.subject_chklist.Location = new System.Drawing.Point(131, 267);
            this.subject_chklist.Name = "subject_chklist";
            this.subject_chklist.Size = new System.Drawing.Size(228, 94);
            this.subject_chklist.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Môn học:";
            this.label7.Click += new System.EventHandler(this.label6_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(74, 396);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.button1.Size = new System.Drawing.Size(77, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Đăng ký";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(195, 396);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.button2.Size = new System.Drawing.Size(75, 43);
            this.button2.TabIndex = 7;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(306, 396);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.button3.Size = new System.Drawing.Size(75, 43);
            this.button3.TabIndex = 8;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 451);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.subject_chklist);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lop_cbox);
            this.Controls.Add(this.nienkhoa_cbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hoten_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.msv_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Dang ky mon hoc";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox msv_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hoten_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox nienkhoa_cbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox lop_cbox;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton hk1_chkb;
        private System.Windows.Forms.RadioButton hk2_cb;
        private System.Windows.Forms.RadioButton hk3_chkb;
        private System.Windows.Forms.RadioButton hk4_chkb;
        private System.Windows.Forms.CheckedListBox subject_chklist;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

