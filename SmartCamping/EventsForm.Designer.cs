namespace SmartCamping
{
    partial class EventsForm
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.ButtonReturn = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelFeedback = new System.Windows.Forms.Label();
            this.listEvents = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.IndianRed;
            this.btnConfirm.Location = new System.Drawing.Point(277, 299);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(173, 49);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Δήλωση Συμμετοχής";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // ButtonReturn
            // 
            this.ButtonReturn.BackColor = System.Drawing.Color.IndianRed;
            this.ButtonReturn.Location = new System.Drawing.Point(661, 205);
            this.ButtonReturn.Name = "ButtonReturn";
            this.ButtonReturn.Size = new System.Drawing.Size(103, 57);
            this.ButtonReturn.TabIndex = 1;
            this.ButtonReturn.Text = "Επιστροφή";
            this.ButtonReturn.UseVisualStyleBackColor = false;
            this.ButtonReturn.Click += new System.EventHandler(this.ButtonReturn_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelTitle.Location = new System.Drawing.Point(249, 38);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(243, 25);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Διαθέσιμες Εκδηλώσεις";
            // 
            // labelFeedback
            // 
            this.labelFeedback.AutoSize = true;
            this.labelFeedback.Location = new System.Drawing.Point(182, 372);
            this.labelFeedback.Name = "labelFeedback";
            this.labelFeedback.Size = new System.Drawing.Size(0, 16);
            this.labelFeedback.TabIndex = 3;
            // 
            // listEvents
            // 
            this.listEvents.FormattingEnabled = true;
            this.listEvents.Location = new System.Drawing.Point(173, 137);
            this.listEvents.Name = "listEvents";
            this.listEvents.Size = new System.Drawing.Size(392, 140);
            this.listEvents.TabIndex = 4;
            // 
            // EventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listEvents);
            this.Controls.Add(this.labelFeedback);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.ButtonReturn);
            this.Controls.Add(this.btnConfirm);
            this.Name = "EventsForm";
            this.Text = "EventsForm";
            this.Load += new System.EventHandler(this.EventsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button ButtonReturn;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelFeedback;
        private System.Windows.Forms.CheckedListBox listEvents;
    }
}