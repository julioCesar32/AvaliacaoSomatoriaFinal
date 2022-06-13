using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartodeAluguelVetor
{
    class DadosQuarto
    {
        public int NumeroDoQuarto = 505;
        public int PessoasHospedadas = 1;
        public int Camas = 1;
        public double MetrosQuadrados = 12;
        public double DiasqueficaraAlugado;
        public double CalculoAluguel()
        {
            return Math.Round(DiasqueficaraAlugado * 20.00, 2);
        }
        public override string ToString()
        {
            return "Numero do quarto: " + NumeroDoQuarto
                   + "\n"
                   + "Pessoas Hospedadas: " + PessoasHospedadas
                   + "\n"
                   + "Camas: " + Camas
                   + "\n"
                   + "M²: " + MetrosQuadrados
                   + "\n"
                   + "Valor da Diária: R$20,00";
        }
    }

    class DadosQuarto1
    {
        public int NumeroDoQuarto = 508;
        public int PessoasHospedadas = 1;
        public int Camas = 1;
        public double MetrosQuadrados = 12;
        public double DiasqueficaraAlugado;
        public double CalculoAluguel()
        {
            return Math.Round(DiasqueficaraAlugado * 20.00, 2);
        }
        public override string ToString()
        {
            return "Numero do quarto: " + NumeroDoQuarto
                   + "\n"
                   + "Pessoas Hospedadas: " + PessoasHospedadas
                   + "\n"
                   + "Camas: " + Camas
                   + "\n"
                   + "M²: " + MetrosQuadrados
                   + "\n"
                   + "Valor da Diária: R$20,00";
        }
    }

    class DadosQuarto2
    {
        public int NumeroDoQuarto = 510;
        public int PessoasHospedadas = 1;
        public int Camas = 2;
        public double MetrosQuadrados = 12;
        public double DiasqueficaraAlugado;
        public double CalculoAluguel()
        {
            return Math.Round(DiasqueficaraAlugado * 25.00, 2);
        }
        public override string ToString()
        {
            return "Numero do quarto: " + NumeroDoQuarto
                   + "\n"
                   + "Pessoas Hospedadas: " + PessoasHospedadas
                   + "\n"
                   + "Camas: " + Camas
                   + "\n"
                   + "M²: " + MetrosQuadrados
                   + "\n"
                   + "Valor da Diária: R$20,00";
        }
    }
}
