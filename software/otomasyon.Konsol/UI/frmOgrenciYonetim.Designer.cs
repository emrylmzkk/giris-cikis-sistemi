namespace Otomasyon.UI
{
    partial class frmOgrenciYonetim
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
            oEkleName = new Label();
            oEkleSurname = new Label();
            oEkleNo = new Label();
            oEkleCardUID = new Label();
            txtoEkleName = new TextBox();
            txtoEkleSurname = new TextBox();
            txtoEkleNo = new TextBox();
            txtoEkleCardUID = new TextBox();
            txtoEkleFoto = new PictureBox();
            btnFotoSec = new Button();
            btnSave = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)txtoEkleFoto).BeginInit();
            SuspendLayout();
            // 
            // oEkleName
            // 
            oEkleName.AutoSize = true;
            oEkleName.Location = new Point(213, 149);
            oEkleName.Name = "oEkleName";
            oEkleName.Size = new Size(32, 15);
            oEkleName.TabIndex = 0;
            oEkleName.Text = "İsim:";
            // 
            // oEkleSurname
            // 
            oEkleSurname.AutoSize = true;
            oEkleSurname.Location = new Point(213, 184);
            oEkleSurname.Name = "oEkleSurname";
            oEkleSurname.RightToLeft = RightToLeft.No;
            oEkleSurname.Size = new Size(45, 15);
            oEkleSurname.TabIndex = 1;
            oEkleSurname.Text = "Soyadı:";
            // 
            // oEkleNo
            // 
            oEkleNo.AutoSize = true;
            oEkleNo.Location = new Point(213, 220);
            oEkleNo.Name = "oEkleNo";
            oEkleNo.Size = new Size(61, 15);
            oEkleNo.TabIndex = 2;
            oEkleNo.Text = "Numarası:";
            // 
            // oEkleCardUID
            // 
            oEkleCardUID.AutoSize = true;
            oEkleCardUID.Location = new Point(213, 254);
            oEkleCardUID.Name = "oEkleCardUID";
            oEkleCardUID.Size = new Size(85, 15);
            oEkleCardUID.TabIndex = 3;
            oEkleCardUID.Text = "Kart Numarası:";
            // 
            // txtoEkleName
            // 
            txtoEkleName.Location = new Point(306, 146);
            txtoEkleName.Name = "txtoEkleName";
            txtoEkleName.Size = new Size(100, 23);
            txtoEkleName.TabIndex = 4;
            // 
            // txtoEkleSurname
            // 
            txtoEkleSurname.Location = new Point(306, 188);
            txtoEkleSurname.Name = "txtoEkleSurname";
            txtoEkleSurname.Size = new Size(100, 23);
            txtoEkleSurname.TabIndex = 5;
            // 
            // txtoEkleNo
            // 
            txtoEkleNo.Location = new Point(306, 220);
            txtoEkleNo.Name = "txtoEkleNo";
            txtoEkleNo.Size = new Size(100, 23);
            txtoEkleNo.TabIndex = 6;
            // 
            // txtoEkleCardUID
            // 
            txtoEkleCardUID.Location = new Point(306, 251);
            txtoEkleCardUID.Name = "txtoEkleCardUID";
            txtoEkleCardUID.Size = new Size(100, 23);
            txtoEkleCardUID.TabIndex = 7;
            // 
            // txtoEkleFoto
            // 
            txtoEkleFoto.BorderStyle = BorderStyle.FixedSingle;
            txtoEkleFoto.Location = new Point(544, 184);
            txtoEkleFoto.Name = "txtoEkleFoto";
            txtoEkleFoto.Size = new Size(100, 50);
            txtoEkleFoto.TabIndex = 8;
            txtoEkleFoto.TabStop = false;
            // 
            // btnFotoSec
            // 
            btnFotoSec.Location = new Point(543, 251);
            btnFotoSec.Name = "btnFotoSec";
            btnFotoSec.Size = new Size(101, 25);
            btnFotoSec.TabIndex = 9;
            btnFotoSec.Text = "Fotoğraf Seç";
            btnFotoSec.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(557, 282);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 10;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(557, 311);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 11;
            btnClose.Text = "Kapat";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // ogrenciYonetim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(btnFotoSec);
            Controls.Add(txtoEkleFoto);
            Controls.Add(txtoEkleCardUID);
            Controls.Add(txtoEkleNo);
            Controls.Add(txtoEkleSurname);
            Controls.Add(txtoEkleName);
            Controls.Add(oEkleCardUID);
            Controls.Add(oEkleNo);
            Controls.Add(oEkleSurname);
            Controls.Add(oEkleName);
            Name = "ogrenciYonetim";
            Text = "ogrenciYonetim";
            ((System.ComponentModel.ISupportInitialize)txtoEkleFoto).EndInit();

            btnClose.Click += btnClose_Click;
            btnFotoSec.Click += btnFotoSec_Click;
            btnSave.Click += btnSave_Click;



            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label oEkleName;
        private Label oEkleSurname;
        private Label oEkleNo;
        private Label oEkleCardUID;
        private TextBox txtoEkleName;
        private TextBox txtoEkleSurname;
        private TextBox txtoEkleNo;
        private TextBox txtoEkleCardUID;
        private PictureBox txtoEkleFoto;
        private Button btnFotoSec;
        private Button btnSave;
        private Button btnClose;
    }
}