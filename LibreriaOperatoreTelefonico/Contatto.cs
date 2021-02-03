using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaOperatoreTelefonico
{
    public class Contatto
    {
        public string Nome { get; private set; }
        public string Cognome { get; private set; }
        public long NumeroTelefono { get; private set; }

        public Contatto(string nome,string cognome,long numeroTelefono)
        {
            Nome = nome;
            Cognome = cognome;
            if (numeroTelefono.ToString().Length < 10)
                throw new Exception("Numero di telefono inserito troppo corto!\nDeve contenere esattamente 10 caratteri!");
            else if (numeroTelefono.ToString().Length > 10)
                throw new Exception("Numero di telefono inserito troppo lungo!\nDeve contenere esattamente 10 caratteri!");
            else
                NumeroTelefono = numeroTelefono;
        }
    }
}
