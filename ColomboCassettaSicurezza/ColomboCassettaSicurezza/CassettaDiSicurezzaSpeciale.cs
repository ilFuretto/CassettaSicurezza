using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColomboCassettaSicurezza
{
    class CassettaDiSicurezzaSpeciale : CassettaDiSicurezza
    {
        public CassettaDiSicurezzaSpeciale(string codiceSeriale, string pin) : base(codiceSeriale, pin)
        { }

        public CassettaDiSicurezzaSpeciale(string codiceSeriale, string pin, OggettoSegreto oggetto) : base(codiceSeriale, pin, oggetto)
        {
            CalcolaValoreAssicurato();
        }


        override public void CalcolaValoreAssicurato()
        {
            if (Oggetto == null)
            {
                ValoreAssicurato = 0.0;
            }
            else if (Oggetto is GioielloPrezioso)
            {
                ValoreAssicurato = Oggetto.ValoreAssicurato * 0.9;  // Sconto del 10% per gioielli preziosi
            }
            else if (Oggetto is DocumentoLegale)
            {
                ValoreAssicurato = Oggetto.ValoreAssicurato * 0.8;  // Sconto del 20% per documenti legali
            }
            else if (Oggetto is ChiaveDiAccesso)
            {
                ValoreAssicurato = Oggetto.ValoreAssicurato * 0.7;  // Sconto del 30% per chiavi di accesso
            }
            else
            {
                ValoreAssicurato = Oggetto.ValoreAssicurato;  // Se l'oggetto è generico, non applicare sconto
            }
        }

    }
}
