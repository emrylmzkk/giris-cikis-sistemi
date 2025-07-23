using MaterialSkin;
using MaterialSkin.Controls;

namespace Otomasyon.UI
{
    public partial class formLogin : MaterialForm
    {
        public string EnteredPassword { get; private set; } = string.Empty;


        public formLogin()
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

        private void formLogin_Load(object sender, EventArgs e)
        {
            this.Size = new Size(250,300);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            

            int panelX = (this.ClientSize.Width - pnlControls.Width) / 2;
            int panelY = (this.ClientSize.Height - pnlControls.Height) / 2;

            pnlControls.Location = new Point(panelX, panelY);

            




        }
    }




}