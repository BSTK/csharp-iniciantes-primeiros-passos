using System;

namespace BSTK.SistemaBancario
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("** Sistema Bancário **");

            var funcionarioAlberto = new Funcionario();
            funcionarioAlberto.Nome = "Alberto Souza";
            funcionarioAlberto.Cpf = "393.112.999/88";

            var funcionarioAdalto = new Funcionario();
            funcionarioAdalto.Nome = "Adalto Pereira";
            funcionarioAdalto.Cpf = "111.222.333/66";

            var gerente = new Gerente();

            Console.WriteLine("> Método somente CPF");
            gerente.AprovarHoraFuncionario(funcionarioAdalto.Cpf);
            gerente.AprovarHoraFuncionario(funcionarioAlberto.Cpf);

            Console.WriteLine();

            Console.WriteLine("> Método objeto");
            gerente.AprovarHoraFuncionario(funcionarioAdalto);
            gerente.AprovarHoraFuncionario(funcionarioAlberto);

            Console.ReadKey();
        }
    }
}
