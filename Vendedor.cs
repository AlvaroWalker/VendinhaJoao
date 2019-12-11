using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace VendinhadoJoao
{
    public class Vendedor : Funcionario
    {
        private float percentualComissao;

        public void Cadastrar(List<Vendedor> list, Vendedor f1) {
            
            string arqvendedor = @"C:\Projeto\Funcionarios.txt";

            StreamReader swo = File.OpenText(arqvendedor);
            string oi = swo.ReadToEnd();
            swo.Close();

            using (StreamWriter sw = File.CreateText(arqvendedor))
            {

                sw.WriteLine(oi + f1.codigo + ";" + f1.nome + ";" + f1.contato + ";" + f1.cpf);
            }
        }
    }


}
