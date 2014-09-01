using System;
using System.Windows.Forms;

namespace CuicaRacingDashboard
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// 
        /// </summary>
        private Session session;

        /// <summary>
        /// 
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="session"></param>
        private void LoadSession(Session session)
        {
            sessionLaps.SetSession(session);
            sessionDashboard.SetSession(session);
            sessionGraph.SetSession(session);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                session = Session.LoadFromFile(openFileDialog1.FileName);

                LoadSession(session);
            }            
        }

        private void newSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //session.AddLap(new Lap(session.Laps.Count() + 1, 48442));
        }

        private void bestLapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bestLapToolStripMenuItem.Checked = !bestLapToolStripMenuItem.Checked;

            sessionGraph.ShowBestLap = bestLapToolStripMenuItem.Checked;

        }

        private void meanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            meanToolStripMenuItem.Checked = !meanToolStripMenuItem.Checked;

            sessionGraph.ShowMean = meanToolStripMenuItem.Checked;
        }

        private void standardDeviationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            standardDeviationToolStripMenuItem.Checked = !standardDeviationToolStripMenuItem.Checked;

            sessionGraph.ShowStandardDeviation = standardDeviationToolStripMenuItem.Checked;
        }
    }
}
