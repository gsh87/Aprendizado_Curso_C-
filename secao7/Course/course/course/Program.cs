using System;
using System.Globalization;

namespace course
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z");

            Console.WriteLine("-----------------------------");
            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 kind: " + d1.Kind);
            Console.WriteLine("d1 to local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to utc: " + d1.ToUniversalTime());

            Console.WriteLine("-----------------------------");
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 kind: " + d2.Kind);
            Console.WriteLine("d2 to local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to utc: " + d2.ToUniversalTime());
            Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ")); // erro
            Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
            /*
             Console.WriteLine("--------------------------------------------------------------------------");
            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine("-----------------------------");
            Console.WriteLine("d1: "+d1);
            Console.WriteLine("d1 kind: "+d1.Kind);
            Console.WriteLine("d1 to local: "+d1.ToLocalTime());
            Console.WriteLine("d1 to utc: "+d1.ToUniversalTime());

            Console.WriteLine("-----------------------------");
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 kind: " + d2.Kind);
            Console.WriteLine("d2 to local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to utc: " + d2.ToUniversalTime());

            Console.WriteLine("-----------------------------");
            Console.WriteLine("d3: " + d3);
            Console.WriteLine("d3 kind: " + d3.Kind);
            Console.WriteLine("d3 to local: " + d3.ToLocalTime());
            Console.WriteLine("d3 to utc: " + d3.ToUniversalTime());
            */

            /*
            Console.WriteLine("--------------------------------------------------------------------------");
            TimeSpan t = new TimeSpan(2,3,5,7,11);
            Console.WriteLine(t);

            Console.WriteLine("Days: " +t.Days);
            Console.WriteLine("Hours: "+t.Hours);
            Console.WriteLine("Minutes: "+t.Minutes);
            Console.WriteLine("Seconds: "+t.Seconds);
            Console.WriteLine("Milliseconds: " + t.Milliseconds);
            Console.WriteLine("Ticks: "+t.Ticks);
            Console.WriteLine("------------------------------");
            Console.WriteLine("TotalDays: "+t.TotalDays);
            Console.WriteLine("TotalHours: "+t.TotalHours);
            Console.WriteLine("TotalMinutes: "+t.TotalMinutes);
            Console.WriteLine("TotalMIllisenconds: "+t.TotalMilliseconds);
            Console.WriteLine("------------------------------");
            Console.WriteLine("------------------------------");


            TimeSpan t1 =  new TimeSpan(1, 30, 10);
            TimeSpan t2 = new TimeSpan(0, 10, 5);

            TimeSpan sum = t1.Add(t2);
            TimeSpan dif = t1.Subtract(t2);
            TimeSpan mult = t1.Multiply(2.0);
            TimeSpan div = t1.Divide(2.0);

            Console.WriteLine("t1:"+t1);
            Console.WriteLine("t2: "+t2);
            Console.WriteLine("sum: "+sum);
            Console.WriteLine("dif: "+dif);
            Console.WriteLine("mult: "+mult);
            Console.WriteLine("Div: "+div);
            */

        }
    }
}
