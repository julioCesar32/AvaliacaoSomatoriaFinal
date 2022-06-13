using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionariosVetor
{
    class Funcionario
    {
        public string Nome { get; set; }
        public double Salariobruto { get; set; }
        public double Aumento { get; set; }
        public double Imposto;
        public char Escolha;


        public Funcionario(string nome, double salarioBruto, double aumento)
        {
            Nome = nome;
            Salariobruto = salarioBruto;
            Aumento = aumento;
        }

        public double CalculoAumento()
        {
            return (Aumento / 100) * Salariobruto;
        }
        public double Salarioliquido()
        {
            return (Salariobruto - calcularImposto()) + Aumento;
        }
        public double calcularImposto()
        {
            if (Salariobruto <= 1900)
            {
               return Imposto = 0;
            }
            else if (Salariobruto >= 1903 && Salariobruto <= 2826)
            {
               return Imposto = (7.5 / 100) * Salariobruto;
            }
            else if (Salariobruto >= 2826 && Salariobruto <= 3751)
            {
                return Imposto = (15 / 100) * Salariobruto;
            }
            else if (Salariobruto >= 375 && Salariobruto <= 4664)
            {
                return Imposto = (22.5 / 100) * Salariobruto;
            }
            else
            {
                return Imposto = (27.5 / 100) * Salariobruto;
            }
        }
        public override string ToString()
        {
            return "Nome: " + Nome
                   + "\n"
                   + "Salário Bruto: R$" + Salariobruto
                   + "\n"
                   + "Imposto: R$" + calcularImposto()
                   + "\n"
                   + "Aumento: R$" + Aumento
                   + "\n"
                   + "Salário liquido: R$" + Salarioliquido();
        }
    }
}
