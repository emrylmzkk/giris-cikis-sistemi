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


        //Uygulama baþlatýlýnca


        private void frmMain_Load(object sender, EventArgs e)
        {


            //Veri tabanýný hazýrla
            try
            {
                Database.InitializeDatabase();
                tsslGenelBilgi.Text = "Veri tabaný baðlantýsý baþarýlý";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri tabaný baþlatýlýrken bir hata meydana geldi:" + ex.Message);
                tsslGenelBilgi.Text = "Veritabaný Hatasý";
                return;


            }


            try
            {
                _serialPort.Open();
                tsslOkuyucuDurum.Text = "Okuyucu: Baðlandý";
                connectionCheckTimer.Start();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Seri port açýlamadý. Lütfen Arduino baðlatnýlarýný kotnrol ediniz");
                tsslOkuyucuDurum.Text = "Okuyucu (arduino) baðlantýsý baþarýsýz. Hata:" + ex.Message;
            }

            UpdateInsideCount();
            UpdateLogView();


        }



        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            try
            {

                string gelenVeri = _serialPort.ReadLine().Trim();

                //Kart tanýmlý degil hatasý 
                //UID formatýnýn 11 karakterli olmasý referans alýnarak

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
                    //Bu kýsma default foto ekle
                    picOgrenciFoto.Image = null;
                }


                if (student.IsInside == 1)
                {
                    lblGirisCikisBilgi.ForeColor = Color.Green;
                    lblGirisCikisBilgi.Text = "GÝRÝÞ YAPILDI";
                }
                else
                {
                    lblGirisCikisBilgi.ForeColor = Color.Blue;
                    lblGirisCikisBilgi.Text = "ÇIKIÞ YAPILDI";
                }

            }
            else
            {
                lblOgrenciAdSoyad.Text = "---";
                lblOgrenciNumara.Text = "---";
                //Default foto ile güncellenecek !!
                picOgrenciFoto.Image = null;
                lblGirisCikisBilgi.ForeColor = Color.Red;
                lblGirisCikisBilgi.Text = "!!!KART TANIMLI DEÐÝL!!!";
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
                        MessageBox.Show("Parola Yanlýþ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                if (log.LogType == "Giriþ")
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

            lblGirisCikisBilgi.Text = "Giriþ yapmadan Önce Lütfen Kartýnýzý Okutun...";
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

                tsslOkuyucuDurum.Text = "Hata: Baðlantý Kopartýldý";
                tsslOkuyucuDurum.ForeColor = Color.Red;

                MessageBox.Show(
                    $"RFID okucu ile baðlantý kopartýldý. Lütfen ({_serialPort.PortName}) baðlantýsýný kontrol edip uygulamayý tekrardan baþlatýnýz.",
                    "Baðlantý Hatasý",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error

                    );


                this.Close();



            }


        }



    }
}