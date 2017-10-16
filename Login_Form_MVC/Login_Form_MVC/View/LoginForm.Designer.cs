namespace Login_Form_MVC
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lblName = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txvPass = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.txbRetypePass = new System.Windows.Forms.TextBox();
            this.lblRetPass = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pctrLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctrLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 44);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(145, 41);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(134, 22);
            this.txbName.TabIndex = 2;
            // 
            // txbSurname
            // 
            this.txbSurname.Location = new System.Drawing.Point(145, 69);
            this.txbSurname.Name = "txbSurname";
            this.txbSurname.Size = new System.Drawing.Size(134, 22);
            this.txbSurname.TabIndex = 4;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(12, 72);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(65, 17);
            this.lblSurname.TabIndex = 3;
            this.lblSurname.Text = "Surname";
            // 
            // txvPass
            // 
            this.txvPass.Location = new System.Drawing.Point(145, 125);
            this.txvPass.Name = "txvPass";
            this.txvPass.PasswordChar = '●';
            this.txvPass.Size = new System.Drawing.Size(134, 22);
            this.txvPass.TabIndex = 8;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 128);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password";
            // 
            // txbUsername
            // 
            this.txbUsername.Location = new System.Drawing.Point(145, 97);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(134, 22);
            this.txbUsername.TabIndex = 6;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(12, 100);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(73, 17);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Username";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(12, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(270, 17);
            this.lblWelcome.TabIndex = 9;
            this.lblWelcome.Text = "Welcome to Digital Management Software";
            // 
            // txbRetypePass
            // 
            this.txbRetypePass.Location = new System.Drawing.Point(145, 153);
            this.txbRetypePass.Name = "txbRetypePass";
            this.txbRetypePass.PasswordChar = '●';
            this.txbRetypePass.Size = new System.Drawing.Size(134, 22);
            this.txbRetypePass.TabIndex = 11;
            // 
            // lblRetPass
            // 
            this.lblRetPass.AutoSize = true;
            this.lblRetPass.Location = new System.Drawing.Point(12, 156);
            this.lblRetPass.Name = "lblRetPass";
            this.lblRetPass.Size = new System.Drawing.Size(123, 17);
            this.lblRetPass.TabIndex = 10;
            this.lblRetPass.Text = "Re-type Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Location = new System.Drawing.Point(15, 191);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 27);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "Είσοδος";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(145, 191);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 27);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Ακύρωση";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pctrLogin
            // 
            this.pctrLogin.Image = global::Login_Form_MVC.Properties.Resources.WelcomeImage;
            this.pctrLogin.Location = new System.Drawing.Point(288, 11);
            this.pctrLogin.Name = "pctrLogin";
            this.pctrLogin.Size = new System.Drawing.Size(243, 207);
            this.pctrLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctrLogin.TabIndex = 14;
            this.pctrLogin.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 231);
            this.Controls.Add(this.pctrLogin);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txbRetypePass);
            this.Controls.Add(this.lblRetPass);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.txvPass);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txbUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txbSurname);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form MVC";
            ((System.ComponentModel.ISupportInitialize)(this.pctrLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txvPass;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TextBox txbRetypePass;
        private System.Windows.Forms.Label lblRetPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pctrLogin;
    }
}

