using System;
using System.Collections.Generic;
using System.Text;

namespace VendinhadoJoao
{
    class MenuCadastro
    {

        public static void CadastroMenu()
        {
            Console.Clear();
            //string menuitem;
            //new Cliente().CadastrarCliente();

            Cliente c1 = new Cliente();

            Console.WriteLine("");
            Console.Write("Digite o Nome do Cliente: ");

            c1.anome = Console.ReadLine();

            Console.WriteLine("");
            Console.Write("Digite o Codigo do Cliente: ");

            c1.acodigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            Console.Write("Digite o Contato do Cliente: ");

            c1.acontato = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Nome: {0}",c1.anome);
            Console.WriteLine("Codigo: {0}", c1.acodigo);
            Console.WriteLine("Contato: {0}",c1.acontato);

            string cebola;
            Console.Write("Digite 1 Para confirmar ou 2 para cancelar");
            cebola = Console.ReadLine();

            if (cebola == "1")
            {
                Console.WriteLine("Cliente Cadastrado");
                Console.WriteLine("Aperte <enter> para retornar ao menu");
                Console.ReadLine();
                Program.Menu1();
            }
            else if (cebola == "2")
            {
                CadastroMenu();
            }
        }
    }
}
