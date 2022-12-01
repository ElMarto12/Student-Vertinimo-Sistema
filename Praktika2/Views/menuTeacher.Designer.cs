namespace Praktika2.Views
{
    partial class menuTeacher
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
            this.student = new System.Windows.Forms.Label();
            this.student_list = new System.Windows.Forms.ListBox();
            this.Dest_vardas = new System.Windows.Forms.Label();
            this.dest_dalyk = new System.Windows.Forms.Label();
            this.pazymys = new System.Windows.Forms.Label();
            this.text_pazymys = new System.Windows.Forms.TextBox();
            this.patvirtint = new System.Windows.Forms.Button();
            this.atsaukt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // student
            // 
            this.student.AutoSize = true;
            this.student.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student.Location = new System.Drawing.Point(146, 109);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(139, 38);
            this.student.TabIndex = 2;
            this.student.Text = "Studentas";
            // 
            // student_list
            // 
            this.student_list.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_list.FormattingEnabled = true;
            this.student_list.ItemHeight = 31;
            this.student_list.Location = new System.Drawing.Point(153, 164);
            this.student_list.Name = "student_list";
            this.student_list.Size = new System.Drawing.Size(538, 407);
            this.student_list.TabIndex = 3;
            this.student_list.SelectedIndexChanged += new System.EventHandler(this.student_list_SelectedIndexChanged);
            // 
            // Dest_vardas
            // 
            this.Dest_vardas.AutoSize = true;
            this.Dest_vardas.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dest_vardas.Location = new System.Drawing.Point(45, 38);
            this.Dest_vardas.Name = "Dest_vardas";
            this.Dest_vardas.Size = new System.Drawing.Size(91, 38);
            this.Dest_vardas.TabIndex = 10;
            this.Dest_vardas.Text = "label1";
            // 
            // dest_dalyk
            // 
            this.dest_dalyk.AutoSize = true;
            this.dest_dalyk.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dest_dalyk.Location = new System.Drawing.Point(181, 38);
            this.dest_dalyk.Name = "dest_dalyk";
            this.dest_dalyk.Size = new System.Drawing.Size(91, 38);
            this.dest_dalyk.TabIndex = 11;
            this.dest_dalyk.Text = "label1";
            // 
            // pazymys
            // 
            this.pazymys.AutoSize = true;
            this.pazymys.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pazymys.Location = new System.Drawing.Point(148, 621);
            this.pazymys.Name = "pazymys";
            this.pazymys.Size = new System.Drawing.Size(124, 38);
            this.pazymys.TabIndex = 12;
            this.pazymys.Text = "Pažymys";
            // 
            // text_pazymys
            // 
            this.text_pazymys.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_pazymys.Location = new System.Drawing.Point(153, 662);
            this.text_pazymys.Multiline = true;
            this.text_pazymys.Name = "text_pazymys";
            this.text_pazymys.Size = new System.Drawing.Size(538, 55);
            this.text_pazymys.TabIndex = 13;
            // 
            // patvirtint
            // 
            this.patvirtint.Font = new System.Drawing.Font("Dubai", 14F);
            this.patvirtint.Location = new System.Drawing.Point(153, 757);
            this.patvirtint.Name = "patvirtint";
            this.patvirtint.Size = new System.Drawing.Size(230, 83);
            this.patvirtint.TabIndex = 14;
            this.patvirtint.Text = "Patvirtinti";
            this.patvirtint.UseVisualStyleBackColor = true;
            this.patvirtint.Click += new System.EventHandler(this.patvirtint_Click);
            // 
            // atsaukt
            // 
            this.atsaukt.Font = new System.Drawing.Font("Dubai", 14F);
            this.atsaukt.Location = new System.Drawing.Point(461, 757);
            this.atsaukt.Name = "atsaukt";
            this.atsaukt.Size = new System.Drawing.Size(230, 83);
            this.atsaukt.TabIndex = 15;
            this.atsaukt.Text = "Atšaukti";
            this.atsaukt.UseVisualStyleBackColor = true;
            this.atsaukt.Click += new System.EventHandler(this.atsaukt_Click);
            // 
            // menuTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(894, 875);
            this.Controls.Add(this.atsaukt);
            this.Controls.Add(this.patvirtint);
            this.Controls.Add(this.text_pazymys);
            this.Controls.Add(this.pazymys);
            this.Controls.Add(this.dest_dalyk);
            this.Controls.Add(this.Dest_vardas);
            this.Controls.Add(this.student_list);
            this.Controls.Add(this.student);
            this.Name = "menuTeacher";
            this.Text = "Dėstytojas";
            this.Load += new System.EventHandler(this.menuTeacher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label student;
        private System.Windows.Forms.ListBox student_list;
        private System.Windows.Forms.Label Dest_vardas;
        private System.Windows.Forms.Label dest_dalyk;
        private System.Windows.Forms.Label pazymys;
        private System.Windows.Forms.TextBox text_pazymys;
        private System.Windows.Forms.Button patvirtint;
        private System.Windows.Forms.Button atsaukt;
    }
}