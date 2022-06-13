using System;
using System.Globalization;

namespace QuartodeAluguelVetor
{
    class Principal
    {

        static void Main(string[] args)
        {
            Hospede[] cliente;
            DadosQuarto Quarto1;
            DadosQuarto1 Quarto2;
            DadosQuarto2 Quarto3;

            Console.WriteLine("Quantos Hóspedes se hospedaram ");
            int QtdeHospedes = int.Parse(Console.ReadLine());
            //Aqui definimos o tamanho do nosso vetor

            cliente = new Hospede[QtdeHospedes];
            Quarto1 = new DadosQuarto();
            Quarto2 = new DadosQuarto1();
            Quarto3 = new DadosQuarto2();



            for (int i = 0; i < QtdeHospedes; i++)
            {
                Console.WriteLine("Preencha com os dados do Hospede: ");
                Console.Write("Nome:....");
                string nome = Console.ReadLine();
                Console.Write("Idade:....");
                int idade = int.Parse(Console.ReadLine());
                Console.Write("Endereço:.....");
                string endereco = Console.ReadLine();
                Console.Write("Telefone para contato:.....");
                long telefone = long.Parse(Console.ReadLine());
                Console.Write("Email:.....");
                string email = Console.ReadLine();
                Console.WriteLine();
                //aqui coletamos os dados dos Hospedes

                Console.WriteLine("Período em DIAS que ficará hospedado");
                Quarto1.DiasqueficaraAlugado = double.Parse(Console.ReadLine());

                double ValorApagar = Quarto1.CalculoAluguel();

                Console.WriteLine("Temos 3 quartos disponíveis");
                Console.WriteLine("Estão disponíveis: 505, 508, 510");
                int escolhadeQuarto = int.Parse(Console.ReadLine());

                if (escolhadeQuarto == Quarto1.NumeroDoQuarto)
                {
                    Console.WriteLine("          _______           ");
                    Console.WriteLine("==========Informações do Quarto==========");
                    Console.WriteLine(Quarto1);

                    Console.WriteLine("Valor a pagar: R$" + ValorApagar.ToString("F"));
                }
                else if (escolhadeQuarto == Quarto2.NumeroDoQuarto)
                {
                    Console.WriteLine("          _______           ");
                    Console.WriteLine("==========Informações do Quarto==========");
                    Console.WriteLine(Quarto2);

                    Console.WriteLine("Valor a pagar: R$" + ValorApagar.ToString("F"));
                }
                else
                {
                    Console.WriteLine("          _______           ");
                    Console.WriteLine("==========Informações do Quarto==========");
                    Console.WriteLine(Quarto3);

                    Console.WriteLine("Valor a pagar: R$" + ValorApagar.ToString("F"));
                }

                cliente[i] =  new Hospede(nome, idade, endereco, telefone, email, escolhadeQuarto);
            }

            for (int i = 0; i < QtdeHospedes; i++)
            {
                Console.WriteLine("                 _______           ");
                Console.WriteLine("==========Informações do Hóspede==========");
                Console.WriteLine(cliente[i]);
                Console.WriteLine();
                //aqui imprimimos os dados armazenados no vetor
            }


        }
    }
}