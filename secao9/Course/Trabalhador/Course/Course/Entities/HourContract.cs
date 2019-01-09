using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }


        // construtores
        public HourContract()
        {
        }

        public HourContract(DateTime data, double valorPorHora, int horas)
        {
            Date = data;
            ValuePerHour = valorPorHora;
            Hours = horas;
        }

        // metodos
        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}
