namespace Praktika2.Views
{
    partial class addSubStudent
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
            this.select_student = new System.Windows.Forms.ListBox();
            this.dalykai = new System.Windows.Forms.Label();
            this.select_subject = new System.Windows.Forms.ListBox();
            this.patvirtint = new System.Windows.Forms.Button();
            this.atsaukt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // student
            // 
            this.student.AutoSize = true;
            this.student.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student.Location = new System.Drawing.Point(65, 46);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(134, 38);
            this.student.TabIndex = 0;
            this.student.Text = "Studentai";
            // 
            // select_student
            // 
            this.select_student.Font = new System.Drawing.Font("Dubai", 12F);
            this.select_student.FormattingEnabled = true;
            this.select_student.ItemHeight = 34;
            this.select_student.Location = new System.Drawing.Point(234, 46);
            this.select_student.Name = "select_student";
            this.select_student.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.select_student.Size = new System.Drawing.Size(452, 140);
            this.select_student.TabIndex = 6;
            this.select_student.TabStop = false;
            this.select_student.SelectedIndexChanged += new System.EventHandler(this.select_student_SelectedIndexChanged);
            // 
            // dalykai
            // 
            this.dalykai.AutoSize = true;
            this.dalykai.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dalykai.Location = new System.Drawing.Point(65, 245);
            this.dalykai.Name = "dalykai";
            this.dalykai.Size = new System.Drawing.Size(107, 38);
            this.dalykai.TabIndex = 7;
            this.dalykai.Text = "Dalykai";
            // 
            // select_subject
            // 
            this.select_subject.Font = new System.Drawing.Font("Dubai", 12F);
            this.select_subject.FormattingEnabled = true;
            this.select_subject.ItemHeight = 34;
            this.select_subject.Location = new System.Drawing.Point(234, 245);
            this.select_subject.Name = "select_subject";
            this.select_subject.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.select_subject.Size = new System.Drawing.Size(452, 140);
            this.select_subject.TabIndex = 8;
            this.select_subject.TabStop = false;
            this.select_subject.SelectedIndexChanged += new System.EventHandler(this.select_subject_SelectedIndexChanged);
            // 
            // patvirtint
            // 
            this.patvirtint.Font = new System.Drawing.Font("Dubai", 14F);
            this.patvirtint.Location = new System.Drawing.Point(234, 473);
            this.patvirtint.Name = "patvirtint";
            this.patvirtint.Size = new System.Drawing.Size(187, 55);
            this.patvirtint.TabIndex = 9;
            this.patvirtint.Text = "Patvirtinti";
            this.patvirtint.UseVisualStyleBackColor = true;
            this.patvirtint.Click += new System.EventHandler(this.patvirtint_Click);
            // 
            // atsaukt
            // 
            this.atsaukt.Font = new System.Drawing.Font("Dubai", 14F);
            this.atsaukt.Location = new System.Drawing.Point(499, 473);
            this.atsaukt.Name = "atsaukt";
            this.atsaukt.Size = new System.Drawing.Size(187, 55);
            this.atsaukt.TabIndex = 10;
            this.atsaukt.Text = "Atšaukti";
            this.atsaukt.UseVisualStyleBackColor = true;
            this.atsaukt.Click += new System.EventHandler(this.atsaukt_Click);
            // 
            // addSubStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(837, 621);
            this.Controls.Add(this.atsaukt);
            this.Controls.Add(this.patvirtint);
            this.Controls.Add(this.select_subject);
            this.Controls.Add(this.dalykai);
            this.Controls.Add(this.select_student);
            this.Controls.Add(this.student);
            this.Name = "addSubStudent";
            this.Text = "Priskirti Dalyką";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label student;
        private System.Windows.Forms.ListBox select_student;
        private System.Windows.Forms.Label dalykai;
        private System.Windows.Forms.ListBox select_subject;
        private System.Windows.Forms.Button patvirtint;
        private System.Windows.Forms.Button atsaukt;
    }
}