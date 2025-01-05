using InventorySystem;

namespace InventorySystem
{
    public partial class FrmLogin : Form
    {
        // Constructor to initialize the form components
        public FrmLogin()
        {
            InitializeComponent();
        }

        // Event handler for the 'Login' button click
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Predefined valid credentials
            string validUsername = "username1";
            string validPassword = "12345";

            // Get entered username and password from the textboxes
            string enteredUsername = txtUsername.Text;
            string enteredPassword = txtPassword.Text;

            // Check if entered credentials match the valid credentials
            if (enteredUsername == validUsername && enteredPassword == validPassword)
            {
                // If login is successful, show a success message and open the homepage
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmHomepage mainMenu = new FrmHomepage();  // Create an instance of the homepage form
                mainMenu.Show();  // Show the homepage form
                this.Hide();  // Hide the login form
            }
            else
            {
                // If login fails, show an error message
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
