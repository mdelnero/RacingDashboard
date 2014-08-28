using System.Linq;
using System.Windows.Forms;

namespace CuicaRacingDashboard
{
    public partial class SessionDashboard : UserControl
    {
        /// <summary>
        /// The Current Session.
        /// </summary>
        private Session session;

        /// <summary>
        /// Class COnstructor.
        /// </summary>
        public SessionDashboard()
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

            Reset();

            if (session.Laps.Count() > 0)
            {
                labelLapsValue.Text = session.Laps.Count().ToString();

                labelBestValue.Text = Util.FormatTime(session.GetBestLap().LapTime);

                labelLastValue.Text = Util.FormatTime(session.GetLastLap().LapTime);
            }
        }

        /// <summary>
        /// Reset Dashboard.
        /// </summary>
        private void Reset()
        {
            labelLapsValue.Text = "0";
            labelBestValue.Text = "00:00.000";
            labelLastValue.Text = "00:00.000";
        }

        /// <summary>
        /// New Session Lap Event.
        /// </summary>
        private void OnNewLap(object sender, NewLapEventArgs args)
        {
            labelLapsValue.Text = session.Laps.Count().ToString();

            labelBestValue.Text = Util.FormatTime(session.GetBestLap().LapTime);

            labelLastValue.Text = Util.FormatTime(session.GetBestLap().LapTime);
        }
    }    
}
