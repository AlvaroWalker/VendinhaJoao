using System;
using System.Collections.Generic;
using System.IO;

namespace VendinhadoJoao
{
    class Program
    {
        static void Main(string[] args){ // converttuint para converte em inteiros

            MenuP();

        }

        public static void MenuP()
        {
            Console.Clear();
            string menuitem;

            Console.WriteLine("");
            Console.WriteLine("Digite o numero para acessar a função desejada.");
            Console.WriteLine("1 - Menu Clientes");
            Console.WriteLine("2 - Menu Produtos");
            Console.WriteLine("");

            menuitem = Console.ReadLine();

            if (menuitem == "1")
            {
                Menu1();
            }
            else if (menuitem == "2")
            {
                Menu2();
            }
            else
            {
                Console.WriteLine("Comando Invalido");
                MenuP();
            }
        }

        public static void Menu1()
        {
            Console.Clear();
            string menuitem;

            Console.WriteLine("");
            Console.WriteLine("Digite o numero para acessar a função desejada.");
            Console.WriteLine("1 - Cadastrar Cliente");
            Console.WriteLine("2 - Deletar Cliente");
            Console.WriteLine("3 - Listar Clientes");
            Console.WriteLine("0 - Voltar");

            menuitem = Console.ReadLine();

            if (menuitem == "1")
            {
                MenuCadastro.CadastroMenu();
            }
            else if (menuitem == "2")
            {
                Console.WriteLine("AQUI VAI DELETAR O CLIENTE");
            }
            else if (menuitem == "3")
            {
                Console.WriteLine("AQUI VAI LISTAR OS CLIENTES");

                string arqclientes = @"C:\Projeto\Clientes.txt";

                if (File.Exists(arqclientes))
                {
                    using (StreamReader arquivo = File.OpenText(arqclientes))
                    {
                        List<Cliente> listaAlunos = new List<Cliente>();

                        while (arquivo.EndOfStream != true)
                        {
                            string linha = arquivo.ReadLine();

                            int idx1 = linha.IndexOf(";", 0);
                            int idx2 = linha.IndexOf(";", idx1 + 1);
                            int idx3 = linha.Length;

                            int tCodigo = idx1;
                            int tNome = idx2 - idx1 - 1;
                            int tMatricula = idx3 - idx2 - 1;

                            string vCodigo = linha.Substring(0, idx1);
                            string vNome = linha.Substring(idx1 + 1, tNome);
                            string vMatricula = linha.Substring(idx2 + 1, tMatricula);

                            Cliente objAluno = new Cliente();
                            objAluno.acodigo = Convert.ToInt32(vCodigo);
                            objAluno.anome = vNome;
                            objAluno.acontato = vMatricula;

                            listaAlunos.Add(objAluno);
                        }

                        foreach (var item in listaAlunos)
                        {
                            int codigo = item.acodigo;
                            string nome = item.anome;
                            string matricula = item.acontato;

                            string texto = "Codigo=" + codigo + " Nome=" + nome + " Matrícula=" + matricula;

                            Console.WriteLine(texto);
                        }

                        //Console.WriteLine(vCodigo);
                        //Console.WriteLine(vNome);
                        //Console.WriteLine(vMatricula);
                    }
                }

            }
            else if (menuitem == "0")
            {
                MenuP();
            }
            else
            {
                Menu1();
            }

        }

        static void Menu2()
        {
            Console.Clear();
            string menuitem;

            Console.WriteLine("");
            Console.WriteLine("Digite o numero para acessar a função desejada.");
            Console.WriteLine("1 - Cadastrar Produto");
            Console.WriteLine("2 - Deletar Produto");
            Console.WriteLine("3 - Listar Produto");
            Console.WriteLine("0 - Voltar");

            menuitem = Console.ReadLine();

            if (menuitem == "1")
            {
                Console.WriteLine("AQUI VAI CADASTRAR O PRODUTO");
            }
            else if (menuitem == "2")
            {
                Console.WriteLine("AQUI VAI DELETAR O PRODUTO");
            }
            else if (menuitem == "3")
            {
                Console.WriteLine("AQUI VAI LISTAR OS PRODUTOS");
            }
            else if (menuitem == "0")
            {
                MenuP();
            }
            else
            {
                Menu2();
            }
        }
    }
}
