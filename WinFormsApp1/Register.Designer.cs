namespace WinFormsApp1
{
    partial class Register
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
            registerLabel = new Label();
            username = new TextBox();
            password = new TextBox();
            passwordConfirm = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            backPictureButton = new PictureBox();
            forwardBox = new PictureBox();
            showPassButton = new PictureBox();
            hidePassButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backPictureButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)forwardBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showPassButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hidePassButton).BeginInit();
            SuspendLayout();
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.Font = new Font("Segoe UI", 26F);
            registerLabel.Location = new Point(316, 66);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(168, 47);
            registerLabel.TabIndex = 0;
            registerLabel.Text = "REGISTER";
            // 
            // username
            // 
            username.Location = new Point(316, 174);
            username.Name = "username";
            username.Size = new Size(168, 23);
            username.TabIndex = 3;
            username.TextChanged += username_TextChanged;
            // 
            // password
            // 
            password.Location = new Point(316, 227);
            password.Name = "password";
            password.Size = new Size(168, 23);
            password.TabIndex = 4;
            password.TextChanged += password_TextChanged;
            // 
            // passwordConfirm
            // 
            passwordConfirm.Location = new Point(316, 276);
            passwordConfirm.Name = "passwordConfirm";
            passwordConfirm.Size = new Size(168, 23);
            passwordConfirm.TabIndex = 5;
            passwordConfirm.TextChanged += passwordConfirm_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.info_icon;
            pictureBox1.Location = new Point(259, 243);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(316, 258);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 7;
            label1.Text = "Confirm Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(316, 209);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 8;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(316, 156);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 9;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 26F);
            label4.Location = new Point(316, 202);
            label4.Name = "label4";
            label4.Size = new Size(0, 47);
            label4.TabIndex = 10;
            // 
            // backPictureButton
            // 
            backPictureButton.Cursor = Cursors.Hand;
            backPictureButton.Image = Properties.Resources.back;
            backPictureButton.Location = new Point(12, 408);
            backPictureButton.Name = "backPictureButton";
            backPictureButton.Size = new Size(30, 30);
            backPictureButton.SizeMode = PictureBoxSizeMode.StretchImage;
            backPictureButton.TabIndex = 16;
            backPictureButton.TabStop = false;
            backPictureButton.Click += backPictureButton_Click;
            // 
            // forwardBox
            // 
            forwardBox.Cursor = Cursors.Hand;
            forwardBox.Image = Properties.Resources.fast_forward;
            forwardBox.Location = new Point(378, 325);
            forwardBox.Name = "forwardBox";
            forwardBox.Size = new Size(52, 48);
            forwardBox.SizeMode = PictureBoxSizeMode.StretchImage;
            forwardBox.TabIndex = 17;
            forwardBox.TabStop = false;
            forwardBox.Click += forwardBox_Click;
            // 
            // showPassButton
            // 
            showPassButton.Cursor = Cursors.Hand;
            showPassButton.Image = Properties.Resources.view;
            showPassButton.Location = new Point(513, 243);
            showPassButton.Name = "showPassButton";
            showPassButton.Size = new Size(30, 30);
            showPassButton.SizeMode = PictureBoxSizeMode.StretchImage;
            showPassButton.TabIndex = 19;
            showPassButton.TabStop = false;
            showPassButton.Click += showPassButton_Click;
            // 
            // hidePassButton
            // 
            hidePassButton.Cursor = Cursors.Hand;
            hidePassButton.Image = Properties.Resources.hide;
            hidePassButton.Location = new Point(513, 243);
            hidePassButton.Name = "hidePassButton";
            hidePassButton.Size = new Size(30, 30);
            hidePassButton.SizeMode = PictureBoxSizeMode.StretchImage;
            hidePassButton.TabIndex = 18;
            hidePassButton.TabStop = false;
            hidePassButton.Click += hidePassButton_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(showPassButton);
            Controls.Add(hidePassButton);
            Controls.Add(forwardBox);
            Controls.Add(backPictureButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(passwordConfirm);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(registerLabel);
            Name = "Register";
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)backPictureButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)forwardBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)showPassButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)hidePassButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label registerLabel;
        private TextBox username;
        private TextBox password;
        private TextBox passwordConfirm;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox backPictureButton;
        private PictureBox forwardBox;
        private PictureBox showPassButton;
        private PictureBox hidePassButton;
    }
}