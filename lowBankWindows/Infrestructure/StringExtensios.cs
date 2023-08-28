using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lowBankWindows
{
    public static class StringExtensios
    {
        public static string Criptografa(this string texto)
        {
            //Cria algoritmo de criptografia
            SHA256 algoritmo = SHA256.Create();

            //Pega a representação da senha (em byte)
            byte[] senhaBytes = Encoding.UTF8.GetBytes(texto);

            //Criptografa calculando o HASH da senha
            byte[] senhaCriptoBytes = algoritmo.ComputeHash(senhaBytes);

            //Transforma byte em caractere
            var listaCaracteres = senhaCriptoBytes
                .Select(b => b.ToString("x2"));

            //Concatena caracteres
            return string.Concat(listaCaracteres);
        }

        public static bool IsCPF(this string cpf)
        {
            // Remover caracteres não numéricos do CPF
            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            if (cpf.Length != 11)
                return false;

            // Verificar se todos os dígitos são iguais (CPF inválido)
            if (new string(cpf[0], 11) == cpf)
                return false;

            int[] pesosPrimeiroDigito = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] pesosSegundoDigito = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            int soma = 0;

            for (int i = 0; i < 9; i++)
            {
                soma += (cpf[i] - '0') * pesosPrimeiroDigito[i];
            }

            int primeiroDigitoVerificador = (soma * 10) % 11;
            if (primeiroDigitoVerificador == 10)
                primeiroDigitoVerificador = 0;

            if (cpf[9] - '0' != primeiroDigitoVerificador)
                return false;

            soma = 0;

            for (int i = 0; i < 10; i++)
            {
                soma += (cpf[i] - '0') * pesosSegundoDigito[i];
            }

            int segundoDigitoVerificador = (soma * 10) % 11;
            if (segundoDigitoVerificador == 10)
                segundoDigitoVerificador = 0;

            return cpf[10] - '0' == segundoDigitoVerificador;
        }
    }
}
