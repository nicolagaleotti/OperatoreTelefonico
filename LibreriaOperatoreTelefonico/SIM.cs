using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaOperatoreTelefonico
{
    public class SIM
    {
        public long NumeroTelefono { get; private set; }
        public int NumeroSeriale { get; private set; }
        public double Credito { get; set; }
        public Valuta Valuta { get; private set; }
        public List<Telefonata> Telefonate { get; private set; } = new List<Telefonata>();

        public SIM(long numeroTelefono,double credito,Valuta valuta)
        {
            if (numeroTelefono.ToString().Length < 10)
                throw new Exception("Numero di telefono inserito troppo corto!\nDeve contenere esattamente 10 caratteri!");
            else if (numeroTelefono.ToString().Length > 10)
                throw new Exception("Numero di telefono inserito troppo lungo!\nDeve contenere esattamente 10 caratteri!");
            else
                NumeroTelefono = numeroTelefono;
            Credito = credito;
            Valuta = valuta;
            if (Operatore.Istanza.SIM[0] == null)
                NumeroSeriale = 100020;
            else
            {
                NumeroSeriale = Operatore.Istanza.SIM[Operatore.Istanza.SIM.Count - 1].NumeroSeriale + 1;
            }
        }

        public void AddTelefonata(Telefonata telefonata)
        {
            Telefonate.Add(telefonata);
        }

        public double CalcolaTotaleMinutiConversazione()
        {
            double totale = 0;
            foreach(Telefonata t in Telefonate)
            {
                totale += t.Durata;
            }
            return totale;
        }

        public string CalcolaTelefonate(long numeroTelefono)
        {
            List<Telefonata> telefonate = new List<Telefonata>();
            foreach(Telefonata t in Telefonate)
            {
                if (t.Contatto.NumeroTelefono == numeroTelefono)
                    telefonate.Add(t);
            }
            double totaleDurata = 0;
            foreach(Telefonata t in telefonate)
            {
                totaleDurata += t.Durata;
            }
            return $"Sono state fatte {telefonate.Count} telefonate al numero {numeroTelefono} per un totale di {totaleDurata} minuti.";
        }

        public string StampaSIM()
        {
            return $"Numero di telefono : {NumeroTelefono}\n" +
                $"Numero seriale : {NumeroSeriale}\n" +
                $"Credito : {Credito} {Valuta}";
        }

        public string StampaTelefonate()
        {
            string telefonate="";
            foreach (Telefonata t in Telefonate)
            {
                telefonate += $"Telefonata a {t.Contatto.Nome} {t.Contatto.Cognome} in data {t.Data} per {t.Durata} minuti.\n";
            }
            return telefonate;
        }
    }
}
