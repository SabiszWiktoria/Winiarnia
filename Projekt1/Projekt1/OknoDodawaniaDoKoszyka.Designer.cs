
namespace Projekt1
{
    partial class OknoDodawaniaDoKoszyka
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OknoDodawaniaDoKoszyka));
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSortuj = new System.Windows.Forms.ComboBox();
            this.btnSortujRocznik = new System.Windows.Forms.Button();
            this.btnSortujOcena = new System.Windows.Forms.Button();
            this.btnSortujCena = new System.Windows.Forms.Button();
            this.btnSzukaj = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.mtxtCenaDo = new System.Windows.Forms.MaskedTextBox();
            this.cmOdmiana = new System.Windows.Forms.ComboBox();
            this.mtxtCenaOd = new System.Windows.Forms.MaskedTextBox();
            this.txtGdzieWyprodukowano = new System.Windows.Forms.TextBox();
            this.mtxtRocznik = new System.Windows.Forms.MaskedTextBox();
            this.cmbSmak = new System.Windows.Forms.ComboBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.lNazwa = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nIlosc = new System.Windows.Forms.NumericUpDown();
            this.lCena = new System.Windows.Forms.Label();
            this.btnDodajDoKoszyka = new System.Windows.Forms.Button();
            this.btnPrzejdzDoKoszyka = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nIlosc)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label7.Location = new System.Drawing.Point(271, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 29);
            this.label7.TabIndex = 59;
            this.label7.Text = "Cena do";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label6.Location = new System.Drawing.Point(27, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 29);
            this.label6.TabIndex = 58;
            this.label6.Text = "Cena od";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Info;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label5.Location = new System.Drawing.Point(27, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 29);
            this.label5.TabIndex = 57;
            this.label5.Text = "Miejsce produkcji";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label4.Location = new System.Drawing.Point(27, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 29);
            this.label4.TabIndex = 56;
            this.label4.Text = "Odmiana";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label3.Location = new System.Drawing.Point(27, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 29);
            this.label3.TabIndex = 55;
            this.label3.Text = "Rocznik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label2.Location = new System.Drawing.Point(27, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 54;
            this.label2.Text = "Smak";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(27, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 29);
            this.label1.TabIndex = 53;
            this.label1.Text = "Marka";
            // 
            // cmbSortuj
            // 
            this.cmbSortuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.cmbSortuj.FormattingEnabled = true;
            this.cmbSortuj.Items.AddRange(new object[] {
            "Rosnąco",
            "Malejąco"});
            this.cmbSortuj.Location = new System.Drawing.Point(97, 464);
            this.cmbSortuj.Name = "cmbSortuj";
            this.cmbSortuj.Size = new System.Drawing.Size(121, 37);
            this.cmbSortuj.TabIndex = 52;
            this.cmbSortuj.SelectedIndexChanged += new System.EventHandler(this.cmbSortuj_SelectedIndexChanged);
            // 
            // btnSortujRocznik
            // 
            this.btnSortujRocznik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSortujRocznik.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnSortujRocznik.Location = new System.Drawing.Point(308, 400);
            this.btnSortujRocznik.Name = "btnSortujRocznik";
            this.btnSortujRocznik.Size = new System.Drawing.Size(129, 46);
            this.btnSortujRocznik.TabIndex = 51;
            this.btnSortujRocznik.Text = "Rocznik";
            this.btnSortujRocznik.UseVisualStyleBackColor = false;
            // 
            // btnSortujOcena
            // 
            this.btnSortujOcena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSortujOcena.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnSortujOcena.Location = new System.Drawing.Point(153, 400);
            this.btnSortujOcena.Name = "btnSortujOcena";
            this.btnSortujOcena.Size = new System.Drawing.Size(114, 46);
            this.btnSortujOcena.TabIndex = 50;
            this.btnSortujOcena.Text = "Ocena";
            this.btnSortujOcena.UseVisualStyleBackColor = false;
            // 
            // btnSortujCena
            // 
            this.btnSortujCena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSortujCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnSortujCena.Location = new System.Drawing.Point(16, 400);
            this.btnSortujCena.Name = "btnSortujCena";
            this.btnSortujCena.Size = new System.Drawing.Size(93, 46);
            this.btnSortujCena.TabIndex = 49;
            this.btnSortujCena.Text = "Cena";
            this.btnSortujCena.UseVisualStyleBackColor = false;
            this.btnSortujCena.Click += new System.EventHandler(this.btnSortujCena_Click);
            // 
            // btnSzukaj
            // 
            this.btnSzukaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSzukaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnSzukaj.Location = new System.Drawing.Point(509, 453);
            this.btnSzukaj.Name = "btnSzukaj";
            this.btnSzukaj.Size = new System.Drawing.Size(207, 48);
            this.btnSzukaj.TabIndex = 48;
            this.btnSzukaj.Text = "Szukaj";
            this.btnSzukaj.UseVisualStyleBackColor = false;
            this.btnSzukaj.Click += new System.EventHandler(this.btnSzukaj_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(9, 509);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(936, 114);
            this.listView1.TabIndex = 47;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // mtxtCenaDo
            // 
            this.mtxtCenaDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.mtxtCenaDo.Location = new System.Drawing.Point(397, 348);
            this.mtxtCenaDo.Mask = "000.00 zł";
            this.mtxtCenaDo.Name = "mtxtCenaDo";
            this.mtxtCenaDo.Size = new System.Drawing.Size(100, 35);
            this.mtxtCenaDo.TabIndex = 46;
            // 
            // cmOdmiana
            // 
            this.cmOdmiana.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.cmOdmiana.FormattingEnabled = true;
            this.cmOdmiana.Items.AddRange(new object[] {
            "Białe",
            "Czerwone",
            "Różowe",
            "Deserowe",
            "Musujące"});
            this.cmOdmiana.Location = new System.Drawing.Point(250, 235);
            this.cmOdmiana.Name = "cmOdmiana";
            this.cmOdmiana.Size = new System.Drawing.Size(466, 37);
            this.cmOdmiana.TabIndex = 45;
            // 
            // mtxtCenaOd
            // 
            this.mtxtCenaOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.mtxtCenaOd.Location = new System.Drawing.Point(153, 348);
            this.mtxtCenaOd.Mask = "000.00 zł";
            this.mtxtCenaOd.Name = "mtxtCenaOd";
            this.mtxtCenaOd.Size = new System.Drawing.Size(100, 35);
            this.mtxtCenaOd.TabIndex = 44;
            // 
            // txtGdzieWyprodukowano
            // 
            this.txtGdzieWyprodukowano.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.txtGdzieWyprodukowano.Location = new System.Drawing.Point(250, 296);
            this.txtGdzieWyprodukowano.Name = "txtGdzieWyprodukowano";
            this.txtGdzieWyprodukowano.Size = new System.Drawing.Size(466, 35);
            this.txtGdzieWyprodukowano.TabIndex = 43;
            // 
            // mtxtRocznik
            // 
            this.mtxtRocznik.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.mtxtRocznik.Location = new System.Drawing.Point(250, 181);
            this.mtxtRocznik.Mask = "0000";
            this.mtxtRocznik.Name = "mtxtRocznik";
            this.mtxtRocznik.Size = new System.Drawing.Size(466, 35);
            this.mtxtRocznik.TabIndex = 42;
            // 
            // cmbSmak
            // 
            this.cmbSmak.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.cmbSmak.FormattingEnabled = true;
            this.cmbSmak.Items.AddRange(new object[] {
            "wytrawne ",
            "półwytrawne ",
            "półsłodkie ",
            "słodkie "});
            this.cmbSmak.Location = new System.Drawing.Point(250, 123);
            this.cmbSmak.Name = "cmbSmak";
            this.cmbSmak.Size = new System.Drawing.Size(466, 37);
            this.cmbSmak.TabIndex = 41;
            // 
            // txtMarka
            // 
            this.txtMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.txtMarka.Location = new System.Drawing.Point(250, 58);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(466, 35);
            this.txtMarka.TabIndex = 40;
            // 
            // lNazwa
            // 
            this.lNazwa.AutoSize = true;
            this.lNazwa.BackColor = System.Drawing.SystemColors.Info;
            this.lNazwa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lNazwa.Location = new System.Drawing.Point(27, 671);
            this.lNazwa.Name = "lNazwa";
            this.lNazwa.Size = new System.Drawing.Size(90, 29);
            this.lNazwa.TabIndex = 60;
            this.lNazwa.Text = "Nazwa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Info;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label9.Location = new System.Drawing.Point(171, 671);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 29);
            this.label9.TabIndex = 61;
            this.label9.Text = "Ilość";
            // 
            // nIlosc
            // 
            this.nIlosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.nIlosc.Location = new System.Drawing.Point(303, 669);
            this.nIlosc.Name = "nIlosc";
            this.nIlosc.Size = new System.Drawing.Size(166, 35);
            this.nIlosc.TabIndex = 62;
            this.nIlosc.ValueChanged += new System.EventHandler(this.nIlosc_ValueChanged);
            // 
            // lCena
            // 
            this.lCena.AutoSize = true;
            this.lCena.BackColor = System.Drawing.SystemColors.Info;
            this.lCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lCena.Location = new System.Drawing.Point(539, 669);
            this.lCena.Name = "lCena";
            this.lCena.Size = new System.Drawing.Size(99, 29);
            this.lCena.TabIndex = 63;
            this.lCena.Text = "Cena zł";
            // 
            // btnDodajDoKoszyka
            // 
            this.btnDodajDoKoszyka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDodajDoKoszyka.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnDodajDoKoszyka.Location = new System.Drawing.Point(72, 735);
            this.btnDodajDoKoszyka.Name = "btnDodajDoKoszyka";
            this.btnDodajDoKoszyka.Size = new System.Drawing.Size(235, 63);
            this.btnDodajDoKoszyka.TabIndex = 64;
            this.btnDodajDoKoszyka.Text = "Dodaj do koszyka";
            this.btnDodajDoKoszyka.UseVisualStyleBackColor = false;
            this.btnDodajDoKoszyka.Click += new System.EventHandler(this.btnDodajDoKoszyka_Click);
            // 
            // btnPrzejdzDoKoszyka
            // 
            this.btnPrzejdzDoKoszyka.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPrzejdzDoKoszyka.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnPrzejdzDoKoszyka.Location = new System.Drawing.Point(632, 735);
            this.btnPrzejdzDoKoszyka.Name = "btnPrzejdzDoKoszyka";
            this.btnPrzejdzDoKoszyka.Size = new System.Drawing.Size(240, 63);
            this.btnPrzejdzDoKoszyka.TabIndex = 65;
            this.btnPrzejdzDoKoszyka.Text = "Przejdź do koszyka";
            this.btnPrzejdzDoKoszyka.UseVisualStyleBackColor = false;
            this.btnPrzejdzDoKoszyka.Click += new System.EventHandler(this.btnPrzejdzDoKoszyka_Click);
            // 
            // OknoDodawaniaDoKoszyka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(957, 832);
            this.Controls.Add(this.btnPrzejdzDoKoszyka);
            this.Controls.Add(this.btnDodajDoKoszyka);
            this.Controls.Add(this.lCena);
            this.Controls.Add(this.nIlosc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lNazwa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSortuj);
            this.Controls.Add(this.btnSortujRocznik);
            this.Controls.Add(this.btnSortujOcena);
            this.Controls.Add(this.btnSortujCena);
            this.Controls.Add(this.btnSzukaj);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.mtxtCenaDo);
            this.Controls.Add(this.cmOdmiana);
            this.Controls.Add(this.mtxtCenaOd);
            this.Controls.Add(this.txtGdzieWyprodukowano);
            this.Controls.Add(this.mtxtRocznik);
            this.Controls.Add(this.cmbSmak);
            this.Controls.Add(this.txtMarka);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(973, 871);
            this.MinimumSize = new System.Drawing.Size(816, 858);
            this.Name = "OknoDodawaniaDoKoszyka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OknoDodawaniaDoKoszyka";
            this.Load += new System.EventHandler(this.OknoDodawaniaDoKoszyka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nIlosc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSortuj;
        private System.Windows.Forms.Button btnSortujRocznik;
        private System.Windows.Forms.Button btnSortujOcena;
        private System.Windows.Forms.Button btnSortujCena;
        private System.Windows.Forms.Button btnSzukaj;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MaskedTextBox mtxtCenaDo;
        private System.Windows.Forms.ComboBox cmOdmiana;
        private System.Windows.Forms.MaskedTextBox mtxtCenaOd;
        private System.Windows.Forms.TextBox txtGdzieWyprodukowano;
        private System.Windows.Forms.MaskedTextBox mtxtRocznik;
        private System.Windows.Forms.ComboBox cmbSmak;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label lNazwa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nIlosc;
        private System.Windows.Forms.Label lCena;
        private System.Windows.Forms.Button btnDodajDoKoszyka;
        private System.Windows.Forms.Button btnPrzejdzDoKoszyka;
    }
}