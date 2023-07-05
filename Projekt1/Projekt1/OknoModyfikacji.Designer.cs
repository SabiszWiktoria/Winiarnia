
namespace Projekt1
{
    partial class OknoModyfikacji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OknoModyfikacji));
            this.cmOdmiana = new System.Windows.Forms.ComboBox();
            this.nOcena = new System.Windows.Forms.NumericUpDown();
            this.nIlosc = new System.Windows.Forms.NumericUpDown();
            this.mtxtCena = new System.Windows.Forms.MaskedTextBox();
            this.txtGdzieWyprodukowano = new System.Windows.Forms.TextBox();
            this.mtxtRocznik = new System.Windows.Forms.MaskedTextBox();
            this.cmbSmak = new System.Windows.Forms.ComboBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnModyfikuj = new System.Windows.Forms.Button();
            this.LMarka = new System.Windows.Forms.Label();
            this.lSmak = new System.Windows.Forms.Label();
            this.lRocznik = new System.Windows.Forms.Label();
            this.lOdmiana = new System.Windows.Forms.Label();
            this.lGdziewyprodukowano = new System.Windows.Forms.Label();
            this.lcena = new System.Windows.Forms.Label();
            this.lIlosc = new System.Windows.Forms.Label();
            this.lOcena = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nOcena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIlosc)).BeginInit();
            this.SuspendLayout();
            // 
            // cmOdmiana
            // 
            this.cmOdmiana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cmOdmiana.FormattingEnabled = true;
            this.cmOdmiana.Items.AddRange(new object[] {
            "Białe",
            "Czerwone",
            "Różowe",
            "Deserowe",
            "Musujące"});
            this.cmOdmiana.Location = new System.Drawing.Point(744, 336);
            this.cmOdmiana.Name = "cmOdmiana";
            this.cmOdmiana.Size = new System.Drawing.Size(121, 28);
            this.cmOdmiana.TabIndex = 17;
            // 
            // nOcena
            // 
            this.nOcena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.nOcena.Location = new System.Drawing.Point(744, 497);
            this.nOcena.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nOcena.Name = "nOcena";
            this.nOcena.Size = new System.Drawing.Size(120, 26);
            this.nOcena.TabIndex = 16;
            // 
            // nIlosc
            // 
            this.nIlosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.nIlosc.Location = new System.Drawing.Point(744, 452);
            this.nIlosc.Name = "nIlosc";
            this.nIlosc.Size = new System.Drawing.Size(120, 26);
            this.nIlosc.TabIndex = 15;
            // 
            // mtxtCena
            // 
            this.mtxtCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.mtxtCena.Location = new System.Drawing.Point(744, 417);
            this.mtxtCena.Mask = "000.00 zł";
            this.mtxtCena.Name = "mtxtCena";
            this.mtxtCena.Size = new System.Drawing.Size(121, 26);
            this.mtxtCena.TabIndex = 14;
            // 
            // txtGdzieWyprodukowano
            // 
            this.txtGdzieWyprodukowano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtGdzieWyprodukowano.Location = new System.Drawing.Point(744, 381);
            this.txtGdzieWyprodukowano.Name = "txtGdzieWyprodukowano";
            this.txtGdzieWyprodukowano.Size = new System.Drawing.Size(120, 26);
            this.txtGdzieWyprodukowano.TabIndex = 13;
            // 
            // mtxtRocznik
            // 
            this.mtxtRocznik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.mtxtRocznik.Location = new System.Drawing.Point(744, 295);
            this.mtxtRocznik.Mask = "0000";
            this.mtxtRocznik.Name = "mtxtRocznik";
            this.mtxtRocznik.Size = new System.Drawing.Size(120, 26);
            this.mtxtRocznik.TabIndex = 12;
            // 
            // cmbSmak
            // 
            this.cmbSmak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cmbSmak.FormattingEnabled = true;
            this.cmbSmak.Items.AddRange(new object[] {
            "wytrawne ",
            "półwytrawne ",
            "półsłodkie ",
            "słodkie "});
            this.cmbSmak.Location = new System.Drawing.Point(744, 251);
            this.cmbSmak.Name = "cmbSmak";
            this.cmbSmak.Size = new System.Drawing.Size(121, 28);
            this.cmbSmak.TabIndex = 11;
            // 
            // txtMarka
            // 
            this.txtMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtMarka.Location = new System.Drawing.Point(744, 207);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(121, 26);
            this.txtMarka.TabIndex = 10;
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(878, 178);
            this.listView1.TabIndex = 26;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnModyfikuj
            // 
            this.btnModyfikuj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnModyfikuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnModyfikuj.Location = new System.Drawing.Point(376, 623);
            this.btnModyfikuj.Name = "btnModyfikuj";
            this.btnModyfikuj.Size = new System.Drawing.Size(213, 74);
            this.btnModyfikuj.TabIndex = 27;
            this.btnModyfikuj.Text = "Modyfikuj";
            this.btnModyfikuj.UseVisualStyleBackColor = false;
            this.btnModyfikuj.Click += new System.EventHandler(this.btnModyfikuj_Click);
            // 
            // LMarka
            // 
            this.LMarka.AutoSize = true;
            this.LMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.LMarka.Location = new System.Drawing.Point(463, 214);
            this.LMarka.Name = "LMarka";
            this.LMarka.Size = new System.Drawing.Size(53, 20);
            this.LMarka.TabIndex = 28;
            this.LMarka.Text = "label1";
            // 
            // lSmak
            // 
            this.lSmak.AutoSize = true;
            this.lSmak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lSmak.Location = new System.Drawing.Point(463, 259);
            this.lSmak.Name = "lSmak";
            this.lSmak.Size = new System.Drawing.Size(53, 20);
            this.lSmak.TabIndex = 29;
            this.lSmak.Text = "label1";
            // 
            // lRocznik
            // 
            this.lRocznik.AutoSize = true;
            this.lRocznik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lRocznik.Location = new System.Drawing.Point(463, 302);
            this.lRocznik.Name = "lRocznik";
            this.lRocznik.Size = new System.Drawing.Size(53, 20);
            this.lRocznik.TabIndex = 30;
            this.lRocznik.Text = "label1";
            // 
            // lOdmiana
            // 
            this.lOdmiana.AutoSize = true;
            this.lOdmiana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lOdmiana.Location = new System.Drawing.Point(463, 344);
            this.lOdmiana.Name = "lOdmiana";
            this.lOdmiana.Size = new System.Drawing.Size(53, 20);
            this.lOdmiana.TabIndex = 31;
            this.lOdmiana.Text = "label1";
            // 
            // lGdziewyprodukowano
            // 
            this.lGdziewyprodukowano.AutoSize = true;
            this.lGdziewyprodukowano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lGdziewyprodukowano.Location = new System.Drawing.Point(463, 387);
            this.lGdziewyprodukowano.Name = "lGdziewyprodukowano";
            this.lGdziewyprodukowano.Size = new System.Drawing.Size(53, 20);
            this.lGdziewyprodukowano.TabIndex = 32;
            this.lGdziewyprodukowano.Text = "label1";
            // 
            // lcena
            // 
            this.lcena.AutoSize = true;
            this.lcena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lcena.Location = new System.Drawing.Point(463, 423);
            this.lcena.Name = "lcena";
            this.lcena.Size = new System.Drawing.Size(53, 20);
            this.lcena.TabIndex = 33;
            this.lcena.Text = "label1";
            // 
            // lIlosc
            // 
            this.lIlosc.AutoSize = true;
            this.lIlosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lIlosc.Location = new System.Drawing.Point(463, 459);
            this.lIlosc.Name = "lIlosc";
            this.lIlosc.Size = new System.Drawing.Size(53, 20);
            this.lIlosc.TabIndex = 34;
            this.lIlosc.Text = "label1";
            // 
            // lOcena
            // 
            this.lOcena.AutoSize = true;
            this.lOcena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lOcena.Location = new System.Drawing.Point(463, 504);
            this.lOcena.Name = "lOcena";
            this.lOcena.Size = new System.Drawing.Size(53, 20);
            this.lOcena.TabIndex = 35;
            this.lOcena.Text = "label1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label8.Location = new System.Drawing.Point(89, 504);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 43;
            this.label8.Text = "Ocena";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(89, 459);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 42;
            this.label7.Text = "Ilość";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(89, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "Cena";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(89, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Miejsce produkcji";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(89, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Odmiana";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(89, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Rocznik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(89, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Smak";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(89, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Marka";
            // 
            // OknoModyfikacji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(902, 721);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lOcena);
            this.Controls.Add(this.lIlosc);
            this.Controls.Add(this.lcena);
            this.Controls.Add(this.lGdziewyprodukowano);
            this.Controls.Add(this.lOdmiana);
            this.Controls.Add(this.lRocznik);
            this.Controls.Add(this.lSmak);
            this.Controls.Add(this.LMarka);
            this.Controls.Add(this.btnModyfikuj);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cmOdmiana);
            this.Controls.Add(this.nOcena);
            this.Controls.Add(this.nIlosc);
            this.Controls.Add(this.mtxtCena);
            this.Controls.Add(this.txtGdzieWyprodukowano);
            this.Controls.Add(this.mtxtRocznik);
            this.Controls.Add(this.cmbSmak);
            this.Controls.Add(this.txtMarka);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(918, 760);
            this.MinimumSize = new System.Drawing.Size(876, 678);
            this.Name = "OknoModyfikacji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OknoModyfikacji";
            this.Load += new System.EventHandler(this.OknoModyfikacji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nOcena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIlosc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmOdmiana;
        private System.Windows.Forms.NumericUpDown nOcena;
        private System.Windows.Forms.NumericUpDown nIlosc;
        private System.Windows.Forms.MaskedTextBox mtxtCena;
        private System.Windows.Forms.TextBox txtGdzieWyprodukowano;
        private System.Windows.Forms.MaskedTextBox mtxtRocznik;
        private System.Windows.Forms.ComboBox cmbSmak;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnModyfikuj;
        private System.Windows.Forms.Label LMarka;
        private System.Windows.Forms.Label lSmak;
        private System.Windows.Forms.Label lRocznik;
        private System.Windows.Forms.Label lOdmiana;
        private System.Windows.Forms.Label lGdziewyprodukowano;
        private System.Windows.Forms.Label lcena;
        private System.Windows.Forms.Label lIlosc;
        private System.Windows.Forms.Label lOcena;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}