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
        { }

            override public void CalcolaValoreAssicurato()
        {
            OggettoSegreto oggetto = Oggetto;

            if (oggetto == null)
            {
                ValoreAssicurato = 0.0;
            }
            else if (oggetto is GioielloPrezioso)
            {
                ValoreAssicurato = ValoreAssicurato * 0.9;
            }
            else if (oggetto is DocumentoLegale)
            {
                ValoreAssicurato = ValoreAssicurato * 0.8;
            }
            else if (oggetto is ChiaveDiAccesso)
            {
                ValoreAssicurato = ValoreAssicurato * 0.7;
            }
            else
            {
                ValoreAssicurato = 0.0;
            }
        }
    }
}
