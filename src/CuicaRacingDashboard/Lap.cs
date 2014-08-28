namespace CuicaRacingDashboard
{
    /// <summary>
    /// Lap Class.
    /// </summary>
    public class Lap
    {
        /// <summary>
        /// Lap Number.
        /// </summary>
        private int lapNumber = 0;

        /// <summary>
        /// Gets Lap Number.
        /// </summary>
        public int LapNumber
        {
            get { return lapNumber; }
        }

        /// <summary>
        /// Lap Time.
        /// </summary>
        private ulong lapTime = 0;

        /// <summary>
        /// Gets Lap Time (ms).
        /// </summary>
        public ulong LapTime
        {
            get { return lapTime; }
        }

        /// <summary>
        /// Difference from previous lap (ms).
        /// </summary>
        private long differenceFromPrevious = 0;

        /// <summary>
        /// Gets difference from previous lap (ms).
        /// </summary>
        public long DifferenceFromPrevious
        {
            get { return differenceFromPrevious; }
        }

        /// <summary>
        /// Class Constructor.
        /// </summary>
        /// <param name="lapNumber">Lap Number.</param>
        /// <param name="lapTime">Lap Time.</param>
        public Lap(int lapNumber, ulong lapTime)
        {
            this.lapNumber = lapNumber;
            this.lapTime = lapTime;
        }

        /// <summary>
        /// Class Constructor.
        /// </summary>
        /// <param name="lapNumber">Lap Number.</param>
        /// <param name="lapTime">Lap Time.</param>
        /// <param name="previousLap">Previous Lap.</param>
        public Lap(int lapNumber, ulong lapTime, Lap previousLap)
        {
            this.lapNumber = lapNumber;
            this.lapTime = lapTime;

            SetPreviousLap(previousLap);
        }

        /// <summary>
        /// Calculate Difference From Previous Lap.
        /// </summary>
        /// <param name="previousLap">Previous Lap.</param>
        public void SetPreviousLap(Lap previousLap)
        {
            differenceFromPrevious = (long)(lapTime - previousLap.lapTime);
        }

        /// <summary>
        /// Get Lap as grid objects.
        /// </summary>
        /// <returns>grid objects</returns>
        public object[] GetFormatedGrid()
        {
            string signal = differenceFromPrevious < 0 ? "-" : differenceFromPrevious == 0 ? "" : "+";

            object[] result = new object[3];

            result[0] = lapNumber;
            result[1] = Util.FormatTime(lapTime);
            result[2] = signal + Util.FormatTime(differenceFromPrevious);

            return result;
        }
    }
}
