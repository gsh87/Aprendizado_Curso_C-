using System;
using System.Collections.Generic;
using System.Globalization;

namespace fopa
{
    class Funcionario
    {
        public string Nome { get; set; }
        public int Id { get; set; }
        public double Salario { get; set; }

        // construtores
        public Funcionario(string nome, int id, double salario)
        {
            Nome = nome;
            Id = id;
            Salario = salario;
        }


        public void ModSalario(double por)
        {
            Salario += Salario * por;
        }

        // impressao
        public override string ToString()
        {
            return "Id: "+Id+
                ", "+Nome+
                ", "+Salario.ToString("f2",CultureInfo.InvariantCulture);     
        }

    }
}
