using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lowBankWindows;

namespace lowBankWindows
{
    public partial class LoginPage : Form
    {
        private bool isDragging = false;
        private Point offset;
        private readonly CSVDataSource dataSource = new CSVDataSource();

        public LoginPage()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (cpfTextBox.Visible)
            {
                //Recupera CPF digitado na tela
                string cpfDaTela = cpfTextBox.Text;

                var clienteResultado = dataSource.GetClienteCPF(cpfDaTela); 

                if (clienteResultado == null)
                {
                    //Apresenta mensagemna tela
                    MessageBox.Show("Usuário não encontrado.");
                }
                else
                {
                    var senhaCriptografada = passwordTextBox.Text.Criptografa();
                    if (clienteResultado.Senha == senhaCriptografada)
                    {
                        HomePage homePage = new HomePage(clienteResultado);
                        homePage.Show();

                        this.Hide();
                    }
                }
            }
            else
            {
                avatarImage.Visible = false;
                cadastroButton.Visible = false;
                loginButton.Location = new Point(183, loginButton.Location.Y);

                cpfTextBox.Visible = true;
                passwordTextBox.Visible = true;
            }
        }

        private void LoginPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                // this.Location = new Point(Location.X + e.X, Location.Y + e.Y);
                Point newLocation = new Point(
                    this.Location.X + e.X - offset.X,
                    this.Location.Y + e.Y - offset.Y
                );
                this.Location = newLocation;
            }
        }

         private void LoginPage_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            offset = e.Location;
        }

        private void LoginPage_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void cadastroButton_Click(object sender, EventArgs e)
        {
            var cadastroPage = new CadastroPage();
            cadastroPage.Show();

            cadastroPage.FormClosed += (s, e) => this.Show();

            this.Hide();

        }
    }
}
