namespace ColomboCassettaSicurezza
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nomeOggetto = new TextBox();
            tipologiaOggetto = new ComboBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            btnNuovaCassetta = new Button();
            label1 = new Label();
            label2 = new Label();
            listBox1 = new ListBox();
            btnNuovoOggetto = new Button();
            btnEliminaOggetto = new Button();
            btnEliminaCassetta = new Button();
            label3 = new Label();
            label4 = new Label();
            listBox2 = new ListBox();
            numericUpDown1 = new NumericUpDown();
            label5 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            occupate = new Label();
            vuote = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // nomeOggetto
            // 
            nomeOggetto.Location = new Point(702, 317);
            nomeOggetto.Name = "nomeOggetto";
            nomeOggetto.Size = new Size(158, 23);
            nomeOggetto.TabIndex = 0;
            // 
            // tipologiaOggetto
            // 
            tipologiaOggetto.FormattingEnabled = true;
            tipologiaOggetto.Items.AddRange(new object[] { "Oggetto Generico", "Gioiello Prezioso", "Documento Legale", "Chiave Di Accesso" });
            tipologiaOggetto.Location = new Point(544, 317);
            tipologiaOggetto.Name = "tipologiaOggetto";
            tipologiaOggetto.Size = new Size(131, 23);
            tipologiaOggetto.TabIndex = 1;
            tipologiaOggetto.SelectedIndexChanged += tipologiaOggetto_SelectedIndexChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = SystemColors.ActiveBorder;
            radioButton1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.Location = new Point(421, 56);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(282, 29);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Cassetta di sicurezza normale";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = SystemColors.ActiveBorder;
            radioButton2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.Location = new Point(724, 56);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(279, 29);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Cassetta di sicurezza speciale";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // btnNuovaCassetta
            // 
            btnNuovaCassetta.BackColor = Color.Lime;
            btnNuovaCassetta.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuovaCassetta.Location = new Point(301, 160);
            btnNuovaCassetta.Name = "btnNuovaCassetta";
            btnNuovaCassetta.Size = new Size(263, 83);
            btnNuovaCassetta.TabIndex = 4;
            btnNuovaCassetta.Text = "AGGIUNGI OGGETTO AD UNA NUOVA CASSETTA";
            btnNuovaCassetta.UseVisualStyleBackColor = false;
            btnNuovaCassetta.Click += btnNuovaCassetta_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(565, 293);
            label1.Name = "label1";
            label1.Size = new Size(92, 21);
            label1.TabIndex = 5;
            label1.Text = "TIPOLOGIA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(718, 293);
            label2.Name = "label2";
            label2.Size = new Size(132, 21);
            label2.TabIndex = 6;
            label2.Text = "NOME OGGETTO";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(3, 56);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(292, 529);
            listBox1.TabIndex = 7;
            // 
            // btnNuovoOggetto
            // 
            btnNuovoOggetto.BackColor = Color.Lime;
            btnNuovoOggetto.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuovoOggetto.Location = new Point(848, 160);
            btnNuovoOggetto.Name = "btnNuovoOggetto";
            btnNuovoOggetto.Size = new Size(263, 83);
            btnNuovoOggetto.TabIndex = 8;
            btnNuovoOggetto.Text = "AGGIUNGI OGGETTO ALLA CASSETTA SELEZIONATA";
            btnNuovoOggetto.UseVisualStyleBackColor = false;
            btnNuovoOggetto.Click += btnNuovoOggetto_Click;
            // 
            // btnEliminaOggetto
            // 
            btnEliminaOggetto.BackColor = Color.Red;
            btnEliminaOggetto.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminaOggetto.Location = new Point(301, 392);
            btnEliminaOggetto.Name = "btnEliminaOggetto";
            btnEliminaOggetto.Size = new Size(263, 83);
            btnEliminaOggetto.TabIndex = 9;
            btnEliminaOggetto.Text = "RIMUOVI OGGETTO DALLA CASSETTA SELEZIONATA";
            btnEliminaOggetto.UseVisualStyleBackColor = false;
            btnEliminaOggetto.Click += btnEliminaOggetto_Click;
            // 
            // btnEliminaCassetta
            // 
            btnEliminaCassetta.BackColor = Color.Red;
            btnEliminaCassetta.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminaCassetta.Location = new Point(848, 392);
            btnEliminaCassetta.Name = "btnEliminaCassetta";
            btnEliminaCassetta.Size = new Size(263, 83);
            btnEliminaCassetta.TabIndex = 10;
            btnEliminaCassetta.Text = "ELIMINA LA CASSETTA SELEZIONATA";
            btnEliminaCassetta.UseVisualStyleBackColor = false;
            btnEliminaCassetta.Click += btnEliminaCassetta_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(3, 29);
            label3.Name = "label3";
            label3.Size = new Size(292, 21);
            label3.TabIndex = 11;
            label3.Text = "CASSETTE DI SICUREZZA OCCUPATE";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(1134, 29);
            label4.Name = "label4";
            label4.Size = new Size(262, 21);
            label4.TabIndex = 13;
            label4.Text = "CASSETTE DI SICUREZZA LIBERE";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(1117, 55);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(292, 529);
            listBox2.TabIndex = 12;
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Location = new Point(626, 376);
            numericUpDown1.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(143, 23);
            numericUpDown1.TabIndex = 14;
            numericUpDown1.ThousandsSeparator = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(626, 352);
            label5.Name = "label5";
            label5.Size = new Size(143, 21);
            label5.TabIndex = 15;
            label5.Text = "VALORE OGGETTO";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(544, 542);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(306, 23);
            textBox1.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(517, 518);
            label6.Name = "label6";
            label6.Size = new Size(363, 21);
            label6.TabIndex = 17;
            label6.Text = "INSERISCI IL PIN DELLA CASSETTA SELEZIONATA";
            // 
            // occupate
            // 
            occupate.AutoSize = true;
            occupate.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            occupate.ForeColor = Color.Black;
            occupate.Location = new Point(129, 9);
            occupate.Name = "occupate";
            occupate.Size = new Size(30, 21);
            occupate.TabIndex = 18;
            occupate.Text = "20";
            occupate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // vuote
            // 
            vuote.AutoSize = true;
            vuote.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            vuote.ForeColor = Color.Black;
            vuote.Location = new Point(1254, 9);
            vuote.Name = "vuote";
            vuote.Size = new Size(30, 21);
            vuote.TabIndex = 19;
            vuote.Text = "20";
            vuote.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1417, 587);
            Controls.Add(vuote);
            Controls.Add(occupate);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(numericUpDown1);
            Controls.Add(label4);
            Controls.Add(listBox2);
            Controls.Add(label3);
            Controls.Add(btnEliminaCassetta);
            Controls.Add(btnEliminaOggetto);
            Controls.Add(btnNuovoOggetto);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnNuovaCassetta);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(tipologiaOggetto);
            Controls.Add(nomeOggetto);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nomeOggetto;
        private ComboBox tipologiaOggetto;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button btnNuovaCassetta;
        private Label label1;
        private Label label2;
        private ListBox listBox1;
        private Button btnNuovoOggetto;
        private Button btnEliminaOggetto;
        private Button btnEliminaCassetta;
        private Label label3;
        private Label label4;
        private ListBox listBox2;
        private NumericUpDown numericUpDown1;
        private Label label5;
        private TextBox textBox1;
        private Label label6;
        private Label occupate;
        private Label vuote;
    }
}
