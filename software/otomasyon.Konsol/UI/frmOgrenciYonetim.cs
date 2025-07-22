using Otomasyon.Business;
using Otomasyon.Data;

namespace Otomasyon.UI
{
    public partial class frmOgrenciYonetim : Form
    {

        private readonly StudentService _studentService;
        private string? _photoPath = null;

        public frmOgrenciYonetim()
        {
            InitializeComponent();
            _studentService = new StudentService();

            

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnFotoSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Resim Dosyaları (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _photoPath = ofd.FileName;
                txtoEkleFoto.Image = Image.FromFile(_photoPath);
                txtoEkleFoto.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var newStudent = new Student
                {
                    Name = txtoEkleName.Text,
                    Surname = txtoEkleSurname.Text,
                    Number = txtoEkleNo.Text,
                    cardUID = txtoEkleCardUID.Text.Trim().ToUpper(),
                    PhotoPath = _photoPath,
                    IsInside = 0,

                    RegistrationDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

                };

                _studentService.AddNewStudent(newStudent);

                MessageBox.Show(
                    "Yeni öğrenci kayıt işlemi başarıyla tamamlandı",
                    "Başarılı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information


                    );

                this.Close();


            }

            catch (Exception ex)
            {

                MessageBox.Show(
                    "Kayıt işlemi sırasında bir hata meydana geldi" + ex.Message,
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error



                    );

            }
        }

    }
}
