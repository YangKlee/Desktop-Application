namespace Bai2Form
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
            this.username_tx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pass_tx = new System.Windows.Forms.TextBox();
            this.login_bt = new System.Windows.Forms.Button();
            this.exit_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(335, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin đăng nhập";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // username_tx
            // 
            this.username_tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_tx.Location = new System.Drawing.Point(155, 87);
            this.username_tx.Name = "username_tx";
            this.username_tx.Size = new System.Drawing.Size(161, 26);
            this.username_tx.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật khẩu:";
            // 
            // pass_tx
            // 
            this.pass_tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_tx.Location = new System.Drawing.Point(155, 146);
            this.pass_tx.Multiline = true;
            this.pass_tx.Name = "pass_tx";
            this.pass_tx.PasswordChar = '*';
            this.pass_tx.Size = new System.Drawing.Size(161, 26);
            this.pass_tx.TabIndex = 2;
            // 
            // login_bt
            // 
            this.login_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_bt.Location = new System.Drawing.Point(49, 228);
            this.login_bt.Name = "login_bt";
            this.login_bt.Size = new System.Drawing.Size(100, 39);
            this.login_bt.TabIndex = 3;
            this.login_bt.Text = "Đăng nhập";
            this.login_bt.UseVisualStyleBackColor = true;
            this.login_bt.Click += new System.EventHandler(this.login_bt_Click);
            // 
            // exit_bt
            // 
            this.exit_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_bt.Location = new System.Drawing.Point(202, 228);
            this.exit_bt.Name = "exit_bt";
            this.exit_bt.Size = new System.Drawing.Size(100, 39);
            this.exit_bt.TabIndex = 3;
            this.exit_bt.Text = "Thoát";
            this.exit_bt.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 318);
            this.Controls.Add(this.exit_bt);
            this.Controls.Add(this.login_bt);
            this.Controls.Add(this.pass_tx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.username_tx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username_tx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pass_tx;
        private System.Windows.Forms.Button login_bt;
        private System.Windows.Forms.Button exit_bt;
    }
}

