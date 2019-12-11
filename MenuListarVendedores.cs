using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace VendinhadoJoao
{
    class MenuListarVendedores
    {
        public static void ListaVendedores()
        {
            Console.Clear();
            Console.WriteLine("Vendedores Cadastrados\n\n");

            string arqvendedores = @"C:\Projeto\Funcionarios.txt";

            if (File.Exists(arqvendedores))
            {
                using (StreamReader arquivo = File.OpenText(arqvendedores))
                {
                    List<Vendedor> listaVendedores = new List<Vendedor>();

                    while (arquivo.EndOfStream != true)
                    {
                        string linha = arquivo.ReadLine();

                        int idx1 = linha.IndexOf(";", 0);
                        int idx2 = linha.IndexOf(";", idx1 + 1);
                        int idx3 = linha.IndexOf(";", idx2 + 1);
                        int idx4 = linha.Length;

                        int tCodigo = idx1;
                        int tNome = idx2 - idx1 - 1;
                        int tMatricula = idx3 - idx2 - 1;
                        int tCpf = idx4 - idx3 - 1;

                        string vCodigo = linha.Substring(0, idx1);
                        string vNome = linha.Substring(idx1 + 1, tNome);
                        string vMatricula = linha.Substring(idx2 + 1, tMatricula);
                        string vCpf = linha.Substring(idx3 + 1, tCpf);

                        Vendedor objVendedor = new Vendedor();
                        objVendedor.codigo = Convert.ToInt32(vCodigo);
                        objVendedor.nome = vNome;
                        objVendedor.contato = vMatricula;
                        objVendedor.cpf = vCpf;


                        listaVendedores.Add(objVendedor);
                    }

                    foreach (var item in listaVendedores)
                    {
                        int codigo = item.codigo;
                        string nome = item.nome;
                        string matricula = item.contato;
                        string cpf = item.cpf;

                        string texto = "Codigo=" + codigo +
                                       "\nNome=" + nome +
                                       "\nCPF=" + cpf +
                                       "\nMatrícula=" + matricula;

                        Console.WriteLine(texto);
                        Console.WriteLine("\n---------------------\n");
                    }


                    Console.ReadKey();
                    Program.MenuP();
                }
            }

        }

    }
}
