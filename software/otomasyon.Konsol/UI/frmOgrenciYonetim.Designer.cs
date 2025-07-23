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
            txtoEkleName = new TextBox();
            txtoEkleSurname = new TextBox();
            txtoEkleNo = new TextBox();
            txtoEkleCardUID = new TextBox();
            txtoEkleFoto = new PictureBox();
            btnFotoSec = new Button();
            btnSave = new Button();
            btnClose = new Button();
            newStudentPanel1 = new Panel();
            oEkleCardUID = new MaterialSkin.Controls.MaterialLabel();
            oEkleNo = new MaterialSkin.Controls.MaterialLabel();
            oEkleSurname = new MaterialSkin.Controls.MaterialLabel();
            oEkleName = new MaterialSkin.Controls.MaterialLabel();
            newStudentPanel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)txtoEkleFoto).BeginInit();
            newStudentPanel1.SuspendLayout();
            newStudentPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtoEkleName
            // 
            txtoEkleName.Location = new Point(180, 21);
            txtoEkleName.Name = "txtoEkleName";
            txtoEkleName.Size = new Size(100, 23);
            txtoEkleName.TabIndex = 4;
            // 
            // txtoEkleSurname
            // 
            txtoEkleSurname.Location = new Point(180, 50);
            txtoEkleSurname.Name = "txtoEkleSurname";
            txtoEkleSurname.Size = new Size(100, 23);
            txtoEkleSurname.TabIndex = 5;
            // 
            // txtoEkleNo
            // 
            txtoEkleNo.Location = new Point(180, 82);
            txtoEkleNo.Name = "txtoEkleNo";
            txtoEkleNo.Size = new Size(100, 23);
            txtoEkleNo.TabIndex = 6;
            // 
            // txtoEkleCardUID
            // 
            txtoEkleCardUID.Location = new Point(180, 113);
            txtoEkleCardUID.Name = "txtoEkleCardUID";
            txtoEkleCardUID.Size = new Size(100, 23);
            txtoEkleCardUID.TabIndex = 7;
            // 
            // txtoEkleFoto
            // 
            txtoEkleFoto.BorderStyle = BorderStyle.FixedSingle;
            txtoEkleFoto.Location = new Point(38, 8);
            txtoEkleFoto.Name = "txtoEkleFoto";
            txtoEkleFoto.Size = new Size(167, 100);
            txtoEkleFoto.TabIndex = 8;
            txtoEkleFoto.TabStop = false;
            // 
            // btnFotoSec
            // 
            btnFotoSec.Location = new Point(68, 114);
            btnFotoSec.Name = "btnFotoSec";
            btnFotoSec.Size = new Size(101, 25);
            btnFotoSec.TabIndex = 9;
            btnFotoSec.Text = "Fotoğraf Seç";
            btnFotoSec.UseVisualStyleBackColor = true;
            btnFotoSec.Click += btnFotoSec_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(38, 145);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 10;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(130, 145);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 11;
            btnClose.Text = "Kapat";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // newStudentPanel1
            // 
            newStudentPanel1.Controls.Add(oEkleCardUID);
            newStudentPanel1.Controls.Add(txtoEkleName);
            newStudentPanel1.Controls.Add(oEkleNo);
            newStudentPanel1.Controls.Add(txtoEkleCardUID);
            newStudentPanel1.Controls.Add(oEkleSurname);
            newStudentPanel1.Controls.Add(txtoEkleSurname);
            newStudentPanel1.Controls.Add(oEkleName);
            newStudentPanel1.Controls.Add(txtoEkleNo);
            newStudentPanel1.Location = new Point(25, 92);
            newStudentPanel1.Name = "newStudentPanel1";
            newStudentPanel1.Size = new Size(287, 160);
            newStudentPanel1.TabIndex = 12;
            // 
            // oEkleCardUID
            // 
            oEkleCardUID.AutoSize = true;
            oEkleCardUID.Depth = 0;
            oEkleCardUID.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            oEkleCardUID.Location = new Point(3, 114);
            oEkleCardUID.MouseState = MaterialSkin.MouseState.HOVER;
            oEkleCardUID.Name = "oEkleCardUID";
            oEkleCardUID.Size = new Size(107, 19);
            oEkleCardUID.TabIndex = 17;
            oEkleCardUID.Text = "Kart Numarası:";
            // 
            // oEkleNo
            // 
            oEkleNo.AutoSize = true;
            oEkleNo.Depth = 0;
            oEkleNo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            oEkleNo.Location = new Point(3, 84);
            oEkleNo.MouseState = MaterialSkin.MouseState.HOVER;
            oEkleNo.Name = "oEkleNo";
            oEkleNo.Size = new Size(132, 19);
            oEkleNo.TabIndex = 16;
            oEkleNo.Text = "Öğrenci Numarası:";
            // 
            // oEkleSurname
            // 
            oEkleSurname.AutoSize = true;
            oEkleSurname.Depth = 0;
            oEkleSurname.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            oEkleSurname.Location = new Point(3, 52);
            oEkleSurname.MouseState = MaterialSkin.MouseState.HOVER;
            oEkleSurname.Name = "oEkleSurname";
            oEkleSurname.Size = new Size(62, 19);
            oEkleSurname.TabIndex = 15;
            oEkleSurname.Text = "Soyisim:";
            // 
            // oEkleName
            // 
            oEkleName.AutoSize = true;
            oEkleName.Depth = 0;
            oEkleName.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            oEkleName.Location = new Point(3, 23);
            oEkleName.MouseState = MaterialSkin.MouseState.HOVER;
            oEkleName.Name = "oEkleName";
            oEkleName.Size = new Size(35, 19);
            oEkleName.TabIndex = 14;
            oEkleName.Text = "İsim:";
            // 
            // newStudentPanel2
            // 
            newStudentPanel2.Controls.Add(txtoEkleFoto);
            newStudentPanel2.Controls.Add(btnFotoSec);
            newStudentPanel2.Controls.Add(btnClose);
            newStudentPanel2.Controls.Add(btnSave);
            newStudentPanel2.Location = new Point(346, 92);
            newStudentPanel2.Name = "newStudentPanel2";
            newStudentPanel2.Size = new Size(230, 183);
            newStudentPanel2.TabIndex = 13;
            // 
            // frmOgrenciYonetim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 332);
            Controls.Add(newStudentPanel2);
            Controls.Add(newStudentPanel1);
            Name = "frmOgrenciYonetim";
            Text = "Yeni Öğrenci Ekleme Portalı";
            FormClosing += frmOgrenciYonetim_FormClosing;
            Load += frmOgrenciYonetim_Load;
            ((System.ComponentModel.ISupportInitialize)txtoEkleFoto).EndInit();
            newStudentPanel1.ResumeLayout(false);
            newStudentPanel1.PerformLayout();
            newStudentPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion



        private TextBox txtoEkleName;
        private TextBox txtoEkleSurname;
        private TextBox txtoEkleNo;
        private TextBox txtoEkleCardUID;
        private PictureBox txtoEkleFoto;
        private Button btnFotoSec;
        private Button btnSave;
        private Button btnClose;
        private Panel newStudentPanel1;
        private Panel newStudentPanel2;
        private MaterialSkin.Controls.MaterialLabel oEkleName;
        private MaterialSkin.Controls.MaterialLabel oEkleSurname;
        private MaterialSkin.Controls.MaterialLabel oEkleNo;
        private MaterialSkin.Controls.MaterialLabel oEkleCardUID;
    }
}