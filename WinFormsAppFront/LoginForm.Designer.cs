namespace WinFormsAppFront
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTc = new Label();
            lblPassword = new Label();
            txtTc = new TextBox();
            txtPassword = new TextBox();
            btnMemberLogin = new Button();
            btnAdminLogin = new Button();
            SuspendLayout();
            // 
            // lblTc
            // 
            lblTc.AutoSize = true;
            lblTc.Location = new Point(12, 9);
            lblTc.Name = "lblTc";
            lblTc.Size = new Size(86, 15);
            lblTc.TabIndex = 0;
            lblTc.Text = "T.C. Kimlik No:";
            // lblTc.Click += label1_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(12, 38);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(60, 15);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password:";
            // 
            // txtTc
            // 
            txtTc.Location = new Point(104, 6);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(100, 23);
            txtTc.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(104, 35);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 3;
            // 
            // btnMemberLogin
            // 
            btnMemberLogin.BackColor = SystemColors.Control;
            btnMemberLogin.Location = new Point(12, 77);
            btnMemberLogin.Name = "btnMemberLogin";
            btnMemberLogin.Size = new Size(115, 23);
            btnMemberLogin.TabIndex = 4;
            btnMemberLogin.Text = "Member Login";
            btnMemberLogin.UseVisualStyleBackColor = false;
            btnMemberLogin.Click += btnMemberLogin_Click;
            // 
            // btnAdminLogin
            // 
            btnAdminLogin.Location = new Point(12, 119);
            btnAdminLogin.Name = "btnAdminLogin";
            btnAdminLogin.Size = new Size(115, 23);
            btnAdminLogin.TabIndex = 5;
            btnAdminLogin.Text = "Admin Login";
            btnAdminLogin.UseVisualStyleBackColor = true;
            btnAdminLogin.Click += btnAdminLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdminLogin);
            Controls.Add(btnMemberLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtTc);
            Controls.Add(lblPassword);
            Controls.Add(lblTc);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTc;
        private Label lblPassword;
        private TextBox txtTc;
        private TextBox txtPassword;
        private Button btnMemberLogin;
        private Button btnAdminLogin;
    }
}
