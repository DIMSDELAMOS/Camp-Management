namespace SmartCamping
{
    partial class NavigationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.picMap = new System.Windows.Forms.PictureBox();
            this.radioShelterA = new System.Windows.Forms.RadioButton();
            this.radioShelterB = new System.Windows.Forms.RadioButton();
            this.radioShelterC = new System.Windows.Forms.RadioButton();
            this.labelDescription = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelWeather = new System.Windows.Forms.Label();
            this.labelSuggestion = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(271, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Πλοήγηση προς Καταφύγιο";
            // 
            // picMap
            // 
            this.picMap.Location = new System.Drawing.Point(215, 151);
            this.picMap.Name = "picMap";
            this.picMap.Size = new System.Drawing.Size(351, 250);
            this.picMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMap.TabIndex = 1;
            this.picMap.TabStop = false;
            // 
            // radioShelterA
            // 
            this.radioShelterA.AutoSize = true;
            this.radioShelterA.Location = new System.Drawing.Point(46, 177);
            this.radioShelterA.Name = "radioShelterA";
            this.radioShelterA.Size = new System.Drawing.Size(103, 20);
            this.radioShelterA.TabIndex = 2;
            this.radioShelterA.TabStop = true;
            this.radioShelterA.Text = "Καταφύγιο Α";
            this.radioShelterA.UseVisualStyleBackColor = true;
            this.radioShelterA.CheckedChanged += new System.EventHandler(this.radioShelterA_CheckedChanged);
            // 
            // radioShelterB
            // 
            this.radioShelterB.AutoSize = true;
            this.radioShelterB.Location = new System.Drawing.Point(46, 237);
            this.radioShelterB.Name = "radioShelterB";
            this.radioShelterB.Size = new System.Drawing.Size(103, 20);
            this.radioShelterB.TabIndex = 3;
            this.radioShelterB.TabStop = true;
            this.radioShelterB.Text = "Καταφύγιο Β";
            this.radioShelterB.UseVisualStyleBackColor = true;
            this.radioShelterB.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // radioShelterC
            // 
            this.radioShelterC.AutoSize = true;
            this.radioShelterC.Location = new System.Drawing.Point(46, 299);
            this.radioShelterC.Name = "radioShelterC";
            this.radioShelterC.Size = new System.Drawing.Size(102, 20);
            this.radioShelterC.TabIndex = 4;
            this.radioShelterC.TabStop = true;
            this.radioShelterC.Text = "Καταφύγιο Γ";
            this.radioShelterC.UseVisualStyleBackColor = true;
            this.radioShelterC.CheckedChanged += new System.EventHandler(this.radioShelterC_CheckedChanged);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(212, 117);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(44, 16);
            this.labelDescription.TabIndex = 5;
            this.labelDescription.Text = "label2";
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.IndianRed;
            this.buttonNext.Location = new System.Drawing.Point(703, 177);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(90, 58);
            this.buttonNext.TabIndex = 6;
            this.buttonNext.Text = "Συνέχεια";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Visible = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelWeather
            // 
            this.labelWeather.AutoSize = true;
            this.labelWeather.Location = new System.Drawing.Point(119, 46);
            this.labelWeather.Name = "labelWeather";
            this.labelWeather.Size = new System.Drawing.Size(44, 16);
            this.labelWeather.TabIndex = 7;
            this.labelWeather.Text = "label2";
            // 
            // labelSuggestion
            // 
            this.labelSuggestion.AutoSize = true;
            this.labelSuggestion.Location = new System.Drawing.Point(119, 82);
            this.labelSuggestion.Name = "labelSuggestion";
            this.labelSuggestion.Size = new System.Drawing.Size(44, 16);
            this.labelSuggestion.TabIndex = 8;
            this.labelSuggestion.Text = "label3";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.IndianRed;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(758, 406);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 32);
            this.button5.TabIndex = 13;
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // NavigationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.labelSuggestion);
            this.Controls.Add(this.labelWeather);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.radioShelterC);
            this.Controls.Add(this.radioShelterB);
            this.Controls.Add(this.radioShelterA);
            this.Controls.Add(this.picMap);
            this.Controls.Add(this.label1);
            this.Name = "NavigationForm";
            this.Text = "NavigationForm";
            this.Load += new System.EventHandler(this.NavigationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picMap;
        private System.Windows.Forms.RadioButton radioShelterA;
        private System.Windows.Forms.RadioButton radioShelterB;
        private System.Windows.Forms.RadioButton radioShelterC;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelWeather;
        private System.Windows.Forms.Label labelSuggestion;
        private System.Windows.Forms.Button button5;
    }
}