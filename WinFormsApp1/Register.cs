using passwordManager.userLogic;
using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Register : Form
    {
        private string loginInput = string.Empty;
        private string passwordInput = string.Empty;
        private string passwordConfirmInput = string.Empty;

        public Register()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            password.UseSystemPasswordChar = true;
            passwordConfirm.UseSystemPasswordChar = true;
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

        /// <summary>
        /// On textbox change
        /// writes into target string
        /// </summary>
        private void passwordConfirm_TextChanged_1(object sender, EventArgs e)
        {
            passwordConfirmInput = passwordConfirm.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please make sure that the password corresponds to the following rules: \n - Minimal length of 10 characters \n - Occurrence of capital letter \n - Occurrence of a number \n - Occurrence of special character", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void passwordConfirm_TextChanged(object sender, EventArgs e)
        {
            passwordConfirmInput = passwordConfirm.Text;
        }

        private void backPictureButton_Click(object sender, EventArgs e)
        {
            var homepageForm = new Homepage();
            this.Hide();
            homepageForm.ShowDialog();
        }

        private void hidePassButton_Click(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = true;
            passwordConfirm.UseSystemPasswordChar = true;
            hidePassButton.Visible = false;
            showPassButton.Visible = true;
        }

        private void showPassButton_Click(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = false;
            passwordConfirm.UseSystemPasswordChar = false;
            showPassButton.Visible = false;
            hidePassButton.Visible = true;
        }

        private void forwardBox_Click(object sender, EventArgs e)
        {
            if (username.TextLength == 0)
            {
                MessageBox.Show("Username input empty.\n Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (password.TextLength == 0 || passwordConfirm.TextLength == 0)
            {
                MessageBox.Show("Password input empty.\n Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!User.CheckPasswordValidity(passwordInput))
            {
                passwordConfirm.Clear();
                MessageBox.Show("Passwords doesn't corresponds to the rules :(\n Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (passwordInput != passwordConfirmInput)
            {
                passwordConfirm.Clear();
                MessageBox.Show("Passwords doesn't match :(\n Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                User user = User.Register(loginInput, passwordInput);
                var menuForm = new Menu(user);
                this.Hide();
                menuForm.ShowDialog();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"InvalidOperation occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unknown error occured\nSee debug console for more information", "Unknown error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(ex);
            }
        }
    }
}
