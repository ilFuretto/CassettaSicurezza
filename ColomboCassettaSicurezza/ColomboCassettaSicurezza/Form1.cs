namespace ColomboCassettaSicurezza
{
    public partial class Form1 : Form
    {
        private bool CassettaSpeciale;
        private OggettoSegreto oggettoSegreto;
        private List<CassettaDiSicurezza> cassetteSicurezza;
        private List<CassettaDiSicurezza> cassetteSicurezzaVuote;
        private CassettaDiSicurezza cassetta;
        private int id, indiceCassettaSelezionata;
        public Form1()
        {
            InitializeComponent();
            cassetteSicurezza = new List<CassettaDiSicurezza>();
            cassetteSicurezzaVuote = new List<CassettaDiSicurezza>();
            id = 1;
            AggiornaNumeroVisualizzato();
        }

        private void AggiornaGrafica(string operazione)
        {
            AggiornaNumeroVisualizzato();
            if (operazione == "nuovaCassetta")
            {
                listBox1.Items.Add(cassetta.Oggetto.GetTipo() + " - valore assicurato: " + cassetta.ValoreAssicurato + " euro");
            }
            else if (operazione == "nuovoOggetto")
            {
                listBox2.Items.Remove(listBox2.Items[indiceCassettaSelezionata]);
                listBox1.Items.Add(cassetta.Oggetto.GetTipo() + " - valore assicurato: " + cassetta.ValoreAssicurato + " euro");
            }
            else if (operazione == "rimuoviOggetto")
            {
                listBox1.Items.Remove(listBox1.Items[indiceCassettaSelezionata]);
                if (cassetta is CassettaDiSicurezzaSpeciale)
                    listBox2.Items.Add("Cassetta di Sicurezza Speciale");
                else
                    listBox2.Items.Add("Cassetta di Sicurezza Normale");
            }
            else if (operazione == "rimuoviCassetta")
            {
                if (radioButtonCassettePiene.Checked)
                {
                    listBox1.Items.RemoveAt(indiceCassettaSelezionata);
                }
                else
                    listBox2.Items.Remove(listBox2.Items[indiceCassettaSelezionata]);
            }

        }

        private void TipoCassetta()
        {
            if (radioButton1.Checked)
            {
                CassettaSpeciale = false;
            }
            else if (radioButton2.Checked)
            {
                CassettaSpeciale = true;
            }
        }

        private void CreaOggetto()
        {
            if (tipologiaOggetto.SelectedItem.ToString() == "Oggetto Generico")
                oggettoSegreto = new OggettoSegreto(id.ToString("D6"), nomeOggetto.Text, Convert.ToDouble(numericUpDown1.Value));
            else if (tipologiaOggetto.SelectedItem.ToString() == "Gioiello Prezioso")
                oggettoSegreto = new GioielloPrezioso(id.ToString("D6"), nomeOggetto.Text, Convert.ToDouble(numericUpDown1.Value), "gioiello prezioso");
            else if (tipologiaOggetto.SelectedItem.ToString() == "Documento Legale")
                oggettoSegreto = new DocumentoLegale(id.ToString("D6"), nomeOggetto.Text, Convert.ToDouble(numericUpDown1.Value), "documento legale");
            else
                oggettoSegreto = new ChiaveDiAccesso(id.ToString("D6"), nomeOggetto.Text, Convert.ToDouble(numericUpDown1.Value), "chiave di accesso");
        }

        private void btnNuovaCassetta_Click(object sender, EventArgs e)
        {
            if ((radioButton1.Checked == false && radioButton2.Checked == false) || nomeOggetto.Text == "" || tipologiaOggetto.SelectedItem == null || numericUpDown1.Value <= 0)
                return;

            TipoCassetta();
            CreaOggetto();

            if (CassettaSpeciale == false)
                cassetta = new CassettaDiSicurezza(id.ToString("D6"), "1234", oggettoSegreto);
            else
                cassetta = new CassettaDiSicurezzaSpeciale(id.ToString("D6"), "1234", oggettoSegreto);

            id++;
            cassetteSicurezza.Add(cassetta);

            AggiornaGrafica("nuovaCassetta");
        }

        private void btnNuovoOggetto_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem == null || nomeOggetto.Text == "" || numericUpDown1.Value <= 0 || tipologiaOggetto.SelectedItem == null)
                return;
            CreaOggetto();

            indiceCassettaSelezionata = listBox2.SelectedIndex;
            cassetta = cassetteSicurezzaVuote[indiceCassettaSelezionata];

            cassetta.InserisciOggetto(oggettoSegreto, textBox1.Text);

            cassetteSicurezzaVuote.Remove(cassetta);
            cassetteSicurezza.Add(cassetta);

            AggiornaGrafica("nuovoOggetto");
        }

        private void btnEliminaOggetto_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
                return;

            indiceCassettaSelezionata = listBox1.SelectedIndex;
            cassetta = cassetteSicurezza[indiceCassettaSelezionata];

            cassetta.RimuoviOggetto(textBox1.Text);
            if (cassetta.Oggetto != null)
                return;

            cassetteSicurezza.Remove(cassetta);
            cassetteSicurezzaVuote.Add(cassetta);

            AggiornaGrafica("rimuoviOggetto");
        }

        private void btnEliminaCassetta_Click(object sender, EventArgs e)
        {
                if (cassetta.ControllaPin(textBox1.Text) == false || (radioButtonCassettePiene.Checked == false && radioButtonCassetteVuote.Checked == false))
                    return;

                if (radioButtonCassettePiene.Checked)
                {
                    if (listBox2.SelectedItem == null)
                        return;

                    indiceCassettaSelezionata = listBox2.SelectedIndex;
                    cassetta = cassetteSicurezza[indiceCassettaSelezionata];

                    cassetteSicurezza.Remove(cassetta);
                }
                else if (radioButtonCassetteVuote.Checked)
                {
                    if (listBox2.SelectedItem == null)
                        return;

                    indiceCassettaSelezionata = listBox2.SelectedIndex;
                    cassetta = cassetteSicurezzaVuote[indiceCassettaSelezionata];

                    cassetteSicurezzaVuote.Remove(cassetta);
                }

                AggiornaGrafica("rimuoviCassetta");
            }

        private void tipologiaOggetto_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void AggiornaNumeroVisualizzato()
        {
            occupate.Text = cassetteSicurezza.Count.ToString();
            vuote.Text = cassetteSicurezzaVuote.Count.ToString();
        }
    }
}
