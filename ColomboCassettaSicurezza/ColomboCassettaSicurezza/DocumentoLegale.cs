using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColomboCassettaSicurezza
{
    class DocumentoLegale : OggettoSegreto
    {
        private string tipo;
        public DocumentoLegale(string id, double valoreDichiarato, string tipo) : base(id, valoreDichiarato)
        {
            this.tipo = tipo;
            CalcolaValoreAssicurato();
        }

        override public void CalcolaValoreAssicurato()
        {
            if (ValoreDichiarato >= 100)
            {
                ValoreAssicurato = ValoreDichiarato;
            }
            else
            {
                ValoreAssicurato = 50;
            }
        }
    }
}
