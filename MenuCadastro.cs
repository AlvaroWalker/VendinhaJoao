using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace VendinhadoJoao
{
    class MenuCadastro
    {

        public static void CadastroMenu()
        {
            Console.Clear();
            //string menuitem;
            //new Cliente().CadastrarCliente();


            string nome,contato;
            int codigo;

            Console.WriteLine("");
            Console.Write("Digite o Nome do Cliente: ");

            nome = Console.ReadLine();

            Console.WriteLine("");
            Console.Write("Digite o Codigo do Cliente: ");

            codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            Console.Write("Digite o Contato do Cliente: ");

            contato = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Nome: {0}", nome);
            Console.WriteLine("Codigo: {0}", codigo);
            Console.WriteLine("Contato: {0}", contato);

            string cebola;
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Digite o numero para acessar a função desejada.");
            Console.WriteLine("1 - Finalizar Cadastro");
            Console.WriteLine("2 - Cancelar e Recomeçar");
            Console.WriteLine("3 - Cancelar e Voltar ao Menu");
            cebola = Console.ReadLine();

            if (cebola == "1")
            {
                string arqclientes = @"C:\Projeto\Clientes.txt";
                if (!File.Exists(arqclientes)){
                    File.CreateText(arqclientes);
                }

                    List<Cliente> clientlist = new List<Cliente>();
                Cliente c1 = new Cliente();

                c1.acodigo = codigo;
                c1.anome = nome;
                c1.acontato = contato;

                clientlist.Add(c1);

                c1.CadastrarCliente(clientlist,c1);



                Console.Clear();

                Console.WriteLine("Cliente Cadastrado");
                Console.WriteLine("");
                Console.WriteLine("Aperte <enter> para retornar ao menu");
                Console.ReadLine();
                Program.MenuP();
            }
            else if (cebola == "2")
            {
                CadastroMenu();
            }
            else if (cebola == "3")
            {
                Program.MenuP();
            }
        }
    }
}
