using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace VendinhadoJoao
{
    class MenuRemoverProduto
    {
        private static List<Produto> listaProdutosNova = new List<Produto>();
        public static void RemoverProduto()
        {
            Console.Clear();
            int codigodigitado;

            Console.WriteLine("");
            Console.Write("Digite o Codigo do Produto: ");

            //acima esta o menu

            codigodigitado = Convert.ToInt32(Console.ReadLine());

            string arqprodutos = @"C:\Projeto\Produtos.txt";

            using (StreamReader arquivo = File.OpenText(arqprodutos))
            {
                List<Produto> listaProduto = new List<Produto>();

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

                    //listaProduto.Add(objProduto);

                    if (objProduto.codigo != codigodigitado)
                    {
                        listaProduto.Add(objProduto);                         // método precisa de parenteses
                    }
                    else
                    {
                        string texto = "Codigo = " + objProduto.codigo +
                                       "\nDescrição = " + objProduto.descricao +
                                       "\nPreço de Compra = " + objProduto.precoCompra +
                                       "\nPreço de Venda = " + objProduto.precoVenda +
                                       "\nQuantidade em estoque = " + objProduto.quantidadeEstoque;
                        Console.WriteLine(texto);
                    }
                }
                listaProdutosNova = listaProduto;
                arquivo.Close();
                Console.Write("Digite 1 para confirmar ou 2 para cancelar : ");
                string conf = Console.ReadLine();
                if (conf == "1")
                {
                    SalvaNovaLista();
                }
                else
                {
                    Program.MenuP();
                }
            }


        }
        private static void SalvaNovaLista()
        {
            string arqprodutos = @"C:\Projeto\Produtos.txt";
            using (StreamWriter sw = File.CreateText(arqprodutos))
            {

                foreach (var item in listaProdutosNova)
                {


                    int codigo = item.codigo;
                    string descricao = item.descricao;
                    float pcompra = item.precoCompra;
                    float pvenda = item.precoVenda;
                    float qestoque = item.quantidadeEstoque;

                    string texto = codigo +
                               ";" + descricao +
                               ";" + pcompra +
                               ";" + pvenda +
                               ";" + qestoque;

                    sw.WriteLine(texto);


                }
            }
            Program.MenuP();
        }
    }
}
