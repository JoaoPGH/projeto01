using Projeto02.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Repositories
{
    public class FuncionarioRepositoryTXT : FuncionarioRepository
    {
        public override void ExportarDados(Funcionario funcionario)
        {
            #region Definindo o nome e o local do arquivo

            var path = "c:\\temp\\funcionarios.txt";


            #endregion

            #region Gravando o conteúdo do arquivo



            using (var streamWrither = new StreamWriter(path, true))
            {
                streamWrither.WriteLine($"ID DO FUNCIONARIO..........: {funcionario.Id}");
                streamWrither.WriteLine($"NOME.........: {funcionario.Nome}");
                streamWrither.WriteLine($"DATA DE NASCIMENTO..........: {funcionario.DataNascimento.ToString("dd/MM/yyyy")}");
                streamWrither.WriteLine($"CPF............: {funcionario.Cpf}");
                streamWrither.WriteLine($"MATRICULA.........: {funcionario.Matricula}");
                streamWrither.WriteLine($"DATA DE ADMISSÃO.........: {funcionario.DataAdmissao.ToString("dd/MM/yyyy")}");
                streamWrither.WriteLine($"ID DO SETOR.........: {funcionario.Setor.Id}");
                streamWrither.WriteLine($"SIGLA DO SETOR........: {funcionario.Setor.Sigla}");
                streamWrither.WriteLine($"DESCRIÇÃO DO SETOR........: {funcionario.Setor.Descricao}");

                streamWrither.WriteLine($"\n");

               
            }
           

            #endregion
        }
    }
}
