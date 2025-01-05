using passwordManager.helpers;
using passwordManager.userLogic;

namespace WinFormsApp1
{
    public partial class Menu : Form
    {
        private User currentUser = new User();

        public User CurrentUser
        {
            get { return this.currentUser; }
            set { currentUser = value; }
        }

        public Menu(User user)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            CurrentUser = user;
            usernamePlaceholder.Text = user.Username;
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

        private void logoutPictureButton_Click(object sender, EventArgs e)
        {
            var homepageForm = new Homepage();
            Globals.Key = null;
            this.Hide();
            homepageForm.ShowDialog();
        }

        private void myCreds_Click_1(object sender, EventArgs e)
        {
            var credListForm = new CredList(this.CurrentUser);
            this.Hide();
            credListForm.ShowDialog();
        }

        private void addNewCred_Click(object sender, EventArgs e)
        {
            var newCredForm = new NewCred(this.CurrentUser);
            this.Hide();
            newCredForm.ShowDialog();
        }
    }
}
