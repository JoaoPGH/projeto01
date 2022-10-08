using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.entities
{
    public class Funcionario : Pessoa
    {
        public string Cpf { get; set; }
        public string Matricula { get; set; }
        public DateTime DataAdmissao { get; set; }
        

        public Setor Setor { get; set; }


    }
}
