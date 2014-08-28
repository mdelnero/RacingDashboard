namespace CuicaRacingDashboard
{
    using System;

    public class Util
    {
        public static string FormatTime(ulong time)
        {
            return TimeSpan.FromMilliseconds(time).ToString("mm':'ss'.'fff");
        }

        public static string FormatTime(long time)
        {
            return TimeSpan.FromMilliseconds(time).ToString("mm':'ss'.'fff");
        }
    }
}
