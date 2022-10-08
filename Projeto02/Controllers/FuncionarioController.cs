using Projeto02.entities;
using Projeto02.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Controllers
{
    public class FuncionarioController 
    {
        public void CadastrarFuncionario()
        {
            try
            {
                Console.WriteLine("\n ***CADASTRO DE FUNCIONARIO *** \n");

                #region capturar dados do Funcionario

                var funcionario = new Funcionario();
                funcionario.Id = Guid.NewGuid();

                Console.WriteLine("NOME DO FUNCIONARIO........: ");
                funcionario.Nome = Console.ReadLine();


                Console.WriteLine("DATA DE NASCIMENTO...........: ");
                funcionario.DataNascimento = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("CPF.............: ");
                funcionario.Cpf = Console.ReadLine();

                Console.WriteLine("MATRICULA...........: ");
                funcionario.Matricula = Console.ReadLine();

                Console.WriteLine("DATA DE ADMISSÃO.............: ");
                funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());




                funcionario.Setor = new Setor();
                funcionario.Setor.Id = Guid.NewGuid();

                Console.WriteLine("SIGLA DO SETOR..........: ");
                funcionario.Setor.Sigla = Console.ReadLine();

                Console.WriteLine("DESCRIÇÃO DO SETOR................: ");
                funcionario.Setor.Descricao = Console.ReadLine();

                #endregion

                #region Exportar dados para o arquivo

                Console.WriteLine("\nINFORME(1)CSV ou (2)TXT");

                var opcao = int.Parse(Console.ReadLine());

                FuncionarioRepository funcionarioRepository = null;

                switch(opcao)
                {
                    case 1: //CSV
                           //POLIMORFISMO
                           funcionarioRepository = new FuncionarioRepositoryCSV();
                        break;


                        case 2: //TXT
                                //POLIMORFISMO
                        funcionarioRepository = new FuncionarioRepositoryTXT();
                        break;

                        default: //NDA
                        Console.WriteLine("\nFormato inválido!");
                        break;
                }

                if(funcionarioRepository != null)
                {
                    funcionarioRepository.ExportarDados(funcionario);

                    Console.WriteLine("\nDados gravados com sucesso!");
                }   



                #endregion
            }

            catch (Exception e)
            {
                Console.WriteLine($"\nFalha ao cadastrar: {e.Message}");

            }
        }
    }
}
