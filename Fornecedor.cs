using System;
using System.Collections.Generic;
using System.Text;

namespace VendinhadoJoao
{
    class Fornecedor
    {
        public int codigo;
        public string razaoSocial;
        Contato contato;

        public Fornecedor ()
        {
            contato = new Contato();
        }
        public void SetContato (string anome, string aemail, int acodigo)

        {
            contato.nome = anome;
            contato.email = aemail;
            contato.codigo = acodigo;
             
        }
    
        public void GetContato ()
        {
            Console.WriteLine(this.codigo);
            Console.WriteLine(this.razaoSocial);
            Console.WriteLine(this.contato.nome);
            Console.WriteLine(this.contato.email);
            Console.WriteLine();
        }
    }




}
