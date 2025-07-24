namespace Otomasyon.UI
{
    partial class frmReport
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
            txtStudentSearch = new MaterialSkin.Controls.MaterialTextBox2();
            btnStudentSearch = new MaterialSkin.Controls.MaterialButton();
            lvSearchNameResult = new MaterialSkin.Controls.MaterialListView();
            reulstName = new ColumnHeader();
            lvSearchLog = new MaterialSkin.Controls.MaterialListView();
            searchLogDate = new ColumnHeader();
            searchLogTime = new ColumnHeader();
            searchLogProc = new ColumnHeader();
            btnDeleteStudent = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // txtStudentSearch
            // 
            txtStudentSearch.AnimateReadOnly = false;
            txtStudentSearch.BackgroundImageLayout = ImageLayout.None;
            txtStudentSearch.CharacterCasing = CharacterCasing.Normal;
            txtStudentSearch.Depth = 0;
            txtStudentSearch.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtStudentSearch.HideSelection = true;
            txtStudentSearch.Hint = "Ad-Soyad";
            txtStudentSearch.LeadingIcon = null;
            txtStudentSearch.Location = new Point(26, 96);
            txtStudentSearch.MaxLength = 32767;
            txtStudentSearch.MouseState = MaterialSkin.MouseState.OUT;
            txtStudentSearch.Name = "txtStudentSearch";
            txtStudentSearch.PasswordChar = '\0';
            txtStudentSearch.PrefixSuffixText = null;
            txtStudentSearch.ReadOnly = false;
            txtStudentSearch.RightToLeft = RightToLeft.No;
            txtStudentSearch.SelectedText = "";
            txtStudentSearch.SelectionLength = 0;
            txtStudentSearch.SelectionStart = 0;
            txtStudentSearch.ShortcutsEnabled = true;
            txtStudentSearch.Size = new Size(250, 48);
            txtStudentSearch.TabIndex = 0;
            txtStudentSearch.TabStop = false;
            txtStudentSearch.TextAlign = HorizontalAlignment.Left;
            txtStudentSearch.TrailingIcon = null;
            txtStudentSearch.UseSystemPasswordChar = false;
            // 
            // btnStudentSearch
            // 
            btnStudentSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnStudentSearch.Cursor = Cursors.Hand;
            btnStudentSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnStudentSearch.Depth = 0;
            btnStudentSearch.HighEmphasis = true;
            btnStudentSearch.Icon = null;
            btnStudentSearch.Location = new Point(125, 153);
            btnStudentSearch.Margin = new Padding(4, 6, 4, 6);
            btnStudentSearch.MouseState = MaterialSkin.MouseState.HOVER;
            btnStudentSearch.Name = "btnStudentSearch";
            btnStudentSearch.NoAccentTextColor = Color.Empty;
            btnStudentSearch.Size = new Size(64, 36);
            btnStudentSearch.TabIndex = 1;
            btnStudentSearch.Text = "ARA";
            btnStudentSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnStudentSearch.UseAccentColor = false;
            btnStudentSearch.UseVisualStyleBackColor = true;
            btnStudentSearch.Click += btnStudentSearch_Click;
            // 
            // lvSearchNameResult
            // 
            lvSearchNameResult.AutoSizeTable = false;
            lvSearchNameResult.BackColor = Color.FromArgb(255, 255, 255);
            lvSearchNameResult.BorderStyle = BorderStyle.None;
            lvSearchNameResult.Columns.AddRange(new ColumnHeader[] { reulstName });
            lvSearchNameResult.Depth = 0;
            lvSearchNameResult.FullRowSelect = true;
            lvSearchNameResult.Location = new Point(341, 96);
            lvSearchNameResult.MinimumSize = new Size(200, 100);
            lvSearchNameResult.MouseLocation = new Point(-1, -1);
            lvSearchNameResult.MouseState = MaterialSkin.MouseState.OUT;
            lvSearchNameResult.Name = "lvSearchNameResult";
            lvSearchNameResult.OwnerDraw = true;
            lvSearchNameResult.Size = new Size(200, 150);
            lvSearchNameResult.TabIndex = 2;
            lvSearchNameResult.UseCompatibleStateImageBehavior = false;
            lvSearchNameResult.View = View.Details;
            lvSearchNameResult.ItemSelectionChanged += lvSearchNameResult_ItemSelectionChanged;
            
            // 
            // reulstName
            // 
            reulstName.Text = "Arama Sonuçları";
            reulstName.Width = 180;
            // 
            // lvSearchLog
            // 
            lvSearchLog.AutoSizeTable = false;
            lvSearchLog.BackColor = Color.FromArgb(255, 255, 255);
            lvSearchLog.BorderStyle = BorderStyle.None;
            lvSearchLog.Columns.AddRange(new ColumnHeader[] { searchLogDate, searchLogTime, searchLogProc });
            lvSearchLog.Depth = 0;
            lvSearchLog.FullRowSelect = true;
            lvSearchLog.Location = new Point(56, 265);
            lvSearchLog.MinimumSize = new Size(200, 100);
            lvSearchLog.MouseLocation = new Point(-1, -1);
            lvSearchLog.MouseState = MaterialSkin.MouseState.OUT;
            lvSearchLog.Name = "lvSearchLog";
            lvSearchLog.OwnerDraw = true;
            lvSearchLog.Size = new Size(450, 151);
            lvSearchLog.TabIndex = 3;
            lvSearchLog.UseCompatibleStateImageBehavior = false;
            lvSearchLog.View = View.Details;
            // 
            // searchLogDate
            // 
            searchLogDate.Text = "Tarih";
            searchLogDate.Width = 150;
            // 
            // searchLogTime
            // 
            searchLogTime.Text = "Saat";
            searchLogTime.TextAlign = HorizontalAlignment.Center;
            searchLogTime.Width = 150;
            // 
            // searchLogProc
            // 
            searchLogProc.Text = "İşlem";
            searchLogProc.TextAlign = HorizontalAlignment.Right;
            searchLogProc.Width = 150;
            // 
            // btnDeleteStudent
            // 
            btnDeleteStudent.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDeleteStudent.Cursor = Cursors.Hand;
            btnDeleteStudent.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDeleteStudent.Depth = 0;
            btnDeleteStudent.Enabled = false;
            btnDeleteStudent.HighEmphasis = true;
            btnDeleteStudent.Icon = null;
            btnDeleteStudent.Location = new Point(82, 201);
            btnDeleteStudent.Margin = new Padding(4, 6, 4, 6);
            btnDeleteStudent.MouseState = MaterialSkin.MouseState.HOVER;
            btnDeleteStudent.Name = "btnDeleteStudent";
            btnDeleteStudent.NoAccentTextColor = Color.Empty;
            btnDeleteStudent.Size = new Size(121, 36);
            btnDeleteStudent.TabIndex = 4;
            btnDeleteStudent.Text = "Öğrenciyi Sil";
            btnDeleteStudent.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnDeleteStudent.UseAccentColor = false;
            btnDeleteStudent.UseVisualStyleBackColor = true;
            btnDeleteStudent.Click += btnDeleteStudent_Click;
            // 
            // frmReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 442);
            Controls.Add(btnDeleteStudent);
            Controls.Add(lvSearchLog);
            Controls.Add(lvSearchNameResult);
            Controls.Add(btnStudentSearch);
            Controls.Add(txtStudentSearch);
            Name = "frmReport";
            Text = "Öğrenci Bazlı Liste";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtStudentSearch;
        private MaterialSkin.Controls.MaterialButton btnStudentSearch;
        private MaterialSkin.Controls.MaterialListView lvSearchNameResult;
        private ColumnHeader reulstName;
        private MaterialSkin.Controls.MaterialListView lvSearchLog;
        private ColumnHeader searchLogDate;
        private ColumnHeader searchLogTime;
        private ColumnHeader searchLogProc;
        private MaterialSkin.Controls.MaterialButton btnDeleteStudent;
    }
}