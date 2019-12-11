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

            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(1, 1);
            int cursorX = Console.CursorTop;
            int cursorY = Console.CursorLeft;

            Console.Write("");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.Write(" ╔════════════════ MENU DE OPÇÕES ═══════════════╗    ");
            Console.SetCursorPosition(2, Console.CursorTop + cursorY);
            Console.Write(" ║ 1 CADASTRO DE CLIENTES                        ║    ");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.Write(" ║                                               ║    ");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.Write(" ║ 2 CADASTRO DE PRODUTOS                        ║    ");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.Write(" ║                                               ║    ");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.Write(" ║ 3 CADASTRO DE VENDEDORES                      ║    ");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.Write(" ║                                               ║    ");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.Write(" ║ 4 EFETUAR VENDAS                              ║    ");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.Write(" ╚═══════════════════════════════════════════════╝    ");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.Write(" ");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.SetCursorPosition(5, Console.CursorTop);
            Console.Write("DIGITE UMA OPÇÃO : ");

            
                    menuitem = Console.ReadLine();

                    if (menuitem == "1")
                    {
                        Menu1();
                    }
                    else if (menuitem == "2")
                    {
                        Menu2();
                    }
                    else if (menuitem == "3")
                    {
                        MenuFuncionario();
                    }

                    else if (menuitem == "4")
                     {
                MenuVendas.MenuVenda();
                     }
                                  
            }

        public static void Menu1()
        {
            Console.Clear();
            string menuitem;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(1, 1);
            int cursorX = Console.CursorTop;
            int cursorY = Console.CursorLeft;

            Console.Write("");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.Write(" ╔══════════ MENU DE OPÇÕES - CLIENTES ══════════╗    ");
            Console.SetCursorPosition(2, Console.CursorTop + cursorY);
            Console.Write(" ║ 1 CADASTRO DE CLIENTES                        ║    ");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.Write(" ║                                               ║    ");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.Write(" ║ 2 DELETAR CLIENTES                            ║    ");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.Write(" ║                                               ║    ");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.Write(" ║ 3 LISTAR CLIENTES                             ║    ");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.Write(" ║                                               ║    ");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.Write(" ║ S SAIR - VOLTA PARA O MENU                    ║    ");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.Write(" ╚═══════════════════════════════════════════════╝    ");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.Write(" ");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.SetCursorPosition(5, Console.CursorTop);
            Console.Write("DIGITE UMA OPÇÃO : ");

            menuitem = Console.ReadLine();

            if (menuitem == "1")
            {
                MenuCadastro.CadastroMenu();
            }
            else if (menuitem == "2")
            {
                //Console.WriteLine("AQUI VAI DELETAR O CLIENTE");
                MenuRemoverCliente.RemoverCliente();

            }
            else if (menuitem == "3")
            {
                Console.Clear();
                Console.WriteLine("Clientes Cadastrados\n\n");

                string arqclientes = @"C:\Projeto\Clientes.txt";

                if (File.Exists(arqclientes))
                {
                    using (StreamReader arquivo = File.OpenText(arqclientes))
                    {
                        List<Cliente> listaClientes = new List<Cliente>();

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

                            Cliente objCliente = new Cliente();
                            objCliente.acodigo = Convert.ToInt32(vCodigo);
                            objCliente.anome = vNome;
                            objCliente.acontato = vMatricula;

                            listaClientes.Add(objCliente);
                        }

                        foreach (var item in listaClientes)
                        {
                            int codigo = item.acodigo;
                            string nome = item.anome;
                            string matricula = item.acontato;

                            string texto = "Codigo = " + codigo + 
                                           "\nNome = " + nome + 
                                           "\nContato = " + matricula;

                            Console.WriteLine(texto);
                            Console.WriteLine("\n---------------------\n");
                        }


                        Console.ReadKey();
                        MenuP();
                    }
                }

            }
            else if (menuitem == "S")
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

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(1, 1);
            int cursorX = Console.CursorTop;
            int cursorY = Console.CursorLeft;

            Console.Write("");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.Write(" ╔═════════ MENU DE OPÇÕES - PRODUTOS ═══════════╗    ");
            Console.SetCursorPosition(2, Console.CursorTop + cursorY);
            Console.Write(" ║ 1 CADASTRO DE PRODUTOS                        ║    ");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.Write(" ║                                               ║    ");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.Write(" ║ 2 DELETAR PRODUTOS                            ║    ");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.Write(" ║                                               ║    ");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.Write(" ║ 3 LISTAR PRODUTOS                             ║    ");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.Write(" ║                                               ║    ");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.Write(" ║ S SAIR - VOLTA PARA O MENU                    ║    ");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.Write(" ╚═══════════════════════════════════════════════╝    ");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.Write(" ");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.SetCursorPosition(5, Console.CursorTop);
            Console.Write("DIGITE UMA OPÇÃO : ");

            menuitem = Console.ReadLine();

            if (menuitem == "1")
            {
                MenuCadastroProduto.CadastroMenu();
                //Console.WriteLine("AQUI VAI CADASTRAR O PRODUTO");
            }
            else if (menuitem == "2")
            {
                //Console.WriteLine("AQUI VAI DELETAR O PRODUTO");

                MenuRemoverProduto.RemoverProduto();
            }
            else if (menuitem == "3")
            {

                string arqprodutos = @"C:\Projeto\Produtos.txt";

                if (File.Exists(arqprodutos))
                {
                    using (StreamReader arquivo = File.OpenText(arqprodutos))
                    {
                        List<Produto> listaProd = new List<Produto>();

                        while (arquivo.EndOfStream != true)
                        {
                            string linha = arquivo.ReadLine();

                            int idx1 = linha.IndexOf(";", 0);
                            int idx2 = linha.IndexOf(";", idx1 + 1);
                            int idx3 = linha.IndexOf(";", idx2 + 1);
                            int idx4 = linha.IndexOf(";", idx3 + 1);

                            int idx5 = linha.Length;

                            int tCodigo = idx1;
                            int tDescricao = idx2 - idx1 - 1;
                            int tPrecoCompra = idx3 - idx2 - 1;
                            int tPrecoVenda = idx4 - idx3 - 1;
                            int tQuantEstoque = idx5 - idx4 - 1;

                            string vCodigo = linha.Substring(0, idx1);
                            string vDescricao = linha.Substring(idx1 + 1, tDescricao);
                            string vPrecoCompra = linha.Substring(idx2 + 1, tPrecoCompra);
                            string vPrecoVenda = linha.Substring(idx3 + 1, tPrecoVenda);
                            string vQuantEstoque = linha.Substring(idx4 + 1, tQuantEstoque);

                            Produto objProduto = new Produto();
                            objProduto.codigo = Convert.ToInt32(vCodigo);
                            objProduto.descricao = vDescricao;
                            objProduto.precoCompra = float.Parse(vPrecoCompra);
                            objProduto.precoVenda = float.Parse(vPrecoVenda);
                            objProduto.quantidadeEstoque = float.Parse(vQuantEstoque);

                            listaProd.Add(objProduto);
                        }
                        Console.Clear();
                        Console.WriteLine("Produtos Cadastrados\n\n");

                        foreach (var item in listaProd)
                        {
                            int codigo = item.codigo;
                            string desc = item.descricao;
                            float compra = item.precoCompra;
                            float venda = item.precoVenda;
                            float estoque = item.quantidadeEstoque;

                            string texto = "Codigo = " + codigo +
                                           "\nDescrição = " + desc +
                                           "\nPreço de Compra = " + compra +
                                           "\nPreço de Venda = " + venda +
                                           "\nQuantidade em estoque = " + estoque;
                            Console.WriteLine(texto);
                            Console.WriteLine("\n---------------------\n");
                        }

                        //Console.WriteLine(vCodigo);
                        //Console.WriteLine(vNome);
                        //Console.WriteLine(vMatricula);
                    }
                }
                //Console.WriteLine("AQUI VAI LISTAR OS PRODUTOS");
                Console.ReadKey();
                MenuP();
            }
            else if (menuitem == "S")
            {
                MenuP();
            }
            else
            {
                Menu2();
            }
        }
        static void MenuFuncionario()
        {

            Console.Clear();
            string menuitem;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(1, 1);
            int cursorX = Console.CursorTop;
            int cursorY = Console.CursorLeft;

            Console.Write("");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.Write(" ╔═════════ MENU DE OPÇÕES - VENDEDORES ═════════╗    ");
            Console.SetCursorPosition(2, Console.CursorTop + cursorY);
            Console.Write(" ║ 1 CADASTRO DE VENDEDORES                      ║    ");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.Write(" ║                                               ║    ");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.Write(" ║ 2 DELETAR VENDEDOR                            ║    ");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.Write(" ║                                               ║    ");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.Write(" ║ 3 LISTAR VENDEDORES                           ║    ");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.Write(" ║                                               ║    ");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.Write(" ║ S SAIR - VOLTA PARA O MENU                    ║    ");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.Write(" ╚═══════════════════════════════════════════════╝    ");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.Write(" ");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.SetCursorPosition(5, Console.CursorTop);
            Console.Write("DIGITE UMA OPÇÃO : ");

            menuitem = Console.ReadLine();

            if (menuitem == "1")
            {
                MenuCadastroFuncionario.CadastroMenu();
            }
            else if (menuitem == "2")
            {
                MenuRemoverFuncionario.RemoverVendedor();
            }
            else if (menuitem == "3")
            {
                MenuListarVendedores.ListaVendedores();
            }
            else if (menuitem == "S")
            {
                MenuP();
            }
            else
            {
                Console.WriteLine("Comando Invalido");
                MenuFuncionario();
            }

            
        }
    }
}
