namespace CuicaRacingDashboard
{
    partial class SessionDashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelLaps = new System.Windows.Forms.Label();
            this.labelBest = new System.Windows.Forms.Label();
            this.labelLapsValue = new System.Windows.Forms.Label();
            this.labelBestValue = new System.Windows.Forms.Label();
            this.labelLastValue = new System.Windows.Forms.Label();
            this.labelLast = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLaps
            // 
            this.labelLaps.AutoSize = true;
            this.labelLaps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLaps.ForeColor = System.Drawing.Color.LawnGreen;
            this.labelLaps.Location = new System.Drawing.Point(23, 27);
            this.labelLaps.Name = "labelLaps";
            this.labelLaps.Size = new System.Drawing.Size(38, 13);
            this.labelLaps.TabIndex = 0;
            this.labelLaps.Text = "Laps:";
            // 
            // labelBest
            // 
            this.labelBest.AutoSize = true;
            this.labelBest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBest.ForeColor = System.Drawing.Color.LawnGreen;
            this.labelBest.Location = new System.Drawing.Point(23, 73);
            this.labelBest.Name = "labelBest";
            this.labelBest.Size = new System.Drawing.Size(36, 13);
            this.labelBest.TabIndex = 1;
            this.labelBest.Text = "Best:";
            // 
            // labelLapsValue
            // 
            this.labelLapsValue.AutoSize = true;
            this.labelLapsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLapsValue.ForeColor = System.Drawing.Color.LawnGreen;
            this.labelLapsValue.Location = new System.Drawing.Point(82, 22);
            this.labelLapsValue.Name = "labelLapsValue";
            this.labelLapsValue.Size = new System.Drawing.Size(19, 20);
            this.labelLapsValue.TabIndex = 3;
            this.labelLapsValue.Text = "0";
            // 
            // labelBestValue
            // 
            this.labelBestValue.AutoSize = true;
            this.labelBestValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBestValue.ForeColor = System.Drawing.Color.LawnGreen;
            this.labelBestValue.Location = new System.Drawing.Point(82, 68);
            this.labelBestValue.Name = "labelBestValue";
            this.labelBestValue.Size = new System.Drawing.Size(89, 20);
            this.labelBestValue.TabIndex = 4;
            this.labelBestValue.Text = "00:00.000";
            // 
            // labelLastValue
            // 
            this.labelLastValue.AutoSize = true;
            this.labelLastValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastValue.ForeColor = System.Drawing.Color.LawnGreen;
            this.labelLastValue.Location = new System.Drawing.Point(82, 115);
            this.labelLastValue.Name = "labelLastValue";
            this.labelLastValue.Size = new System.Drawing.Size(89, 20);
            this.labelLastValue.TabIndex = 6;
            this.labelLastValue.Text = "00:00.000";
            // 
            // labelLast
            // 
            this.labelLast.AutoSize = true;
            this.labelLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLast.ForeColor = System.Drawing.Color.LawnGreen;
            this.labelLast.Location = new System.Drawing.Point(23, 120);
            this.labelLast.Name = "labelLast";
            this.labelLast.Size = new System.Drawing.Size(35, 13);
            this.labelLast.TabIndex = 5;
            this.labelLast.Text = "Last:";
            // 
            // SessionDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.labelLastValue);
            this.Controls.Add(this.labelLast);
            this.Controls.Add(this.labelBestValue);
            this.Controls.Add(this.labelLapsValue);
            this.Controls.Add(this.labelBest);
            this.Controls.Add(this.labelLaps);
            this.Name = "SessionDashboard";
            this.Size = new System.Drawing.Size(303, 320);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLaps;
        private System.Windows.Forms.Label labelBest;
        private System.Windows.Forms.Label labelLapsValue;
        private System.Windows.Forms.Label labelBestValue;
        private System.Windows.Forms.Label labelLastValue;
        private System.Windows.Forms.Label labelLast;
    }
}
