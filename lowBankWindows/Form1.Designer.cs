namespace lowBankWindows
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            painelFundo = new CustomPanel();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            cartaoCredito = new CustomPanel();
            label3 = new Label();
            label2 = new Label();
            button2 = new CustomButton();
            button1 = new CustomButton();
            label1 = new Label();
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
            painelFundo.Controls.Add(label1);
            painelFundo.Location = new Point(0, 117);
            painelFundo.Name = "painelFundo";
            painelFundo.Size = new Size(676, 256);
            painelFundo.TabIndex = 0;
            painelFundo.Paint += panel1_Paint;
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
            cartaoCredito.Controls.Add(label3);
            cartaoCredito.Controls.Add(label2);
            cartaoCredito.Location = new Point(356, 56);
            cartaoCredito.Name = "cartaoCredito";
            cartaoCredito.Size = new Size(300, 180);
            cartaoCredito.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(29, 55);
            label3.Name = "label3";
            label3.Size = new Size(243, 42);
            label3.TabIndex = 2;
            label3.Text = "R$ 10.000,00";
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(85, 25);
            label1.Name = "label1";
            label1.Size = new Size(145, 18);
            label1.TabIndex = 0;
            label1.Text = "Bem viado, Cliente!";
            label1.Click += label1_Click;
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
        private Label label1;
        private CustomPanel painelFundo;
        private CustomPanel cartaoCredito;
        private CustomButton button2;
        private CustomButton button1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox2;
        private Label label4;
        private PictureBox pictureBox1;
    }
}