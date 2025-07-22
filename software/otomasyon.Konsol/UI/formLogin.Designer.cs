namespace Otomasyon.UI
{
    partial class formLogin
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
            label1 = new Label();
            txtAdminPassword = new TextBox();
            btnLoginAdd = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(154, 99);
            label1.Name = "label1";
            label1.Size = new Size(206, 21);
            label1.TabIndex = 0;
            label1.Text = "Yönetici Parolasını Giriniz";
            // 
            // txtAdminPassword
            // 
            txtAdminPassword.Location = new Point(154, 123);
            txtAdminPassword.Name = "txtAdminPassword";
            txtAdminPassword.PasswordChar = '*';
            txtAdminPassword.Size = new Size(206, 23);
            txtAdminPassword.TabIndex = 1;
            // 
            // btnLoginAdd
            // 
            btnLoginAdd.Location = new Point(154, 152);
            btnLoginAdd.Name = "btnLoginAdd";
            btnLoginAdd.Size = new Size(75, 23);
            btnLoginAdd.TabIndex = 2;
            btnLoginAdd.Text = "Giriş Yap";
            btnLoginAdd.UseVisualStyleBackColor = true;
            btnLoginAdd.Click += btnLoginAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(285, 152);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // formLogin
            // 
            AcceptButton = btnLoginAdd;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CancelButton = btnCancel;
            ClientSize = new Size(505, 297);
            Controls.Add(btnCancel);
            Controls.Add(btnLoginAdd);
            Controls.Add(txtAdminPassword);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "formLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAdminPassword;
        private Button btnLoginAdd;
        private Button btnCancel;
    }
}