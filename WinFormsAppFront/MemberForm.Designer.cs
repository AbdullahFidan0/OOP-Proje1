namespace WinFormsAppFront
{
    partial class MemberForm
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
            lblWelcome = new Label();
            lblPackage = new Label();
            lblEndDate = new Label();
            lstMyLessons = new ListBox();
            btnCatalog = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(12, 9);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(48, 15);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Üye Adı";
            // 
            // lblPackage
            // 
            lblPackage.AutoSize = true;
            lblPackage.Location = new Point(12, 34);
            lblPackage.Name = "lblPackage";
            lblPackage.Size = new Size(57, 15);
            lblPackage.TabIndex = 1;
            lblPackage.Text = "Paket Adı";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(12, 61);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(61, 15);
            lblEndDate.TabIndex = 2;
            lblEndDate.Text = "Bitiş Tarihi";
            // 
            // lstMyLessons
            // 
            lstMyLessons.FormattingEnabled = true;
            lstMyLessons.Location = new Point(12, 194);
            lstMyLessons.Name = "lstMyLessons";
            lstMyLessons.Size = new Size(120, 94);
            lstMyLessons.TabIndex = 3;
            // 
            // btnCatalog
            // 
            btnCatalog.Location = new Point(12, 104);
            btnCatalog.Name = "btnCatalog";
            btnCatalog.Size = new Size(117, 23);
            btnCatalog.TabIndex = 4;
            btnCatalog.Text = "Ders Kataloğu";
            btnCatalog.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(12, 144);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(117, 23);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Çıkış";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // MemberForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnCatalog);
            Controls.Add(lstMyLessons);
            Controls.Add(lblEndDate);
            Controls.Add(lblPackage);
            Controls.Add(lblWelcome);
            Name = "MemberForm";
            Text = "MemberForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Label lblPackage;
        private Label lblEndDate;
        private ListBox lstMyLessons;
        private Button btnCatalog;
        private Button btnLogout;
    }
}