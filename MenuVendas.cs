using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace VendinhadoJoao
{
    class MenuVendas
    {
        

        

        public static void MenuVenda()
        {
            Carrinho carrinho = new Carrinho();
            bool VendaEncerrada = false;
            List<Vendedor> listaVendedores = new List<Vendedor>(); // todos vendedores
            List<Cliente> listaClientes = new List<Cliente>(); //todos clientes
            List<Produto> listaProd = new List<Produto>(); //todos produtos
            
            
            List<Produto> listaCarrinho = new List<Produto>(); //produtos do carrinho


            Vendedor v = new Vendedor(); // vendedor que esta realizando a venda
            Cliente c = new Cliente(); // cliente que esta realizando a compra

            Console.Clear();

                Console.WriteLine("Vendedores Cadastrados\n\n");

            //
            //  CARREGAMENDO E LISTAGEM DOS VENDEDORES CADASTRADOS
            //

                string arqvendedores = @"C:\Projeto\Funcionarios.txt";

                if (File.Exists(arqvendedores))
                {
                    using (StreamReader arquivo = File.OpenText(arqvendedores))
                    {
                        

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

                        /*
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.SetCursorPosition(1, 1);
                        int cursorX = Console.CursorTop;
                        int cursorY = Console.CursorLeft;

                        Console.Write("");
                        Console.SetCursorPosition(2, cursorY + Console.CursorTop);
                        */

                        string texto = "Cod=" + codigo +
                                           "    Nome=" + nome;

                            Console.WriteLine(texto);
                          // Console.WriteLine("\n---------------------\n");
                        }
                    }
                }
            //
            // FIM DA LISTAGEM DOS VENDEDORES
            //
            Console.WriteLine(" ");
            Console.Write("Digite o codigo do vendedor: ");
            int vendedorcod = int.Parse(Console.ReadLine());

            foreach (var item in listaVendedores)
            {
                if (item.codigo == vendedorcod)
                {
                    v.codigo = item.codigo;
                    v.contato = item.contato;
                    v.nome = item.nome;
                    v.cpf = item.cpf;
                }
            }
            Console.Clear();

            Console.WriteLine("Vendedor = {0}", v.nome);
            
            
            Console.WriteLine(" ");
            Console.WriteLine("Clientes Cadastrados\n\n");

            //
            //AQUI FAZ A LEITURA DOS CLIENTES
            //

            string arqclientes = @"C:\Projeto\Clientes.txt";

            if (File.Exists(arqclientes))
            {
                using (StreamReader arquivo = File.OpenText(arqclientes))
                {

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

                        string texto = "Codigo=" + codigo +
                                       "  Nome=" + nome;

                        Console.WriteLine(texto);
                       // Console.WriteLine("\n---------------------\n");
                    }
                }
            }
            //
            //AQUI TERMINA A LEITURA DOS CLIENTES
            //

            Console.WriteLine(" ");
            Console.Write("Digite o codigo do Cliente: ");
            int clientecod = int.Parse(Console.ReadLine());

            foreach (var item in listaClientes)
            {
                if (item.acodigo == clientecod)
                {
                    c.acodigo = item.acodigo;
                    c.acontato = item.acontato;
                    c.anome = item.anome;
                }
            }

            Console.WriteLine("Vendedor = {0}", v.nome);
            Console.WriteLine("Cliente = {0}", c.anome);

            //
            //LISTA DE PRODUTOS
            //

            string arqprodutos = @"C:\Projeto\Produtos.txt";

            if (File.Exists(arqprodutos))
            {
                using (StreamReader arquivo = File.OpenText(arqprodutos))
                {
                    

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
                    


                }
            }


            //
            //lista produtos
            //

            while (!VendaEncerrada)
            {
                Console.Clear();
                Console.WriteLine("Vendedor = {0}", v.nome);
                Console.WriteLine("Cliente = {0}", c.anome);
                Console.WriteLine("\n\nProdutos Cadastrados\n\n");



                foreach (var item in listaProd)
                {
                    int codigo = item.codigo;
                    string desc = item.descricao;
                    float compra = item.precoCompra;
                    float venda = item.precoVenda;
                    float estoque = item.quantidadeEstoque;


                 //   int cursorX = Console.CursorTop;
                 //   int cursorY = Console.CursorLeft;


                    Console.SetCursorPosition(5,  Console.CursorTop);
                    string texto = "Codigo = " + codigo +
                                   "    Descrição = " + desc;
                                      Console.Write(texto);

                  Console.SetCursorPosition(40, Console.CursorTop);
                 //   "    Preço de Venda = " + venda;
                    Console.Write("Preço de Venda = " + venda);
                    Console.WriteLine(" ");

                    // Console.WriteLine("\n---------------------\n");


                }
                Console.WriteLine(" ");
                Console.Write("Adicione o Produto: ");
                int produtocod = int.Parse(Console.ReadLine());
                
                if (produtocod == 0) { VendaEncerrada=true; }

                int quantidadeProd;
                // do while 
                Console.WriteLine(" ");
                Console.Write("Adicione a quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());
                                
               if (quantidade == 0) { VendaEncerrada = true; }
                
                foreach (var item in listaProd)
                {
                    if (item.codigo == produtocod)
                    {

                        listaCarrinho.Add(item);

                    }
                }
            }



            carrinho.EtiquetaProduto(v,c,listaCarrinho);

        }

        }
    }
