namespace SmartCamping
{
    partial class WeatherMonitorForm
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
            this.labelConditions = new System.Windows.Forms.Label();
            this.labelPlacedShades = new System.Windows.Forms.Label();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.ButtonReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // labelConditions
            // 
            this.labelConditions.AutoSize = true;
            this.labelConditions.Location = new System.Drawing.Point(37, 124);
            this.labelConditions.Name = "labelConditions";
            this.labelConditions.Size = new System.Drawing.Size(44, 16);
            this.labelConditions.TabIndex = 0;
            this.labelConditions.Text = "label1";
            // 
            // labelPlacedShades
            // 
            this.labelPlacedShades.AutoSize = true;
            this.labelPlacedShades.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelPlacedShades.Location = new System.Drawing.Point(37, 224);
            this.labelPlacedShades.Name = "labelPlacedShades";
            this.labelPlacedShades.Size = new System.Drawing.Size(44, 16);
            this.labelPlacedShades.TabIndex = 1;
            this.labelPlacedShades.Text = "label1";
            // 
            // picPreview
            // 
            this.picPreview.Location = new System.Drawing.Point(-3, 65);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(805, 386);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPreview.TabIndex = 2;
            this.picPreview.TabStop = false;
            // 
            // ButtonReturn
            // 
            this.ButtonReturn.BackColor = System.Drawing.Color.IndianRed;
            this.ButtonReturn.Location = new System.Drawing.Point(695, 255);
            this.ButtonReturn.Name = "ButtonReturn";
            this.ButtonReturn.Size = new System.Drawing.Size(93, 64);
            this.ButtonReturn.TabIndex = 3;
            this.ButtonReturn.Text = "Επιστροφή";
            this.ButtonReturn.UseVisualStyleBackColor = false;
            this.ButtonReturn.Click += new System.EventHandler(this.ButtonReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(172, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Καιρικές συνθήκες και επιθεώρηση πανιών";
            // 
            // WeatherMonitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonReturn);
            this.Controls.Add(this.labelPlacedShades);
            this.Controls.Add(this.labelConditions);
            this.Controls.Add(this.picPreview);
            this.Name = "WeatherMonitorForm";
            this.Text = "WeatherMonitorForm";
            this.Load += new System.EventHandler(this.WeatherMonitorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelConditions;
        private System.Windows.Forms.Label labelPlacedShades;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Button ButtonReturn;
        private System.Windows.Forms.Label label1;
    }
}