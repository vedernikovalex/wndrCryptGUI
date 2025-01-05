using passwordManager.userLogic;

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        private string loginInput = string.Empty;
        private string passwordInput = string.Empty;

        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            password.UseSystemPasswordChar = true;
            hidePassButton.Visible = false;
            showPassButton.Visible = true;
        }

        /// <summary>
        /// Proper form closing event
        /// </summary>
        /// <param name="e"></param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = false;
            base.OnFormClosing(e);
            Environment.Exit(0);
        }

        /// <summary>
        /// On textbox change
        /// writes into target string
        /// </summary>
        private void username_TextChanged(object sender, EventArgs e)
        {
            loginInput = username.Text;
        }

        /// <summary>
        /// On textbox change
        /// writes into target string
        /// </summary>
        private void password_TextChanged(object sender, EventArgs e)
        {
            passwordInput = password.Text;
        }

        private void backPictureButton_Click(object sender, EventArgs e)
        {
            var homepageForm = new Homepage();
            this.Hide();
            homepageForm.ShowDialog();
        }

        private void forwardBox_Click(object sender, EventArgs e)
        {
            User? user = User.Login(loginInput, passwordInput);
            if (user != null)
            {
                var menuForm = new Menu(user);
                this.Hide();
                menuForm.ShowDialog();
            }
            else
            {
                password.Clear();
                MessageBox.Show("Username or password are incorrect. Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void showPassButton_Click_1(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = false;
            showPassButton.Visible = false;
            hidePassButton.Visible = true;
        }

        private void hidePassButton_Click_1(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = true;
            hidePassButton.Visible = false;
            showPassButton.Visible = true;
        }
    }
}
