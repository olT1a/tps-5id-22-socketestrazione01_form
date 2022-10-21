
namespace Rocchi_client01_form
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
            this.lbl_titolo = new System.Windows.Forms.Label();
            this.btn_connetti = new System.Windows.Forms.Button();
            this.lbl_inserisci = new System.Windows.Forms.Label();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.list_eventi = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_titolo
            // 
            this.lbl_titolo.AutoSize = true;
            this.lbl_titolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titolo.Location = new System.Drawing.Point(12, 9);
            this.lbl_titolo.Name = "lbl_titolo";
            this.lbl_titolo.Size = new System.Drawing.Size(92, 25);
            this.lbl_titolo.TabIndex = 0;
            this.lbl_titolo.Text = "CLIENT";
            // 
            // btn_connetti
            // 
            this.btn_connetti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connetti.Location = new System.Drawing.Point(23, 141);
            this.btn_connetti.Name = "btn_connetti";
            this.btn_connetti.Size = new System.Drawing.Size(97, 58);
            this.btn_connetti.TabIndex = 1;
            this.btn_connetti.Text = "Connetti";
            this.btn_connetti.UseVisualStyleBackColor = true;
            this.btn_connetti.Click += new System.EventHandler(this.btn_connetti_Click);
            // 
            // lbl_inserisci
            // 
            this.lbl_inserisci.AutoSize = true;
            this.lbl_inserisci.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inserisci.Location = new System.Drawing.Point(17, 58);
            this.lbl_inserisci.Name = "lbl_inserisci";
            this.lbl_inserisci.Size = new System.Drawing.Size(158, 13);
            this.lbl_inserisci.TabIndex = 2;
            this.lbl_inserisci.Text = "Inserisci numero tra 1 e 10";
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(20, 93);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(100, 20);
            this.txt_num.TabIndex = 3;
            this.txt_num.TextChanged += new System.EventHandler(this.txt_num_TextChanged);
            // 
            // list_eventi
            // 
            this.list_eventi.FormattingEnabled = true;
            this.list_eventi.Location = new System.Drawing.Point(255, 58);
            this.list_eventi.Name = "list_eventi";
            this.list_eventi.Size = new System.Drawing.Size(342, 160);
            this.list_eventi.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.list_eventi);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.lbl_inserisci);
            this.Controls.Add(this.btn_connetti);
            this.Controls.Add(this.lbl_titolo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titolo;
        private System.Windows.Forms.Button btn_connetti;
        private System.Windows.Forms.Label lbl_inserisci;
        public System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.ListBox list_eventi;
    }
}

