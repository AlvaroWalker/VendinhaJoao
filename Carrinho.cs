using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace VendinhadoJoao
{
    public class Carrinho
    {
        public Cliente cliente;
        public Vendedor vendedor;
        public Produto[] listaProduto;
        float total;
        double tComissao;

        public void EtiquetaProduto(Vendedor v,Cliente c,List<Produto> p)
        {
            Console.Clear();
            Console.WriteLine("Vendedor = {0}", v.nome);
            Console.WriteLine("Cliente = {0}", c.anome);
            Console.WriteLine("\n\n---------------------\n\n");

            foreach (var item in p)
            {
                int codigo = item.codigo;
                string desc = item.descricao;
                float compra = item.precoCompra;
                float venda = item.precoVenda;
                float estoque = item.quantidadeEstoque;

                total = total + item.precoVenda;

                string texto = desc + "   Preço:" + venda;
                Console.WriteLine(texto);


            }
            TotalCompra();
        }

         public void TotalCompra()
           
        {
            Console.WriteLine(" ");
            Console.WriteLine("Total da Venda: R$ "+ total.ToString("F2", CultureInfo.InvariantCulture));
            CalculaComissao();
        }


        public void CalculaComissao()
        {
            tComissao = total * 0.05;
            Console.WriteLine(" ");
            Console.WriteLine("Total da Comissão: R$ " + tComissao);

        }
    }
}
