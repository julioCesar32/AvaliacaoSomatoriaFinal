using System;
using System.Globalization;

namespace AlunosNotas_vetores
{
    class Principal
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Olá seja Bem-Vindo ao sistema de notas, tecle ENTER para continuar");
            Console.ReadLine();

            Console.WriteLine("Para começarmos digite a quantidade de Alunos");
            int Qtde_Alunos = int.Parse(Console.ReadLine());
            //definimos o tamanho do nosso vetor
            DadoAlunos[] Alunos = new DadoAlunos[Qtde_Alunos];


            for (int i = 0; i < Qtde_Alunos; i++)
            {
                Console.WriteLine("Por favor, digite nome e sobrenome do Aluno");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite a nota do primeiro Trimestre: ");
                Console.WriteLine("ATENÇÃO: a nota deve ser menor ou igual a 30");
                double nota1 = double.Parse(Console.ReadLine());
                if (nota1 > 30)
                {
                    while (nota1 > 30)
                    {
                        Console.WriteLine("Primeira Nota Inválida, Insira a nota correta: ");
                        nota1 = double.Parse(Console.ReadLine());
                    }
                }

                Console.WriteLine("Digite a nota do segundo Trimestre: ");
                Console.WriteLine("ATENÇÃO: as notas do segundo e do terceiro trimestre devem ser menor ou igual a 35");
                double nota2 = double.Parse(Console.ReadLine());
                if (nota2 > 35)
                {
                    while (nota2 > 35)
                    {
                        Console.WriteLine("Segunda Nota Inválida, Insira a nota correta: ");
                        nota2 = double.Parse(Console.ReadLine());
                    }
                }

                Console.WriteLine("Digite a nota do Terceiro Trimestre: ");
                Console.WriteLine("ATENÇÃO: as notas do segundo e do terceiro trimestre devem ser menor ou igual a 35");
                double nota3 = double.Parse(Console.ReadLine());
                if (nota3 > 35)
                {
                    while (nota3 > 35)
                    {
                        Console.WriteLine("Terceira Nota Inválida, Insira a nota correta: ");
                        nota3 = double.Parse(Console.ReadLine());

                    }
                }
                //Aqui coletamos os dados e verificamos se as Notas atendem aos critérios, se caso elas forem inválida execyuta um while até que elas recebam um valor válido
                Alunos[i] = new DadoAlunos(nome, nota1, nota2, nota3);

            }

            Console.WriteLine("Gostaria de ver a situação do aluno? (S/N)");
            char Escolha = char.Parse(Console.ReadLine());
            //Aqui perguntamos se o usuário gostaria de imprimir as informações
            if (Escolha == 'S' || Escolha == 's')
            {


                for (int i = 0; i < Qtde_Alunos; i++)
                {
                    Console.WriteLine(Alunos[i]);
                    //aqui imprimimos os dados do Alunos e depois mostramos o resultado do Aluno
                    if (Alunos[i].SomadasNotas() < 60)
                    {
                        Console.WriteLine("Aluno reprovado");
                        Console.WriteLine("Faltaram " + (60 - Alunos[i].SomadasNotas()) + " Pontos para aprovação");
                    }
                    else
                    {
                        Console.WriteLine("Aluno Aprovado");
                        Console.WriteLine("Parabéns :D");
                        Console.ReadLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("Então ta bom :(");
                Console.ReadLine();
            }
        }
    }
}