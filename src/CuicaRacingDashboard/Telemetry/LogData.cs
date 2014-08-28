namespace CuicaRacingDashboard.Telemetry
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class LogData
    {
        public ulong elapsedTime;

        GPSLogData gps;

        IMULogData imu;

        /*
     * "Time",
     * "Lap",
     * "GPS_Update",
     * "GPS_Delay",
     
     * "Heading",
     * "X",
     * "Y",
     * "Z",
     * "OBD_Update",
     * "Engine Speed (RPM) *OBD",
     * "Accelerator Pedal (%) *OBD"
     */
    }
}
