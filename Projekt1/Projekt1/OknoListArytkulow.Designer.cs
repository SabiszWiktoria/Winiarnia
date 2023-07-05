
namespace Projekt1
{
    partial class OknoListArytkulow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OknoListArytkulow));
            this.cmOdmiana = new System.Windows.Forms.ComboBox();
            this.mtxtCenaOd = new System.Windows.Forms.MaskedTextBox();
            this.txtGdzieWyprodukowano = new System.Windows.Forms.TextBox();
            this.mtxtRocznik = new System.Windows.Forms.MaskedTextBox();
            this.cmbSmak = new System.Windows.Forms.ComboBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.mtxtCenaDo = new System.Windows.Forms.MaskedTextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnSzukaj = new System.Windows.Forms.Button();
            this.btnSortujCena = new System.Windows.Forms.Button();
            this.btnSortujOcena = new System.Windows.Forms.Button();
            this.btnSortujRocznik = new System.Windows.Forms.Button();
            this.cmbSortuj = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.cmOdmiana.Location = new System.Drawing.Point(246, 205);
            this.cmOdmiana.Name = "cmOdmiana";
            this.cmOdmiana.Size = new System.Drawing.Size(282, 37);
            this.cmOdmiana.TabIndex = 25;
            // 
            // mtxtCenaOd
            // 
            this.mtxtCenaOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.mtxtCenaOd.Location = new System.Drawing.Point(149, 318);
            this.mtxtCenaOd.Mask = "000.00 zł";
            this.mtxtCenaOd.Name = "mtxtCenaOd";
            this.mtxtCenaOd.Size = new System.Drawing.Size(100, 35);
            this.mtxtCenaOd.TabIndex = 22;
            // 
            // txtGdzieWyprodukowano
            // 
            this.txtGdzieWyprodukowano.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.txtGdzieWyprodukowano.Location = new System.Drawing.Point(246, 266);
            this.txtGdzieWyprodukowano.Name = "txtGdzieWyprodukowano";
            this.txtGdzieWyprodukowano.Size = new System.Drawing.Size(282, 35);
            this.txtGdzieWyprodukowano.TabIndex = 21;
            // 
            // mtxtRocznik
            // 
            this.mtxtRocznik.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.mtxtRocznik.Location = new System.Drawing.Point(246, 151);
            this.mtxtRocznik.Mask = "0000";
            this.mtxtRocznik.Name = "mtxtRocznik";
            this.mtxtRocznik.Size = new System.Drawing.Size(91, 35);
            this.mtxtRocznik.TabIndex = 20;
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
            this.cmbSmak.Location = new System.Drawing.Point(246, 93);
            this.cmbSmak.Name = "cmbSmak";
            this.cmbSmak.Size = new System.Drawing.Size(282, 37);
            this.cmbSmak.TabIndex = 19;
            // 
            // txtMarka
            // 
            this.txtMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.txtMarka.Location = new System.Drawing.Point(246, 28);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(282, 35);
            this.txtMarka.TabIndex = 18;
            // 
            // mtxtCenaDo
            // 
            this.mtxtCenaDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.mtxtCenaDo.Location = new System.Drawing.Point(393, 318);
            this.mtxtCenaDo.Mask = "000.00 zł";
            this.mtxtCenaDo.Name = "mtxtCenaDo";
            this.mtxtCenaDo.Size = new System.Drawing.Size(100, 35);
            this.mtxtCenaDo.TabIndex = 26;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(28, 493);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(783, 238);
            this.listView1.TabIndex = 27;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnSzukaj
            // 
            this.btnSzukaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSzukaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnSzukaj.Location = new System.Drawing.Point(505, 423);
            this.btnSzukaj.Name = "btnSzukaj";
            this.btnSzukaj.Size = new System.Drawing.Size(207, 48);
            this.btnSzukaj.TabIndex = 28;
            this.btnSzukaj.Text = "Szukaj";
            this.btnSzukaj.UseVisualStyleBackColor = false;
            this.btnSzukaj.Click += new System.EventHandler(this.btnSzukaj_Click);
            // 
            // btnSortujCena
            // 
            this.btnSortujCena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSortujCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnSortujCena.Location = new System.Drawing.Point(12, 370);
            this.btnSortujCena.Name = "btnSortujCena";
            this.btnSortujCena.Size = new System.Drawing.Size(93, 46);
            this.btnSortujCena.TabIndex = 29;
            this.btnSortujCena.Text = "Cena";
            this.btnSortujCena.UseVisualStyleBackColor = false;
            this.btnSortujCena.Click += new System.EventHandler(this.btnSortujCena_Click);
            // 
            // btnSortujOcena
            // 
            this.btnSortujOcena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSortujOcena.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnSortujOcena.Location = new System.Drawing.Point(149, 370);
            this.btnSortujOcena.Name = "btnSortujOcena";
            this.btnSortujOcena.Size = new System.Drawing.Size(114, 46);
            this.btnSortujOcena.TabIndex = 30;
            this.btnSortujOcena.Text = "Ocena";
            this.btnSortujOcena.UseVisualStyleBackColor = false;
            this.btnSortujOcena.Click += new System.EventHandler(this.btnSortujOcena_Click);
            // 
            // btnSortujRocznik
            // 
            this.btnSortujRocznik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSortujRocznik.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnSortujRocznik.Location = new System.Drawing.Point(304, 370);
            this.btnSortujRocznik.Name = "btnSortujRocznik";
            this.btnSortujRocznik.Size = new System.Drawing.Size(129, 46);
            this.btnSortujRocznik.TabIndex = 31;
            this.btnSortujRocznik.Text = "Rocznik";
            this.btnSortujRocznik.UseVisualStyleBackColor = false;
            this.btnSortujRocznik.Click += new System.EventHandler(this.btnSortujRocznik_Click);
            // 
            // cmbSortuj
            // 
            this.cmbSortuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.cmbSortuj.FormattingEnabled = true;
            this.cmbSortuj.Items.AddRange(new object[] {
            "Rosnąco",
            "Malejąco"});
            this.cmbSortuj.Location = new System.Drawing.Point(93, 434);
            this.cmbSortuj.Name = "cmbSortuj";
            this.cmbSortuj.Size = new System.Drawing.Size(121, 37);
            this.cmbSortuj.TabIndex = 32;
            this.cmbSortuj.SelectedIndexChanged += new System.EventHandler(this.cmbSortuj_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label6.Location = new System.Drawing.Point(23, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 29);
            this.label6.TabIndex = 38;
            this.label6.Text = "Cena od";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Info;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label5.Location = new System.Drawing.Point(23, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 29);
            this.label5.TabIndex = 37;
            this.label5.Text = "Miejsce produkcji";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label4.Location = new System.Drawing.Point(23, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 29);
            this.label4.TabIndex = 36;
            this.label4.Text = "Odmiana";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label3.Location = new System.Drawing.Point(23, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 29);
            this.label3.TabIndex = 35;
            this.label3.Text = "Rocznik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label2.Location = new System.Drawing.Point(23, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 34;
            this.label2.Text = "Smak";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "Marka";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label7.Location = new System.Drawing.Point(267, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 29);
            this.label7.TabIndex = 39;
            this.label7.Text = "Cena do";
            // 
            // OknoListArytkulow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(860, 753);
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
            this.MaximumSize = new System.Drawing.Size(876, 792);
            this.MinimumSize = new System.Drawing.Size(816, 768);
            this.Name = "OknoListArytkulow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OknoListArytkulow";
            this.Load += new System.EventHandler(this.OknoListArytkulow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmOdmiana;
        private System.Windows.Forms.MaskedTextBox mtxtCenaOd;
        private System.Windows.Forms.TextBox txtGdzieWyprodukowano;
        private System.Windows.Forms.MaskedTextBox mtxtRocznik;
        private System.Windows.Forms.ComboBox cmbSmak;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.MaskedTextBox mtxtCenaDo;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnSzukaj;
        private System.Windows.Forms.Button btnSortujCena;
        private System.Windows.Forms.Button btnSortujOcena;
        private System.Windows.Forms.Button btnSortujRocznik;
        private System.Windows.Forms.ComboBox cmbSortuj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
    }
}