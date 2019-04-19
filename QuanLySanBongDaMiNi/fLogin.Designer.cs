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
            this.lbID = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.txtbID = new System.Windows.Forms.TextBox();
            this.txtbPass = new System.Windows.Forms.TextBox();
            this.grboxAccount = new System.Windows.Forms.GroupBox();
            this.bttExit = new System.Windows.Forms.Button();
            this.bttLogin = new System.Windows.Forms.Button();
            this.grboxAccount.SuspendLayout();
            this.SuspendLayout();

            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(17, 25);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(64, 13);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "Tài khoản";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.Location = new System.Drawing.Point(17, 68);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(60, 13);
            this.lbPass.TabIndex = 2;
            this.lbPass.Text = "Mật khẩu";
            // 
            // txtbID
            // 
            this.txtbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbID.Location = new System.Drawing.Point(87, 18);
            this.txtbID.Name = "txtbID";
            this.txtbID.Size = new System.Drawing.Size(160, 20);
            this.txtbID.TabIndex = 1;
            // 
            // txtbPass
            // 
            this.txtbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPass.Location = new System.Drawing.Point(87, 68);
            this.txtbPass.Name = "txtbPass";
            this.txtbPass.PasswordChar = '*';
            this.txtbPass.Size = new System.Drawing.Size(160, 20);
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
            this.grboxAccount.Location = new System.Drawing.Point(12, 12);
            this.grboxAccount.Name = "grboxAccount";
            this.grboxAccount.Size = new System.Drawing.Size(265, 157);
            this.grboxAccount.TabIndex = 5;
            this.grboxAccount.TabStop = false;
            this.grboxAccount.Text = "Đăng nhập";
            // 
            // bttExit
            // 
            this.bttExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttExit.Location = new System.Drawing.Point(131, 103);
            this.bttExit.Name = "bttExit";
            this.bttExit.Size = new System.Drawing.Size(117, 35);
            this.bttExit.TabIndex = 5;
            this.bttExit.Text = "Thoát";
            this.bttExit.UseVisualStyleBackColor = true;
            this.bttExit.Click += new System.EventHandler(this.bttExit_Click);
            // 
            // bttLogin
            // 
            this.bttLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttLogin.Location = new System.Drawing.Point(20, 103);
            this.bttLogin.Name = "bttLogin";
            this.bttLogin.Size = new System.Drawing.Size(105, 35);
            this.bttLogin.TabIndex = 4;
            this.bttLogin.Text = "Đăng nhập";
            this.bttLogin.UseVisualStyleBackColor = true;
            this.bttLogin.Click += new System.EventHandler(this.bttLogin_Click);
            // 
            // fLogin
            // 
            this.AcceptButton = this.bttLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bttExit;
            this.ClientSize = new System.Drawing.Size(286, 178);
            this.Controls.Add(this.grboxAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.TextBox txtbID;
        private System.Windows.Forms.TextBox txtbPass;
        private System.Windows.Forms.GroupBox grboxAccount;
        private System.Windows.Forms.Button bttLogin;
        private System.Windows.Forms.Button bttExit;
    }
}

