
namespace Rocchi_server01_form
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
            this.btn_attiva = new System.Windows.Forms.Button();
            this.lbl_titolo = new System.Windows.Forms.Label();
            this.list_eventi = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_attiva
            // 
            this.btn_attiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_attiva.Location = new System.Drawing.Point(18, 52);
            this.btn_attiva.Name = "btn_attiva";
            this.btn_attiva.Size = new System.Drawing.Size(106, 67);
            this.btn_attiva.TabIndex = 0;
            this.btn_attiva.Text = "Attiva socket";
            this.btn_attiva.UseVisualStyleBackColor = true;
            this.btn_attiva.Click += new System.EventHandler(this.btn_attiva_Click);
            // 
            // lbl_titolo
            // 
            this.lbl_titolo.AutoSize = true;
            this.lbl_titolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titolo.Location = new System.Drawing.Point(13, 13);
            this.lbl_titolo.Name = "lbl_titolo";
            this.lbl_titolo.Size = new System.Drawing.Size(111, 25);
            this.lbl_titolo.TabIndex = 1;
            this.lbl_titolo.Text = "SERVER ";
            // 
            // list_eventi
            // 
            this.list_eventi.FormattingEnabled = true;
            this.list_eventi.Location = new System.Drawing.Point(18, 148);
            this.list_eventi.Name = "list_eventi";
            this.list_eventi.Size = new System.Drawing.Size(306, 199);
            this.list_eventi.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.list_eventi);
            this.Controls.Add(this.lbl_titolo);
            this.Controls.Add(this.btn_attiva);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_attiva;
        private System.Windows.Forms.Label lbl_titolo;
        private System.Windows.Forms.ListBox list_eventi;
    }
}

