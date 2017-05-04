namespace SwissTransport
{
    partial class Form1
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnverbindungen = new System.Windows.Forms.Button();
            this.btnfahrplan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(2, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 437);
            this.panel1.TabIndex = 39;
            // 
            // btnverbindungen
            // 
            this.btnverbindungen.Location = new System.Drawing.Point(12, 12);
            this.btnverbindungen.Name = "btnverbindungen";
            this.btnverbindungen.Size = new System.Drawing.Size(85, 22);
            this.btnverbindungen.TabIndex = 40;
            this.btnverbindungen.Text = "Verbindungen";
            this.btnverbindungen.UseVisualStyleBackColor = true;
            this.btnverbindungen.Click += new System.EventHandler(this.btnverbindungen_Click);
            // 
            // btnfahrplan
            // 
            this.btnfahrplan.Location = new System.Drawing.Point(103, 12);
            this.btnfahrplan.Name = "btnfahrplan";
            this.btnfahrplan.Size = new System.Drawing.Size(85, 22);
            this.btnfahrplan.TabIndex = 41;
            this.btnfahrplan.Text = "Fahrplan";
            this.btnfahrplan.UseVisualStyleBackColor = true;
            this.btnfahrplan.Click += new System.EventHandler(this.btnfahrplan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(572, 506);
            this.Controls.Add(this.btnfahrplan);
            this.Controls.Add(this.btnverbindungen);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnverbindungen;
        private System.Windows.Forms.Button btnfahrplan;
    }
}

