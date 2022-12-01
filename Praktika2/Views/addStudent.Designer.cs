namespace Praktika2.Views
{
    partial class addStudent
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
            this.text_vardas = new System.Windows.Forms.TextBox();
            this.pavarde = new System.Windows.Forms.Label();
            this.text_pavarde = new System.Windows.Forms.TextBox();
            this.grupe = new System.Windows.Forms.Label();
            this.select_grupe = new System.Windows.Forms.ListBox();
            this.patvirtint = new System.Windows.Forms.Button();
            this.atsaukt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vardas
            // 
            this.vardas.AutoSize = true;
            this.vardas.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vardas.Location = new System.Drawing.Point(63, 69);
            this.vardas.Name = "vardas";
            this.vardas.Size = new System.Drawing.Size(100, 38);
            this.vardas.TabIndex = 0;
            this.vardas.Text = "Vardas";
            // 
            // text_vardas
            // 
            this.text_vardas.Font = new System.Drawing.Font("Dubai", 13.8F);
            this.text_vardas.Location = new System.Drawing.Point(212, 69);
            this.text_vardas.Multiline = true;
            this.text_vardas.Name = "text_vardas";
            this.text_vardas.Size = new System.Drawing.Size(452, 45);
            this.text_vardas.TabIndex = 1;
           
            // 
            // pavarde
            // 
            this.pavarde.AutoSize = true;
            this.pavarde.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pavarde.Location = new System.Drawing.Point(63, 156);
            this.pavarde.Name = "pavarde";
            this.pavarde.Size = new System.Drawing.Size(115, 38);
            this.pavarde.TabIndex = 2;
            this.pavarde.Text = "Pavardė";
            // 
            // text_pavarde
            // 
            this.text_pavarde.Font = new System.Drawing.Font("Dubai", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_pavarde.Location = new System.Drawing.Point(212, 156);
            this.text_pavarde.Multiline = true;
            this.text_pavarde.Name = "text_pavarde";
            this.text_pavarde.Size = new System.Drawing.Size(452, 45);
            this.text_pavarde.TabIndex = 3;
            
            // 
            // grupe
            // 
            this.grupe.AutoSize = true;
            this.grupe.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupe.Location = new System.Drawing.Point(63, 243);
            this.grupe.Name = "grupe";
            this.grupe.Size = new System.Drawing.Size(93, 38);
            this.grupe.TabIndex = 4;
            this.grupe.Text = "Grupė";
            // 
            // select_grupe
            // 
            this.select_grupe.Font = new System.Drawing.Font("Dubai", 12F);
            this.select_grupe.FormattingEnabled = true;
            this.select_grupe.ItemHeight = 34;
            this.select_grupe.Location = new System.Drawing.Point(212, 243);
            this.select_grupe.Name = "select_grupe";
            this.select_grupe.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.select_grupe.Size = new System.Drawing.Size(452, 140);
            this.select_grupe.TabIndex = 5;
            this.select_grupe.TabStop = false;
            
            // 
            // patvirtint
            // 
            this.patvirtint.Font = new System.Drawing.Font("Dubai", 14F);
            this.patvirtint.Location = new System.Drawing.Point(212, 429);
            this.patvirtint.Name = "patvirtint";
            this.patvirtint.Size = new System.Drawing.Size(187, 55);
            this.patvirtint.TabIndex = 6;
            this.patvirtint.Text = "Patvirtinti";
            this.patvirtint.UseVisualStyleBackColor = true;
            this.patvirtint.Click += new System.EventHandler(this.patvirtint_Click);
            // 
            // atsaukt
            // 
            this.atsaukt.Font = new System.Drawing.Font("Dubai", 14F);
            this.atsaukt.Location = new System.Drawing.Point(468, 429);
            this.atsaukt.Name = "atsaukt";
            this.atsaukt.Size = new System.Drawing.Size(187, 55);
            this.atsaukt.TabIndex = 7;
            this.atsaukt.Text = "Atšaukti";
            this.atsaukt.UseVisualStyleBackColor = true;
            this.atsaukt.Click += new System.EventHandler(this.atsaukt_Click);
            // 
            // addStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(837, 543);
            this.Controls.Add(this.atsaukt);
            this.Controls.Add(this.patvirtint);
            this.Controls.Add(this.select_grupe);
            this.Controls.Add(this.grupe);
            this.Controls.Add(this.text_pavarde);
            this.Controls.Add(this.pavarde);
            this.Controls.Add(this.text_vardas);
            this.Controls.Add(this.vardas);
            this.Name = "addStudent";
            this.Text = "Pridėti Studentą";
            this.Load += new System.EventHandler(this.addStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vardas;
        private System.Windows.Forms.TextBox text_vardas;
        private System.Windows.Forms.Label pavarde;
        private System.Windows.Forms.TextBox text_pavarde;
        private System.Windows.Forms.Label grupe;
        private System.Windows.Forms.ListBox select_grupe;
        private System.Windows.Forms.Button patvirtint;
        private System.Windows.Forms.Button atsaukt;
    }
}