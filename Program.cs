using System;
using Academia.Model;

namespace Academia
{
    class Program
    {
        static void Main()

        {



            Console.WriteLine("OPÇÕES");
            Console.WriteLine("1 - Cadastro Alunos");
            Console.WriteLine("2 - Cadastro Colaboradores");
            string opcao = Console.ReadLine();

            if (opcao == "1")
            {
                int IdadeAluno = 1;
                do
                {

                    Console.Clear();
                    Console.WriteLine("*** Cadastro de Alunos ***");
                    // Instanciando uma classe
                    Aluno pess01 = new Aluno { Id = Guid.NewGuid().ToString() };
                    //Aluno pess01 = new Aluno();
                    pess01.Id = Guid.NewGuid().ToString();

                    //atribuindo valor ao nome
                    Console.WriteLine("Digite o nome: ");
                    pess01.Nome = Console.ReadLine();

                    //atribuindo valor a data de nascimento
                    Console.WriteLine("Digite a data de nascimento: ");
                    pess01.DataNascimento = DateTime.Parse(Console.ReadLine());

                    //Calculando idade
                    IdadeAluno = DateTime.Now.Year - pess01.DataNascimento.Year;
                    if (DateTime.Now.DayOfYear < pess01.DataNascimento.DayOfYear) IdadeAluno--;

                    //atribuindo atribuindo valor a idade
                    //Console.WriteLine("Digite a idade: ");
                    //pess01.Idade = Int32.Parse(Console.ReadLine());
                    pess01.Idade = IdadeAluno;
                    Console.WriteLine(IdadeAluno + " anos de idade.");

                    //atribuindo valor a maior idade
                    if (IdadeAluno < 18)
                    {
                        Console.Clear();
                        Console.WriteLine("***Cadastro invalido para MENOR DE IDADE***");
                        Console.ReadKey();
                    }
                    else
                    {
                        //atribuindo valor ao peso
                        Console.WriteLine("Digite o peso: ");
                        pess01.Peso = Decimal.Parse(Console.ReadLine());

                    }

                } while (IdadeAluno < 18);


                //expondo os valores com tratamento de string
                //Console.WriteLine("esse é o nome {0} essa aqui é a idade {1}",pess01.Nome,pess01.Idade);

                //expondo todos os valores

                //Console.WriteLine("Id: " + pess01.Id);
                //Console.WriteLine("Nome: " + pess01.Nome);
                //Console.WriteLine("Data de nascimento: " + pess01.DataNascimento);
                //Console.WriteLine("Idade: " + pess01.Idade);
                //Console.WriteLine("Peso: " + pess01.Peso);
                //Console.WriteLine("Maioridade :" + pess01.MaiorIdade);

            }



            if (opcao == "2")
            {
                Console.WriteLine("Hello opcao 2");

            }


        }
    }
}