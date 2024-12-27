using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColomboCassettaSicurezza
{
    class CassettaDiSicurezzaSpeciale : CassettaDiSicurezza
    {
        private double valoreAssicurato;

        public double ValoreAssicurato
        {
            get { return valoreAssicurato; }
        }

        public CassettaDiSicurezzaSpeciale(string codiceSeriale, string pin) : base(codiceSeriale, pin)
        { }

        public void CalcolaValoreAssicurato()
        {
            OggettoSegreto oggetto = Oggetto;

            if (oggetto == null)
            {
                valoreAssicurato = 0;
            }
            else if (oggetto is GioielloPrezioso)
            {
                valoreAssicurato = oggetto.ValoreAssicurato * 0.9;
            }
            else if (oggetto is DocumentoLegale)
            {
                valoreAssicurato = oggetto.ValoreAssicurato * 0.8;
            }
            else if (oggetto is ChiaveDiAccesso)
            {
                valoreAssicurato = oggetto.ValoreAssicurato * 0.7;
            }
            else
            {
                valoreAssicurato = 0;
            }
        }
    }
}
