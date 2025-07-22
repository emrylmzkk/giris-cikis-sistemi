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
            gbOgrenciBilgileri = new GroupBox();
            lblAdBaslik = new Label();
            lblOgrenciAdSoyad = new Label();
            lblNumaraBaslik = new Label();
            lblOgrenciNumara = new Label();
            picOgrenciFoto = new PictureBox();
            lblIceridekiOgrenciSayisi = new Label();
            lblIceridekiSayiBaslik = new Label();
            lblGirisCikisBilgi = new Label();
            gbAnlikDurum = new GroupBox();
            lvLogs = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            statusStrip1 = new StatusStrip();
            tsslGenelBilgi = new ToolStripStatusLabel();
            tsslOkuyucuDurum = new ToolStripStatusLabel();
            btnNewStudent = new Button();
            uiClearTimer = new System.Windows.Forms.Timer(components);
            connectionCheckTimer = new System.Windows.Forms.Timer(components);
            gbOgrenciBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picOgrenciFoto).BeginInit();
            gbAnlikDurum.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // gbOgrenciBilgileri
            // 
            gbOgrenciBilgileri.Controls.Add(lblAdBaslik);
            gbOgrenciBilgileri.Controls.Add(lblOgrenciAdSoyad);
            gbOgrenciBilgileri.Controls.Add(lblNumaraBaslik);
            gbOgrenciBilgileri.Controls.Add(lblOgrenciNumara);
            gbOgrenciBilgileri.Controls.Add(picOgrenciFoto);
            gbOgrenciBilgileri.Location = new Point(721, 116);
            gbOgrenciBilgileri.Name = "gbOgrenciBilgileri";
            gbOgrenciBilgileri.Size = new Size(423, 406);
            gbOgrenciBilgileri.TabIndex = 0;
            gbOgrenciBilgileri.TabStop = false;
            gbOgrenciBilgileri.Text = "Öğrenci Bilgileri";
            // 
            // lblAdBaslik
            // 
            lblAdBaslik.AutoSize = true;
            lblAdBaslik.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAdBaslik.Location = new Point(62, 189);
            lblAdBaslik.Name = "lblAdBaslik";
            lblAdBaslik.Size = new Size(96, 21);
            lblAdBaslik.TabIndex = 2;
            lblAdBaslik.Text = "Adı Soyadı:";
            // 
            // lblOgrenciAdSoyad
            // 
            lblOgrenciAdSoyad.AutoSize = true;
            lblOgrenciAdSoyad.Location = new Point(164, 194);
            lblOgrenciAdSoyad.Name = "lblOgrenciAdSoyad";
            lblOgrenciAdSoyad.Size = new Size(27, 15);
            lblOgrenciAdSoyad.TabIndex = 3;
            lblOgrenciAdSoyad.Text = "----";
            // 
            // lblNumaraBaslik
            // 
            lblNumaraBaslik.AutoSize = true;
            lblNumaraBaslik.Location = new Point(62, 236);
            lblNumaraBaslik.Name = "lblNumaraBaslik";
            lblNumaraBaslik.Size = new Size(71, 15);
            lblNumaraBaslik.TabIndex = 4;
            lblNumaraBaslik.Text = "Öğrenci No:";
            // 
            // lblOgrenciNumara
            // 
            lblOgrenciNumara.AutoSize = true;
            lblOgrenciNumara.Location = new Point(169, 236);
            lblOgrenciNumara.Name = "lblOgrenciNumara";
            lblOgrenciNumara.Size = new Size(22, 15);
            lblOgrenciNumara.TabIndex = 5;
            lblOgrenciNumara.Text = "---";
            // 
            // picOgrenciFoto
            // 
            picOgrenciFoto.Location = new Point(62, 22);
            picOgrenciFoto.Name = "picOgrenciFoto";
            picOgrenciFoto.Size = new Size(149, 116);
            picOgrenciFoto.TabIndex = 1;
            picOgrenciFoto.TabStop = false;
            // 
            // lblIceridekiOgrenciSayisi
            // 
            lblIceridekiOgrenciSayisi.AutoSize = true;
            lblIceridekiOgrenciSayisi.Location = new Point(195, 36);
            lblIceridekiOgrenciSayisi.Name = "lblIceridekiOgrenciSayisi";
            lblIceridekiOgrenciSayisi.Size = new Size(13, 15);
            lblIceridekiOgrenciSayisi.TabIndex = 0;
            lblIceridekiOgrenciSayisi.Text = "0";
            // 
            // lblIceridekiSayiBaslik
            // 
            lblIceridekiSayiBaslik.AutoSize = true;
            lblIceridekiSayiBaslik.Location = new Point(47, 36);
            lblIceridekiSayiBaslik.Name = "lblIceridekiSayiBaslik";
            lblIceridekiSayiBaslik.Size = new Size(125, 15);
            lblIceridekiSayiBaslik.TabIndex = 8;
            lblIceridekiSayiBaslik.Text = "Yurttaki Öğrenci Sayısı";
            // 
            // lblGirisCikisBilgi
            // 
            lblGirisCikisBilgi.AutoSize = true;
            lblGirisCikisBilgi.Location = new Point(529, 138);
            lblGirisCikisBilgi.Name = "lblGirisCikisBilgi";
            lblGirisCikisBilgi.Size = new Size(73, 15);
            lblGirisCikisBilgi.TabIndex = 6;
            lblGirisCikisBilgi.Text = "Hoş Geldiniz";
            // 
            // gbAnlikDurum
            // 
            gbAnlikDurum.Controls.Add(lblIceridekiSayiBaslik);
            gbAnlikDurum.Controls.Add(lblIceridekiOgrenciSayisi);
            gbAnlikDurum.Controls.Add(lvLogs);
            gbAnlikDurum.Location = new Point(43, 138);
            gbAnlikDurum.Name = "gbAnlikDurum";
            gbAnlikDurum.Size = new Size(304, 310);
            gbAnlikDurum.TabIndex = 7;
            gbAnlikDurum.TabStop = false;
            gbAnlikDurum.Text = "Anlık Durum ve Kayıtlar";
            // 
            // lvLogs
            // 
            lvLogs.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvLogs.Location = new Point(47, 93);
            lvLogs.Name = "lvLogs";
            lvLogs.Size = new Size(184, 97);
            lvLogs.TabIndex = 9;
            lvLogs.UseCompatibleStateImageBehavior = false;
            lvLogs.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Öğrenci";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "İşlem";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Saat";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsslGenelBilgi, tsslOkuyucuDurum });
            statusStrip1.Location = new Point(3, 600);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1169, 22);
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
            // btnNewStudent
            // 
            btnNewStudent.Location = new Point(458, 530);
            btnNewStudent.Name = "btnNewStudent";
            btnNewStudent.Size = new Size(222, 31);
            btnNewStudent.TabIndex = 11;
            btnNewStudent.Text = "Yeni Öğrenci Ekle";
            btnNewStudent.UseVisualStyleBackColor = true;
            btnNewStudent.Click += btnNewStudent_Click;
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
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 625);
            Controls.Add(btnNewStudent);
            Controls.Add(statusStrip1);
            Controls.Add(gbAnlikDurum);
            Controls.Add(lblGirisCikisBilgi);
            Controls.Add(gbOgrenciBilgileri);
            Name = "frmMain";
            Text = "Giriş-Çıkış Kontrol Sistemi";
            Load += frmMain_Load;
            gbOgrenciBilgileri.ResumeLayout(false);
            gbOgrenciBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picOgrenciFoto).EndInit();
            gbAnlikDurum.ResumeLayout(false);
            gbAnlikDurum.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbOgrenciBilgileri;
        private PictureBox picOgrenciFoto;
        private Label lblAdBaslik;
        private Label lblOgrenciAdSoyad;
        private Label lblNumaraBaslik;
        private Label lblOgrenciNumara;
        private Label lblGirisCikisBilgi;
        private GroupBox gbAnlikDurum;
        private Label lblIceridekiSayiBaslik;
        private Label lblIceridekiOgrenciSayisi;
        private ListView lvLogs;
        private StatusStrip statusStrip1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ToolStripStatusLabel tsslGenelBilgi;
        private ToolStripStatusLabel tsslOkuyucuDurum;
        private Button btnNewStudent;
        private System.Windows.Forms.Timer uiClearTimer;
        private System.Windows.Forms.Timer connectionCheckTimer;
    }
}
