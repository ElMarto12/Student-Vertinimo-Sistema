namespace Praktika2.Views
{
    partial class menuAdmin
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
            this.btn_studentas_pridet = new System.Windows.Forms.Button();
            this.stud_control = new System.Windows.Forms.Label();
            this.dest_control = new System.Windows.Forms.Label();
            this.dal_control = new System.Windows.Forms.Label();
            this.grup_control = new System.Windows.Forms.Label();
            this.btn_destytojas_pridet = new System.Windows.Forms.Button();
            this.bnt_pridet_dalyka = new System.Windows.Forms.Button();
            this.btn_pridet_grupe = new System.Windows.Forms.Button();
            this.btn_priskirt_dalyka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_studentas_pridet
            // 
            this.btn_studentas_pridet.BackColor = System.Drawing.Color.Yellow;
            this.btn_studentas_pridet.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_studentas_pridet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_studentas_pridet.Location = new System.Drawing.Point(41, 90);
            this.btn_studentas_pridet.Name = "btn_studentas_pridet";
            this.btn_studentas_pridet.Size = new System.Drawing.Size(248, 87);
            this.btn_studentas_pridet.TabIndex = 0;
            this.btn_studentas_pridet.Text = "Pridėti Studentą";
            this.btn_studentas_pridet.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_studentas_pridet.UseVisualStyleBackColor = false;
            this.btn_studentas_pridet.Click += new System.EventHandler(this.btn_studentas_pridet_Click);
            // 
            // stud_control
            // 
            this.stud_control.AutoSize = true;
            this.stud_control.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stud_control.Location = new System.Drawing.Point(34, 36);
            this.stud_control.Name = "stud_control";
            this.stud_control.Size = new System.Drawing.Size(255, 38);
            this.stud_control.TabIndex = 1;
            this.stud_control.Text = "Studento Valdymas";
            // 
            // dest_control
            // 
            this.dest_control.AutoSize = true;
            this.dest_control.Font = new System.Drawing.Font("Ebrima", 16.2F);
            this.dest_control.Location = new System.Drawing.Point(354, 36);
            this.dest_control.Name = "dest_control";
            this.dest_control.Size = new System.Drawing.Size(261, 38);
            this.dest_control.TabIndex = 2;
            this.dest_control.Text = "Dėstytojo Valdymas";
            // 
            // dal_control
            // 
            this.dal_control.AutoSize = true;
            this.dal_control.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dal_control.Location = new System.Drawing.Point(679, 36);
            this.dal_control.Name = "dal_control";
            this.dal_control.Size = new System.Drawing.Size(228, 38);
            this.dal_control.TabIndex = 3;
            this.dal_control.Text = "Dalyko Valdymas";
            // 
            // grup_control
            // 
            this.grup_control.AutoSize = true;
            this.grup_control.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grup_control.Location = new System.Drawing.Point(993, 36);
            this.grup_control.Name = "grup_control";
            this.grup_control.Size = new System.Drawing.Size(231, 38);
            this.grup_control.TabIndex = 4;
            this.grup_control.Text = "Grupės Valdymas";
            // 
            // btn_destytojas_pridet
            // 
            this.btn_destytojas_pridet.BackColor = System.Drawing.Color.Yellow;
            this.btn_destytojas_pridet.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
            this.btn_destytojas_pridet.Location = new System.Drawing.Point(361, 90);
            this.btn_destytojas_pridet.Name = "btn_destytojas_pridet";
            this.btn_destytojas_pridet.Size = new System.Drawing.Size(254, 87);
            this.btn_destytojas_pridet.TabIndex = 5;
            this.btn_destytojas_pridet.Text = "Pridėti Dėstytoją";
            this.btn_destytojas_pridet.UseVisualStyleBackColor = false;
            this.btn_destytojas_pridet.Click += new System.EventHandler(this.btn_destytojas_pridet_Click);
            // 
            // bnt_pridet_dalyka
            // 
            this.bnt_pridet_dalyka.BackColor = System.Drawing.Color.Yellow;
            this.bnt_pridet_dalyka.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
            this.bnt_pridet_dalyka.Location = new System.Drawing.Point(669, 90);
            this.bnt_pridet_dalyka.Name = "bnt_pridet_dalyka";
            this.bnt_pridet_dalyka.Size = new System.Drawing.Size(254, 87);
            this.bnt_pridet_dalyka.TabIndex = 6;
            this.bnt_pridet_dalyka.Text = "Pridėti Dalyką";
            this.bnt_pridet_dalyka.UseVisualStyleBackColor = false;
            this.bnt_pridet_dalyka.Click += new System.EventHandler(this.bnt_pridet_dalyka_Click);
            // 
            // btn_pridet_grupe
            // 
            this.btn_pridet_grupe.BackColor = System.Drawing.Color.Yellow;
            this.btn_pridet_grupe.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
            this.btn_pridet_grupe.Location = new System.Drawing.Point(982, 90);
            this.btn_pridet_grupe.Name = "btn_pridet_grupe";
            this.btn_pridet_grupe.Size = new System.Drawing.Size(254, 87);
            this.btn_pridet_grupe.TabIndex = 7;
            this.btn_pridet_grupe.Text = "Pridėti Grupę";
            this.btn_pridet_grupe.UseVisualStyleBackColor = false;
            this.btn_pridet_grupe.Click += new System.EventHandler(this.btn_pridet_grupe_Click);
            // 
            // btn_priskirt_dalyka
            // 
            this.btn_priskirt_dalyka.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_priskirt_dalyka.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_priskirt_dalyka.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_priskirt_dalyka.Location = new System.Drawing.Point(41, 216);
            this.btn_priskirt_dalyka.Name = "btn_priskirt_dalyka";
            this.btn_priskirt_dalyka.Size = new System.Drawing.Size(248, 87);
            this.btn_priskirt_dalyka.TabIndex = 8;
            this.btn_priskirt_dalyka.Text = "Priskirti dalyką";
            this.btn_priskirt_dalyka.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_priskirt_dalyka.UseVisualStyleBackColor = false;
            this.btn_priskirt_dalyka.Click += new System.EventHandler(this.btn_priskirt_dalyka_Click);
            // 
            // menuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1283, 643);
            this.Controls.Add(this.btn_priskirt_dalyka);
            this.Controls.Add(this.btn_pridet_grupe);
            this.Controls.Add(this.bnt_pridet_dalyka);
            this.Controls.Add(this.btn_destytojas_pridet);
            this.Controls.Add(this.grup_control);
            this.Controls.Add(this.dal_control);
            this.Controls.Add(this.dest_control);
            this.Controls.Add(this.stud_control);
            this.Controls.Add(this.btn_studentas_pridet);
            this.Name = "menuAdmin";
            this.Text = "Administratorius";
            this.Load += new System.EventHandler(this.menuAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_studentas_pridet;
        private System.Windows.Forms.Label stud_control;
        private System.Windows.Forms.Label dest_control;
        private System.Windows.Forms.Label dal_control;
        private System.Windows.Forms.Label grup_control;
        private System.Windows.Forms.Button btn_destytojas_pridet;
        private System.Windows.Forms.Button bnt_pridet_dalyka;
        private System.Windows.Forms.Button btn_pridet_grupe;
        private System.Windows.Forms.Button btn_priskirt_dalyka;
    }
}