using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace VendinhadoJoao
{
    public abstract class Funcionario              // Classe abstrata, será utilizada para herança entre as classes: Vendedor, Gerente, Entregador.
    {
        public int codigo;
        public string nome;
        public string cpf;
        public string contato;


        public void Cadastrar(List<Vendedor> list, Vendedor f1)
        {

            string arqvendedor = @"C:\Projeto\Funcionarios.txt";

            StreamReader swo = File.OpenText(arqvendedor);
            string oi = swo.ReadToEnd();
            swo.Close();

            using (StreamWriter sw = File.CreateText(arqvendedor))
            {

                sw.WriteLine(oi + f1.codigo + ";" + f1.nome + ";" + f1.contato + ";" + f1.cpf);
            }
        }

        public void Excluir() { 
        
        }
        public void Listar() { 
        
        }
        public float CalculaComissao(float comissao) {

            return comissao * 0.05f ;

        }      // Verificar a opção void, deve ter tipo float.
    

    }
    
}

