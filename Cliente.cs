using System;
using System.Collections.Generic;
using System.Text;

namespace VendinhadoJoao
{
    public class Cliente                    // utilizamos associação entre as classes Pessoa e Endereço.
    {
        
        new Endereco aendereco;
        new Pessoa apessoa;


        public string anome;
        public int acodigo;
        public string acontato;

        public void CadastrarCliente ()
        {



            apessoa.nome = anome;
            apessoa.codigo = acodigo;
            apessoa.contato = acontato;


        }
        public void DeletaCliente ()

        {

        }
        public void ListaCliente ()
        {
            

        }
    }
}
