namespace lowBankWindows
{
    partial class CadastroPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroPage));
            nomeTextBox = new TextBox();
            cadastroButton = new CustomButton();
            senhaTextBox = new TextBox();
            logoImage = new PictureBox();
            cpfTextBox = new MaskedTextBox();
            confirmaSenhaTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)logoImage).BeginInit();
            SuspendLayout();
            // 
            // nomeTextBox
            // 
            nomeTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nomeTextBox.Location = new Point(182, 170);
            nomeTextBox.Name = "nomeTextBox";
            nomeTextBox.PlaceholderText = "Nome";
            nomeTextBox.Size = new Size(122, 26);
            nomeTextBox.TabIndex = 0;
            // 
            // cadastroButton
            // 
            cadastroButton.BackColor = Color.Gold;
            cadastroButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cadastroButton.Location = new Point(183, 327);
            cadastroButton.Name = "cadastroButton";
            cadastroButton.Size = new Size(120, 40);
            cadastroButton.TabIndex = 3;
            cadastroButton.Text = "Cadastrar";
            cadastroButton.UseVisualStyleBackColor = false;
            cadastroButton.Click += cadastroButton_Click;
            // 
            // senhaTextBox
            // 
            senhaTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            senhaTextBox.Location = new Point(182, 244);
            senhaTextBox.Name = "senhaTextBox";
            senhaTextBox.PlaceholderText = "Senha";
            senhaTextBox.Size = new Size(122, 26);
            senhaTextBox.TabIndex = 4;
            senhaTextBox.UseSystemPasswordChar = true;
            // 
            // logoImage
            // 
            logoImage.Image = (Image)resources.GetObject("logoImage.Image");
            logoImage.Location = new Point(198, 34);
            logoImage.Name = "logoImage";
            logoImage.Size = new Size(91, 82);
            logoImage.TabIndex = 6;
            logoImage.TabStop = false;
            // 
            // cpfTextBox
            // 
            cpfTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cpfTextBox.Location = new Point(182, 208);
            cpfTextBox.Mask = "000,000,000-00";
            cpfTextBox.Name = "cpfTextBox";
            cpfTextBox.Size = new Size(122, 26);
            cpfTextBox.TabIndex = 7;
            // 
            // confirmaSenhaTextBox
            // 
            confirmaSenhaTextBox.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            confirmaSenhaTextBox.Location = new Point(181, 283);
            confirmaSenhaTextBox.Name = "confirmaSenhaTextBox";
            confirmaSenhaTextBox.PlaceholderText = "Confirme a senha";
            confirmaSenhaTextBox.Size = new Size(122, 25);
            confirmaSenhaTextBox.TabIndex = 8;
            confirmaSenhaTextBox.UseSystemPasswordChar = true;
            // 
            // CadastroPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(485, 437);
            Controls.Add(confirmaSenhaTextBox);
            Controls.Add(cpfTextBox);
            Controls.Add(logoImage);
            Controls.Add(senhaTextBox);
            Controls.Add(cadastroButton);
            Controls.Add(nomeTextBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CadastroPage";
            Text = "CadastroPage";
            ((System.ComponentModel.ISupportInitialize)logoImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nomeTextBox;
        private CustomButton cadastroButton;
        private TextBox senhaTextBox;
        private PictureBox logoImage;
        private MaskedTextBox cpfTextBox;
        private TextBox confirmaSenhaTextBox;
    }
}