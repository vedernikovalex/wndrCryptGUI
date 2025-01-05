using passwordManager;
using passwordManager.helpers;
using passwordManager.userLogic;
using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class NewCred : Form
    {
        private User currentUser = new User();

        private string credNameInput = string.Empty;
        private string credPasswordInput = string.Empty;
        private string credNoteInput = string.Empty;

        public User CurrentUser
        {
            get { return this.currentUser; }
            set { currentUser = value; }
        }

        public NewCred(User user)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            textBox1.UseSystemPasswordChar = true;
            hidePassButton.Visible = false;
            showPassButton.Visible = true;
            CurrentUser = user;
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

        private void backPictureButton_Click(object sender, EventArgs e)
        {
            var menuForm = new Menu(this.CurrentUser);
            this.Hide();
            menuForm.ShowDialog();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            credNameInput = username.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            credPasswordInput = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            credNoteInput = textBox2.Text;
        }

        private void hidePassButton_Click(object sender, EventArgs e)
        {
            textBox1.UseSystemPasswordChar = true;
            hidePassButton.Visible = false;
            showPassButton.Visible = true;
        }

        private void showPassButton_Click(object sender, EventArgs e)
        {
            textBox1.UseSystemPasswordChar = false;
            showPassButton.Visible = false;
            hidePassButton.Visible = true;
        }


        private void forwardBox_Click(object sender, EventArgs e)
        {
            if (username.TextLength == 0)
            {
                MessageBox.Show("Credential name input empty.\n Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox1.TextLength == 0)
            {
                MessageBox.Show("Credential input empty.\n Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                byte[]? ecryptedPassword = Crypt.Encrypt(credPasswordInput, Globals.Key, CurrentUser.Username);
                if (ecryptedPassword == null)
                {
                    throw new ArgumentNullException();
                }
                Credential newCredential = new Credential(credNameInput, ecryptedPassword, credNoteInput, this.CurrentUser.Username);
                Credential.AddNewCredential(newCredential);

                var menuForm = new Menu(this.CurrentUser);
                this.Hide();
                menuForm.ShowDialog();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Encrypted password was null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unknown error occured", "Unknown error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(ex);
            }
        }
    }
}
