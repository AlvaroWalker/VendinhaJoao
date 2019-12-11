using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace VendinhadoJoao
{
    class MenuRemoverCliente
    {
        private static List<Cliente> listaClientesNova = new List<Cliente>();
        public static void RemoverCliente()
        {
            Console.Clear();
            int codigodigitado;

            Console.WriteLine("");
            Console.Write("Digite o Codigo do Cliente: ");

            //acima esta o menu

            codigodigitado = Convert.ToInt32(Console.ReadLine());

            string arqclientes = @"C:\Projeto\Clientes.txt";

            using (StreamReader arquivo = File.OpenText(arqclientes))
            {
                List<Cliente> listaCliente = new List<Cliente>();

                while (arquivo.EndOfStream != true)
                {
                    string linha = arquivo.ReadLine();                                          // índice é a posição do texto, iniciando com 0 (zero)

                    int idx1 = linha.IndexOf(";", 0);                                           // a partir o índice zero vai localizar a primeira ocorrencia, devolvendo inteiro = 3
                    int idx2 = linha.IndexOf(";", idx1 + 1);
                    int idx3 = linha.Length;                                                    // o atributo já consta 20 caracteres, que é o total da linha

                    int tCodigo = idx1;                                                        // Calcula a quantidade de caracteres
                    int tNome = idx2 - idx1 - 1;                                               // Calcula a quantidade de caracteres
                    int tMatricula = idx3 - idx2 - 1;                                          // Calcula a quantidade de caracteres

                    string vCodigo = linha.Substring(0, idx1);
                    string vNome = linha.Substring(idx1 + 1, tNome);
                    string vMatricula = linha.Substring(idx2 + 1, tMatricula);

                    Cliente objCliente = new Cliente();
                    objCliente.acodigo = Convert.ToInt32(vCodigo);
                    objCliente.anome = vNome;
                    objCliente.acontato = vMatricula;

                    if (objCliente.acodigo != codigodigitado)
                    {
                        listaCliente.Add(objCliente);                         // método precisa de parenteses
                    }
                    else
                    {
                        string texto = "Codigo=" + objCliente.acodigo + " Nome=" + objCliente.anome + " Matrícula=" + objCliente.acontato;

                        Console.WriteLine(texto);
                    }
                }
                listaClientesNova = listaCliente;
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
            string arqclientes = @"C:\Projeto\Clientes.txt";
            using (StreamWriter sw = File.CreateText(arqclientes))
            {

                foreach (var item in listaClientesNova)
                {


                    int codigo = item.acodigo;
                    string nome = item.anome;
                    string matricula = item.acontato;

                    string texto = codigo + ";" + nome + ";" + matricula;

                    sw.WriteLine(texto);


                }
            }
            Program.MenuP();
        }
    }
}
