namespace WinFormsApp1
{
    partial class Menu
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
            logoutPictureButton = new PictureBox();
            menuLabel = new Label();
            usernamePlaceholder = new Label();
            label3 = new Label();
            myCreds = new PictureBox();
            addNewCred = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logoutPictureButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)myCreds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addNewCred).BeginInit();
            SuspendLayout();
            // 
            // logoutPictureButton
            // 
            logoutPictureButton.Cursor = Cursors.Hand;
            logoutPictureButton.Image = Properties.Resources.logout;
            logoutPictureButton.Location = new Point(12, 9);
            logoutPictureButton.Name = "logoutPictureButton";
            logoutPictureButton.Size = new Size(30, 30);
            logoutPictureButton.SizeMode = PictureBoxSizeMode.StretchImage;
            logoutPictureButton.TabIndex = 7;
            logoutPictureButton.TabStop = false;
            logoutPictureButton.Click += logoutPictureButton_Click;
            // 
            // menuLabel
            // 
            menuLabel.AutoSize = true;
            menuLabel.Font = new Font("Segoe UI", 26F);
            menuLabel.Location = new Point(273, 33);
            menuLabel.Name = "menuLabel";
            menuLabel.Size = new Size(239, 47);
            menuLabel.TabIndex = 8;
            menuLabel.Text = "wndrCryptGUI";
            // 
            // usernamePlaceholder
            // 
            usernamePlaceholder.Anchor = AnchorStyles.Right;
            usernamePlaceholder.BackColor = Color.Transparent;
            usernamePlaceholder.Font = new Font("Segoe UI", 14F);
            usernamePlaceholder.Location = new Point(590, 33);
            usernamePlaceholder.Name = "usernamePlaceholder";
            usernamePlaceholder.RightToLeft = RightToLeft.Yes;
            usernamePlaceholder.Size = new Size(198, 25);
            usernamePlaceholder.TabIndex = 16;
            usernamePlaceholder.Text = "placeholder";
            usernamePlaceholder.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(707, 9);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 15;
            label3.Text = "logged in as";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // myCreds
            // 
            myCreds.Cursor = Cursors.Hand;
            myCreds.Image = Properties.Resources.document;
            myCreds.Location = new Point(243, 183);
            myCreds.Name = "myCreds";
            myCreds.Size = new Size(120, 120);
            myCreds.SizeMode = PictureBoxSizeMode.StretchImage;
            myCreds.TabIndex = 17;
            myCreds.TabStop = false;
            myCreds.Click += myCreds_Click_1;
            // 
            // addNewCred
            // 
            addNewCred.Cursor = Cursors.Hand;
            addNewCred.Image = Properties.Resources.add_document1;
            addNewCred.Location = new Point(434, 183);
            addNewCred.Name = "addNewCred";
            addNewCred.Size = new Size(100, 120);
            addNewCred.SizeMode = PictureBoxSizeMode.StretchImage;
            addNewCred.TabIndex = 18;
            addNewCred.TabStop = false;
            addNewCred.Click += addNewCred_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(addNewCred);
            Controls.Add(myCreds);
            Controls.Add(usernamePlaceholder);
            Controls.Add(label3);
            Controls.Add(menuLabel);
            Controls.Add(logoutPictureButton);
            Name = "Menu";
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)logoutPictureButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)myCreds).EndInit();
            ((System.ComponentModel.ISupportInitialize)addNewCred).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logoutPictureButton;
        private Label menuLabel;
        private Label usernamePlaceholder;
        private Label label3;
        private PictureBox myCreds;
        private PictureBox addNewCred;
    }
}