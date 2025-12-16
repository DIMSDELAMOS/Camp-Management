using System.Runtime.CompilerServices;

namespace SmartCamping
{
    partial class PegsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PegsForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label_Angle = new System.Windows.Forms.Label();
            this.Track_Angle = new System.Windows.Forms.TrackBar();
            this.Label_AngleFeedback = new System.Windows.Forms.Label();
            this.Track_Pressure = new System.Windows.Forms.TrackBar();
            this.Label_Pressure = new System.Windows.Forms.Label();
            this.Label_PressureFeedback = new System.Windows.Forms.Label();
            this.Button_Next = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Track_Angle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Track_Pressure)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(803, 449);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Label_Angle
            // 
            this.Label_Angle.AutoSize = true;
            this.Label_Angle.BackColor = System.Drawing.Color.IndianRed;
            this.Label_Angle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Label_Angle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_Angle.Location = new System.Drawing.Point(12, 26);
            this.Label_Angle.Name = "Label_Angle";
            this.Label_Angle.Size = new System.Drawing.Size(128, 20);
            this.Label_Angle.TabIndex = 1;
            this.Label_Angle.Text = "Ρύθμιση Γωνίας";
            // 
            // Track_Angle
            // 
            this.Track_Angle.BackColor = System.Drawing.Color.IndianRed;
            this.Track_Angle.Location = new System.Drawing.Point(147, 12);
            this.Track_Angle.Maximum = 90;
            this.Track_Angle.Name = "Track_Angle";
            this.Track_Angle.Size = new System.Drawing.Size(144, 56);
            this.Track_Angle.TabIndex = 2;
            this.Track_Angle.TickFrequency = 2;
            this.Track_Angle.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.Track_Angle.Scroll += new System.EventHandler(this.Track_Angle_Scroll);
            // 
            // Label_AngleFeedback
            // 
            this.Label_AngleFeedback.AutoSize = true;
            this.Label_AngleFeedback.BackColor = System.Drawing.Color.IndianRed;
            this.Label_AngleFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Label_AngleFeedback.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_AngleFeedback.Location = new System.Drawing.Point(288, 26);
            this.Label_AngleFeedback.Name = "Label_AngleFeedback";
            this.Label_AngleFeedback.Size = new System.Drawing.Size(0, 20);
            this.Label_AngleFeedback.TabIndex = 3;
            // 
            // Track_Pressure
            // 
            this.Track_Pressure.BackColor = System.Drawing.Color.IndianRed;
            this.Track_Pressure.Location = new System.Drawing.Point(147, 370);
            this.Track_Pressure.Maximum = 100;
            this.Track_Pressure.Name = "Track_Pressure";
            this.Track_Pressure.Size = new System.Drawing.Size(144, 56);
            this.Track_Pressure.TabIndex = 5;
            this.Track_Pressure.TickFrequency = 2;
            this.Track_Pressure.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.Track_Pressure.Scroll += new System.EventHandler(this.Track_Pressure_Scroll);
            // 
            // Label_Pressure
            // 
            this.Label_Pressure.AutoSize = true;
            this.Label_Pressure.BackColor = System.Drawing.Color.IndianRed;
            this.Label_Pressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Label_Pressure.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_Pressure.Location = new System.Drawing.Point(12, 380);
            this.Label_Pressure.Name = "Label_Pressure";
            this.Label_Pressure.Size = new System.Drawing.Size(128, 20);
            this.Label_Pressure.TabIndex = 6;
            this.Label_Pressure.Text = "Ρύθμιση Πίεσης";
            this.Label_Pressure.Click += new System.EventHandler(this.label1_Click);
            // 
            // Label_PressureFeedback
            // 
            this.Label_PressureFeedback.AutoSize = true;
            this.Label_PressureFeedback.BackColor = System.Drawing.Color.IndianRed;
            this.Label_PressureFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Label_PressureFeedback.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_PressureFeedback.Location = new System.Drawing.Point(288, 382);
            this.Label_PressureFeedback.Name = "Label_PressureFeedback";
            this.Label_PressureFeedback.Size = new System.Drawing.Size(0, 20);
            this.Label_PressureFeedback.TabIndex = 7;
            // 
            // Button_Next
            // 
            this.Button_Next.BackColor = System.Drawing.Color.IndianRed;
            this.Button_Next.ForeColor = System.Drawing.Color.Black;
            this.Button_Next.Location = new System.Drawing.Point(690, 181);
            this.Button_Next.Name = "Button_Next";
            this.Button_Next.Size = new System.Drawing.Size(88, 59);
            this.Button_Next.TabIndex = 8;
            this.Button_Next.Text = "Συνέχεια";
            this.Button_Next.UseVisualStyleBackColor = false;
            this.Button_Next.Click += new System.EventHandler(this.Button_Next_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.IndianRed;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(758, 406);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 32);
            this.button5.TabIndex = 9;
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // PegsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Button_Next);
            this.Controls.Add(this.Label_PressureFeedback);
            this.Controls.Add(this.Label_Pressure);
            this.Controls.Add(this.Track_Pressure);
            this.Controls.Add(this.Label_AngleFeedback);
            this.Controls.Add(this.Track_Angle);
            this.Controls.Add(this.Label_Angle);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "PegsForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.PegsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Track_Angle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Track_Pressure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Label_Angle;
        private System.Windows.Forms.TrackBar Track_Angle;
        private System.Windows.Forms.Label Label_AngleFeedback;
        private System.Windows.Forms.TrackBar Track_Pressure;
        private System.Windows.Forms.Label Label_Pressure;
        private System.Windows.Forms.Label Label_PressureFeedback;
        private System.Windows.Forms.Button Button_Next;
        private System.Windows.Forms.Button button5;
    }
}