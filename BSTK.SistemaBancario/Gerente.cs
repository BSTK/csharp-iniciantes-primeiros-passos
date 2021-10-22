using System;

namespace BSTK.SistemaBancario
{
    class Gerente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cpf{ get; set; }

        public void AprovarHoraFuncionario(Funcionario funcionario)
        {
            if (funcionario is null)
            {
                Console.WriteLine("Dados inválidos!");
                return;
            }

            ValidarCpf(funcionario.Cpf);

            Console.WriteLine("Aprovando horas para funcionario " + funcionario.Nome + " de CPF: " + funcionario.Cpf);

        }

        public void AprovarHoraFuncionario(string cpf)
        {
            ValidarCpf(cpf);

            Console.WriteLine("Aprovando horas para funcionario de CPF: " + cpf);
        }

        private void ValidarCpf(string cpf)
        {
            if (cpf is null || "".Equals(Cpf))
            {
                Console.WriteLine("CPF Invalido!");
                return;
            }
        }
    }
}
