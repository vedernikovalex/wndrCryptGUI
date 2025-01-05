namespace WinFormsApp1
{
    partial class Login
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
            password = new TextBox();
            username = new TextBox();
            login_label = new Label();
            label3 = new Label();
            label2 = new Label();
            backPictureButton = new PictureBox();
            forwardBox = new PictureBox();
            showPassButton = new PictureBox();
            hidePassButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)backPictureButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)forwardBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showPassButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hidePassButton).BeginInit();
            SuspendLayout();
            // 
            // password
            // 
            password.Location = new Point(324, 232);
            password.Name = "password";
            password.Size = new Size(168, 23);
            password.TabIndex = 10;
            password.TextChanged += password_TextChanged;
            // 
            // username
            // 
            username.Location = new Point(324, 187);
            username.Name = "username";
            username.Size = new Size(168, 23);
            username.TabIndex = 9;
            username.TextChanged += username_TextChanged;
            // 
            // login_label
            // 
            login_label.AutoSize = true;
            login_label.Font = new Font("Segoe UI", 26F);
            login_label.Location = new Point(348, 70);
            login_label.Name = "login_label";
            login_label.Size = new Size(120, 47);
            login_label.TabIndex = 6;
            login_label.Text = "LOGIN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(324, 169);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 11;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(324, 214);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 12;
            label2.Text = "Password";
            // 
            // backPictureButton
            // 
            backPictureButton.Cursor = Cursors.Hand;
            backPictureButton.Image = Properties.Resources.back;
            backPictureButton.Location = new Point(12, 408);
            backPictureButton.Name = "backPictureButton";
            backPictureButton.Size = new Size(30, 30);
            backPictureButton.SizeMode = PictureBoxSizeMode.StretchImage;
            backPictureButton.TabIndex = 15;
            backPictureButton.TabStop = false;
            backPictureButton.Click += backPictureButton_Click;
            // 
            // forwardBox
            // 
            forwardBox.Cursor = Cursors.Hand;
            forwardBox.Image = Properties.Resources.fast_forward;
            forwardBox.Location = new Point(377, 286);
            forwardBox.Name = "forwardBox";
            forwardBox.Size = new Size(52, 48);
            forwardBox.SizeMode = PictureBoxSizeMode.StretchImage;
            forwardBox.TabIndex = 16;
            forwardBox.TabStop = false;
            forwardBox.Click += forwardBox_Click;
            // 
            // showPassButton
            // 
            showPassButton.Cursor = Cursors.Hand;
            showPassButton.Image = Properties.Resources.view;
            showPassButton.Location = new Point(524, 225);
            showPassButton.Name = "showPassButton";
            showPassButton.Size = new Size(30, 30);
            showPassButton.SizeMode = PictureBoxSizeMode.StretchImage;
            showPassButton.TabIndex = 19;
            showPassButton.TabStop = false;
            showPassButton.Click += showPassButton_Click_1;
            // 
            // hidePassButton
            // 
            hidePassButton.Cursor = Cursors.Hand;
            hidePassButton.Image = Properties.Resources.hide;
            hidePassButton.Location = new Point(524, 225);
            hidePassButton.Name = "hidePassButton";
            hidePassButton.Size = new Size(30, 30);
            hidePassButton.SizeMode = PictureBoxSizeMode.StretchImage;
            hidePassButton.TabIndex = 18;
            hidePassButton.TabStop = false;
            hidePassButton.Click += hidePassButton_Click_1;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(showPassButton);
            Controls.Add(hidePassButton);
            Controls.Add(forwardBox);
            Controls.Add(backPictureButton);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(login_label);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)backPictureButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)forwardBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)showPassButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)hidePassButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox passwordConfirm;
        private TextBox password;
        private TextBox username;
        private Label login_label;
        private Label label3;
        private Label label2;
        private PictureBox backPictureButton;
        private PictureBox forwardBox;
        private PictureBox showPassButton;
        private PictureBox hidePassButton;
    }
}