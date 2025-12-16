namespace SmartCamping
{
    partial class LightingForm
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
            this.Label_Conditions = new System.Windows.Forms.Label();
            this.Label_BrightnessFeedback = new System.Windows.Forms.Label();
            this.TrackBar_Brightness = new System.Windows.Forms.TrackBar();
            this.Button_ColorSelect = new System.Windows.Forms.Button();
            this.Button_Continue = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.Panel_ColorPreview = new System.Windows.Forms.Panel();
            this.ComboBox_Effect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Brightness)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Conditions
            // 
            this.Label_Conditions.AutoSize = true;
            this.Label_Conditions.Location = new System.Drawing.Point(253, 9);
            this.Label_Conditions.Name = "Label_Conditions";
            this.Label_Conditions.Size = new System.Drawing.Size(44, 16);
            this.Label_Conditions.TabIndex = 0;
            this.Label_Conditions.Text = "label1";
            // 
            // Label_BrightnessFeedback
            // 
            this.Label_BrightnessFeedback.AutoSize = true;
            this.Label_BrightnessFeedback.Location = new System.Drawing.Point(66, 193);
            this.Label_BrightnessFeedback.Name = "Label_BrightnessFeedback";
            this.Label_BrightnessFeedback.Size = new System.Drawing.Size(11, 16);
            this.Label_BrightnessFeedback.TabIndex = 1;
            this.Label_BrightnessFeedback.Text = "-";
            // 
            // TrackBar_Brightness
            // 
            this.TrackBar_Brightness.BackColor = System.Drawing.Color.IndianRed;
            this.TrackBar_Brightness.Location = new System.Drawing.Point(53, 134);
            this.TrackBar_Brightness.Maximum = 100;
            this.TrackBar_Brightness.Name = "TrackBar_Brightness";
            this.TrackBar_Brightness.Size = new System.Drawing.Size(104, 56);
            this.TrackBar_Brightness.TabIndex = 2;
            this.TrackBar_Brightness.TickFrequency = 2;
            this.TrackBar_Brightness.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.TrackBar_Brightness.Scroll += new System.EventHandler(this.TrackBar_Brightness_Scroll);
            // 
            // Button_ColorSelect
            // 
            this.Button_ColorSelect.BackColor = System.Drawing.Color.IndianRed;
            this.Button_ColorSelect.Location = new System.Drawing.Point(546, 135);
            this.Button_ColorSelect.Name = "Button_ColorSelect";
            this.Button_ColorSelect.Size = new System.Drawing.Size(75, 28);
            this.Button_ColorSelect.TabIndex = 3;
            this.Button_ColorSelect.Text = "Επιλογή";
            this.Button_ColorSelect.UseVisualStyleBackColor = false;
            this.Button_ColorSelect.Click += new System.EventHandler(this.Button_ColorSelect_Click);
            // 
            // Button_Continue
            // 
            this.Button_Continue.BackColor = System.Drawing.Color.IndianRed;
            this.Button_Continue.ForeColor = System.Drawing.Color.Black;
            this.Button_Continue.Location = new System.Drawing.Point(696, 193);
            this.Button_Continue.Name = "Button_Continue";
            this.Button_Continue.Size = new System.Drawing.Size(92, 51);
            this.Button_Continue.TabIndex = 4;
            this.Button_Continue.Text = "Συνέχεια";
            this.Button_Continue.UseVisualStyleBackColor = false;
            this.Button_Continue.Click += new System.EventHandler(this.Button_Continue_Click);
            // 
            // Panel_ColorPreview
            // 
            this.Panel_ColorPreview.Location = new System.Drawing.Point(477, 169);
            this.Panel_ColorPreview.Name = "Panel_ColorPreview";
            this.Panel_ColorPreview.Size = new System.Drawing.Size(200, 100);
            this.Panel_ColorPreview.TabIndex = 5;
            // 
            // ComboBox_Effect
            // 
            this.ComboBox_Effect.BackColor = System.Drawing.Color.IndianRed;
            this.ComboBox_Effect.FormattingEnabled = true;
            this.ComboBox_Effect.Location = new System.Drawing.Point(290, 134);
            this.ComboBox_Effect.Name = "ComboBox_Effect";
            this.ComboBox_Effect.Size = new System.Drawing.Size(121, 24);
            this.ComboBox_Effect.TabIndex = 6;
            this.ComboBox_Effect.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Effect_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ρύθμιση Φωτισμού";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.IndianRed;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(64, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ένταση";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.IndianRed;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(548, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Χρώμα";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.IndianRed;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(321, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Εφέ";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.IndianRed;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(758, 406);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 32);
            this.button5.TabIndex = 11;
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // LightingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBox_Effect);
            this.Controls.Add(this.Panel_ColorPreview);
            this.Controls.Add(this.Button_Continue);
            this.Controls.Add(this.Button_ColorSelect);
            this.Controls.Add(this.TrackBar_Brightness);
            this.Controls.Add(this.Label_BrightnessFeedback);
            this.Controls.Add(this.Label_Conditions);
            this.Name = "LightingForm";
            this.Text = "LightingForm";
            this.Load += new System.EventHandler(this.LightingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_Brightness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Conditions;
        private System.Windows.Forms.Label Label_BrightnessFeedback;
        private System.Windows.Forms.TrackBar TrackBar_Brightness;
        private System.Windows.Forms.Button Button_ColorSelect;
        private System.Windows.Forms.Button Button_Continue;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Panel Panel_ColorPreview;
        private System.Windows.Forms.ComboBox ComboBox_Effect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
    }
}