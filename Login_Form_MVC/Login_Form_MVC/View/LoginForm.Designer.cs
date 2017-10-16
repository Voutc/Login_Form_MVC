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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(145, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(134, 22);
            this.textBox2.TabIndex = 4;
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(145, 125);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '1';
            this.textBox3.Size = new System.Drawing.Size(134, 22);
            this.textBox3.TabIndex = 8;
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
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(145, 97);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(134, 22);
            this.textBox4.TabIndex = 6;
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
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(145, 153);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(134, 22);
            this.textBox5.TabIndex = 11;
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
            this.btnLogin.Location = new System.Drawing.Point(15, 191);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 27);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "Είσοδος";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(145, 191);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 27);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Ακύρωση";
            this.btnCancel.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.lblRetPass);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "Login Form MVC";
            ((System.ComponentModel.ISupportInitialize)(this.pctrLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lblRetPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pctrLogin;
    }
}

