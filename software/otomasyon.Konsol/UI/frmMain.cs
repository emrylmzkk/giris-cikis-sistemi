using System.IO.Ports;
using Otomasyon.Business;
using Otomasyon.Data;
using System.Configuration;
using MaterialSkin;
using MaterialSkin.Controls;



namespace Otomasyon.UI
{
    public partial class frmMain : MaterialForm
    {
        private readonly SerialPort _serialPort;
        private readonly StudentService _studentService;
        private readonly LogService _logService;

        public frmMain()
        {
            InitializeComponent();


            _studentService = new StudentService();
            _serialPort = new SerialPort("COM7", 9600);
            _logService = new LogService();


            _serialPort.DataReceived += SerialPort_DataReceived;

        }


        //Uygulama ba�lat�l�nca


        private void frmMain_Load(object sender, EventArgs e)
        {


            //Veri taban�n� haz�rla
            try
            {
                Database.InitializeDatabase();
                tsslGenelBilgi.Text = "Veri taban� ba�lant�s� ba�ar�l�";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri taban� ba�lat�l�rken bir hata meydana geldi:" + ex.Message);
                tsslGenelBilgi.Text = "Veritaban� Hatas�";
                return;


            }


            try
            {
                _serialPort.Open();
                tsslOkuyucuDurum.Text = "Okuyucu: Ba�land�";
                connectionCheckTimer.Start();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Seri port a��lamad�. L�tfen Arduino ba�latn�lar�n� kotnrol ediniz");
                tsslOkuyucuDurum.Text = "Okuyucu (arduino) ba�lant�s� ba�ar�s�z. Hata:" + ex.Message;
            }

            UpdateInsideCount();
            UpdateLogView();


        }



        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            try
            {

                string gelenVeri = _serialPort.ReadLine().Trim();

                //Kart tan�ml� degil hatas� 
                //UID format�n�n 11 karakterli olmas� referans al�narak

                if (string.IsNullOrEmpty(gelenVeri) || gelenVeri.Length < 5)
                {
                    return;
                }


                string cardUID = gelenVeri;



                Student? bulunanOgrenci = _studentService.ProcessCardScan(cardUID);

                this.Invoke(new Action(() => UpdateUIWithStudentInfo(bulunanOgrenci, cardUID)));






            }
            catch (Exception)
            {

            }

        }


        private void UpdateUIWithStudentInfo(Student? student, string scannedUID)
        {
            tsslGenelBilgi.Text = $"Kart Okundu: {scannedUID}";


            if (student != null)
            {
                lblOgrenciAdSoyad.Text = $"{student.Name} {student.Surname}";
                lblOgrenciNumara.Text = student.Number;

                if (!string.IsNullOrEmpty(student.PhotoPath) && File.Exists(student.PhotoPath))
                {
                    using (var bmpTemp = new Bitmap(student.PhotoPath))
                    {
                        picOgrenciFoto.Image = new Bitmap(bmpTemp);

                    }

                    picOgrenciFoto.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    //Bu k�sma default foto ekle
                    picOgrenciFoto.Image = null;
                }


                if (student.IsInside == 1)
                {
                    lblGirisCikisBilgi.ForeColor = Color.Green;
                    lblGirisCikisBilgi.Text = "G�R�� YAPILDI";
                }
                else
                {
                    lblGirisCikisBilgi.ForeColor = Color.Blue;
                    lblGirisCikisBilgi.Text = "�IKI� YAPILDI";
                }

            }
            else
            {
                lblOgrenciAdSoyad.Text = "---";
                lblOgrenciNumara.Text = "---";
                //Default foto ile g�ncellenecek !!
                picOgrenciFoto.Image = null;
                lblGirisCikisBilgi.ForeColor = Color.Red;
                lblGirisCikisBilgi.Text = "!!!KART TANIMLI DE��L!!!";
            }

            UpdateInsideCount();
            UpdateLogView();

            uiClearTimer.Stop();
            uiClearTimer.Start();


        }


        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            connectionCheckTimer.Stop();
            uiClearTimer.Stop();


            if (_serialPort.IsOpen)
            {
                _serialPort.Close();
            }
        }

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            using (formLogin loginForm = new formLogin())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {

                    string inpPassword = loginForm.EnteredPassword;

                    string correctPassword = ConfigurationManager.AppSettings["adminPassword"];

                    string inpPasswordHash = SecurityHelper.ComputeSha256Hash(inpPassword);

                    if (inpPasswordHash == correctPassword)
                    {
                        using (frmOgrenciYonetim ogrenciYonetimForm = new frmOgrenciYonetim())
                        {
                            ogrenciYonetimForm.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Parola Yanl��", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                }
            }

        }

        private void UpdateInsideCount()
        {
            int count = _studentService.GetCurrentInsideCount();
            lblIceridekiOgrenciSayisi.Text = count.ToString();
        }


        private void UpdateLogView()
        {
            lvLogs.Items.Clear();

            var recentLogs = _logService.GetRecentLogs();

            foreach (var log in recentLogs)
            {
                var item = new ListViewItem(log.StudentFullName);

                item.SubItems.Add(log.LogType);
                item.SubItems.Add(log.LogTime);

                if (log.LogType == "Giri�")
                {
                    item.ForeColor = Color.DarkGreen;
                }
                else
                {
                    item.ForeColor = Color.Red;
                }

                lvLogs.Items.Add(item);



            }
        }


        private void uiClearTimer_Tick(object sender, EventArgs e)
        {
            uiClearTimer.Stop();

            picOgrenciFoto.Image = null;

            lblOgrenciAdSoyad.Text = "---";
            lblOgrenciNumara.Text = "---";

            lblGirisCikisBilgi.Text = "Giri� yapmadan �nce L�tfen Kart�n�z� Okutun...";
            lblGirisCikisBilgi.ForeColor = SystemColors.ControlText;


        }


        private void connectionCheckTimer_Tick(object sender, EventArgs e)
        {

            string[] availablePorts = SerialPort.GetPortNames();

            if (!availablePorts.Contains(_serialPort.PortName))
            {
                connectionCheckTimer.Stop();


                if (_serialPort.IsOpen)
                {
                    _serialPort.Close();
                }

                uiClearTimer.Stop();

                tsslOkuyucuDurum.Text = "Hata: Ba�lant� Kopart�ld�";
                tsslOkuyucuDurum.ForeColor = Color.Red;

                MessageBox.Show(
                    $"RFID okucu ile ba�lant� kopart�ld�. L�tfen ({_serialPort.PortName}) ba�lant�s�n� kontrol edip uygulamay� tekrardan ba�lat�n�z.",
                    "Ba�lant� Hatas�",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error

                    );


                this.Close();



            }


        }



    }
}