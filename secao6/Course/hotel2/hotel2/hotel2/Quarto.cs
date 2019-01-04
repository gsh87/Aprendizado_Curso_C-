using System;
using System.Collections.Generic;
using System.Text;

namespace hotel2
{
    class Quarto
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int NQuarto { get; set; }

        // construtores
        public Quarto(string nome, string email, int numero)
        {
            Nome = nome;
            Email = email;
            NQuarto = numero;
        }
        // print
        public override string ToString()
        {
            return "Quarto: " + NQuarto +
                ", " + Nome +
                ", " + Email;
        }
    }
}
