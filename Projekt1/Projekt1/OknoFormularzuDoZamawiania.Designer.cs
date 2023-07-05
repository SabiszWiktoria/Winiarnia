
namespace Projekt1
{
    partial class OknoFormularzuDoZamawiania
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OknoFormularzuDoZamawiania));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lWartosc = new System.Windows.Forms.Label();
            this.txtMiasto = new System.Windows.Forms.TextBox();
            this.TxtUlica = new System.Windows.Forms.TextBox();
            this.txtNrDomu = new System.Windows.Forms.TextBox();
            this.mtxtKodpocztowy = new System.Windows.Forms.MaskedTextBox();
            this.btnZamow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(54, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Miasto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label2.Location = new System.Drawing.Point(54, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ulica";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label3.Location = new System.Drawing.Point(54, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nr domu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label4.Location = new System.Drawing.Point(54, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kod pocztowy";
            // 
            // lWartosc
            // 
            this.lWartosc.AutoSize = true;
            this.lWartosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lWartosc.Location = new System.Drawing.Point(89, 435);
            this.lWartosc.Name = "lWartosc";
            this.lWartosc.Size = new System.Drawing.Size(81, 29);
            this.lWartosc.TabIndex = 4;
            this.lWartosc.Text = "label5";
            // 
            // txtMiasto
            // 
            this.txtMiasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.txtMiasto.Location = new System.Drawing.Point(273, 78);
            this.txtMiasto.Name = "txtMiasto";
            this.txtMiasto.Size = new System.Drawing.Size(196, 35);
            this.txtMiasto.TabIndex = 5;
            // 
            // TxtUlica
            // 
            this.TxtUlica.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.TxtUlica.Location = new System.Drawing.Point(273, 137);
            this.TxtUlica.Name = "TxtUlica";
            this.TxtUlica.Size = new System.Drawing.Size(196, 35);
            this.TxtUlica.TabIndex = 6;
            // 
            // txtNrDomu
            // 
            this.txtNrDomu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.txtNrDomu.Location = new System.Drawing.Point(273, 220);
            this.txtNrDomu.Name = "txtNrDomu";
            this.txtNrDomu.Size = new System.Drawing.Size(196, 35);
            this.txtNrDomu.TabIndex = 7;
            this.txtNrDomu.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // mtxtKodpocztowy
            // 
            this.mtxtKodpocztowy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.mtxtKodpocztowy.Location = new System.Drawing.Point(273, 298);
            this.mtxtKodpocztowy.Mask = "00-000";
            this.mtxtKodpocztowy.Name = "mtxtKodpocztowy";
            this.mtxtKodpocztowy.Size = new System.Drawing.Size(196, 35);
            this.mtxtKodpocztowy.TabIndex = 8;
            // 
            // btnZamow
            // 
            this.btnZamow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnZamow.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnZamow.Location = new System.Drawing.Point(94, 612);
            this.btnZamow.Name = "btnZamow";
            this.btnZamow.Size = new System.Drawing.Size(253, 83);
            this.btnZamow.TabIndex = 9;
            this.btnZamow.Text = "Zamów";
            this.btnZamow.UseVisualStyleBackColor = false;
            this.btnZamow.Click += new System.EventHandler(this.btnZamow_Click);
            // 
            // OknoFormularzuDoZamawiania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(860, 753);
            this.Controls.Add(this.btnZamow);
            this.Controls.Add(this.mtxtKodpocztowy);
            this.Controls.Add(this.txtNrDomu);
            this.Controls.Add(this.TxtUlica);
            this.Controls.Add(this.txtMiasto);
            this.Controls.Add(this.lWartosc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(876, 792);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "OknoFormularzuDoZamawiania";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OknoFormularzuDoZamawiania";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lWartosc;
        private System.Windows.Forms.TextBox txtMiasto;
        private System.Windows.Forms.TextBox TxtUlica;
        private System.Windows.Forms.TextBox txtNrDomu;
        private System.Windows.Forms.MaskedTextBox mtxtKodpocztowy;
        private System.Windows.Forms.Button btnZamow;
    }
}