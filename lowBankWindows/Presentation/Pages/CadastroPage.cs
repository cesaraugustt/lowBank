using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lowBankWindows;

namespace lowBankWindows
{
    public partial class CadastroPage : Form
    {
        private readonly CSVDataSource dataSource = new CSVDataSource();

        public CadastroPage()
        {
            InitializeComponent();
        }

        private void cadastroButton_Click(object sender, EventArgs e)
        {
            var nome = nomeTextBox.Text;
            var cpf = cpfTextBox.Text;
            var senha = senhaTextBox.Text;
            var conta = Random.Shared.Next(1000,9999);
            var saldo = 0;

            var senhaCriptografada = senha.Criptografa();
            var novoCliente = new Cliente(nome, cpf, conta.ToString(), saldo, senhaCriptografada);

            dataSource.SalvaCliente(novoCliente);

            MessageBox.Show($"Conta {novoCliente.Conta} cadastrada com sucesso!");
            this.Close();

        }
    }
}
