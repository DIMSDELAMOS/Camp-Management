namespace SmartCamping
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.ButtonSummary = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ButtonFinished = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonSummary
            // 
            this.ButtonSummary.BackColor = System.Drawing.Color.IndianRed;
            this.ButtonSummary.Location = new System.Drawing.Point(662, 110);
            this.ButtonSummary.Name = "ButtonSummary";
            this.ButtonSummary.Size = new System.Drawing.Size(105, 51);
            this.ButtonSummary.TabIndex = 0;
            this.ButtonSummary.Text = "Σύνοψη Επιλογών";
            this.ButtonSummary.UseVisualStyleBackColor = false;
            this.ButtonSummary.Click += new System.EventHandler(this.ButtonSummary_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(39, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Τουρισμός";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.Location = new System.Drawing.Point(39, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 51);
            this.button2.TabIndex = 6;
            this.button2.Text = "Συνομιλία";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.IndianRed;
            this.button3.Location = new System.Drawing.Point(39, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 51);
            this.button3.TabIndex = 7;
            this.button3.Text = "Καιρός";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.IndianRed;
            this.button4.Location = new System.Drawing.Point(39, 245);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 51);
            this.button4.TabIndex = 8;
            this.button4.Text = "Παραγγελία";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ButtonFinished
            // 
            this.ButtonFinished.BackColor = System.Drawing.Color.IndianRed;
            this.ButtonFinished.Location = new System.Drawing.Point(662, 245);
            this.ButtonFinished.Name = "ButtonFinished";
            this.ButtonFinished.Size = new System.Drawing.Size(105, 51);
            this.ButtonFinished.TabIndex = 9;
            this.ButtonFinished.Text = "Ολοκλήρωση Project";
            this.ButtonFinished.UseVisualStyleBackColor = false;
            this.ButtonFinished.Click += new System.EventHandler(this.ButtonFinished_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.IndianRed;
            this.button5.Location = new System.Drawing.Point(39, 319);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 51);
            this.button5.TabIndex = 10;
            this.button5.Text = "Εκδηλώσεις";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.IndianRed;
            this.button6.Location = new System.Drawing.Point(662, 179);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(105, 51);
            this.button6.TabIndex = 11;
            this.button6.Text = "Επιστροφή στην αρχή";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.IndianRed;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(758, 406);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(30, 32);
            this.button7.TabIndex = 13;
            this.button7.Text = "?";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.ButtonFinished);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonSummary);
            this.DoubleBuffered = true;
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonSummary;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button ButtonFinished;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}