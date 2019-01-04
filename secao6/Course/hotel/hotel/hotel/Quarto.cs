using System.Globalization;

namespace hotel
{
    class Quarto
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Numero { get; set; }


        // constrututores
        public Quarto(string nome, string email, int numero)
        {
            Nome = nome;
            Email = email;
            Numero = numero;
        }

        // print
        public override string ToString()
        {
            return "Quarto: " + Numero +
                    ", " + Nome +
                    ", " + Email;
        }


    }
}
