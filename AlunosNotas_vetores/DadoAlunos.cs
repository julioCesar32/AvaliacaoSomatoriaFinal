using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunosNotas_vetores
{
    class DadoAlunos
    {

        public string Nome { get; set;  } 
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        public char Escolha;  


        public DadoAlunos(string nome, double nota1, double nota2, double nota3)
        {
            Nome = nome;
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
        }

        public double SomadasNotas()
        {
            return Math.Round((Nota1 + Nota2 + Nota3), 2);
        }
        
        public override string ToString()
        {
            return "Nome: " + Nome
                +"\n"
                +"Nota do Primeiro Trimestre: " + Nota1
                +"\n"
                +"Nota do Segundo Trimestre: " + Nota2
                +"\n"
                +"Nota do Terceiro Trimestre: " + Nota3
                +"\n"
                +"Nota Final: " + SomadasNotas();
            
        }
    }
}
