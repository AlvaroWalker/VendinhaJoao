using System;
using System.Collections.Generic;
using System.Text;

namespace VendinhadoJoao
{
    abstract class Funcionario              // Classe abstrata, será utilizada para herança entre as classes: Vendedor, Gerente, Entregador.
    {
        int codigo;
        string nome;
        int cpf;
        string contato;

        public abstract void Cadastrar();
        public abstract void Excluir();
        public abstract void Listar();
        public abstract float CalculaComissao();      // Verificar a opção void, deve ter tipo float.
    

    }
    
}

