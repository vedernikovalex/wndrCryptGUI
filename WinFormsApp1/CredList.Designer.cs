namespace WinFormsApp1
{
    partial class CredList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuLabel = new Label();
            backPictureButton = new PictureBox();
            credentialDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)backPictureButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)credentialDataGrid).BeginInit();
            SuspendLayout();
            // 
            // menuLabel
            // 
            menuLabel.AutoSize = true;
            menuLabel.Font = new Font("Segoe UI", 26F);
            menuLabel.Location = new Point(287, 34);
            menuLabel.Name = "menuLabel";
            menuLabel.Size = new Size(239, 47);
            menuLabel.TabIndex = 9;
            menuLabel.Text = "wndrCryptGUI";
            // 
            // backPictureButton
            // 
            backPictureButton.Cursor = Cursors.Hand;
            backPictureButton.Image = Properties.Resources.back;
            backPictureButton.Location = new Point(12, 408);
            backPictureButton.Name = "backPictureButton";
            backPictureButton.Size = new Size(30, 30);
            backPictureButton.SizeMode = PictureBoxSizeMode.StretchImage;
            backPictureButton.TabIndex = 14;
            backPictureButton.TabStop = false;
            backPictureButton.Click += backPictureButton_Click;
            // 
            // credentialDataGrid
            // 
            credentialDataGrid.AllowUserToAddRows = false;
            credentialDataGrid.AllowUserToDeleteRows = false;
            credentialDataGrid.AllowUserToResizeRows = false;
            credentialDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            credentialDataGrid.BackgroundColor = Color.WhiteSmoke;
            credentialDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            credentialDataGrid.Location = new Point(128, 131);
            credentialDataGrid.Name = "credentialDataGrid";
            credentialDataGrid.ReadOnly = true;
            credentialDataGrid.Size = new Size(555, 257);
            credentialDataGrid.TabIndex = 15;
            // 
            // CredList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(credentialDataGrid);
            Controls.Add(backPictureButton);
            Controls.Add(menuLabel);
            Name = "CredList";
            Text = "CredList";
            ((System.ComponentModel.ISupportInitialize)backPictureButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)credentialDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label menuLabel;
        private PictureBox backPictureButton;
        private DataGridView credentialDataGrid;
    }
}