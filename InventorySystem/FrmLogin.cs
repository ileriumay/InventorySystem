using InventorySystem;

namespace InventorySystem
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string validUsername = "username1";
            string validPassword = "12345";

            string enteredUsername = txtUsername.Text;
            string enteredPassword = txtPassword.Text;

            if (enteredUsername == validUsername && enteredPassword == validPassword)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmHomepage mainMenu = new FrmHomepage();
                mainMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
