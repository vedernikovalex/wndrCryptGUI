namespace WinFormsApp1
{
    partial class NewCred
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
            username = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            newCredLabel = new Label();
            backPictureButton = new PictureBox();
            hidePassButton = new PictureBox();
            showPassButton = new PictureBox();
            forwardBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)backPictureButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hidePassButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showPassButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)forwardBox).BeginInit();
            SuspendLayout();
            // 
            // username
            // 
            username.Location = new Point(310, 153);
            username.Name = "username";
            username.Size = new Size(168, 23);
            username.TabIndex = 4;
            username.TextChanged += username_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(310, 201);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(168, 23);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(310, 252);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(168, 84);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(310, 234);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 9;
            label2.Text = "Note";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(310, 183);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 10;
            label1.Text = "Credential";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(310, 135);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 11;
            label3.Text = "Name";
            // 
            // newCredLabel
            // 
            newCredLabel.AutoSize = true;
            newCredLabel.Font = new Font("Segoe UI", 26F);
            newCredLabel.Location = new Point(251, 43);
            newCredLabel.Name = "newCredLabel";
            newCredLabel.Size = new Size(303, 47);
            newCredLabel.TabIndex = 12;
            newCredLabel.Text = "NEW CREDENTIAL";
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
            // hidePassButton
            // 
            hidePassButton.Cursor = Cursors.Hand;
            hidePassButton.Image = Properties.Resources.hide;
            hidePassButton.Location = new Point(507, 201);
            hidePassButton.Name = "hidePassButton";
            hidePassButton.Size = new Size(30, 30);
            hidePassButton.SizeMode = PictureBoxSizeMode.StretchImage;
            hidePassButton.TabIndex = 16;
            hidePassButton.TabStop = false;
            hidePassButton.Click += hidePassButton_Click;
            // 
            // showPassButton
            // 
            showPassButton.Cursor = Cursors.Hand;
            showPassButton.Image = Properties.Resources.view;
            showPassButton.Location = new Point(507, 201);
            showPassButton.Name = "showPassButton";
            showPassButton.Size = new Size(30, 30);
            showPassButton.SizeMode = PictureBoxSizeMode.StretchImage;
            showPassButton.TabIndex = 17;
            showPassButton.TabStop = false;
            showPassButton.Click += showPassButton_Click;
            // 
            // forwardBox
            // 
            forwardBox.Cursor = Cursors.Hand;
            forwardBox.Image = Properties.Resources.fast_forward;
            forwardBox.Location = new Point(372, 355);
            forwardBox.Name = "forwardBox";
            forwardBox.Size = new Size(52, 48);
            forwardBox.SizeMode = PictureBoxSizeMode.StretchImage;
            forwardBox.TabIndex = 18;
            forwardBox.TabStop = false;
            forwardBox.Click += forwardBox_Click;
            // 
            // NewCred
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(forwardBox);
            Controls.Add(showPassButton);
            Controls.Add(hidePassButton);
            Controls.Add(backPictureButton);
            Controls.Add(newCredLabel);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(username);
            Name = "NewCred";
            Text = "NewCred";
            ((System.ComponentModel.ISupportInitialize)backPictureButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)hidePassButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)showPassButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)forwardBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label newCredLabel;
        private PictureBox backPictureButton;
        private PictureBox hidePassButton;
        private PictureBox showPassButton;
        private PictureBox forwardBox;
    }
}