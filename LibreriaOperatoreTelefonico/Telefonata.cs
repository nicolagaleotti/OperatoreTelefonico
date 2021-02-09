using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaOperatoreTelefonico
{
    public class Telefonata
    {
        public DateTime Data { get; private set; }
        public double Durata { get; private set; }
        public Contatto Contatto { get; private set; }

        public Telefonata(DateTime data, double durata, Contatto contatto)
        {
            Data = data;
            Durata = durata;
            Contatto = contatto;
        }

        public override string ToString()
        {
            return $"{Data} {Durata} {Contatto}";
        }
    }
}
