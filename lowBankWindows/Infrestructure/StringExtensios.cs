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
    }
}
