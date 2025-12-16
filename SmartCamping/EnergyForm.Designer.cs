namespace SmartCamping
{
    partial class EnergyForm
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
            this.ProgressBar_Energy = new System.Windows.Forms.ProgressBar();
            this.Label_BatteryStatus = new System.Windows.Forms.Label();
            this.Label_SolarOutput = new System.Windows.Forms.Label();
            this.Label_Consumption = new System.Windows.Forms.Label();
            this.Label_Advice = new System.Windows.Forms.Label();
            this.Button_Next = new System.Windows.Forms.Button();
            this.Check_AC = new System.Windows.Forms.CheckBox();
            this.Check_Devices = new System.Windows.Forms.CheckBox();
            this.Check_Lights = new System.Windows.Forms.CheckBox();
            this.Label_Feedback = new System.Windows.Forms.Label();
            this.Check_Override = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProgressBar_Energy
            // 
            this.ProgressBar_Energy.Location = new System.Drawing.Point(44, 66);
            this.ProgressBar_Energy.Name = "ProgressBar_Energy";
            this.ProgressBar_Energy.Size = new System.Drawing.Size(100, 23);
            this.ProgressBar_Energy.TabIndex = 0;
            this.ProgressBar_Energy.Value = 75;
            // 
            // Label_BatteryStatus
            // 
            this.Label_BatteryStatus.AutoSize = true;
            this.Label_BatteryStatus.Location = new System.Drawing.Point(41, 103);
            this.Label_BatteryStatus.Name = "Label_BatteryStatus";
            this.Label_BatteryStatus.Size = new System.Drawing.Size(146, 32);
            this.Label_BatteryStatus.TabIndex = 1;
            this.Label_BatteryStatus.Text = "Στάθμη ενέργειας: 75%\n\n";
            // 
            // Label_SolarOutput
            // 
            this.Label_SolarOutput.AutoSize = true;
            this.Label_SolarOutput.Location = new System.Drawing.Point(41, 172);
            this.Label_SolarOutput.Name = "Label_SolarOutput";
            this.Label_SolarOutput.Size = new System.Drawing.Size(193, 16);
            this.Label_SolarOutput.TabIndex = 2;
            this.Label_SolarOutput.Text = "Απόδοση φωτοβολταϊκών: 82%";
            // 
            // Label_Consumption
            // 
            this.Label_Consumption.AutoSize = true;
            this.Label_Consumption.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Label_Consumption.Location = new System.Drawing.Point(41, 144);
            this.Label_Consumption.Name = "Label_Consumption";
            this.Label_Consumption.Size = new System.Drawing.Size(113, 16);
            this.Label_Consumption.TabIndex = 3;
            this.Label_Consumption.Text = "Κατανάλωση: 67%";
            // 
            // Label_Advice
            // 
            this.Label_Advice.AutoSize = true;
            this.Label_Advice.Location = new System.Drawing.Point(421, 73);
            this.Label_Advice.Name = "Label_Advice";
            this.Label_Advice.Size = new System.Drawing.Size(285, 16);
            this.Label_Advice.TabIndex = 4;
            this.Label_Advice.Text = "⚠ Χαμηλή ενέργεια - Συνιστάται εξοικονόμηση";
            this.Label_Advice.Click += new System.EventHandler(this.Label_Advice_Click);
            // 
            // Button_Next
            // 
            this.Button_Next.BackColor = System.Drawing.Color.IndianRed;
            this.Button_Next.Location = new System.Drawing.Point(680, 194);
            this.Button_Next.Name = "Button_Next";
            this.Button_Next.Size = new System.Drawing.Size(89, 54);
            this.Button_Next.TabIndex = 5;
            this.Button_Next.Text = "Συνέχεια";
            this.Button_Next.UseVisualStyleBackColor = false;
            this.Button_Next.Visible = false;
            this.Button_Next.Click += new System.EventHandler(this.Button_Next_Click);
            // 
            // Check_AC
            // 
            this.Check_AC.AutoSize = true;
            this.Check_AC.Location = new System.Drawing.Point(12, 304);
            this.Check_AC.Name = "Check_AC";
            this.Check_AC.Size = new System.Drawing.Size(209, 20);
            this.Check_AC.TabIndex = 6;
            this.Check_AC.Text = "Απενεργοποίηση Air Condition";
            this.Check_AC.UseVisualStyleBackColor = true;
            this.Check_AC.CheckedChanged += new System.EventHandler(this.Check_AC_CheckedChanged_1);
            // 
            // Check_Devices
            // 
            this.Check_Devices.AutoSize = true;
            this.Check_Devices.Location = new System.Drawing.Point(471, 304);
            this.Check_Devices.Name = "Check_Devices";
            this.Check_Devices.Size = new System.Drawing.Size(289, 20);
            this.Check_Devices.TabIndex = 7;
            this.Check_Devices.Text = "Απενεργοποίηση μη απαραίτητων συσκευών";
            this.Check_Devices.UseVisualStyleBackColor = true;
            this.Check_Devices.CheckedChanged += new System.EventHandler(this.Check_Devices_CheckedChanged);
            // 
            // Check_Lights
            // 
            this.Check_Lights.AutoSize = true;
            this.Check_Lights.Location = new System.Drawing.Point(249, 304);
            this.Check_Lights.Name = "Check_Lights";
            this.Check_Lights.Size = new System.Drawing.Size(186, 20);
            this.Check_Lights.TabIndex = 8;
            this.Check_Lights.Text = "Μείωση έντασης φωτισμού";
            this.Check_Lights.UseVisualStyleBackColor = true;
            this.Check_Lights.CheckedChanged += new System.EventHandler(this.Check_Lights_CheckedChanged_1);
            // 
            // Label_Feedback
            // 
            this.Label_Feedback.AutoSize = true;
            this.Label_Feedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Label_Feedback.Location = new System.Drawing.Point(12, 341);
            this.Label_Feedback.Name = "Label_Feedback";
            this.Label_Feedback.Size = new System.Drawing.Size(11, 15);
            this.Label_Feedback.TabIndex = 9;
            this.Label_Feedback.Text = "-";
            // 
            // Check_Override
            // 
            this.Check_Override.AutoSize = true;
            this.Check_Override.Location = new System.Drawing.Point(424, 168);
            this.Check_Override.Name = "Check_Override";
            this.Check_Override.Size = new System.Drawing.Size(305, 20);
            this.Check_Override.TabIndex = 10;
            this.Check_Override.Text = "Συνέχεια με δική μου ευθύνη (χαμηλή ενέργεια)";
            this.Check_Override.UseVisualStyleBackColor = true;
            this.Check_Override.Visible = false;
            this.Check_Override.CheckedChanged += new System.EventHandler(this.Check_Override_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(281, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Διαχείριση Ενέργειας";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.IndianRed;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(758, 406);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 32);
            this.button5.TabIndex = 12;
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // EnergyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Check_Override);
            this.Controls.Add(this.Label_Feedback);
            this.Controls.Add(this.Check_Lights);
            this.Controls.Add(this.Check_Devices);
            this.Controls.Add(this.Check_AC);
            this.Controls.Add(this.Button_Next);
            this.Controls.Add(this.Label_Advice);
            this.Controls.Add(this.Label_Consumption);
            this.Controls.Add(this.Label_SolarOutput);
            this.Controls.Add(this.Label_BatteryStatus);
            this.Controls.Add(this.ProgressBar_Energy);
            this.Name = "EnergyForm";
            this.Text = "EnergyForm";
            this.Load += new System.EventHandler(this.EnergyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar ProgressBar_Energy;
        private System.Windows.Forms.Label Label_BatteryStatus;
        private System.Windows.Forms.Label Label_SolarOutput;
        private System.Windows.Forms.Label Label_Consumption;
        private System.Windows.Forms.Label Label_Advice;
        private System.Windows.Forms.Button Button_Next;
        private System.Windows.Forms.CheckBox Check_AC;
        private System.Windows.Forms.CheckBox Check_Devices;
        private System.Windows.Forms.CheckBox Check_Lights;
        private System.Windows.Forms.Label Label_Feedback;
        private System.Windows.Forms.CheckBox Check_Override;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
    }
}