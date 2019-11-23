using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace VendinhadoJoao
{
    public class Cliente                    // utilizamos associação entre as classes Pessoa e Endereço.
    {
        
        new Endereco aendereco;
        new Pessoa apessoa;

        public List<Cliente> listaclientes;

        public string anome;
        public int acodigo;
        public string acontato;

        public void CadastrarCliente (List<Cliente> c11,Cliente cliente)
        {
            string arqclientes = @"C:\Projeto\Clientes.txt";

            StreamReader swo = File.OpenText(arqclientes);
            string oi = swo.ReadToEnd();
            swo.Close();

            using (StreamWriter sw = File.CreateText(arqclientes))
            {
                
                sw.WriteLine(oi + cliente.acodigo + ";" + cliente.anome+ ";" + cliente.acontato + ";");
            }

            //apessoa.nome = anome;
            //apessoa.codigo = acodigo;
            //apessoa.contato = acontato;



            listaclientes = c11;

        }
        public void DeletaCliente ()

        {

        }
        public void ListaCliente ()
        {

            foreach (var item in listaclientes)
            {
                int codigo = item.acodigo;
                string nome = item.anome;
                string matricula = item.acontato;

                string texto = "Codigo=" + codigo + " Nome=" + nome + " Matrícula=" + matricula;

                Console.WriteLine(texto);
            }


        }
        public List<Cliente> ListarClientes()
        {
            return listaclientes;
        }
    }
}
