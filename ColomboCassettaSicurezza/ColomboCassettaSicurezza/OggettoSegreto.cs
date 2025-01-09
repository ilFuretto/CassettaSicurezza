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
        private string nome;
        private double valoreDichiarato;
        private double valoreAssicurato;

        public string Id
        {
            get { return id; }
        }

        public string Nome
        {
            get { return nome; }
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

        public OggettoSegreto(string id, string nome, double valoreDichiarato)
        {
            this.nome = nome;
            this.id = id;
            if (valoreDichiarato <= 0)
                return;
            this.valoreDichiarato = valoreDichiarato;
            CalcolaValoreAssicurato();
        }
        virtual public void CalcolaValoreAssicurato()
        {
            ValoreAssicurato = ValoreDichiarato;
        }

        virtual public string GetTipo() 
        { 
            return "Oggetto Generico"; 
        }
    }
}
