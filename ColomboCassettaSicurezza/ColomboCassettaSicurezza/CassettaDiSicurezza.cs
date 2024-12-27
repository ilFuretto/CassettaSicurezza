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
        }

        public void InserisciOggetto(OggettoSegreto oggetto, string pin)
        {
            if (this.pin == pin && this.oggetto == null)
            {
                this.oggetto = oggetto;
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
    }
}
