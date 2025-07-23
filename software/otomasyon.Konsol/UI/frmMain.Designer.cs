namespace Otomasyon.UI
{
    partial class frmMain
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
            components = new System.ComponentModel.Container();
            lblIceridekiOgrenciSayisi = new Label();
            lblIceridekiSayiBaslik = new Label();
            lblGirisCikisBilgi = new Label();
            statusStrip1 = new StatusStrip();
            tsslGenelBilgi = new ToolStripStatusLabel();
            tsslOkuyucuDurum = new ToolStripStatusLabel();
            uiClearTimer = new System.Windows.Forms.Timer(components);
            connectionCheckTimer = new System.Windows.Forms.Timer(components);
            picOgrenciFoto = new PictureBox();
            lblOgrenciNumara = new Label();
            lblNumaraBaslik = new Label();
            lblOgrenciAdSoyad = new Label();
            lblAdBaslik = new Label();
            lvLogs = new MaterialSkin.Controls.MaterialListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            btnNewStudent = new MaterialSkin.Controls.MaterialButton();
            btnReport = new MaterialSkin.Controls.MaterialButton();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picOgrenciFoto).BeginInit();
            SuspendLayout();
            // 
            // lblIceridekiOgrenciSayisi
            // 
            lblIceridekiOgrenciSayisi.AutoSize = true;
            lblIceridekiOgrenciSayisi.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblIceridekiOgrenciSayisi.ForeColor = SystemColors.ControlText;
            lblIceridekiOgrenciSayisi.Location = new Point(262, 566);
            lblIceridekiOgrenciSayisi.Name = "lblIceridekiOgrenciSayisi";
            lblIceridekiOgrenciSayisi.Size = new Size(25, 30);
            lblIceridekiOgrenciSayisi.TabIndex = 0;
            lblIceridekiOgrenciSayisi.Text = "0";
            // 
            // lblIceridekiSayiBaslik
            // 
            lblIceridekiSayiBaslik.AutoSize = true;
            lblIceridekiSayiBaslik.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblIceridekiSayiBaslik.ForeColor = SystemColors.ControlText;
            lblIceridekiSayiBaslik.Location = new Point(27, 566);
            lblIceridekiSayiBaslik.Name = "lblIceridekiSayiBaslik";
            lblIceridekiSayiBaslik.Size = new Size(242, 30);
            lblIceridekiSayiBaslik.TabIndex = 8;
            lblIceridekiSayiBaslik.Text = "Yurttaki Öğrenci Sayısı:";
            // 
            // lblGirisCikisBilgi
            // 
            lblGirisCikisBilgi.AutoSize = true;
            lblGirisCikisBilgi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblGirisCikisBilgi.Location = new Point(282, 204);
            lblGirisCikisBilgi.Name = "lblGirisCikisBilgi";
            lblGirisCikisBilgi.Size = new Size(384, 21);
            lblGirisCikisBilgi.TabIndex = 6;
            lblGirisCikisBilgi.Text = "Giriş yapmadan Önce Lütfen Kartınızı Okutunuz...";
            lblGirisCikisBilgi.TextAlign = ContentAlignment.TopCenter;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsslGenelBilgi, tsslOkuyucuDurum });
            statusStrip1.Location = new Point(3, 602);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(677, 22);
            statusStrip1.TabIndex = 10;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsslGenelBilgi
            // 
            tsslGenelBilgi.Name = "tsslGenelBilgi";
            tsslGenelBilgi.Size = new Size(103, 17);
            tsslGenelBilgi.Text = "Sistem Bekelmede";
            // 
            // tsslOkuyucuDurum
            // 
            tsslOkuyucuDurum.Name = "tsslOkuyucuDurum";
            tsslOkuyucuDurum.Size = new Size(118, 17);
            tsslOkuyucuDurum.Text = "toolStripStatusLabel1";
            // 
            // uiClearTimer
            // 
            uiClearTimer.Interval = 5000;
            uiClearTimer.Tick += uiClearTimer_Tick;
            // 
            // connectionCheckTimer
            // 
            connectionCheckTimer.Interval = 3000;
            connectionCheckTimer.Tick += connectionCheckTimer_Tick;
            // 
            // picOgrenciFoto
            // 
            picOgrenciFoto.Location = new Point(27, 84);
            picOgrenciFoto.Name = "picOgrenciFoto";
            picOgrenciFoto.Size = new Size(249, 201);
            picOgrenciFoto.TabIndex = 1;
            picOgrenciFoto.TabStop = false;
            // 
            // lblOgrenciNumara
            // 
            lblOgrenciNumara.AutoSize = true;
            lblOgrenciNumara.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblOgrenciNumara.Location = new Point(503, 144);
            lblOgrenciNumara.Name = "lblOgrenciNumara";
            lblOgrenciNumara.Size = new Size(27, 20);
            lblOgrenciNumara.TabIndex = 5;
            lblOgrenciNumara.Text = "---";
            // 
            // lblNumaraBaslik
            // 
            lblNumaraBaslik.AutoSize = true;
            lblNumaraBaslik.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblNumaraBaslik.Location = new Point(382, 144);
            lblNumaraBaslik.Name = "lblNumaraBaslik";
            lblNumaraBaslik.Size = new Size(101, 21);
            lblNumaraBaslik.TabIndex = 4;
            lblNumaraBaslik.Text = "Öğrenci No:";
            // 
            // lblOgrenciAdSoyad
            // 
            lblOgrenciAdSoyad.AutoSize = true;
            lblOgrenciAdSoyad.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblOgrenciAdSoyad.Location = new Point(503, 115);
            lblOgrenciAdSoyad.Name = "lblOgrenciAdSoyad";
            lblOgrenciAdSoyad.Size = new Size(33, 20);
            lblOgrenciAdSoyad.TabIndex = 3;
            lblOgrenciAdSoyad.Text = "----";
            // 
            // lblAdBaslik
            // 
            lblAdBaslik.AutoSize = true;
            lblAdBaslik.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAdBaslik.Location = new Point(382, 114);
            lblAdBaslik.Name = "lblAdBaslik";
            lblAdBaslik.Size = new Size(96, 21);
            lblAdBaslik.TabIndex = 2;
            lblAdBaslik.Text = "Adı Soyadı:";
            // 
            // lvLogs
            // 
            lvLogs.AutoSizeTable = false;
            lvLogs.BackColor = Color.FromArgb(255, 255, 255);
            lvLogs.BorderStyle = BorderStyle.None;
            lvLogs.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7 });
            lvLogs.Depth = 0;
            lvLogs.FullRowSelect = true;
            lvLogs.Location = new Point(27, 307);
            lvLogs.MinimumSize = new Size(200, 100);
            lvLogs.MouseLocation = new Point(-1, -1);
            lvLogs.MouseState = MaterialSkin.MouseState.OUT;
            lvLogs.Name = "lvLogs";
            lvLogs.OwnerDraw = true;
            lvLogs.Size = new Size(635, 240);
            lvLogs.TabIndex = 12;
            lvLogs.UseCompatibleStateImageBehavior = false;
            lvLogs.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "ÖĞRENCİ";
            columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "İŞLEM";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 200;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "SAAT";
            columnHeader7.TextAlign = HorizontalAlignment.Center;
            columnHeader7.Width = 200;
            // 
            // btnNewStudent
            // 
            btnNewStudent.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNewStudent.Cursor = Cursors.Hand;
            btnNewStudent.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNewStudent.Depth = 0;
            btnNewStudent.HighEmphasis = true;
            btnNewStudent.Icon = null;
            btnNewStudent.Location = new Point(503, 556);
            btnNewStudent.Margin = new Padding(4, 6, 4, 6);
            btnNewStudent.MouseState = MaterialSkin.MouseState.HOVER;
            btnNewStudent.Name = "btnNewStudent";
            btnNewStudent.NoAccentTextColor = Color.Empty;
            btnNewStudent.Size = new Size(157, 36);
            btnNewStudent.TabIndex = 13;
            btnNewStudent.Text = "Yeni Öğrenci Ekle";
            btnNewStudent.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNewStudent.UseAccentColor = false;
            btnNewStudent.UseVisualStyleBackColor = true;
            btnNewStudent.Click += btnNewStudent_Click;
            // 
            // btnReport
            // 
            btnReport.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnReport.Cursor = Cursors.Hand;
            btnReport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnReport.Depth = 0;
            btnReport.HighEmphasis = true;
            btnReport.Icon = null;
            btnReport.Location = new Point(401, 556);
            btnReport.Margin = new Padding(4, 6, 4, 6);
            btnReport.MouseState = MaterialSkin.MouseState.HOVER;
            btnReport.Name = "btnReport";
            btnReport.NoAccentTextColor = Color.Empty;
            btnReport.Size = new Size(94, 36);
            btnReport.TabIndex = 14;
            btnReport.Text = "Detaylar";
            btnReport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnReport.UseAccentColor = false;
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 627);
            Controls.Add(btnReport);
            Controls.Add(btnNewStudent);
            Controls.Add(lvLogs);
            Controls.Add(lblIceridekiOgrenciSayisi);
            Controls.Add(lblIceridekiSayiBaslik);
            Controls.Add(lblNumaraBaslik);
            Controls.Add(lblOgrenciAdSoyad);
            Controls.Add(lblOgrenciNumara);
            Controls.Add(lblAdBaslik);
            Controls.Add(statusStrip1);
            Controls.Add(lblGirisCikisBilgi);
            Controls.Add(picOgrenciFoto);
            Name = "frmMain";
            Text = "Giriş-Çıkış Kontrol Sistemi";
            Load += frmMain_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picOgrenciFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblGirisCikisBilgi;
        private Label lblIceridekiSayiBaslik;
        private Label lblIceridekiOgrenciSayisi;
        
        private StatusStrip statusStrip1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ToolStripStatusLabel tsslGenelBilgi;
        private ToolStripStatusLabel tsslOkuyucuDurum;
        private System.Windows.Forms.Timer uiClearTimer;
        private System.Windows.Forms.Timer connectionCheckTimer;
        private PictureBox picOgrenciFoto;
        private Label lblOgrenciNumara;
        private Label lblNumaraBaslik;
        private Label lblOgrenciAdSoyad;
        private Label lblAdBaslik;
        private MaterialSkin.Controls.MaterialListView lvLogs;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private MaterialSkin.Controls.MaterialButton btnNewStudent;
        private MaterialSkin.Controls.MaterialButton btnReport;
    }
}
