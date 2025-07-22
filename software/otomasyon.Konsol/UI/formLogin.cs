

namespace Otomasyon.UI
{
    public partial class formLogin : Form
    {
        public string EnteredPassword { get; private set; } = string.Empty;


        public formLogin()
        {
            InitializeComponent();

        }

        private void btnLoginAdd_Click(object sender, EventArgs e)
        {
            this.EnteredPassword = txtAdminPassword.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }




}