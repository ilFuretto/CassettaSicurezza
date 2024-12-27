using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColomboCassettaSicurezza
{
    class GioielloPrezioso : OggettoSegreto
    {
        private string tipo;
        public GioielloPrezioso(string id, double valoreDichiarato, string tipo) : base(id, valoreDichiarato)
        {
            this.tipo = tipo;
            CalcolaValoreAssicurato();
        }

        override public void CalcolaValoreAssicurato()
        {
            ValoreAssicurato = ValoreDichiarato * 5;
        }
    }
}
