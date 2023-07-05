
namespace Projekt1
{
    partial class OknoDodawanie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OknoDodawanie));
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.cmbSmak = new System.Windows.Forms.ComboBox();
            this.mtxtRocznik = new System.Windows.Forms.MaskedTextBox();
            this.txtGdzieWyprodukowano = new System.Windows.Forms.TextBox();
            this.mtxtCena = new System.Windows.Forms.MaskedTextBox();
            this.nIlosc = new System.Windows.Forms.NumericUpDown();
            this.nOcena = new System.Windows.Forms.NumericUpDown();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.cmOdmiana = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nIlosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOcena)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMarka
            // 
            this.txtMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.txtMarka.Location = new System.Drawing.Point(312, 36);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(409, 35);
            this.txtMarka.TabIndex = 0;
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
            this.cmbSmak.Location = new System.Drawing.Point(312, 89);
            this.cmbSmak.Name = "cmbSmak";
            this.cmbSmak.Size = new System.Drawing.Size(409, 37);
            this.cmbSmak.TabIndex = 1;
            this.cmbSmak.SelectedIndexChanged += new System.EventHandler(this.cmbSmak_SelectedIndexChanged);
            // 
            // mtxtRocznik
            // 
            this.mtxtRocznik.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.mtxtRocznik.Location = new System.Drawing.Point(312, 146);
            this.mtxtRocznik.Mask = "0000";
            this.mtxtRocznik.Name = "mtxtRocznik";
            this.mtxtRocznik.Size = new System.Drawing.Size(409, 35);
            this.mtxtRocznik.TabIndex = 2;
            // 
            // txtGdzieWyprodukowano
            // 
            this.txtGdzieWyprodukowano.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.txtGdzieWyprodukowano.Location = new System.Drawing.Point(312, 262);
            this.txtGdzieWyprodukowano.Name = "txtGdzieWyprodukowano";
            this.txtGdzieWyprodukowano.Size = new System.Drawing.Size(409, 35);
            this.txtGdzieWyprodukowano.TabIndex = 4;
            // 
            // mtxtCena
            // 
            this.mtxtCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.mtxtCena.Location = new System.Drawing.Point(312, 312);
            this.mtxtCena.Mask = "000.00 zł";
            this.mtxtCena.Name = "mtxtCena";
            this.mtxtCena.Size = new System.Drawing.Size(167, 35);
            this.mtxtCena.TabIndex = 5;
            // 
            // nIlosc
            // 
            this.nIlosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.nIlosc.Location = new System.Drawing.Point(313, 370);
            this.nIlosc.Name = "nIlosc";
            this.nIlosc.Size = new System.Drawing.Size(166, 35);
            this.nIlosc.TabIndex = 6;
            // 
            // nOcena
            // 
            this.nOcena.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.nOcena.Location = new System.Drawing.Point(313, 436);
            this.nOcena.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nOcena.Name = "nOcena";
            this.nOcena.Size = new System.Drawing.Size(166, 35);
            this.nOcena.TabIndex = 7;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnDodaj.Location = new System.Drawing.Point(264, 659);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(161, 68);
            this.btnDodaj.TabIndex = 8;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
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
            this.cmOdmiana.Location = new System.Drawing.Point(312, 199);
            this.cmOdmiana.Name = "cmOdmiana";
            this.cmOdmiana.Size = new System.Drawing.Size(409, 37);
            this.cmOdmiana.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(41, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label2.Location = new System.Drawing.Point(41, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Smak";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label3.Location = new System.Drawing.Point(41, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Rocznik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label4.Location = new System.Drawing.Point(41, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Odmiana";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label5.Location = new System.Drawing.Point(41, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "Miejsce produkcji";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label6.Location = new System.Drawing.Point(41, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cena";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label7.Location = new System.Drawing.Point(41, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ilość";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label8.Location = new System.Drawing.Point(37, 442);
            this.label8.MaximumSize = new System.Drawing.Size(87, 29);
            this.label8.MinimumSize = new System.Drawing.Size(87, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 29);
            this.label8.TabIndex = 17;
            this.label8.Text = "Ocena";
            // 
            // OknoDodawanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(929, 753);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmOdmiana);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.nOcena);
            this.Controls.Add(this.nIlosc);
            this.Controls.Add(this.mtxtCena);
            this.Controls.Add(this.txtGdzieWyprodukowano);
            this.Controls.Add(this.mtxtRocznik);
            this.Controls.Add(this.cmbSmak);
            this.Controls.Add(this.txtMarka);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(945, 792);
            this.MinimumSize = new System.Drawing.Size(945, 792);
            this.Name = "OknoDodawanie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OknoDodawanie";
            ((System.ComponentModel.ISupportInitialize)(this.nIlosc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOcena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.ComboBox cmbSmak;
        private System.Windows.Forms.MaskedTextBox mtxtRocznik;
        private System.Windows.Forms.TextBox txtGdzieWyprodukowano;
        private System.Windows.Forms.MaskedTextBox mtxtCena;
        private System.Windows.Forms.NumericUpDown nIlosc;
        private System.Windows.Forms.NumericUpDown nOcena;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ComboBox cmOdmiana;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}