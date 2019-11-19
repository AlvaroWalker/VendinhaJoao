using System;
using System.IO;

namespace VendinhadoJoao
{
    class Program
    {
        static void Main(string[] args){ // converttuint para converte em inteiros

            MenuP();

        }

        static void MenuP()
        {
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

        static void Menu1()
        {
            string menuitem;

            Console.WriteLine("");
            Console.WriteLine("1 - Cadastrar Cliente");
            Console.WriteLine("2 - Deletar Cliente");
            Console.WriteLine("3 - Listar Clientes");
            Console.WriteLine("0 - Voltar");

            menuitem = Console.ReadLine();

            if (menuitem == "1")
            {
                Console.WriteLine("AQUI VAI CADASTRAR O CLIENTE");
            }
            else if (menuitem == "2")
            {
                Console.WriteLine("AQUI VAI DELETAR O CLIENTE");
            }
            else if (menuitem == "3")
            {
                Console.WriteLine("AQUI VAI LISTAR OS CLIENTES");
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
            string menuitem;

            Console.WriteLine("");
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
