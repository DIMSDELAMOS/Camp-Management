namespace SmartCamping
{
    partial class MapSelectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapSelectionForm));
            this.picMap = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Label_Feedback = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).BeginInit();
            this.SuspendLayout();
            // 
            // picMap
            // 
            this.picMap.Image = ((System.Drawing.Image)(resources.GetObject("picMap.Image")));
            this.picMap.Location = new System.Drawing.Point(2, -1);
            this.picMap.Name = "picMap";
            this.picMap.Size = new System.Drawing.Size(824, 474);
            this.picMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMap.TabIndex = 0;
            this.picMap.TabStop = false;
            this.picMap.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(188, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Α";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.Location = new System.Drawing.Point(403, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Β";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.IndianRed;
            this.button3.Location = new System.Drawing.Point(563, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 28);
            this.button3.TabIndex = 3;
            this.button3.Text = "Γ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Label_Feedback
            // 
            this.Label_Feedback.AutoSize = true;
            this.Label_Feedback.BackColor = System.Drawing.Color.IndianRed;
            this.Label_Feedback.Location = new System.Drawing.Point(244, 12);
            this.Label_Feedback.Name = "Label_Feedback";
            this.Label_Feedback.Size = new System.Drawing.Size(44, 16);
            this.Label_Feedback.TabIndex = 4;
            this.Label_Feedback.Text = "label1";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.IndianRed;
            this.button4.Location = new System.Drawing.Point(717, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 45);
            this.button4.TabIndex = 5;
            this.button4.Text = "Συνέχεια";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Επιλογή σημείου στησίματος";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.IndianRed;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(781, 428);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 32);
            this.button5.TabIndex = 7;
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // MapSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 472);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Label_Feedback);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picMap);
            this.Name = "MapSelectionForm";
            this.Text = "MapSelectionForm";
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Label_Feedback;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
    }
}