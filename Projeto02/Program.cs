using Projeto02.Controllers;

namespace Projeto02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var funcionarioController = new FuncionarioController();

            funcionarioController.CadastrarFuncionario();

            Console.ReadKey();
        }
    }
}