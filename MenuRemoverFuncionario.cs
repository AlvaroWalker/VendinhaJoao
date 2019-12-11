using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace VendinhadoJoao
{
    class MenuRemoverFuncionario
    {
        private static List<Vendedor> listaVendedoresNova = new List<Vendedor>();
        public static void RemoverVendedor()
        {
            Console.Clear();
            int codigodigitado;

            Console.WriteLine("");
            Console.Write("Digite o Codigo do Vendedor: ");

            //acima esta o menu

            codigodigitado = Convert.ToInt32(Console.ReadLine());

            string arqvendedores = @"C:\Projeto\Funcionarios.txt";

            using (StreamReader arquivo = File.OpenText(arqvendedores))
            {
                List<Vendedor> listaVendedor = new List<Vendedor>();

                while (arquivo.EndOfStream != true)
                {
                    string linha = arquivo.ReadLine();                                          // índice é a posição do texto, iniciando com 0 (zero)

                    int idx1 = linha.IndexOf(";", 0);                                           // a partir o índice zero vai localizar a primeira ocorrencia, devolvendo inteiro = 3
                    int idx2 = linha.IndexOf(";", idx1 + 1);
                    int idx3 = linha.IndexOf(";", idx2 + 1);
                    int idx4 = linha.Length;                                                    // o atributo já consta 20 caracteres, que é o total da linha

                    int tCodigo = idx1;                                                        // Calcula a quantidade de caracteres
                    int tNome = idx2 - idx1 - 1;                                               // Calcula a quantidade de caracteres
                    int tMatricula = idx3 - idx2 - 1;                                          // Calcula a quantidade de caracteres
                    int tCpf = idx4 - idx3 - 1;                                          // Calcula a quantidade de caracteres

                    string vCodigo = linha.Substring(0, idx1);
                    string vNome = linha.Substring(idx1 + 1, tNome);
                    string vMatricula = linha.Substring(idx2 + 1, tMatricula);
                    string vCpf = linha.Substring(idx3 + 1, tCpf);

                    Vendedor objVendedor = new Vendedor();
                    objVendedor.codigo = Convert.ToInt32(vCodigo);
                    objVendedor.nome = vNome;
                    objVendedor.contato = vMatricula;
                    objVendedor.cpf = vCpf;

                    if (objVendedor.codigo != codigodigitado)
                    {
                        listaVendedor.Add(objVendedor);                         // método precisa de parenteses
                    }
                    else
                    {
                        string texto = "Codigo=" + objVendedor.codigo + " Nome=" + objVendedor.nome + " Matrícula=" + objVendedor.contato + " CPF= " + objVendedor.cpf;

                        Console.WriteLine(texto);
                    }
                }
                listaVendedoresNova = listaVendedor;
                arquivo.Close();
                Console.Write("Digite 1 para confirmar ou 2 para cancelar : ");
                string conf = Console.ReadLine();
                if (conf == "1")
                {
                    SalvaNovaLista();
                }
                else
                {
                    Program.MenuP();
                }
            }


        }
        private static void SalvaNovaLista()
        {
            string arqclientes = @"C:\Projeto\Funcionarios.txt";
            using (StreamWriter sw = File.CreateText(arqclientes))
            {

                foreach (var item in listaVendedoresNova)
                {


                    int codigo = item.codigo;
                    string nome = item.nome;
                    string matricula = item.contato;
                    string cpf = item.cpf;

                    string texto = codigo + ";" + nome + ";" + matricula + ";" + cpf;

                    sw.WriteLine(texto);


                }
            }
            Program.MenuP();
        }
    }
}
