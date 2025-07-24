using MaterialSkin;
using MaterialSkin.Controls;
using Otomasyon.Business;
using Otomasyon.Data;

namespace Otomasyon.UI
{
    public partial class frmReport : MaterialForm
    {

        private readonly StudentService _studentService;
        private readonly LogService _logService;
        public frmReport()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;


            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.DeepPurple800,
                Primary.DeepPurple900,
                Primary.DeepPurple500,
                Accent.Orange200,
                TextShade.WHITE

                );


            _studentService = new StudentService();
            _logService = new LogService();

        }

        private void btnStudentSearch_Click(object sender, EventArgs e)
        {

            btnDeleteStudent.Enabled = false;
            string searchTerm = txtStudentSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchTerm)) return;

            lvSearchLog.Items.Clear();
            lvSearchNameResult.Items.Clear();


            var foundStudent = _studentService.FindStudentByName(searchTerm);

            foreach (var student in foundStudent)
            {
                var item = new ListViewItem(student.FullName);
                item.Tag = student.Id;
                lvSearchNameResult.Items.Add(item);

            }

            lvSearchNameResult.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void lvSearchNameResult_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {


            if (e.IsSelected)
            {
                btnDeleteStudent.Enabled = true;

                int selectedStudentId = (int)e.Item.Tag;
                var logs = _logService.GetStudentSpecLog(selectedStudentId);

                lvSearchLog.Items.Clear();

                foreach (var log in logs)
                {
                    if (DateTime.TryParse(log.LogTime, out DateTime logTime))
                    {

                        var item = new ListViewItem(logTime.ToString("dd.MM.yyyy"));
                        item.SubItems.Add(logTime.ToString("HH:mm:ss"));
                        item.SubItems.Add(log.LogType);
                        lvSearchLog.Items.Add(item);

                    }
                }


            }
            else
            {
                btnDeleteStudent.Enabled = false;
                lvSearchLog.Items.Clear();
            }


        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {

            if (lvSearchNameResult.SelectedItems.Count == 0)
            {
                MaterialMessageBox.Show(this, "Lütfen silmek için öğrenci seçiniz", "Uyarı");
                return;
            }


            var selectedItem = lvSearchNameResult.SelectedItems[0];
            int selectedStudentId = (int)selectedItem.Tag;
            string selectedStudentName = selectedItem.Text;


            var approval = MaterialMessageBox.Show(
                this,
                $"'{selectedStudentName} adlı öğrenciye ait tüm veriler kalıcı olarak silinecektir.\n\nBu işlem geri alınamaz!!!'",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                false

                );


            if (approval == DialogResult.Yes)
            {

                try
                {
                    _studentService.DeleteStudentandLogs(selectedStudentId);

                    MaterialMessageBox.Show(this, $"'{selectedStudentName}' kaydı başarıyla silindi.", "İşlem Başarılı");


                    //Ekranı otomatik olarak yenileme

                    lvSearchNameResult.Items.Remove(selectedItem);
                    lvSearchLog.Items.Clear();
                    btnDeleteStudent.Enabled = false;




                }
                catch (Exception ex)
                {
                    MaterialMessageBox.Show(this, "Silme işlemi sırasında bir hata meydana geldi" + ex.Message, "Hata");
                }


            }









        }

        
    }
}
