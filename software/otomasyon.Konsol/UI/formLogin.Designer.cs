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
            btnCancel = new MaterialSkin.Controls.MaterialButton();
            btnLoginAdd = new MaterialSkin.Controls.MaterialButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            txtAdminPassword = new MaterialSkin.Controls.MaterialTextBox2();
            pnlControls = new Panel();
            pnlControls.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancel.Depth = 0;
            btnCancel.HighEmphasis = true;
            btnCancel.Icon = null;
            btnCancel.Location = new Point(158, 96);
            btnCancel.Margin = new Padding(4, 6, 4, 6);
            btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancel.Name = "btnCancel";
            btnCancel.NoAccentTextColor = Color.Empty;
            btnCancel.Size = new Size(64, 36);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "İPTAL";
            btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancel.UseAccentColor = false;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnLoginAdd
            // 
            btnLoginAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLoginAdd.Cursor = Cursors.Hand;
            btnLoginAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLoginAdd.Depth = 0;
            btnLoginAdd.HighEmphasis = true;
            btnLoginAdd.Icon = null;
            btnLoginAdd.Location = new Point(16, 99);
            btnLoginAdd.Margin = new Padding(4, 6, 4, 6);
            btnLoginAdd.MouseState = MaterialSkin.MouseState.HOVER;
            btnLoginAdd.Name = "btnLoginAdd";
            btnLoginAdd.NoAccentTextColor = Color.Empty;
            btnLoginAdd.Size = new Size(89, 36);
            btnLoginAdd.TabIndex = 6;
            btnLoginAdd.Text = "GİRİŞ YAP";
            btnLoginAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLoginAdd.UseAccentColor = false;
            btnLoginAdd.UseVisualStyleBackColor = true;
            btnLoginAdd.Click += btnLoginAdd_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(28, 20);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(182, 19);
            materialLabel1.TabIndex = 7;
            materialLabel1.Text = "Yönetici Parolasını Giriniz";
            // 
            // txtAdminPassword
            // 
            txtAdminPassword.AnimateReadOnly = false;
            txtAdminPassword.BackgroundImageLayout = ImageLayout.None;
            txtAdminPassword.CharacterCasing = CharacterCasing.Normal;
            txtAdminPassword.Depth = 0;
            txtAdminPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAdminPassword.HideSelection = true;
            txtAdminPassword.Hint = "Parolayı giriniz";
            txtAdminPassword.LeadingIcon = null;
            txtAdminPassword.Location = new Point(16, 42);
            txtAdminPassword.MaxLength = 16;
            txtAdminPassword.MouseState = MaterialSkin.MouseState.OUT;
            txtAdminPassword.Name = "txtAdminPassword";
            txtAdminPassword.PasswordChar = '●';
            txtAdminPassword.PrefixSuffixText = null;
            txtAdminPassword.ReadOnly = false;
            txtAdminPassword.RightToLeft = RightToLeft.No;
            txtAdminPassword.SelectedText = "";
            txtAdminPassword.SelectionLength = 0;
            txtAdminPassword.SelectionStart = 0;
            txtAdminPassword.ShortcutsEnabled = true;
            txtAdminPassword.Size = new Size(206, 48);
            txtAdminPassword.TabIndex = 8;
            txtAdminPassword.TabStop = false;
            txtAdminPassword.TextAlign = HorizontalAlignment.Center;
            txtAdminPassword.TrailingIcon = null;
            txtAdminPassword.UseSystemPasswordChar = true;
            // 
            // pnlControls
            // 
            pnlControls.Anchor = AnchorStyles.None;
            pnlControls.Controls.Add(materialLabel1);
            pnlControls.Controls.Add(txtAdminPassword);
            pnlControls.Controls.Add(btnCancel);
            pnlControls.Controls.Add(btnLoginAdd);
            pnlControls.Location = new Point(30, 88);
            pnlControls.Name = "pnlControls";
            pnlControls.Size = new Size(237, 155);
            pnlControls.TabIndex = 9;
            // 
            // formLogin
            // 
            AcceptButton = btnLoginAdd;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(320, 286);
            Controls.Add(pnlControls);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "formLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yönetici Giriş";
            Load += formLogin_Load;
            pnlControls.ResumeLayout(false);
            pnlControls.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnCancel;
        private MaterialSkin.Controls.MaterialButton btnLoginAdd;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 txtAdminPassword;
        private Panel pnlControls;
    }
}