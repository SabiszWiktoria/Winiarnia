
namespace Projekt1
{
    partial class Witamy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Witamy));
            this.btnAdministrator = new System.Windows.Forms.Button();
            this.btnKlient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdministrator
            // 
            this.btnAdministrator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnAdministrator.Location = new System.Drawing.Point(36, 108);
            this.btnAdministrator.Name = "btnAdministrator";
            this.btnAdministrator.Size = new System.Drawing.Size(196, 66);
            this.btnAdministrator.TabIndex = 0;
            this.btnAdministrator.Text = "Administrator";
            this.btnAdministrator.UseVisualStyleBackColor = false;
            this.btnAdministrator.Click += new System.EventHandler(this.btnAdministrator_Click);
            // 
            // btnKlient
            // 
            this.btnKlient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnKlient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnKlient.Location = new System.Drawing.Point(475, 108);
            this.btnKlient.Name = "btnKlient";
            this.btnKlient.Size = new System.Drawing.Size(189, 66);
            this.btnKlient.TabIndex = 1;
            this.btnKlient.Text = "Klient";
            this.btnKlient.UseVisualStyleBackColor = false;
            this.btnKlient.Click += new System.EventHandler(this.btnKlient_Click);
            // 
            // Witamy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(693, 319);
            this.Controls.Add(this.btnKlient);
            this.Controls.Add(this.btnAdministrator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(709, 358);
            this.MinimumSize = new System.Drawing.Size(709, 358);
            this.Name = "Witamy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Witamy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdministrator;
        private System.Windows.Forms.Button btnKlient;
    }
}

