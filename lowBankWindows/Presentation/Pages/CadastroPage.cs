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
        private readonly BaseDataSource dataSource;

        public CadastroPage(BaseDataSource datasource)
        {
            InitializeComponent();
            dataSource = datasource;
        }

        private void cadastroButton_Click(object sender, EventArgs e)
        {
            var valorCampoTexto = cpfTextBox.Text;
            var listaCaracteresNum = valorCampoTexto.Where(c => Char.IsDigit(c) || Char.IsPunctuation(c));
            var cpf = string.Concat(listaCaracteresNum);

            if (nomeTextBox.Text == "")
            {
                MessageBox.Show("O campo \"nome\" precisa ser preenchido.");
                return;
            }

            if (cpfTextBox.Text == "" || !cpfTextBox.Text.IsCPF())
            {
                MessageBox.Show("O campo \"CPF\" está inválido.");
                return;
            }

            if (senhaTextBox.Text == "")
            {
                MessageBox.Show("O campo \"Senha\" está inválido.");
                return;
            }

            if (confirmaSenhaTextBox.Text == "")
            {
                MessageBox.Show("O campo \"Confirme a senha\" está inválido.");
                return;
            }

            if (senhaTextBox.Text != confirmaSenhaTextBox.Text)
            {
                MessageBox.Show("As senhas não coincidem.");
                return;
            }

            var nome = nomeTextBox.Text;
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
