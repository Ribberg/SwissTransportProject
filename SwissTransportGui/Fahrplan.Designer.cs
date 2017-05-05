namespace SwissTransport
{
    partial class Fahrplan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxStation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsearch1 = new System.Windows.Forms.Button();
            this.listBoxPlan1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, -59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "Fahrplan";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(-26, -59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 39;
            this.button2.Text = "Verbindungen";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBoxStation
            // 
            this.comboBoxStation.FormattingEnabled = true;
            this.comboBoxStation.Location = new System.Drawing.Point(7, 31);
            this.comboBoxStation.Name = "comboBoxStation";
            this.comboBoxStation.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStation.TabIndex = 41;
            this.comboBoxStation.Text = "Search";
            this.comboBoxStation.TextUpdate += new System.EventHandler(this.comboBoxStation_TextUpdate_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Station";
            // 
            // btnsearch1
            // 
            this.btnsearch1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnsearch1.Location = new System.Drawing.Point(158, 31);
            this.btnsearch1.Name = "btnsearch1";
            this.btnsearch1.Size = new System.Drawing.Size(79, 21);
            this.btnsearch1.TabIndex = 43;
            this.btnsearch1.Text = "Search";
            this.btnsearch1.UseVisualStyleBackColor = true;
            this.btnsearch1.Click += new System.EventHandler(this.btnsearch1_Click);
            // 
            // listBoxPlan1
            // 
            this.listBoxPlan1.FormattingEnabled = true;
            this.listBoxPlan1.Location = new System.Drawing.Point(7, 59);
            this.listBoxPlan1.Name = "listBoxPlan1";
            this.listBoxPlan1.Size = new System.Drawing.Size(552, 290);
            this.listBoxPlan1.TabIndex = 44;
            // 
            // Fahrplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.Controls.Add(this.listBoxPlan1);
            this.Controls.Add(this.btnsearch1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxStation);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Name = "Fahrplan";
            this.Size = new System.Drawing.Size(572, 365);
            this.Load += new System.EventHandler(this.Fahrplan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxStation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsearch1;
        private System.Windows.Forms.ListBox listBoxPlan1;
    }
}
