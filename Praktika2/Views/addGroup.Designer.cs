namespace Praktika2.Views
{
    partial class addGroup
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
            this.fakultetas = new System.Windows.Forms.Label();
            this.text_pavadinimas = new System.Windows.Forms.TextBox();
            this.text_fakultetas = new System.Windows.Forms.TextBox();
            this.patvirtint = new System.Windows.Forms.Button();
            this.atsaukt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pavadinimas
            // 
            this.pavadinimas.AutoSize = true;
            this.pavadinimas.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pavadinimas.Location = new System.Drawing.Point(55, 72);
            this.pavadinimas.Name = "pavadinimas";
            this.pavadinimas.Size = new System.Drawing.Size(170, 38);
            this.pavadinimas.TabIndex = 1;
            this.pavadinimas.Text = "Pavadinimas";
            // 
            // fakultetas
            // 
            this.fakultetas.AutoSize = true;
            this.fakultetas.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fakultetas.Location = new System.Drawing.Point(55, 196);
            this.fakultetas.Name = "fakultetas";
            this.fakultetas.Size = new System.Drawing.Size(141, 38);
            this.fakultetas.TabIndex = 2;
            this.fakultetas.Text = "Fakultetas";
            // 
            // text_pavadinimas
            // 
            this.text_pavadinimas.Font = new System.Drawing.Font("Dubai", 13.8F);
            this.text_pavadinimas.Location = new System.Drawing.Point(256, 73);
            this.text_pavadinimas.Multiline = true;
            this.text_pavadinimas.Name = "text_pavadinimas";
            this.text_pavadinimas.Size = new System.Drawing.Size(452, 45);
            this.text_pavadinimas.TabIndex = 3;
            // 
            // text_fakultetas
            // 
            this.text_fakultetas.Font = new System.Drawing.Font("Dubai", 13.8F);
            this.text_fakultetas.Location = new System.Drawing.Point(256, 197);
            this.text_fakultetas.Multiline = true;
            this.text_fakultetas.Name = "text_fakultetas";
            this.text_fakultetas.Size = new System.Drawing.Size(452, 45);
            this.text_fakultetas.TabIndex = 4;
            // 
            // patvirtint
            // 
            this.patvirtint.Font = new System.Drawing.Font("Dubai", 14F);
            this.patvirtint.Location = new System.Drawing.Point(256, 302);
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
            this.atsaukt.Location = new System.Drawing.Point(521, 302);
            this.atsaukt.Name = "atsaukt";
            this.atsaukt.Size = new System.Drawing.Size(187, 55);
            this.atsaukt.TabIndex = 8;
            this.atsaukt.Text = "Atšaukti";
            this.atsaukt.UseVisualStyleBackColor = true;
            this.atsaukt.Click += new System.EventHandler(this.atsaukt_Click);
            // 
            // addGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(837, 456);
            this.Controls.Add(this.atsaukt);
            this.Controls.Add(this.patvirtint);
            this.Controls.Add(this.text_fakultetas);
            this.Controls.Add(this.text_pavadinimas);
            this.Controls.Add(this.fakultetas);
            this.Controls.Add(this.pavadinimas);
            this.Name = "addGroup";
            this.Text = "Pridėti Grupę";
            this.Load += new System.EventHandler(this.addGroup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pavadinimas;
        private System.Windows.Forms.Label fakultetas;
        private System.Windows.Forms.TextBox text_pavadinimas;
        private System.Windows.Forms.TextBox text_fakultetas;
        private System.Windows.Forms.Button patvirtint;
        private System.Windows.Forms.Button atsaukt;
    }
}