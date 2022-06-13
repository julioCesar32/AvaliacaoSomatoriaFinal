using System;
using System.Globalization;

namespace FuncionariosVetor
{
    class Principal
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Quantos funcionários iremos analisar?");
            int N = int.Parse(Console.ReadLine());
            //definimos o tamanho do nosso vetor

            Funcionario[] contribuidor1 = new Funcionario[N];


            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Por favor, digite o nome do contribuidor");
                string nome = Console.ReadLine();

                Console.WriteLine("Agora digite o salário bruto do mesmo");
                double salarioBruto = double.Parse(Console.ReadLine());


                Console.WriteLine("O funcionário recebera aumento?Digite S/N");
                char Escolha = char.Parse(Console.ReadLine());
                //coletamos os dados do funcionario
                if (Escolha == 'S' || Escolha == 's')
                {
                    Console.WriteLine("Aumentaremos enquantos %");
                    double aumento = double.Parse(Console.ReadLine());
                    aumento = (aumento / 100) * salarioBruto;
                    contribuidor1[i] = new Funcionario(nome, salarioBruto, aumento);
                    //Se caso o if for verdadeiro Ele aumenta o salário com base no que o usuario digitar
                }
                else
                {
                    double aumento = 0;
                    contribuidor1[i] = new Funcionario(nome, salarioBruto, aumento);
                }
            }

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("_________________");
                Console.WriteLine(contribuidor1[i]);
                //aqui imprimimos as informações
            }
        }
    }
}