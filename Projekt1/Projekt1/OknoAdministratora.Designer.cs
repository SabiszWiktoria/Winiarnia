
namespace Projekt1
{
    partial class OknoAdministratora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OknoAdministratora));
            this.btnModyfikowanie = new System.Windows.Forms.Button();
            this.btnUsuwanie = new System.Windows.Forms.Button();
            this.btnDodawanie = new System.Windows.Forms.Button();
            this.btnListaArtykulow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModyfikowanie
            // 
            this.btnModyfikowanie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnModyfikowanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnModyfikowanie.Location = new System.Drawing.Point(417, 269);
            this.btnModyfikowanie.Name = "btnModyfikowanie";
            this.btnModyfikowanie.Size = new System.Drawing.Size(233, 82);
            this.btnModyfikowanie.TabIndex = 7;
            this.btnModyfikowanie.Text = "Modyfikacja artykułu";
            this.btnModyfikowanie.UseVisualStyleBackColor = false;
            this.btnModyfikowanie.Click += new System.EventHandler(this.btnModyfikowanie_Click_1);
            // 
            // btnUsuwanie
            // 
            this.btnUsuwanie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnUsuwanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnUsuwanie.Location = new System.Drawing.Point(100, 269);
            this.btnUsuwanie.Name = "btnUsuwanie";
            this.btnUsuwanie.Size = new System.Drawing.Size(247, 82);
            this.btnUsuwanie.TabIndex = 6;
            this.btnUsuwanie.Text = "Usuwanie";
            this.btnUsuwanie.UseVisualStyleBackColor = false;
            this.btnUsuwanie.Click += new System.EventHandler(this.btnUsuwanie_Click_1);
            // 
            // btnDodawanie
            // 
            this.btnDodawanie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDodawanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnDodawanie.Location = new System.Drawing.Point(417, 112);
            this.btnDodawanie.Name = "btnDodawanie";
            this.btnDodawanie.Size = new System.Drawing.Size(233, 81);
            this.btnDodawanie.TabIndex = 5;
            this.btnDodawanie.Text = "Dodawanie";
            this.btnDodawanie.UseVisualStyleBackColor = false;
            this.btnDodawanie.Click += new System.EventHandler(this.btnDodawanie_Click_1);
            // 
            // btnListaArtykulow
            // 
            this.btnListaArtykulow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnListaArtykulow.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnListaArtykulow.Location = new System.Drawing.Point(100, 112);
            this.btnListaArtykulow.Name = "btnListaArtykulow";
            this.btnListaArtykulow.Size = new System.Drawing.Size(247, 81);
            this.btnListaArtykulow.TabIndex = 4;
            this.btnListaArtykulow.Text = "Lista dostępnych artykułów";
            this.btnListaArtykulow.UseVisualStyleBackColor = false;
            this.btnListaArtykulow.Click += new System.EventHandler(this.btnListaArtykulow_Click);
            // 
            // OknoAdministratora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModyfikowanie);
            this.Controls.Add(this.btnUsuwanie);
            this.Controls.Add(this.btnDodawanie);
            this.Controls.Add(this.btnListaArtykulow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "OknoAdministratora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OknoAdministratora";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModyfikowanie;
        private System.Windows.Forms.Button btnUsuwanie;
        private System.Windows.Forms.Button btnDodawanie;
        private System.Windows.Forms.Button btnListaArtykulow;
    }
}