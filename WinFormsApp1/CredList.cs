using passwordManager;
using passwordManager.helpers;
using passwordManager.userLogic;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net;
using WinFormsApp1.helpers;
using System.Diagnostics;


namespace WinFormsApp1
{
    public partial class CredList : Form
    {
        private User currentUser = new User();
        private Image showImage;
        private Image hideImage;
        private Image deleteImage;

        private string hiddenPasswordString = "***********";

        public User CurrentUser
        {
            get { return this.currentUser; }
            set { currentUser = value; }
        }

        public CredList(User user)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            CurrentUser = user;

            showImage = Properties.Resources.view1;
            hideImage = Properties.Resources.hide1;
            deleteImage = Properties.Resources.delete1;

            List<Credential> credentialList = Credential.GetCredentialList(user.Username);

            DataTable dt = new DataTable();
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Password", typeof(string));
            dt.Columns.Add("Note", typeof(string));

            for (int i = 0; i < credentialList.Count; i++)
            {
                dt.Rows.Add(new object[] { credentialList[i].Name, hiddenPasswordString, credentialList[i].Note });
            }

            credentialDataGrid.DataSource = dt;
            credentialDataGrid.RowTemplate.Height = 30;
            DataGridHelper.SetGridViewSortState(credentialDataGrid, DataGridViewColumnSortMode.NotSortable);

            DataGridViewImageColumn showHideColumn = new DataGridViewImageColumn
            {
                HeaderText = "",
                Name = "ShowHideImageColumn",
                Image = showImage,
            };
            showHideColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            showHideColumn.Resizable = DataGridViewTriState.False;
            showHideColumn.Width = 30;
            showHideColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            DataGridViewImageColumn deleteColumn = new DataGridViewImageColumn
            {
                HeaderText = "",
                Name = "DeleteImageColumn",
                Image = deleteImage,
            };
            deleteColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            deleteColumn.Resizable = DataGridViewTriState.False;
            deleteColumn.Width = 30;
            deleteColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            credentialDataGrid.Columns.Add(showHideColumn);
            credentialDataGrid.Columns.Add(deleteColumn);
            credentialDataGrid.CellClick += CredentialDataGrid_CellClick;
        }

        private void CredentialDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the click is on the show/hide image column
            if (e.ColumnIndex == credentialDataGrid.Columns["ShowHideImageColumn"].Index && e.RowIndex >= 0)
            {
                var passwordCell = credentialDataGrid.Rows[e.RowIndex].Cells["Password"];
                var imageCell = credentialDataGrid.Rows[e.RowIndex].Cells["ShowHideImageColumn"] as DataGridViewImageCell;

                if (passwordCell.Value != null && imageCell != null)
                {
                    if (imageCell.Value == showImage)
                    {
                        passwordCell.Value = GetPasswordForRow(e.RowIndex);
                        imageCell.Value = hideImage;
                    }
                    else
                    {
                        passwordCell.Value = hiddenPasswordString;
                        imageCell.Value = showImage;
                    }
                }
            }
            // Check if the click is on the delete image column
            else if (e.ColumnIndex == credentialDataGrid.Columns["DeleteImageColumn"].Index && e.RowIndex >= 0)
            {
                var result = MessageBox.Show(
                    "Are you sure you want to delete this credential?",
                    "Delete Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    Credential.DeleteCredential(e.RowIndex, CurrentUser.Username);
                    credentialDataGrid.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private string? GetPasswordForRow(int rowIndex)
        {
            Credential? cred = Credential.GetCredential(rowIndex, CurrentUser.Username);
            if (cred == null || Globals.Key == null)
            {
                return null;
            }
            string? decyptCred = Crypt.Decrypt(cred.Password, Globals.Key, CurrentUser.Username);
            return decyptCred;
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
    }
}
