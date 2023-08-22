using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace lowBankWindows
{
    public class Cliente
    {
        public string Nome;
        public string CPF;
        public string Conta;
        public decimal Saldo;
        public string Senha;

        public Cliente(string nome, string cpf, string conta, decimal saldo, string senha)
        {
            Nome = nome;
            CPF = cpf;
            Conta = conta;
            Saldo = saldo;
            Senha = senha;
        }

        public override string ToString()
        {
            return $"{CPF},{Conta},{Nome},{Saldo},{Senha}";

        }

        public static Cliente Parse(string text)
        {
            //Quebrar informações por virgula
            string[] informacoes = text.Split(',');

            string cpf = informacoes[0];
            string conta = informacoes[1];
            string nome = informacoes[2];
            string saldo = informacoes[3];
            decimal saldoDecimal = decimal.Parse(saldo);
            string senha = informacoes[4];
            return new Cliente(nome, cpf, conta, saldoDecimal, senha);
        }
    }
}
