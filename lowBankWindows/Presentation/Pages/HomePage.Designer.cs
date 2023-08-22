namespace lowBankWindows
{
    partial class HomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            painelFundo = new CustomPanel();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            cartaoCredito = new CustomPanel();
            saldoTexto = new Label();
            label2 = new Label();
            button2 = new CustomButton();
            button1 = new CustomButton();
            textoBemVindo = new Label();
            pictureBox1 = new PictureBox();
            painelFundo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            cartaoCredito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // painelFundo
            // 
            painelFundo.BackColor = Color.White;
            painelFundo.Controls.Add(label4);
            painelFundo.Controls.Add(pictureBox2);
            painelFundo.Controls.Add(cartaoCredito);
            painelFundo.Controls.Add(button2);
            painelFundo.Controls.Add(button1);
            painelFundo.Controls.Add(textoBemVindo);
            painelFundo.Location = new Point(0, 117);
            painelFundo.Name = "painelFundo";
            painelFundo.Size = new Size(676, 256);
            painelFundo.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(20, 218);
            label4.Name = "label4";
            label4.Size = new Size(190, 18);
            label4.TabIndex = 5;
            label4.Text = "Criado por César Augusto";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(20, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 48);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // cartaoCredito
            // 
            cartaoCredito.BackColor = Color.MediumBlue;
            cartaoCredito.Controls.Add(saldoTexto);
            cartaoCredito.Controls.Add(label2);
            cartaoCredito.Location = new Point(356, 56);
            cartaoCredito.Name = "cartaoCredito";
            cartaoCredito.Size = new Size(300, 180);
            cartaoCredito.TabIndex = 3;
            // 
            // saldoTexto
            // 
            saldoTexto.AutoSize = true;
            saldoTexto.BackColor = Color.Transparent;
            saldoTexto.Font = new Font("Arial", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            saldoTexto.ForeColor = Color.White;
            saldoTexto.Location = new Point(29, 55);
            saldoTexto.Name = "saldoTexto";
            saldoTexto.Size = new Size(243, 42);
            saldoTexto.TabIndex = 2;
            saldoTexto.Text = "R$ 10.000,00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(23, 35);
            label2.Name = "label2";
            label2.Size = new Size(91, 19);
            label2.TabIndex = 1;
            label2.Text = "Seu saldo:";
            // 
            // button2
            // 
            button2.BackColor = Color.Gold;
            button2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(206, 56);
            button2.Name = "button2";
            button2.Size = new Size(120, 40);
            button2.TabIndex = 2;
            button2.Text = "Transferir";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(77, 56);
            button1.Name = "button1";
            button1.Size = new Size(120, 40);
            button1.TabIndex = 1;
            button1.Text = "Depositar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textoBemVindo
            // 
            textoBemVindo.AutoSize = true;
            textoBemVindo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textoBemVindo.Location = new Point(85, 25);
            textoBemVindo.Name = "textoBemVindo";
            textoBemVindo.Size = new Size(144, 18);
            textoBemVindo.TabIndex = 0;
            textoBemVindo.Text = "Bem vindo, Cliente!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(325, 92);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(676, 373);
            Controls.Add(pictureBox1);
            Controls.Add(painelFundo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            painelFundo.ResumeLayout(false);
            painelFundo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            cartaoCredito.ResumeLayout(false);
            cartaoCredito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label textoBemVindo;
        private CustomPanel painelFundo;
        private CustomPanel cartaoCredito;
        private CustomButton button2;
        private CustomButton button1;
        private Label label2;
        private Label saldoTexto;
        private PictureBox pictureBox2;
        private Label label4;
        private PictureBox pictureBox1;
    }
}