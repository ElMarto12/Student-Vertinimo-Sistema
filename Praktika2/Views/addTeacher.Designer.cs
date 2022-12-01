namespace Praktika2.Views
{
    partial class addTeacher
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
            this.vardas = new System.Windows.Forms.Label();
            this.pavardee = new System.Windows.Forms.Label();
            this.text_vardas = new System.Windows.Forms.TextBox();
            this.text_pavarde = new System.Windows.Forms.TextBox();
            this.patvirtint = new System.Windows.Forms.Button();
            this.atsaukt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vardas
            // 
            this.vardas.AutoSize = true;
            this.vardas.Font = new System.Drawing.Font("Ebrima", 16.2F);
            this.vardas.Location = new System.Drawing.Point(83, 95);
            this.vardas.Name = "vardas";
            this.vardas.Size = new System.Drawing.Size(100, 38);
            this.vardas.TabIndex = 0;
            this.vardas.Text = "Vardas";
            // 
            // pavardee
            // 
            this.pavardee.AutoSize = true;
            this.pavardee.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pavardee.Location = new System.Drawing.Point(83, 185);
            this.pavardee.Name = "pavardee";
            this.pavardee.Size = new System.Drawing.Size(115, 38);
            this.pavardee.TabIndex = 1;
            this.pavardee.Text = "Pavardė";
            // 
            // text_vardas
            // 
            this.text_vardas.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_vardas.Location = new System.Drawing.Point(239, 95);
            this.text_vardas.Multiline = true;
            this.text_vardas.Name = "text_vardas";
            this.text_vardas.Size = new System.Drawing.Size(391, 45);
            this.text_vardas.TabIndex = 2;
            // 
            // text_pavarde
            // 
            this.text_pavarde.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_pavarde.Location = new System.Drawing.Point(239, 185);
            this.text_pavarde.Multiline = true;
            this.text_pavarde.Name = "text_pavarde";
            this.text_pavarde.Size = new System.Drawing.Size(391, 45);
            this.text_pavarde.TabIndex = 3;
            // 
            // patvirtint
            // 
            this.patvirtint.Font = new System.Drawing.Font("Dubai", 14F);
            this.patvirtint.Location = new System.Drawing.Point(239, 276);
            this.patvirtint.Name = "patvirtint";
            this.patvirtint.Size = new System.Drawing.Size(172, 52);
            this.patvirtint.TabIndex = 7;
            this.patvirtint.Text = "Patvirtinti";
            this.patvirtint.UseVisualStyleBackColor = true;
            this.patvirtint.Click += new System.EventHandler(this.patvirtint_Click);
            // 
            // atsaukt
            // 
            this.atsaukt.Font = new System.Drawing.Font("Dubai", 14F);
            this.atsaukt.Location = new System.Drawing.Point(458, 276);
            this.atsaukt.Name = "atsaukt";
            this.atsaukt.Size = new System.Drawing.Size(172, 52);
            this.atsaukt.TabIndex = 8;
            this.atsaukt.Text = "Atšaukti";
            this.atsaukt.UseVisualStyleBackColor = true;
            this.atsaukt.Click += new System.EventHandler(this.atsaukt_Click);
            // 
            // addTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(804, 399);
            this.Controls.Add(this.atsaukt);
            this.Controls.Add(this.patvirtint);
            this.Controls.Add(this.text_pavarde);
            this.Controls.Add(this.text_vardas);
            this.Controls.Add(this.pavardee);
            this.Controls.Add(this.vardas);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "addTeacher";
            this.Text = "Pridėti Dėstytoją";
            this.Load += new System.EventHandler(this.addTeacher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vardas;
        private System.Windows.Forms.Label pavardee;
        private System.Windows.Forms.TextBox text_vardas;
        private System.Windows.Forms.TextBox text_pavarde;
        private System.Windows.Forms.Button patvirtint;
        private System.Windows.Forms.Button atsaukt;
    }
}