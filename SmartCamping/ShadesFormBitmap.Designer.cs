namespace SmartCamping
{
    partial class ShadesFormBitmap
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
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.Label_Shade1 = new System.Windows.Forms.Label();
            this.Label_Shade2 = new System.Windows.Forms.Label();
            this.Label_Shade3 = new System.Windows.Forms.Label();
            this.Label_Weather = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCanvas.Location = new System.Drawing.Point(0, 0);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(800, 450);
            this.picCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.Click += new System.EventHandler(this.picCanvas_Click);
            this.picCanvas.DragDrop += new System.Windows.Forms.DragEventHandler(this.picCanvas_DragDrop);
            this.picCanvas.DragEnter += new System.Windows.Forms.DragEventHandler(this.picCanvas_DragEnter);
            // 
            // Label_Shade1
            // 
            this.Label_Shade1.AutoSize = true;
            this.Label_Shade1.Location = new System.Drawing.Point(12, 113);
            this.Label_Shade1.Name = "Label_Shade1";
            this.Label_Shade1.Size = new System.Drawing.Size(135, 16);
            this.Label_Shade1.TabIndex = 1;
            this.Label_Shade1.Text = "Πανί για δυτικό άνεμο";
            this.Label_Shade1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label_Shade1_MouseDown);
            // 
            // Label_Shade2
            // 
            this.Label_Shade2.AutoSize = true;
            this.Label_Shade2.Location = new System.Drawing.Point(618, 113);
            this.Label_Shade2.Name = "Label_Shade2";
            this.Label_Shade2.Size = new System.Drawing.Size(158, 16);
            this.Label_Shade2.TabIndex = 2;
            this.Label_Shade2.Text = "Πανί για ανατολικό άνεμο";
            this.Label_Shade2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label_Shade2_MouseDown_1);
            // 
            // Label_Shade3
            // 
            this.Label_Shade3.AutoSize = true;
            this.Label_Shade3.Location = new System.Drawing.Point(162, 363);
            this.Label_Shade3.Name = "Label_Shade3";
            this.Label_Shade3.Size = new System.Drawing.Size(93, 16);
            this.Label_Shade3.TabIndex = 3;
            this.Label_Shade3.Text = "Πανί για βροχή";
            this.Label_Shade3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label_Shade3_MouseDown_1);
            // 
            // Label_Weather
            // 
            this.Label_Weather.AutoSize = true;
            this.Label_Weather.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Label_Weather.Location = new System.Drawing.Point(12, 219);
            this.Label_Weather.Name = "Label_Weather";
            this.Label_Weather.Size = new System.Drawing.Size(23, 18);
            this.Label_Weather.TabIndex = 4;
            this.Label_Weather.Text = "---";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(704, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "Συνέχεια";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.IndianRed;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(758, 406);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 32);
            this.button5.TabIndex = 10;
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ShadesFormBitmap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Label_Weather);
            this.Controls.Add(this.Label_Shade3);
            this.Controls.Add(this.Label_Shade2);
            this.Controls.Add(this.Label_Shade1);
            this.Controls.Add(this.picCanvas);
            this.Name = "ShadesFormBitmap";
            this.Text = "ShadesFormBitmap";
            this.Load += new System.EventHandler(this.ShadesFormBitmap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label Label_Shade1;
        private System.Windows.Forms.Label Label_Shade2;
        private System.Windows.Forms.Label Label_Shade3;
        private System.Windows.Forms.Label Label_Weather;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
    }
}