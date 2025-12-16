namespace SmartCamping
{
    partial class SummaryForm
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
            this.Label_Location = new System.Windows.Forms.Label();
            this.Label_Pegs = new System.Windows.Forms.Label();
            this.Label_Shades = new System.Windows.Forms.Label();
            this.Label_Lighting = new System.Windows.Forms.Label();
            this.Label_Energy = new System.Windows.Forms.Label();
            this.Label_Shelter = new System.Windows.Forms.Label();
            this.ButtonReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_Location
            // 
            this.Label_Location.AutoSize = true;
            this.Label_Location.Location = new System.Drawing.Point(81, 73);
            this.Label_Location.Name = "Label_Location";
            this.Label_Location.Size = new System.Drawing.Size(44, 16);
            this.Label_Location.TabIndex = 0;
            this.Label_Location.Text = "label1";
            // 
            // Label_Pegs
            // 
            this.Label_Pegs.AutoSize = true;
            this.Label_Pegs.Location = new System.Drawing.Point(81, 116);
            this.Label_Pegs.Name = "Label_Pegs";
            this.Label_Pegs.Size = new System.Drawing.Size(44, 16);
            this.Label_Pegs.TabIndex = 1;
            this.Label_Pegs.Text = "label2";
            this.Label_Pegs.Click += new System.EventHandler(this.label2_Click);
            // 
            // Label_Shades
            // 
            this.Label_Shades.AutoSize = true;
            this.Label_Shades.Location = new System.Drawing.Point(81, 164);
            this.Label_Shades.Name = "Label_Shades";
            this.Label_Shades.Size = new System.Drawing.Size(44, 16);
            this.Label_Shades.TabIndex = 2;
            this.Label_Shades.Text = "label3";
            // 
            // Label_Lighting
            // 
            this.Label_Lighting.AutoSize = true;
            this.Label_Lighting.Location = new System.Drawing.Point(81, 207);
            this.Label_Lighting.Name = "Label_Lighting";
            this.Label_Lighting.Size = new System.Drawing.Size(44, 16);
            this.Label_Lighting.TabIndex = 3;
            this.Label_Lighting.Text = "label4";
            // 
            // Label_Energy
            // 
            this.Label_Energy.AutoSize = true;
            this.Label_Energy.Location = new System.Drawing.Point(81, 257);
            this.Label_Energy.Name = "Label_Energy";
            this.Label_Energy.Size = new System.Drawing.Size(44, 16);
            this.Label_Energy.TabIndex = 4;
            this.Label_Energy.Text = "label5";
            // 
            // Label_Shelter
            // 
            this.Label_Shelter.AutoSize = true;
            this.Label_Shelter.Location = new System.Drawing.Point(81, 298);
            this.Label_Shelter.Name = "Label_Shelter";
            this.Label_Shelter.Size = new System.Drawing.Size(44, 16);
            this.Label_Shelter.TabIndex = 5;
            this.Label_Shelter.Text = "label6";
            // 
            // ButtonReturn
            // 
            this.ButtonReturn.BackColor = System.Drawing.Color.IndianRed;
            this.ButtonReturn.Location = new System.Drawing.Point(668, 178);
            this.ButtonReturn.Name = "ButtonReturn";
            this.ButtonReturn.Size = new System.Drawing.Size(92, 56);
            this.ButtonReturn.TabIndex = 6;
            this.ButtonReturn.Text = "Επιστροφή";
            this.ButtonReturn.UseVisualStyleBackColor = false;
            this.ButtonReturn.Click += new System.EventHandler(this.ButtonReturn_Click);
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonReturn);
            this.Controls.Add(this.Label_Shelter);
            this.Controls.Add(this.Label_Energy);
            this.Controls.Add(this.Label_Lighting);
            this.Controls.Add(this.Label_Shades);
            this.Controls.Add(this.Label_Pegs);
            this.Controls.Add(this.Label_Location);
            this.Name = "SummaryForm";
            this.Text = "SummaryForm";
            this.Load += new System.EventHandler(this.SummaryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Location;
        private System.Windows.Forms.Label Label_Pegs;
        private System.Windows.Forms.Label Label_Shades;
        private System.Windows.Forms.Label Label_Lighting;
        private System.Windows.Forms.Label Label_Energy;
        private System.Windows.Forms.Label Label_Shelter;
        private System.Windows.Forms.Button ButtonReturn;
    }
}