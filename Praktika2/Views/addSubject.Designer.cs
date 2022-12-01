namespace Praktika2.Views
{
    partial class addSubject
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
            this.pavadinimas = new System.Windows.Forms.Label();
            this.text_pavadinimas = new System.Windows.Forms.TextBox();
            this.destytojas = new System.Windows.Forms.Label();
            this.select_destytojas = new System.Windows.Forms.ListBox();
            this.patvirtint = new System.Windows.Forms.Button();
            this.atsaukt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pavadinimas
            // 
            this.pavadinimas.AutoSize = true;
            this.pavadinimas.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pavadinimas.Location = new System.Drawing.Point(82, 65);
            this.pavadinimas.Name = "pavadinimas";
            this.pavadinimas.Size = new System.Drawing.Size(170, 38);
            this.pavadinimas.TabIndex = 1;
            this.pavadinimas.Text = "Pavadinimas";
            // 
            // text_pavadinimas
            // 
            this.text_pavadinimas.Font = new System.Drawing.Font("Dubai", 13.8F);
            this.text_pavadinimas.Location = new System.Drawing.Point(89, 117);
            this.text_pavadinimas.Multiline = true;
            this.text_pavadinimas.Name = "text_pavadinimas";
            this.text_pavadinimas.Size = new System.Drawing.Size(470, 45);
            this.text_pavadinimas.TabIndex = 2;
            // 
            // destytojas
            // 
            this.destytojas.AutoSize = true;
            this.destytojas.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destytojas.Location = new System.Drawing.Point(82, 207);
            this.destytojas.Name = "destytojas";
            this.destytojas.Size = new System.Drawing.Size(253, 38);
            this.destytojas.TabIndex = 3;
            this.destytojas.Text = "Pasirinkti Dėstytoją";
            // 
            // select_destytojas
            // 
            this.select_destytojas.Font = new System.Drawing.Font("Dubai", 12F);
            this.select_destytojas.FormattingEnabled = true;
            this.select_destytojas.ItemHeight = 34;
            this.select_destytojas.Location = new System.Drawing.Point(89, 262);
            this.select_destytojas.Name = "select_destytojas";
            this.select_destytojas.Size = new System.Drawing.Size(470, 208);
            this.select_destytojas.TabIndex = 4;
            // 
            // patvirtint
            // 
            this.patvirtint.Font = new System.Drawing.Font("Dubai", 14F);
            this.patvirtint.Location = new System.Drawing.Point(89, 508);
            this.patvirtint.Name = "patvirtint";
            this.patvirtint.Size = new System.Drawing.Size(187, 55);
            this.patvirtint.TabIndex = 7;
            this.patvirtint.Text = "Patvirtinti";
            this.patvirtint.UseVisualStyleBackColor = true;
            this.patvirtint.Click += new System.EventHandler(this.patvirtint_Click);
            // 
            // atsaukt
            // 
            this.atsaukt.Font = new System.Drawing.Font("Dubai", 14F);
            this.atsaukt.Location = new System.Drawing.Point(372, 508);
            this.atsaukt.Name = "atsaukt";
            this.atsaukt.Size = new System.Drawing.Size(187, 55);
            this.atsaukt.TabIndex = 8;
            this.atsaukt.Text = "Atšaukti";
            this.atsaukt.UseVisualStyleBackColor = true;
            this.atsaukt.Click += new System.EventHandler(this.atsaukt_Click);
            // 
            // addSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(673, 635);
            this.Controls.Add(this.atsaukt);
            this.Controls.Add(this.patvirtint);
            this.Controls.Add(this.select_destytojas);
            this.Controls.Add(this.destytojas);
            this.Controls.Add(this.text_pavadinimas);
            this.Controls.Add(this.pavadinimas);
            this.Name = "addSubject";
            this.Text = "Pridėti Dalyką";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pavadinimas;
        private System.Windows.Forms.TextBox text_pavadinimas;
        private System.Windows.Forms.Label destytojas;
        private System.Windows.Forms.ListBox select_destytojas;
        private System.Windows.Forms.Button patvirtint;
        private System.Windows.Forms.Button atsaukt;
    }
}