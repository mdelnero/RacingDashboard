using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CuicaRacingDashboard
{
    public partial class SessionLaps : UserControl
    {
        /// <summary>
        /// The Current Session.
        /// </summary>
        private Session session;

        /// <summary>
        /// Class Constructor.
        /// </summary>
        public SessionLaps()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the current Session.
        /// </summary>
        /// <param name="session">current Session.</param>
        public void SetSession(Session session)
        {
            this.session = session;
            session.NewLapEvent += this.OnNewLap;

            if (session.Laps.Count() > 0)
            {
                dataGridLapView.Rows.Clear();

                foreach (Lap lap in session.Laps)
                {
                    object[] data = lap.GetFormatedGrid();

                    dataGridLapView.Rows.Add(data);
                }
            }
        }

        /// <summary>
        /// New Session Lap Event.
        /// </summary>
        private void OnNewLap(object sender, NewLapEventArgs args)
        {
            object[] data = args.Lap.GetFormatedGrid();
            dataGridLapView.Rows.Add(data);

            dataGridLapView.Rows[dataGridLapView.Rows.Count-1].Selected = true;
        }

        /// <summary>
        /// Chose Grid Cells colors.
        /// </summary>
        private void dataGridLapView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Lap lap = this.session.Laps[e.RowIndex];

                DataGridViewCell cell = dataGridLapView[e.ColumnIndex, e.RowIndex];

                if (lap.LapNumber == session.GetBestLap().LapNumber)
                {
                    cell.Style.BackColor = Color.Blue;
                }
                else
                {
                    if (e.ColumnIndex != 2 || lap.DifferenceFromPrevious == 0)
                    {
                        cell.Style.BackColor = Color.Black;
                    }
                    else
                    {
                        if (lap.DifferenceFromPrevious < 0)
                        {
                            cell.Style.BackColor = Color.Green;
                        }
                        else if (lap.DifferenceFromPrevious > 0)
                        {
                            cell.Style.BackColor = Color.Red;
                        }
                    }
                }
            }
        }
    }
}
