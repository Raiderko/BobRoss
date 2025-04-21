namespace BobRoss
{
    partial class SineConstructor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SineConstructor));
            this.AngBox = new System.Windows.Forms.TextBox();
            this.FreqBox = new System.Windows.Forms.TextBox();
            this.AmpBox = new System.Windows.Forms.TextBox();
            this.AngleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AngBox
            // 
            this.AngBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.AngBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AngBox.Location = new System.Drawing.Point(121, 32);
            this.AngBox.Name = "AngBox";
            this.AngBox.Size = new System.Drawing.Size(100, 20);
            this.AngBox.TabIndex = 0;
            this.AngBox.Text = "0.0";
            this.AngBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FreqBox
            // 
            this.FreqBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.FreqBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FreqBox.Location = new System.Drawing.Point(121, 80);
            this.FreqBox.Name = "FreqBox";
            this.FreqBox.Size = new System.Drawing.Size(100, 20);
            this.FreqBox.TabIndex = 1;
            this.FreqBox.Text = "0.0";
            this.FreqBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AmpBox
            // 
            this.AmpBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.AmpBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AmpBox.Location = new System.Drawing.Point(121, 127);
            this.AmpBox.Name = "AmpBox";
            this.AmpBox.Size = new System.Drawing.Size(100, 20);
            this.AmpBox.TabIndex = 2;
            this.AmpBox.Text = "0.0";
            this.AmpBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AngleLabel
            // 
            this.AngleLabel.AutoSize = true;
            this.AngleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AngleLabel.Location = new System.Drawing.Point(64, 33);
            this.AngleLabel.Name = "AngleLabel";
            this.AngleLabel.Size = new System.Drawing.Size(51, 16);
            this.AngleLabel.TabIndex = 3;
            this.AngleLabel.Text = "Angle:";
            this.AngleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Frequency (f):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Amplitude (t):";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(90, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 24);
            this.button1.TabIndex = 6;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SineConstructor
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 200);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AngleLabel);
            this.Controls.Add(this.AmpBox);
            this.Controls.Add(this.FreqBox);
            this.Controls.Add(this.AngBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SineConstructor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SineConstructor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label AngleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox AngBox;
        public System.Windows.Forms.TextBox FreqBox;
        public System.Windows.Forms.TextBox AmpBox;
        public System.Windows.Forms.Button button1;
    }
}