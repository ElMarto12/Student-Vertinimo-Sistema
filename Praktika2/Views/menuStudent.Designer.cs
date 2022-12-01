namespace Praktika2.Views
{
    partial class menuStudent
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
            this.pazymiai = new System.Windows.Forms.Label();
            this.view_grade = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.view_grade)).BeginInit();
            this.SuspendLayout();
            // 
            // pazymiai
            // 
            this.pazymiai.AutoSize = true;
            this.pazymiai.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pazymiai.Location = new System.Drawing.Point(75, 60);
            this.pazymiai.Name = "pazymiai";
            this.pazymiai.Size = new System.Drawing.Size(126, 38);
            this.pazymiai.TabIndex = 0;
            this.pazymiai.Text = "Pažymiai";
            // 
            // view_grade
            // 
            this.view_grade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_grade.Location = new System.Drawing.Point(82, 135);
            this.view_grade.Name = "view_grade";
            this.view_grade.RowHeadersWidth = 51;
            this.view_grade.RowTemplate.Height = 24;
            this.view_grade.Size = new System.Drawing.Size(778, 262);
            this.view_grade.TabIndex = 1;
            // 
            // menuStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(974, 618);
            this.Controls.Add(this.view_grade);
            this.Controls.Add(this.pazymiai);
            this.Name = "menuStudent";
            this.Text = "Studentas";
            this.Load += new System.EventHandler(this.menuStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view_grade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pazymiai;
        private System.Windows.Forms.DataGridView view_grade;
    }
}