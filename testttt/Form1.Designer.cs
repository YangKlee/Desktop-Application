namespace testttt
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_list = new System.Windows.Forms.FlowLayoutPanel();
            this.add_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.lop_tb = new System.Windows.Forms.ComboBox();
            this.ngaysinh_tb = new System.Windows.Forms.DateTimePicker();
            this.diachi_tb = new System.Windows.Forms.TextBox();
            this.hoten_tb = new System.Windows.Forms.TextBox();
            this.msv_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dsSV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.btn_list.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_list);
            this.groupBox1.Controls.Add(this.lop_tb);
            this.groupBox1.Controls.Add(this.ngaysinh_tb);
            this.groupBox1.Controls.Add(this.diachi_tb);
            this.groupBox1.Controls.Add(this.hoten_tb);
            this.groupBox1.Controls.Add(this.msv_tb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 246);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // btn_list
            // 
            this.btn_list.Controls.Add(this.add_btn);
            this.btn_list.Controls.Add(this.edit_btn);
            this.btn_list.Controls.Add(this.delete_btn);
            this.btn_list.Controls.Add(this.exit_btn);
            this.btn_list.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.btn_list.Location = new System.Drawing.Point(320, 19);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(118, 202);
            this.btn_list.TabIndex = 4;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(3, 3);
            this.add_btn.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(93, 39);
            this.add_btn.TabIndex = 0;
            this.add_btn.Text = "Thêm mới";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(3, 53);
            this.edit_btn.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(93, 39);
            this.edit_btn.TabIndex = 1;
            this.edit_btn.Text = "Cập nhật item";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(3, 103);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(93, 39);
            this.delete_btn.TabIndex = 2;
            this.delete_btn.Text = "Xóa item";
            this.delete_btn.UseVisualStyleBackColor = true;
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(3, 153);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(93, 39);
            this.exit_btn.TabIndex = 3;
            this.exit_btn.Text = "Thoát";
            this.exit_btn.UseVisualStyleBackColor = true;
            // 
            // lop_tb
            // 
            this.lop_tb.FormattingEnabled = true;
            this.lop_tb.Items.AddRange(new object[] {
            "Lop A",
            "Lop B",
            "Lop C",
            "Lop D",
            "Lop E",
            "Lop F"});
            this.lop_tb.Location = new System.Drawing.Point(102, 183);
            this.lop_tb.Name = "lop_tb";
            this.lop_tb.Size = new System.Drawing.Size(201, 21);
            this.lop_tb.TabIndex = 3;
            // 
            // ngaysinh_tb
            // 
            this.ngaysinh_tb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngaysinh_tb.Location = new System.Drawing.Point(102, 145);
            this.ngaysinh_tb.Name = "ngaysinh_tb";
            this.ngaysinh_tb.Size = new System.Drawing.Size(201, 20);
            this.ngaysinh_tb.TabIndex = 2;
            // 
            // diachi_tb
            // 
            this.diachi_tb.Location = new System.Drawing.Point(102, 108);
            this.diachi_tb.Name = "diachi_tb";
            this.diachi_tb.Size = new System.Drawing.Size(201, 20);
            this.diachi_tb.TabIndex = 1;
            // 
            // hoten_tb
            // 
            this.hoten_tb.Location = new System.Drawing.Point(102, 71);
            this.hoten_tb.Name = "hoten_tb";
            this.hoten_tb.Size = new System.Drawing.Size(201, 20);
            this.hoten_tb.TabIndex = 1;
            // 
            // msv_tb
            // 
            this.msv_tb.Location = new System.Drawing.Point(102, 36);
            this.msv_tb.Name = "msv_tb";
            this.msv_tb.Size = new System.Drawing.Size(201, 20);
            this.msv_tb.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Lớp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SV:";
            // 
            // dsSV
            // 
            this.dsSV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.dsSV.FullRowSelect = true;
            this.dsSV.HideSelection = false;
            this.dsSV.Location = new System.Drawing.Point(13, 278);
            this.dsSV.MultiSelect = false;
            this.dsSV.Name = "dsSV";
            this.dsSV.Size = new System.Drawing.Size(474, 177);
            this.dsSV.TabIndex = 3;
            this.dsSV.UseCompatibleStateImageBehavior = false;
            this.dsSV.View = System.Windows.Forms.View.Details;
            this.dsSV.SelectedIndexChanged += new System.EventHandler(this.dsSV_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ tên";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Địa chỉ";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày sinh";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Lớp";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 467);
            this.Controls.Add(this.dsSV);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.btn_list.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel btn_list;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.ComboBox lop_tb;
        private System.Windows.Forms.DateTimePicker ngaysinh_tb;
        private System.Windows.Forms.TextBox diachi_tb;
        private System.Windows.Forms.TextBox hoten_tb;
        private System.Windows.Forms.TextBox msv_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView dsSV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

