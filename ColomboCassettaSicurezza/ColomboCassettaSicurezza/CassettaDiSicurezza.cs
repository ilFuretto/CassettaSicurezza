using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColomboCassettaSicurezza
{
    class CassettaDiSicurezza
    {
        private string codiceSeriale;
        private string pin;
        private OggettoSegreto oggetto;
        private double valoreAssicurato;

        public double ValoreAssicurato
        {
            get { return valoreAssicurato; }
            protected set { valoreAssicurato = value; }
        }

        public string CodiceSeriale
        {
            get { return codiceSeriale; }
        }

        public OggettoSegreto Oggetto
        {
            get { return oggetto; }
        }

        public CassettaDiSicurezza(string codiceSeriale, string pin)
        {
            this.codiceSeriale = codiceSeriale;
            this.pin = pin;
            this.oggetto = null;
            CalcolaValoreAssicurato();
        }

        public CassettaDiSicurezza(string codiceSeriale, string pin, OggettoSegreto oggetto)
        {
            this.codiceSeriale = codiceSeriale;
            this.pin = pin;
            this.oggetto = oggetto;
            CalcolaValoreAssicurato();
        }

        public void InserisciOggetto(OggettoSegreto oggetto, string pin)
        {
            if (this.pin == pin && this.oggetto != null)
            {
                this.oggetto = oggetto;
                CalcolaValoreAssicurato();
            }
            return;

        }

        public void RimuoviOggetto(string pin)
        {
            if (this.pin == pin && this.oggetto != null)
            {
                this.oggetto = null;
            }
            return;
        }
        virtual public void CalcolaValoreAssicurato()
        {
            if (oggetto != null) 
                ValoreAssicurato = oggetto.ValoreAssicurato; 
            else
            {
                ValoreAssicurato = 0.0;
            }

        }
     }
}
