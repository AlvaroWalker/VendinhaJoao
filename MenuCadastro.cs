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

            string cebola; // inseri agora 28/11/2019.
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

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(1, 1);
            int cursorX = Console.CursorTop;
            int cursorY = Console.CursorLeft;

            Console.Write("");
            Console.SetCursorPosition(40, cursorY + Console.CursorTop);
            Console.Write(" ╔════════════════ MENU DE OPÇÕES ═══════════════╗    ");
            Console.SetCursorPosition(40, Console.CursorTop + cursorY);
            Console.Write(" ║ 1 FINALIZAR CADASTRO                          ║    ");
            Console.SetCursorPosition(40, cursorY + Console.CursorTop);
            Console.Write(" ║                                               ║    ");
            Console.SetCursorPosition(40, cursorY + Console.CursorTop);
            Console.Write(" ║ 2 CANCELAR E RECOMEÇAR                        ║    ");
            Console.SetCursorPosition(40, cursorY + Console.CursorTop);
            Console.Write(" ║                                               ║    ");
            Console.SetCursorPosition(40, cursorY + Console.CursorTop);
            Console.Write(" ║ 3 CANCELAR E VOLTAR AO MENU                   ║    ");
            Console.SetCursorPosition(40, cursorY + Console.CursorTop);
            Console.Write(" ║                                               ║    ");
            Console.SetCursorPosition(40, cursorY + Console.CursorTop);
            Console.Write(" ║ S SAIR - VOLTA PARA O MENU                    ║    ");
            Console.SetCursorPosition(40, cursorY + Console.CursorTop);
            Console.Write(" ╚═══════════════════════════════════════════════╝    ");
            Console.SetCursorPosition(40, cursorY + Console.CursorTop);
            Console.Write(" ");
            Console.Write("     DIGITE UMA OPÇÃO : ");
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
