namespace TaxaaOpgave
{
    partial class Form1
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
            this.StartPoint = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Destination = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Distance = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.NatteTime = new System.Windows.Forms.CheckBox();
            this.DagTime = new System.Windows.Forms.CheckBox();
            this.BeregnPris = new System.Windows.Forms.Button();
            this.ForventetPris = new System.Windows.Forms.Label();
            this.AabenGoogleMaps = new System.Windows.Forms.Button();
            this.storeVogne = new System.Windows.Forms.CheckBox();
            this.AntalafPassagere = new System.Windows.Forms.Label();
            this.numericUpDownPassagere = new System.Windows.Forms.NumericUpDown();
            this.Duration = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPassagere)).BeginInit();
            this.SuspendLayout();
            // 
            // StartPoint
            // 
            this.StartPoint.AutoSize = true;
            this.StartPoint.Location = new System.Drawing.Point(12, 12);
            this.StartPoint.Name = "StartPoint";
            this.StartPoint.Size = new System.Drawing.Size(56, 13);
            this.StartPoint.TabIndex = 1;
            this.StartPoint.Text = "StartPoint:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Destination
            // 
            this.Destination.AutoSize = true;
            this.Destination.Location = new System.Drawing.Point(12, 36);
            this.Destination.Name = "Destination";
            this.Destination.Size = new System.Drawing.Size(63, 13);
            this.Destination.TabIndex = 3;
            this.Destination.Text = "Destination:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(74, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // Distance
            // 
            this.Distance.AutoSize = true;
            this.Distance.Location = new System.Drawing.Point(16, 63);
            this.Distance.Name = "Distance";
            this.Distance.Size = new System.Drawing.Size(52, 13);
            this.Distance.TabIndex = 5;
            this.Distance.Text = "Distance:";
            this.Distance.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(74, 63);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // NatteTime
            // 
            this.NatteTime.AutoSize = true;
            this.NatteTime.Location = new System.Drawing.Point(74, 86);
            this.NatteTime.Name = "NatteTime";
            this.NatteTime.Size = new System.Drawing.Size(75, 17);
            this.NatteTime.TabIndex = 7;
            this.NatteTime.Text = "NatteTime";
            this.NatteTime.UseVisualStyleBackColor = true;
            // 
            // DagTime
            // 
            this.DagTime.AutoSize = true;
            this.DagTime.Location = new System.Drawing.Point(74, 109);
            this.DagTime.Name = "DagTime";
            this.DagTime.Size = new System.Drawing.Size(69, 17);
            this.DagTime.TabIndex = 8;
            this.DagTime.Text = "DagTime";
            this.DagTime.UseVisualStyleBackColor = true;
            // 
            // BeregnPris
            // 
            this.BeregnPris.Location = new System.Drawing.Point(74, 178);
            this.BeregnPris.Name = "BeregnPris";
            this.BeregnPris.Size = new System.Drawing.Size(75, 23);
            this.BeregnPris.TabIndex = 9;
            this.BeregnPris.Text = "Beregn Pris";
            this.BeregnPris.UseVisualStyleBackColor = true;
            this.BeregnPris.Click += new System.EventHandler(this.button1_Click);
            // 
            // ForventetPris
            // 
            this.ForventetPris.AutoSize = true;
            this.ForventetPris.Location = new System.Drawing.Point(2, 205);
            this.ForventetPris.Name = "ForventetPris";
            this.ForventetPris.Size = new System.Drawing.Size(72, 13);
            this.ForventetPris.TabIndex = 10;
            this.ForventetPris.Text = "ForventetPris:";
            // 
            // AabenGoogleMaps
            // 
            this.AabenGoogleMaps.Location = new System.Drawing.Point(74, 221);
            this.AabenGoogleMaps.Name = "AabenGoogleMaps";
            this.AabenGoogleMaps.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AabenGoogleMaps.Size = new System.Drawing.Size(112, 23);
            this.AabenGoogleMaps.TabIndex = 11;
            this.AabenGoogleMaps.Text = "Aaben Google Maps";
            this.AabenGoogleMaps.UseVisualStyleBackColor = true;
            this.AabenGoogleMaps.Click += new System.EventHandler(this.button2_Click);
            // 
            // storeVogne
            // 
            this.storeVogne.AutoSize = true;
            this.storeVogne.Location = new System.Drawing.Point(74, 132);
            this.storeVogne.Name = "storeVogne";
            this.storeVogne.Size = new System.Drawing.Size(80, 17);
            this.storeVogne.TabIndex = 12;
            this.storeVogne.Text = "storeVogne";
            this.storeVogne.UseVisualStyleBackColor = true;
            // 
            // AntalafPassagere
            // 
            this.AntalafPassagere.AutoSize = true;
            this.AntalafPassagere.Location = new System.Drawing.Point(0, 152);
            this.AntalafPassagere.Name = "AntalafPassagere";
            this.AntalafPassagere.Size = new System.Drawing.Size(90, 13);
            this.AntalafPassagere.TabIndex = 13;
            this.AntalafPassagere.Text = "AntalafPassagere";
            // 
            // numericUpDownPassagere
            // 
            this.numericUpDownPassagere.Location = new System.Drawing.Point(86, 152);
            this.numericUpDownPassagere.Name = "numericUpDownPassagere";
            this.numericUpDownPassagere.Size = new System.Drawing.Size(121, 20);
            this.numericUpDownPassagere.TabIndex = 14;
            // 
            // Duration
            // 
            this.Duration.AutoSize = true;
            this.Duration.Location = new System.Drawing.Point(180, 12);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(94, 13);
            this.Duration.TabIndex = 16;
            this.Duration.Text = "varighed (minutter)";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(280, 9);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Duration);
            this.Controls.Add(this.numericUpDownPassagere);
            this.Controls.Add(this.AntalafPassagere);
            this.Controls.Add(this.storeVogne);
            this.Controls.Add(this.AabenGoogleMaps);
            this.Controls.Add(this.ForventetPris);
            this.Controls.Add(this.BeregnPris);
            this.Controls.Add(this.DagTime);
            this.Controls.Add(this.NatteTime);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Distance);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Destination);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.StartPoint);
            this.Name = "Form1";
            this.Text = "Taxa";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPassagere)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StartPoint;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Destination;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Distance;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox NatteTime;
        private System.Windows.Forms.CheckBox DagTime;
        private System.Windows.Forms.Button BeregnPris;
        private System.Windows.Forms.Label ForventetPris;
        private System.Windows.Forms.Button AabenGoogleMaps;
        private System.Windows.Forms.CheckBox storeVogne;
        private System.Windows.Forms.Label AntalafPassagere;
        private System.Windows.Forms.NumericUpDown numericUpDownPassagere;
        private System.Windows.Forms.Label Duration;
        private System.Windows.Forms.TextBox textBox4;
    }
}

