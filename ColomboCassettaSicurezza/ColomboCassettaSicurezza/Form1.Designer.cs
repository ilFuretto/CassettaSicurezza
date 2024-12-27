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
            SuspendLayout();
            // 
            // nomeOggetto
            // 
            nomeOggetto.Location = new Point(608, 261);
            nomeOggetto.Name = "nomeOggetto";
            nomeOggetto.Size = new Size(158, 23);
            nomeOggetto.TabIndex = 0;
            // 
            // tipologiaOggetto
            // 
            tipologiaOggetto.FormattingEnabled = true;
            tipologiaOggetto.Items.AddRange(new object[] { "Oggetto Generico", "Gioiello Prezioso", "Documento Legale", "Chiave Di Accesso" });
            tipologiaOggetto.Location = new Point(437, 261);
            tipologiaOggetto.Name = "tipologiaOggetto";
            tipologiaOggetto.Size = new Size(121, 23);
            tipologiaOggetto.TabIndex = 1;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = SystemColors.ActiveBorder;
            radioButton1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.Location = new Point(388, 60);
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
            radioButton2.Location = new Point(691, 60);
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
            btnNuovaCassetta.Location = new Point(820, 151);
            btnNuovaCassetta.Name = "btnNuovaCassetta";
            btnNuovaCassetta.Size = new Size(263, 83);
            btnNuovaCassetta.TabIndex = 4;
            btnNuovaCassetta.Text = "AGGIUNGI OGGETTO AD UNA NUOVA CASSETTA";
            btnNuovaCassetta.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(456, 227);
            label1.Name = "label1";
            label1.Size = new Size(92, 21);
            label1.TabIndex = 5;
            label1.Text = "TIPOLOGIA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(623, 227);
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
            btnNuovoOggetto.BackColor = Color.LimeGreen;
            btnNuovoOggetto.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuovoOggetto.Location = new Point(820, 251);
            btnNuovoOggetto.Name = "btnNuovoOggetto";
            btnNuovoOggetto.Size = new Size(263, 83);
            btnNuovoOggetto.TabIndex = 8;
            btnNuovoOggetto.Text = "AGGIUNGI OGGETTO ALLA CASSETTA SELEZIONATA";
            btnNuovoOggetto.UseVisualStyleBackColor = false;
            // 
            // btnEliminaOggetto
            // 
            btnEliminaOggetto.BackColor = Color.Red;
            btnEliminaOggetto.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminaOggetto.Location = new Point(366, 367);
            btnEliminaOggetto.Name = "btnEliminaOggetto";
            btnEliminaOggetto.Size = new Size(263, 83);
            btnEliminaOggetto.TabIndex = 9;
            btnEliminaOggetto.Text = "RIMUOVI OGGETTO DALLA CASSETTA SELEZIONATA";
            btnEliminaOggetto.UseVisualStyleBackColor = false;
            // 
            // btnEliminaCassetta
            // 
            btnEliminaCassetta.BackColor = Color.Salmon;
            btnEliminaCassetta.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminaCassetta.Location = new Point(677, 367);
            btnEliminaCassetta.Name = "btnEliminaCassetta";
            btnEliminaCassetta.Size = new Size(263, 83);
            btnEliminaCassetta.TabIndex = 10;
            btnEliminaCassetta.Text = "RIMUOVI OGGETTO DALLA CASSETTA SELEZIONATA";
            btnEliminaCassetta.UseVisualStyleBackColor = false;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1460, 596);
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
    }
}
