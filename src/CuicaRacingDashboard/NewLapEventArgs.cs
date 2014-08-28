namespace CuicaRacingDashboard
{
    using System;

    public class NewLapEventArgs : EventArgs
    {
        private Lap lap;

        public Lap Lap
        {
            get { return lap; }
        }

        public NewLapEventArgs(Lap lap)
        {
            this.lap = lap;
        }
    }
}
