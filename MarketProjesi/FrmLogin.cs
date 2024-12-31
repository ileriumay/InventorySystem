using MarketProject;

namespace MarketProjesi
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var homepage = new FrmHomepage();
            homepage.Show();
            this.Hide();
        }
    }
}
