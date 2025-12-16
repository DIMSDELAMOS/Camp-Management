namespace SmartCamping
{
    partial class OrderForm
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
            this.btnOrder = new System.Windows.Forms.Button();
            this.ButtonReturn = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboItem = new System.Windows.Forms.ComboBox();
            this.comboTime = new System.Windows.Forms.ComboBox();
            this.checkPayNow = new System.Windows.Forms.CheckBox();
            this.checkAddToAccount = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.IndianRed;
            this.btnOrder.Location = new System.Drawing.Point(288, 286);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(106, 49);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "Καταχώρηση";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // ButtonReturn
            // 
            this.ButtonReturn.BackColor = System.Drawing.Color.IndianRed;
            this.ButtonReturn.Location = new System.Drawing.Point(695, 184);
            this.ButtonReturn.Name = "ButtonReturn";
            this.ButtonReturn.Size = new System.Drawing.Size(93, 54);
            this.ButtonReturn.TabIndex = 1;
            this.ButtonReturn.Text = "Επιστροφή";
            this.ButtonReturn.UseVisualStyleBackColor = false;
            this.ButtonReturn.Click += new System.EventHandler(this.ButtonReturn_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelTitle.Location = new System.Drawing.Point(232, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(274, 25);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Καταχώρηση Παραγγελίας";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelStatus.Location = new System.Drawing.Point(158, 373);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 20);
            this.labelStatus.TabIndex = 3;
            // 
            // comboItem
            // 
            this.comboItem.FormattingEnabled = true;
            this.comboItem.Items.AddRange(new object[] {
            "Καφές",
            "Πρωινό",
            "Γεύμα",
            "Χορτοφαγικό Γεύμα",
            "Ποτό"});
            this.comboItem.Location = new System.Drawing.Point(134, 101);
            this.comboItem.Name = "comboItem";
            this.comboItem.Size = new System.Drawing.Size(177, 24);
            this.comboItem.TabIndex = 4;
            this.comboItem.Text = "Είδος";
            // 
            // comboTime
            // 
            this.comboTime.FormattingEnabled = true;
            this.comboTime.Items.AddRange(new object[] {
            "08:00",
            "09:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00"});
            this.comboTime.Location = new System.Drawing.Point(395, 101);
            this.comboTime.Name = "comboTime";
            this.comboTime.Size = new System.Drawing.Size(177, 24);
            this.comboTime.TabIndex = 5;
            this.comboTime.Text = "Ώρα";
            // 
            // checkPayNow
            // 
            this.checkPayNow.AutoSize = true;
            this.checkPayNow.Location = new System.Drawing.Point(162, 202);
            this.checkPayNow.Name = "checkPayNow";
            this.checkPayNow.Size = new System.Drawing.Size(117, 20);
            this.checkPayNow.TabIndex = 6;
            this.checkPayNow.Text = "Πληρωμή τώρα";
            this.checkPayNow.UseVisualStyleBackColor = true;
            // 
            // checkAddToAccount
            // 
            this.checkAddToAccount.AutoSize = true;
            this.checkAddToAccount.Location = new System.Drawing.Point(395, 202);
            this.checkAddToAccount.Name = "checkAddToAccount";
            this.checkAddToAccount.Size = new System.Drawing.Size(198, 20);
            this.checkAddToAccount.TabIndex = 7;
            this.checkAddToAccount.Text = "Προσθήκη στον λογαριασμό";
            this.checkAddToAccount.UseVisualStyleBackColor = true;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkAddToAccount);
            this.Controls.Add(this.checkPayNow);
            this.Controls.Add(this.comboTime);
            this.Controls.Add(this.comboItem);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.ButtonReturn);
            this.Controls.Add(this.btnOrder);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button ButtonReturn;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox comboItem;
        private System.Windows.Forms.ComboBox comboTime;
        private System.Windows.Forms.CheckBox checkPayNow;
        private System.Windows.Forms.CheckBox checkAddToAccount;
    }
}