namespace QuanLySanBongDaMiNi
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.button1 = new System.Windows.Forms.Button();
            this.lbID = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.txtbID = new System.Windows.Forms.TextBox();
            this.txtbPass = new System.Windows.Forms.TextBox();
            this.grboxAccount = new System.Windows.Forms.GroupBox();
            this.bttLogin = new System.Windows.Forms.Button();
            this.bttExit = new System.Windows.Forms.Button();
            this.grboxAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(926, 749);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(26, 38);
            this.lbID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(90, 20);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "Tài khoản";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.Location = new System.Drawing.Point(26, 105);
            this.lbPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(85, 20);
            this.lbPass.TabIndex = 2;
            this.lbPass.Text = "Mật khẩu";
            // 
            // txtbID
            // 
            this.txtbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbID.Location = new System.Drawing.Point(130, 28);
            this.txtbID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbID.Name = "txtbID";
            this.txtbID.Size = new System.Drawing.Size(238, 26);
            this.txtbID.TabIndex = 1;
            // 
            // txtbPass
            // 
            this.txtbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPass.Location = new System.Drawing.Point(130, 105);
            this.txtbPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbPass.Name = "txtbPass";
            this.txtbPass.PasswordChar = '*';
            this.txtbPass.Size = new System.Drawing.Size(238, 26);
            this.txtbPass.TabIndex = 3;
            // 
            // grboxAccount
            // 
            this.grboxAccount.Controls.Add(this.bttExit);
            this.grboxAccount.Controls.Add(this.bttLogin);
            this.grboxAccount.Controls.Add(this.txtbPass);
            this.grboxAccount.Controls.Add(this.txtbID);
            this.grboxAccount.Controls.Add(this.lbPass);
            this.grboxAccount.Controls.Add(this.lbID);
            this.grboxAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grboxAccount.Location = new System.Drawing.Point(18, 18);
            this.grboxAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grboxAccount.Name = "grboxAccount";
            this.grboxAccount.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grboxAccount.Size = new System.Drawing.Size(393, 237);
            this.grboxAccount.TabIndex = 5;
            this.grboxAccount.TabStop = false;
            this.grboxAccount.Text = "Đăng nhập";
            // 
            // bttLogin
            // 
            this.bttLogin.Location = new System.Drawing.Point(30, 158);
            this.bttLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttLogin.Name = "bttLogin";
            this.bttLogin.Size = new System.Drawing.Size(158, 54);
            this.bttLogin.TabIndex = 4;
            this.bttLogin.Text = "Đăng nhập";
            this.bttLogin.UseVisualStyleBackColor = true;
            this.bttLogin.Click += new System.EventHandler(this.bttLogin_Click);
            // 
            // bttExit
            // 
            this.bttExit.Location = new System.Drawing.Point(196, 158);
            this.bttExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttExit.Name = "bttExit";
            this.bttExit.Size = new System.Drawing.Size(175, 54);
            this.bttExit.TabIndex = 5;
            this.bttExit.Text = "Thoát";
            this.bttExit.UseVisualStyleBackColor = true;
            this.bttExit.Click += new System.EventHandler(this.bttExit_Click);
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 274);
            this.Controls.Add(this.grboxAccount);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý sân bóng đá mini";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing);
            this.grboxAccount.ResumeLayout(false);
            this.grboxAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.TextBox txtbID;
        private System.Windows.Forms.TextBox txtbPass;
        private System.Windows.Forms.GroupBox grboxAccount;
        private System.Windows.Forms.Button bttLogin;
        private System.Windows.Forms.Button bttExit;
    }
}

