namespace CuicaRacingDashboard
{
    partial class SessionLaps
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridLapView = new System.Windows.Forms.DataGridView();
            this.ColumnLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullLapTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiffColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLapView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridLapView
            // 
            this.dataGridLapView.AllowUserToAddRows = false;
            this.dataGridLapView.AllowUserToDeleteRows = false;
            this.dataGridLapView.AllowUserToResizeRows = false;
            this.dataGridLapView.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridLapView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLapView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnLap,
            this.FullLapTimeColumn,
            this.DiffColumn});
            this.dataGridLapView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridLapView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridLapView.Location = new System.Drawing.Point(0, 0);
            this.dataGridLapView.MultiSelect = false;
            this.dataGridLapView.Name = "dataGridLapView";
            this.dataGridLapView.RowHeadersVisible = false;
            this.dataGridLapView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.dataGridLapView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridLapView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridLapView.ShowEditingIcon = false;
            this.dataGridLapView.Size = new System.Drawing.Size(237, 181);
            this.dataGridLapView.TabIndex = 3;
            this.dataGridLapView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridLapView_CellPainting);
            // 
            // ColumnLap
            // 
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ColumnLap.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnLap.HeaderText = "#Lap";
            this.ColumnLap.Name = "ColumnLap";
            this.ColumnLap.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnLap.Width = 50;
            // 
            // FullLapTimeColumn
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.FullLapTimeColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.FullLapTimeColumn.HeaderText = "Full";
            this.FullLapTimeColumn.Name = "FullLapTimeColumn";
            // 
            // DiffColumn
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.DiffColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.DiffColumn.HeaderText = "Difference";
            this.DiffColumn.Name = "DiffColumn";
            // 
            // SessionLaps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridLapView);
            this.Name = "SessionLaps";
            this.Size = new System.Drawing.Size(237, 181);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLapView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridLapView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullLapTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiffColumn;
    }
}
