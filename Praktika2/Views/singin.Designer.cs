namespace Praktika2
{
    partial class singin
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
            this.Iseiti = new System.Windows.Forms.Button();
            this.Prisijungti = new System.Windows.Forms.Button();
            this.IvestVardas = new System.Windows.Forms.TextBox();
            this.info_log_vardas = new System.Windows.Forms.Label();
            this.slaptazodis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Iseiti
            // 
            this.Iseiti.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Iseiti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Iseiti.Font = new System.Drawing.Font("Dubai", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Iseiti.Location = new System.Drawing.Point(425, 326);
            this.Iseiti.Name = "Iseiti";
            this.Iseiti.Size = new System.Drawing.Size(148, 65);
            this.Iseiti.TabIndex = 1;
            this.Iseiti.Text = "Įšeiti";
            this.Iseiti.UseVisualStyleBackColor = false;
            this.Iseiti.Click += new System.EventHandler(this.Iseiti_Click);
            // 
            // Prisijungti
            // 
            this.Prisijungti.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Prisijungti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Prisijungti.Font = new System.Drawing.Font("Dubai", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prisijungti.Location = new System.Drawing.Point(216, 326);
            this.Prisijungti.Name = "Prisijungti";
            this.Prisijungti.Size = new System.Drawing.Size(148, 65);
            this.Prisijungti.TabIndex = 2;
            this.Prisijungti.Text = "Prisijungti";
            this.Prisijungti.UseVisualStyleBackColor = false;
            this.Prisijungti.Click += new System.EventHandler(this.Prisijungti_Click);
            // 
            // IvestVardas
            // 
            this.IvestVardas.Font = new System.Drawing.Font("Dubai", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IvestVardas.Location = new System.Drawing.Point(216, 87);
            this.IvestVardas.MaximumSize = new System.Drawing.Size(500, 500);
            this.IvestVardas.Multiline = true;
            this.IvestVardas.Name = "IvestVardas";
            this.IvestVardas.Size = new System.Drawing.Size(357, 46);
            this.IvestVardas.TabIndex = 3;
            this.IvestVardas.TextChanged += new System.EventHandler(this.IvestVardas_TextChanged);
            // 
            // info_log_vardas
            // 
            this.info_log_vardas.AutoSize = true;
            this.info_log_vardas.Font = new System.Drawing.Font("Dubai", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_log_vardas.Location = new System.Drawing.Point(209, 42);
            this.info_log_vardas.Name = "info_log_vardas";
            this.info_log_vardas.Size = new System.Drawing.Size(225, 42);
            this.info_log_vardas.TabIndex = 4;
            this.info_log_vardas.Text = "Prisijungimo Vardas";
            // 
            // slaptazodis
            // 
            this.slaptazodis.BackColor = System.Drawing.SystemColors.Window;
            this.slaptazodis.Font = new System.Drawing.Font("Dubai", 13.8F);
            this.slaptazodis.Location = new System.Drawing.Point(216, 207);
            this.slaptazodis.Name = "slaptazodis";
            this.slaptazodis.PasswordChar = '*';
            this.slaptazodis.Size = new System.Drawing.Size(357, 46);
            this.slaptazodis.TabIndex = 5;
            this.slaptazodis.UseSystemPasswordChar = true;
            this.slaptazodis.TextChanged += new System.EventHandler(this.slaptazodis_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Slaptažodis";
            // 
            // singin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.slaptazodis);
            this.Controls.Add(this.info_log_vardas);
            this.Controls.Add(this.IvestVardas);
            this.Controls.Add(this.Prisijungti);
            this.Controls.Add(this.Iseiti);
            this.Name = "singin";
            this.Text = "Prisijungimas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Iseiti;
        private System.Windows.Forms.Button Prisijungti;
        private System.Windows.Forms.Label info_log_vardas;
        private System.Windows.Forms.TextBox IvestVardas;
        private System.Windows.Forms.TextBox slaptazodis;
        private System.Windows.Forms.Label label1;
    }
}

