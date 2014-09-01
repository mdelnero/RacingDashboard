namespace CuicaRacingDashboard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    /// <summary>
    /// Lap Session Class.
    /// </summary>
    public class Session
    {
        /// <summary>
        /// New Lap Event.
        /// </summary>
        public event EventHandler<NewLapEventArgs> NewLapEvent;

        /// <summary>
        /// Data Changed Event.
        /// </summary>
        public event EventHandler DataChangedEvent;

        /// <summary>
        /// Lap List.
        /// </summary>
        private List<Lap> laps = new List<Lap>();

        /// <summary>
        /// Get Session Laps.
        /// </summary>
        public IList<Lap> Laps
        {
            get { return laps; }
        }

        /// <summary>
        /// Get Session Laps.
        /// </summary>
        private IList<Lap> ThresholdLaps
        {
            get
            {
                ulong best = GetBestLap().LapTime + threshold;

                IList<Lap> result = new List<Lap>();

                foreach (Lap l in laps)
                {
                    if (l.LapTime < best)
                        result.Add(l);
                }

                return result;
            }
        }

        /// <summary>
        /// Statistical threshold.
        /// </summary>
        private ulong threshold = 3000;

        /// <summary>
        /// Gets or Sets Statistical threshold.
        /// </summary>
        public ulong Threshold
        {
            get { return threshold; }
            set
            {
                threshold = value;

                if (DataChangedEvent != null)
                {
                    DataChangedEvent(this, new EventArgs());
                }
            }
        }

        /// <summary>
        /// Session Name.
        /// </summary>
        private string sessionName;

        /// <summary>
        /// Gets Session Name.
        /// </summary>
        public string Name
        {
            get { return sessionName; }
            set { sessionName = value; }
        }

        /// <summary>
        /// Add given lap to session.
        /// </summary>
        /// <param name="lap">Lap to add.</param>
        public void AddLap(Lap lap)
        {
            if (laps.Count > 0)
            {
                lap.SetPreviousLap(laps.Last());
            }

            laps.Add(lap);

            if (NewLapEvent != null)
            {
                NewLapEvent(this, new NewLapEventArgs(lap));
            }
        }

        /// <summary>
        /// Gets the Session Best Lap.
        /// </summary>
        /// <returns>Session Best Lap.</returns>
        public Lap GetBestLap()
        {
            Lap resultLap = new Lap(0, ulong.MaxValue);

            foreach (Lap l in laps)
            {
                if (l.LapTime <= resultLap.LapTime)
                {
                    resultLap = l;
                }
            }

            return resultLap;
        }

        /// <summary>
        /// Gets the Session Worst Lap.
        /// </summary>
        /// <returns>Session Worst Lap.</returns>
        public Lap GetWorstLap()
        {
            Lap resultLap = new Lap(0, ulong.MinValue);

            foreach (Lap l in laps)
            {
                if (l.LapTime >= resultLap.LapTime)
                {
                    resultLap = l;
                }
            }

            return resultLap;
        }

        /// <summary>
        /// Gets the Session Last Lap.
        /// </summary>
        /// <returns>Session Last Lap.</returns>
        public Lap GetLastLap()
        {
            if (laps.Count == 0)
                return null;

            return laps.Last();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double GetMean()
        {
            double s = 0;
            int count = 0;

            foreach (Lap l in ThresholdLaps)
            {
                s += l.LapTime;
                count++;
            }

            return s / count;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double GetVariance()
        {
            double mean = GetMean();

            double variance = 0;

            foreach (Lap l in ThresholdLaps)
            {
                variance += Math.Pow((l.LapTime - mean), 2);
            }

            return variance / laps.Count;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double GetStandardDeviation()
        {
            return Math.Sqrt(GetVariance());
        }

        /// <summary>
        /// Load Session from file.
        /// </summary>
        public static Session LoadFromFile(string filename)
        {
            Session session = new Session();

            int lap = 1;

            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(filename);

                string line;

                while ((line = file.ReadLine()) != null)
                {
                    string ms = line.Substring(3, 6).Replace(".", string.Empty);
                    session.AddLap(new Lap(lap++, ulong.Parse(ms)));
                }

                file.Close();

                session.Name = Path.GetFileName(filename);
            }
            catch
            {
                session = null;
            }

            //session.AddLap(new Lap(lap++, 53349));
            //session.AddLap(new Lap(lap++, 54474));
            //session.AddLap(new Lap(lap++, 50264));
            //session.AddLap(new Lap(lap++, 49873));
            //session.AddLap(new Lap(lap++, 50442));
            //session.AddLap(new Lap(lap++, 50563));
            //session.AddLap(new Lap(lap++, 51231));
            //session.AddLap(new Lap(lap++, 50494));
            //session.AddLap(new Lap(lap++, 50300));
            //session.AddLap(new Lap(lap++, 50181));
            //session.AddLap(new Lap(lap++, 50715));
            //session.AddLap(new Lap(lap++, 50807));
            //session.AddLap(new Lap(lap++, 50491));
            //session.AddLap(new Lap(lap++, 50405));
            //session.AddLap(new Lap(lap++, 50411));
            //session.AddLap(new Lap(lap++, 50392));
            //session.AddLap(new Lap(lap++, 53374));
            //session.AddLap(new Lap(lap++, 55590));
            //session.AddLap(new Lap(lap++, 51322));
            //session.AddLap(new Lap(lap++, 51217));
            //session.AddLap(new Lap(lap++, 50812));
            //session.AddLap(new Lap(lap++, 50214));
            //session.AddLap(new Lap(lap++, 50838));
            //session.AddLap(new Lap(lap++, 50698));
            //session.AddLap(new Lap(lap++, 50199));
            //session.AddLap(new Lap(lap++, 50105));
            //session.AddLap(new Lap(lap++, 50825));
            //session.AddLap(new Lap(lap++, 50710));
            //session.AddLap(new Lap(lap++, 50320));
            //session.AddLap(new Lap(lap++, 50728));
            //session.AddLap(new Lap(lap++, 50736));
            //session.AddLap(new Lap(lap++, 50538));
            //session.AddLap(new Lap(lap++, 50725));
            //session.AddLap(new Lap(lap++, 49734));
            //session.AddLap(new Lap(lap++, 49948));
            //session.AddLap(new Lap(lap++, 52378));
            //session.AddLap(new Lap(lap++, 50645));
            //session.AddLap(new Lap(lap++, 50806));
            //session.AddLap(new Lap(lap++, 50629));
            //session.AddLap(new Lap(lap++, 50548));
            //session.AddLap(new Lap(lap++, 50933));
            //session.AddLap(new Lap(lap++, 51141));




            //session.AddLap(new Lap(lap++, 53333));
            //session.AddLap(new Lap(lap++, 53662));
            //session.AddLap(new Lap(lap++, 54126));
            //session.AddLap(new Lap(lap++, 52819));
            //session.AddLap(new Lap(lap++, 52128));
            //session.AddLap(new Lap(lap++, 52960));
            //session.AddLap(new Lap(lap++, 51223));
            //session.AddLap(new Lap(lap++, 51798));
            //session.AddLap(new Lap(lap++, 51752));
            //session.AddLap(new Lap(lap++, 51417));
            //session.AddLap(new Lap(lap++, 51664));
            //session.AddLap(new Lap(lap++, 52334));
            //session.AddLap(new Lap(lap++, 53452));
            //session.AddLap(new Lap(lap++, 51883));
            //session.AddLap(new Lap(lap++, 51930));
            //session.AddLap(new Lap(lap++, 51386));
            //session.AddLap(new Lap(lap++, 51586));
            //session.AddLap(new Lap(lap++, 50740));
            //session.AddLap(new Lap(lap++, 51500));
            //session.AddLap(new Lap(lap++, 52913));
            //session.AddLap(new Lap(lap++, 52582));
            //session.AddLap(new Lap(lap++, 51852));
            //session.AddLap(new Lap(lap++, 52235));
            //session.AddLap(new Lap(lap++, 51615));
            //session.AddLap(new Lap(lap++, 59898));
            //session.AddLap(new Lap(lap++, 53711));
            //session.AddLap(new Lap(lap++, 51880));
            //session.AddLap(new Lap(lap++, 52536));
            //session.AddLap(new Lap(lap++, 52556));
            //session.AddLap(new Lap(lap++, 51218));
            //session.AddLap(new Lap(lap++, 51631));
            //session.AddLap(new Lap(lap++, 51881));
            //session.AddLap(new Lap(lap++, 51591));
            //session.AddLap(new Lap(lap++, 51862));
            //session.AddLap(new Lap(lap++, 58408));
            //session.AddLap(new Lap(lap++, 53791));
            //session.AddLap(new Lap(lap++, 53651));
            //session.AddLap(new Lap(lap++, 52057));
            //session.AddLap(new Lap(lap++, 51477));
            //session.AddLap(new Lap(lap++, 51529));
            //session.AddLap(new Lap(lap++, 52229));
            //session.AddLap(new Lap(lap++, 52047));
            //session.AddLap(new Lap(lap++, 50625));
            //session.AddLap(new Lap(lap++, 51459));
            //session.AddLap(new Lap(lap++, 51147));
            //session.AddLap(new Lap(lap++, 51516));
            //session.AddLap(new Lap(lap++, 51647));
            //session.AddLap(new Lap(lap++, 51035));
            //session.AddLap(new Lap(lap++, 51340));
            //session.AddLap(new Lap(lap++, 50501));
            //session.AddLap(new Lap(lap++, 51130));
            //session.AddLap(new Lap(lap++, 51139));
            //session.AddLap(new Lap(lap++, 51136));
            //session.AddLap(new Lap(lap++, 52511));
            //session.AddLap(new Lap(lap++, 51180));
            //session.AddLap(new Lap(lap++, 50890));
            //session.AddLap(new Lap(lap++, 51263));

            return session;
        }
    }
}
