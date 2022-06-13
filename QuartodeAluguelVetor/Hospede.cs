using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartodeAluguelVetor
{
    class Hospede
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Endereco { get; set; }
        public long Telefone { get; set; }
        public string Email { get; set; }
        public int EscolhadeQuarto { get; set; }

        public Hospede(string nome, int idade, string endereco, long telefone, string email, int escolhade_Quarto)
        {
            Nome = nome;
            Idade = idade;
            Endereco = endereco;
            Telefone = telefone;
            Email = email;
            EscolhadeQuarto = escolhade_Quarto;
        }
        public override string ToString()
        {
            return "Nome: " + Nome
                   + "\n"
                   + "Idade: " + Idade
                   + "\n"
                   + "Endereço: " + Endereco
                   + "\n"
                   + "Telefone: " + Telefone
                   + "\n"
                   + "Email: " + Email;
        }
    }
}
