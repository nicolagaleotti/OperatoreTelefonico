using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaOperatoreTelefonico;

namespace ProvaOperatoreTelefonico
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Inserisci un numero di telefono (10 caratteri) : ");
                long numero = long.Parse(Console.ReadLine());
                SIM sim1 = new SIM(numero, 10, Valuta.Euro);
                Console.WriteLine($"Numero seriale : {sim1.NumeroSeriale}");
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
