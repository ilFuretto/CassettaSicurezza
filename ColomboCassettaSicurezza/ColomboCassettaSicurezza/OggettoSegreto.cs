using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColomboCassettaSicurezza
{
    class OggettoSegreto
    {
        private string id;
        private double valoreDichiarato;
        private double valoreAssicurato;

        public string Id
        {
            get { return id; }
        }

        public double ValoreDichiarato
        {
            get { return valoreDichiarato; }
        }

        public double ValoreAssicurato
        {
            get { return valoreAssicurato; }
            protected set { valoreAssicurato = value; }
        }

        public OggettoSegreto(string id, double valoreDichiarato)
        {
            this.id = id;
            this.valoreDichiarato = valoreDichiarato;
            CalcolaValoreAssicurato();
        }
        virtual public void CalcolaValoreAssicurato()
        {
            ValoreAssicurato = ValoreDichiarato;
        }
    }
}
