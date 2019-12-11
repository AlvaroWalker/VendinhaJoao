using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace VendinhadoJoao
{
    class MenuCadastroProduto
    {
        public static void CadastroMenu()
        {
            Console.Clear();

            string descricao;
            int codigo;
            float precoCompra, precoVenda, quantEstoque;

            Console.WriteLine("");
            Console.Write("Digite a descrição do produto: ");

            descricao = Console.ReadLine();

            Console.WriteLine("");
            Console.Write("Digite o Codigo do produto: ");

            codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            Console.Write("Digite o Preço de Compra: ");

            precoCompra = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.Write("Digite o Preço de Venda: ");

            precoVenda = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.Write("Digite a quantidade em estoque: ");

            quantEstoque = float.Parse(Console.ReadLine());

            Console.Clear();

            Console.SetCursorPosition(5, Console.CursorTop + 13); // 
            Console.WriteLine("Descrição: {0}", descricao);
            Console.SetCursorPosition(5, Console.CursorTop);
            Console.WriteLine("Codigo: {0}", codigo);
            Console.SetCursorPosition(5, Console.CursorTop);
            Console.WriteLine("Preço de compra: {0}", precoCompra);
            Console.SetCursorPosition(5, Console.CursorTop);
            Console.WriteLine("Preço de venda: {0}", precoVenda);
            Console.SetCursorPosition(5, Console.CursorTop);
            Console.WriteLine("Quantidade em estoque: {0}", quantEstoque);

            string confirmacao;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(1, 1);
            int cursorX = Console.CursorTop;
            int cursorY = Console.CursorLeft;

            Console.Write("");
            Console.SetCursorPosition(2, cursorY + Console.CursorTop);
            Console.Write(" ╔════════════════ MENU DE OPÇÕES ═══════════════╗    ");
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
            confirmacao = Console.ReadLine();

            if (confirmacao == "1")
            {
                string arqProdutos = @"C:\Projeto\Produtos.txt";
                if (!File.Exists(arqProdutos))
                {
                    File.CreateText(arqProdutos);
                }

                List<Produto> produtolist = new List<Produto>();
                Produto c1 = new Produto();

                c1.codigo = codigo;
                c1.descricao = descricao;
                c1.precoCompra = precoCompra;
                c1.precoVenda = precoVenda;
                c1.quantidadeEstoque = quantEstoque;

                produtolist.Add(c1);

                c1.CadastrarProduto(produtolist, c1);



                Console.Clear();

                Console.WriteLine("Produto Cadastrado");
                Console.WriteLine("");
                Console.WriteLine("Aperte <enter> para retornar ao menu");
                Console.ReadLine();
                Program.MenuP();
            }
            else if (confirmacao == "2")
            {
                CadastroMenu();
            }
            else if (confirmacao == "3")
            {
                Program.MenuP();
            }
        }
    }
}
