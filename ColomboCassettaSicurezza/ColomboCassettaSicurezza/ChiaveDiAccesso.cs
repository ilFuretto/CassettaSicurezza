using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColomboCassettaSicurezza
{
    class ChiaveDiAccesso : OggettoSegreto
    {
        private string tipo;
        public ChiaveDiAccesso(string id, string nome, double valoreDichiarato, string tipo) : base(id, nome, valoreDichiarato)
        {
            this.tipo = tipo;
            CalcolaValoreAssicurato();
        }

        override public void CalcolaValoreAssicurato()
        {
            ValoreAssicurato = ValoreDichiarato * 1000;
        }
        override public string GetTipo()
        {
            return tipo;
        }
    }
}
