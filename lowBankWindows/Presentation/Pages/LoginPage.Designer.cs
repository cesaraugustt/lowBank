namespace lowBankWindows
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            loginButton = new CustomButton();
            cadastroButton = new CustomButton();
            avatarImage = new PictureBox();
            logoImage = new PictureBox();
            cpfTextBox = new MaskedTextBox();
            passwordTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)avatarImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoImage).BeginInit();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.Gold;
            loginButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.Location = new Point(113, 330);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(120, 40);
            loginButton.TabIndex = 2;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // cadastroButton
            // 
            cadastroButton.BackColor = Color.Gold;
            cadastroButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cadastroButton.Location = new Point(250, 330);
            cadastroButton.Name = "cadastroButton";
            cadastroButton.Size = new Size(120, 40);
            cadastroButton.TabIndex = 3;
            cadastroButton.Text = "Cadastrar";
            cadastroButton.UseVisualStyleBackColor = false;
            cadastroButton.Click += cadastroButton_Click;
            // 
            // avatarImage
            // 
            avatarImage.Image = (Image)resources.GetObject("avatarImage.Image");
            avatarImage.Location = new Point(218, 232);
            avatarImage.Name = "avatarImage";
            avatarImage.Size = new Size(48, 48);
            avatarImage.TabIndex = 5;
            avatarImage.TabStop = false;
            // 
            // logoImage
            // 
            logoImage.Image = (Image)resources.GetObject("logoImage.Image");
            logoImage.Location = new Point(120, 34);
            logoImage.Name = "logoImage";
            logoImage.Size = new Size(245, 148);
            logoImage.TabIndex = 6;
            logoImage.TabStop = false;
            // 
            // cpfTextBox
            // 
            cpfTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cpfTextBox.Location = new Point(181, 229);
            cpfTextBox.Mask = "000,000,000-00";
            cpfTextBox.Name = "cpfTextBox";
            cpfTextBox.Size = new Size(122, 26);
            cpfTextBox.TabIndex = 8;
            cpfTextBox.Visible = false;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(181, 265);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PlaceholderText = "Password";
            passwordTextBox.Size = new Size(122, 26);
            passwordTextBox.TabIndex = 10;
            passwordTextBox.UseSystemPasswordChar = true;
            passwordTextBox.Visible = false;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(485, 437);
            Controls.Add(passwordTextBox);
            Controls.Add(cpfTextBox);
            Controls.Add(logoImage);
            Controls.Add(avatarImage);
            Controls.Add(cadastroButton);
            Controls.Add(loginButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginPage";
            Text = "LoginPage";
            ((System.ComponentModel.ISupportInitialize)avatarImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomButton loginButton;
        private CustomButton cadastroButton;
        private PictureBox avatarImage;
        private PictureBox logoImage;
        private TextBox passwordTextBox;
        private MaskedTextBox cpfTextBox;
    }
}