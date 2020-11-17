namespace WA_Test_BGW_Tanti_Bgw
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btAvvio2 = new System.Windows.Forms.Button();
            this.tbAvvio2 = new System.Windows.Forms.TextBox();
            this.tbAvvia100 = new System.Windows.Forms.TextBox();
            this.btAvvio100 = new System.Windows.Forms.Button();
            this.btStop100 = new System.Windows.Forms.Button();
            this.btStop2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btAvvio2
            // 
            this.btAvvio2.Location = new System.Drawing.Point(12, 12);
            this.btAvvio2.Name = "btAvvio2";
            this.btAvvio2.Size = new System.Drawing.Size(75, 23);
            this.btAvvio2.TabIndex = 0;
            this.btAvvio2.Text = "Avvio 2";
            this.btAvvio2.UseVisualStyleBackColor = true;
            this.btAvvio2.Click += new System.EventHandler(this.btAvvio2_Click);
            // 
            // tbAvvio2
            // 
            this.tbAvvio2.Location = new System.Drawing.Point(93, 14);
            this.tbAvvio2.Multiline = true;
            this.tbAvvio2.Name = "tbAvvio2";
            this.tbAvvio2.Size = new System.Drawing.Size(100, 353);
            this.tbAvvio2.TabIndex = 1;
            // 
            // tbAvvia100
            // 
            this.tbAvvia100.Location = new System.Drawing.Point(401, 14);
            this.tbAvvia100.Multiline = true;
            this.tbAvvia100.Name = "tbAvvia100";
            this.tbAvvia100.Size = new System.Drawing.Size(100, 353);
            this.tbAvvia100.TabIndex = 2;
            // 
            // btAvvio100
            // 
            this.btAvvio100.Location = new System.Drawing.Point(320, 12);
            this.btAvvio100.Name = "btAvvio100";
            this.btAvvio100.Size = new System.Drawing.Size(75, 23);
            this.btAvvio100.TabIndex = 3;
            this.btAvvio100.Text = "Avvio 100";
            this.btAvvio100.UseVisualStyleBackColor = true;
            this.btAvvio100.Click += new System.EventHandler(this.btAvvio100_Click);
            // 
            // btStop100
            // 
            this.btStop100.Location = new System.Drawing.Point(320, 53);
            this.btStop100.Name = "btStop100";
            this.btStop100.Size = new System.Drawing.Size(75, 23);
            this.btStop100.TabIndex = 4;
            this.btStop100.Text = "Stop 100";
            this.btStop100.UseVisualStyleBackColor = true;
            this.btStop100.Click += new System.EventHandler(this.btStop100_Click);
            // 
            // btStop2
            // 
            this.btStop2.Location = new System.Drawing.Point(12, 53);
            this.btStop2.Name = "btStop2";
            this.btStop2.Size = new System.Drawing.Size(75, 23);
            this.btStop2.TabIndex = 5;
            this.btStop2.Text = "Stop 2";
            this.btStop2.UseVisualStyleBackColor = true;
            this.btStop2.Click += new System.EventHandler(this.btStop2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 450);
            this.Controls.Add(this.btStop2);
            this.Controls.Add(this.btStop100);
            this.Controls.Add(this.btAvvio100);
            this.Controls.Add(this.tbAvvia100);
            this.Controls.Add(this.tbAvvio2);
            this.Controls.Add(this.btAvvio2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAvvio2;
        private System.Windows.Forms.TextBox tbAvvio2;
        private System.Windows.Forms.TextBox tbAvvia100;
        private System.Windows.Forms.Button btAvvio100;
        private System.Windows.Forms.Button btStop100;
        private System.Windows.Forms.Button btStop2;
    }
}

