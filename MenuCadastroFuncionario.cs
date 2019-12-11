using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace VendinhadoJoao
{
    class MenuCadastroFuncionario
    {
        public static void CadastroMenu()
        {
            Console.Clear();
            //string menuitem;
            //new Cliente().CadastrarCliente();


            string cpf, nome, contato;
            int codigo;

            Console.WriteLine("");
            Console.Write("Digite o Nome do Funcionario: ");

            nome = Console.ReadLine();

            Console.WriteLine("");
            Console.Write("Digite o CPF do Funcionario: ");

            cpf = Console.ReadLine();

            Console.WriteLine("");
            Console.Write("Digite o Codigo do Funcionario: ");

            //codigo = int.Parse(Console.ReadLine());

            codigo = 0;

            var foo = Console.ReadLine();
            if (int.TryParse(foo, out int number1))
            {
                codigo = number1;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Codigo do Funcionario Invalido");
                Console.ReadKey();
                CadastroMenu();
            }


            Console.WriteLine("");
            Console.Write("Digite o Contato do Funcionario: ");

            contato = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Nome: {0}", nome);
            Console.WriteLine("CPF: {0}", cpf);
            Console.WriteLine("Codigo: {0}", codigo);
            Console.WriteLine("Contato: {0}", contato);

            string cebola;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(1, 1);
            int cursorX = Console.CursorTop;
            int cursorY = Console.CursorLeft;

            Console.Write("");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.Write(" ╔════════ MENU DE OPÇÕES - FUNCIONARIOS ════════╗    ");
            Console.SetCursorPosition(2, Console.CursorTop + cursorY);
            Console.Write(" ║ 1 FINALIZAR CADASTRO                          ║    ");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.Write(" ║                                               ║    ");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.Write(" ║ 2 CANCELAR E RECOMEÇAR                        ║    ");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.Write(" ║                                               ║    ");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.Write(" ║ 3 CANCELAR E VOLTAR AO MENU                   ║    ");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.Write(" ╚═══════════════════════════════════════════════╝    ");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.Write(" ");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.SetCursorPosition(5, Console.CursorTop);
            Console.Write("DIGITE UMA OPÇÃO : ");
            cebola = Console.ReadLine();

            if (cebola == "1")
            {
                string arqfuncionarios = @"C:\Projeto\Funcionarios.txt";
                if (!File.Exists(arqfuncionarios))
                {
                    File.CreateText(arqfuncionarios);
                }

                List<Vendedor> funcionariolist = new List<Vendedor>();
                Vendedor c1 = new Vendedor();

                c1.codigo = codigo;
                c1.nome = nome;
                c1.contato = contato;
                c1.cpf = cpf;

                funcionariolist.Add(c1);

                
                c1.Cadastrar(funcionariolist,c1);



                Console.Clear();

                Console.WriteLine("Funcionario Cadastrado");
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
