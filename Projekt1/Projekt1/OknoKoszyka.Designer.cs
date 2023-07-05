
namespace Projekt1
{
    partial class OknoKoszyka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OknoKoszyka));
            this.btnUsun = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lWartoscKoszyka = new System.Windows.Forms.Label();
            this.lCena = new System.Windows.Forms.Label();
            this.nIlosc = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.lNazwa = new System.Windows.Forms.Label();
            this.btnModyfikuj = new System.Windows.Forms.Button();
            this.btnZmow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nIlosc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUsun
            // 
            this.btnUsun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnUsun.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnUsun.Location = new System.Drawing.Point(43, 548);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(171, 57);
            this.btnUsun.TabIndex = 5;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = false;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // listView2
            // 
            this.listView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(12, 259);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(836, 111);
            this.listView2.TabIndex = 4;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 49);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(836, 152);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // lWartoscKoszyka
            // 
            this.lWartoscKoszyka.AutoSize = true;
            this.lWartoscKoszyka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lWartoscKoszyka.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lWartoscKoszyka.Location = new System.Drawing.Point(169, 219);
            this.lWartoscKoszyka.Name = "lWartoscKoszyka";
            this.lWartoscKoszyka.Size = new System.Drawing.Size(91, 25);
            this.lWartoscKoszyka.TabIndex = 6;
            this.lWartoscKoszyka.Text = "Wartość";
            // 
            // lCena
            // 
            this.lCena.AutoSize = true;
            this.lCena.BackColor = System.Drawing.SystemColors.Info;
            this.lCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lCena.Location = new System.Drawing.Point(576, 427);
            this.lCena.Name = "lCena";
            this.lCena.Size = new System.Drawing.Size(99, 29);
            this.lCena.TabIndex = 67;
            this.lCena.Text = "Cena zł";
            // 
            // nIlosc
            // 
            this.nIlosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.nIlosc.Location = new System.Drawing.Point(342, 425);
            this.nIlosc.Name = "nIlosc";
            this.nIlosc.Size = new System.Drawing.Size(166, 35);
            this.nIlosc.TabIndex = 66;
            this.nIlosc.ValueChanged += new System.EventHandler(this.nIlosc_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Info;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label9.Location = new System.Drawing.Point(237, 431);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 29);
            this.label9.TabIndex = 65;
            this.label9.Text = "Ilość";
            // 
            // lNazwa
            // 
            this.lNazwa.AutoSize = true;
            this.lNazwa.BackColor = System.Drawing.SystemColors.Info;
            this.lNazwa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lNazwa.Location = new System.Drawing.Point(57, 431);
            this.lNazwa.Name = "lNazwa";
            this.lNazwa.Size = new System.Drawing.Size(90, 29);
            this.lNazwa.TabIndex = 64;
            this.lNazwa.Text = "Nazwa";
            // 
            // btnModyfikuj
            // 
            this.btnModyfikuj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnModyfikuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnModyfikuj.Location = new System.Drawing.Point(613, 548);
            this.btnModyfikuj.Name = "btnModyfikuj";
            this.btnModyfikuj.Size = new System.Drawing.Size(171, 57);
            this.btnModyfikuj.TabIndex = 68;
            this.btnModyfikuj.Text = "Zmień ilość";
            this.btnModyfikuj.UseVisualStyleBackColor = false;
            this.btnModyfikuj.Click += new System.EventHandler(this.btnModyfikuj_Click);
            // 
            // btnZmow
            // 
            this.btnZmow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnZmow.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnZmow.Location = new System.Drawing.Point(272, 637);
            this.btnZmow.Name = "btnZmow";
            this.btnZmow.Size = new System.Drawing.Size(190, 68);
            this.btnZmow.TabIndex = 69;
            this.btnZmow.Text = "Zamów";
            this.btnZmow.UseVisualStyleBackColor = false;
            this.btnZmow.Click += new System.EventHandler(this.btnZmow_Click);
            // 
            // OknoKoszyka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(860, 735);
            this.Controls.Add(this.btnZmow);
            this.Controls.Add(this.btnModyfikuj);
            this.Controls.Add(this.lCena);
            this.Controls.Add(this.nIlosc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lNazwa);
            this.Controls.Add(this.lWartoscKoszyka);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(876, 792);
            this.MinimumSize = new System.Drawing.Size(816, 627);
            this.Name = "OknoKoszyka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OknoKoszyka";
            this.Load += new System.EventHandler(this.OknoKoszyka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nIlosc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lWartoscKoszyka;
        private System.Windows.Forms.Label lCena;
        private System.Windows.Forms.NumericUpDown nIlosc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lNazwa;
        private System.Windows.Forms.Button btnModyfikuj;
        private System.Windows.Forms.Button btnZmow;
    }
}