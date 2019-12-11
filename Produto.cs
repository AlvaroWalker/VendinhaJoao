using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace VendinhadoJoao   // 
{
    public class Produto
    {
        public int codigo;
        public string descricao;
        public float precoCompra;
        public float precoVenda;
        public float quantidadeEstoque;
        public Fornecedor forncedor;

        private List<Produto> listaProdutos;

        


        public void CadastrarProduto(List<Produto> c11, Produto produto)
        {

            string arqProdutos = @"C:\Projeto\Produtos.txt";

            StreamReader swo = File.OpenText(arqProdutos);
            string oi = swo.ReadToEnd();
            swo.Close();

            using (StreamWriter sw = File.CreateText(arqProdutos))
            {

                sw.WriteLine(oi + produto.codigo + ";" + produto.descricao + ";" + produto.precoCompra + ";" + produto.precoVenda + ";" + produto.quantidadeEstoque);
            }

            //apessoa.nome = anome;
            //apessoa.codigo = acodigo;
            //apessoa.contato = acontato;



            listaProdutos = c11;


        }
        public List<Produto> LsProd()
        {
            return listaProdutos;
        }

        public void ListaProduto()
        {
            //List<Produto> listProdutos = new List<Produto>();
            //listProdutos = LsProd();
            foreach (var item in listaProdutos)
            {
                int codigo = item.codigo;
                string descricao = item.descricao;
                float pcompra = item.precoCompra;
                float pvenda = item.precoVenda;
                float qestoque = item.quantidadeEstoque;

                string texto = "Codigo = " + codigo + 
                               "Descrição = " + descricao + 
                               "Preço de Compra = " + pcompra + 
                               "Preço de Venda = " + pvenda + 
                               "Quantidade em estoque = " + qestoque;

                Console.WriteLine(texto);
            }

        }
        public void ApagaProduto()
        {
        }


    }

}



    

