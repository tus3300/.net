namespace GUI.FRM
{
    partial class frmChangePassword
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
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.txtPrePassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(312, 198);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(274, 35);
            this.txtNewPassword.TabIndex = 1;
            this.txtNewPassword.Tag = "Mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 36);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mật khẩu mới";
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPassword.Location = new System.Drawing.Point(312, 120);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.PasswordChar = '*';
            this.txtOldPassword.Size = new System.Drawing.Size(274, 35);
            this.txtOldPassword.TabIndex = 0;
            this.txtOldPassword.Tag = "Mật khẩu cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 36);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mật khẩu cũ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(184, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 58);
            this.label1.TabIndex = 17;
            this.label1.Text = "Đổi mật khẩu";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.AutoSize = true;
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Image = global::GUI.Properties.Resources.device;
            this.btnChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePassword.Location = new System.Drawing.Point(243, 332);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(197, 39);
            this.btnChangePassword.TabIndex = 3;
            this.btnChangePassword.Text = "Xác nhận";
            this.btnChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // txtPrePassword
            // 
            this.txtPrePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrePassword.Location = new System.Drawing.Point(312, 269);
            this.txtPrePassword.Name = "txtPrePassword";
            this.txtPrePassword.PasswordChar = '*';
            this.txtPrePassword.Size = new System.Drawing.Size(274, 35);
            this.txtPrePassword.TabIndex = 2;
            this.txtPrePassword.Tag = "Xác nhận mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 36);
            this.label4.TabIndex = 22;
            this.label4.Text = "Xác nhận mật khẩu";
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 401);
            this.Controls.Add(this.txtPrePassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChangePassword);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.TextBox txtPrePassword;
        private System.Windows.Forms.Label label4;
    }
}