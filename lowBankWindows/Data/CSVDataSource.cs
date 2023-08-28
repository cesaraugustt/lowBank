using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lowBankWindows;

namespace lowBankWindows
{
    public class CSVDataSource : BaseDataSource
    {
        private string dbPath = "C:\\Users\\cesar\\Downloads\\LowBankBancoDeDados.csv";

        public override void SalvaCliente(Cliente cliente)
        {
            //Salvar novo cliente no documento
            File.AppendAllText(dbPath, "\n" + cliente.ToString());
        }

        public override Cliente? GetClienteCPF(string cpf)
        {
            //Acesar o arquivo, ler o texto
            string[] conteudoArquivo = File.ReadAllLines(dbPath);

            var clienteResultado = conteudoArquivo
                .Skip(1)
                .Select(linha => Cliente.Parse(linha))
                .FirstOrDefault(c => c.CPF == cpf);

            return clienteResultado;
        }
    }
}
