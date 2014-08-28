namespace CuicaRacingDashboard
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.splitContainerLaps = new System.Windows.Forms.SplitContainer();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionGraph = new CuicaRacingDashboard.SessionGraph();
            this.sessionDashboard = new CuicaRacingDashboard.SessionDashboard();
            this.sessionLaps = new CuicaRacingDashboard.SessionLaps();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLaps)).BeginInit();
            this.splitContainerLaps.Panel1.SuspendLayout();
            this.splitContainerLaps.Panel2.SuspendLayout();
            this.splitContainerLaps.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(891, 24);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSessionToolStripMenuItem,
            this.openSessionToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newSessionToolStripMenuItem
            // 
            this.newSessionToolStripMenuItem.Enabled = false;
            this.newSessionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newSessionToolStripMenuItem.Image")));
            this.newSessionToolStripMenuItem.Name = "newSessionToolStripMenuItem";
            this.newSessionToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.newSessionToolStripMenuItem.Text = "New Session";
            this.newSessionToolStripMenuItem.Click += new System.EventHandler(this.newSessionToolStripMenuItem_Click);
            // 
            // openSessionToolStripMenuItem
            // 
            this.openSessionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openSessionToolStripMenuItem.Image")));
            this.openSessionToolStripMenuItem.Name = "openSessionToolStripMenuItem";
            this.openSessionToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.openSessionToolStripMenuItem.Text = "Open Session...";
            this.openSessionToolStripMenuItem.Click += new System.EventHandler(this.openSessionToolStripMenuItem_Click);
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 24);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.sessionGraph);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.splitContainerLaps);
            this.splitContainerMain.Size = new System.Drawing.Size(891, 624);
            this.splitContainerMain.SplitterDistance = 321;
            this.splitContainerMain.TabIndex = 2;
            // 
            // splitContainerLaps
            // 
            this.splitContainerLaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLaps.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerLaps.Location = new System.Drawing.Point(0, 0);
            this.splitContainerLaps.Name = "splitContainerLaps";
            // 
            // splitContainerLaps.Panel1
            // 
            this.splitContainerLaps.Panel1.Controls.Add(this.sessionDashboard);
            // 
            // splitContainerLaps.Panel2
            // 
            this.splitContainerLaps.Panel2.Controls.Add(this.sessionLaps);
            this.splitContainerLaps.Size = new System.Drawing.Size(891, 299);
            this.splitContainerLaps.SplitterDistance = 204;
            this.splitContainerLaps.TabIndex = 2;
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // sessionGraph
            // 
            this.sessionGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sessionGraph.Location = new System.Drawing.Point(0, 0);
            this.sessionGraph.Name = "sessionGraph";
            this.sessionGraph.Size = new System.Drawing.Size(891, 321);
            this.sessionGraph.TabIndex = 0;
            // 
            // sessionDashboard
            // 
            this.sessionDashboard.BackColor = System.Drawing.Color.Black;
            this.sessionDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sessionDashboard.Location = new System.Drawing.Point(0, 0);
            this.sessionDashboard.Name = "sessionDashboard";
            this.sessionDashboard.Size = new System.Drawing.Size(204, 299);
            this.sessionDashboard.TabIndex = 0;
            // 
            // sessionLaps
            // 
            this.sessionLaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sessionLaps.Location = new System.Drawing.Point(0, 0);
            this.sessionLaps.Name = "sessionLaps";
            this.sessionLaps.Size = new System.Drawing.Size(683, 299);
            this.sessionLaps.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(891, 648);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuíca Racing Dashboard";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.splitContainerLaps.Panel1.ResumeLayout(false);
            this.splitContainerLaps.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLaps)).EndInit();
            this.splitContainerLaps.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSessionToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.ToolStripMenuItem newSessionToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainerLaps;
        private SessionDashboard sessionDashboard;
        private SessionGraph sessionGraph;
        private SessionLaps sessionLaps;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

