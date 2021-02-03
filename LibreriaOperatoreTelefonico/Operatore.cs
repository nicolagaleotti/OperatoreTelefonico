using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaOperatoreTelefonico
{
    public class Operatore
    {
        public string Nome { get; private set; }
        public static Operatore Istanza { get; } = new Operatore();
        public List<SIM> SIM { get; private set; } = new List<SIM>();

        private Operatore()
        {
            Nome = "Iliad";
        }

        public SIM AddSIM(long numeroTelefono)
        {
            SIM sim = new SIM(numeroTelefono, 10.0, Valuta.Euro);
            SIM.Add(sim);
            return sim;
        }

        public void RicaricaCredito(int seriale,double quantita)
        {
            bool trovato = false;
            foreach(SIM s in SIM)
            {
                if(s.NumeroSeriale == seriale)
                {
                    s.Credito += quantita;
                    trovato = true;
                }
            }
            if(trovato == false)
            {
                throw new Exception("Numero seriale non trovato!");
            }
        }

        public string StampaSIM(int seriale)
        {
            string sim = "SIM non trovata!";
            foreach(SIM s in SIM)
            {
                if(s.NumeroSeriale == seriale)
                {
                    sim = s.StampaSIM();
                }
            }
            return sim;
        }
    }
}
