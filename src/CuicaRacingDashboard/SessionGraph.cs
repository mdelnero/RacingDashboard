using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ZedGraph;

namespace CuicaRacingDashboard
{
    public partial class SessionGraph : UserControl
    {
        /// <summary>
        /// The Current Session.
        /// </summary>
        private Session session;

        /// <summary>
        /// ZedGraph Control.
        /// </summary>
        private ZedGraphControl graphControl;

        /// <summary>
        /// Lap Time Curve;
        /// </summary>
        LineItem lapTimeCurve;

        /// <summary>
        /// Best Lap Line .
        /// </summary>
        LineObj bestLapTimeLine;

        /// <summary>
        /// Class Constructor.
        /// </summary>
        public SessionGraph()
        {
            InitializeComponent();
            InitializeChartControl();
        }

        /// <summary>
        /// Initialize Chart Control.
        /// </summary>
        private void InitializeChartControl()
        {
            graphControl = new ZedGraphControl();
            graphControl.Dock = DockStyle.Fill;

            GraphPane myPane = graphControl.GraphPane;

            myPane.Title.Text = string.Empty;

            ///
            /// Lap Number Axis
            /// 
            myPane.XAxis.Title.Text = "Lap Number";
            // Grid
            myPane.XAxis.MajorGrid.Color = System.Drawing.Color.White;
            myPane.XAxis.MajorGrid.IsVisible = true;
            // Grid Step
            myPane.XAxis.Scale.MajorStep = 1;
            myPane.XAxis.Scale.MajorStepAuto = false;
            myPane.XAxis.Scale.MinorStep = 0.5;
            myPane.XAxis.Scale.MinorStepAuto = false;

            ///
            /// Lap Time Axis
            /// 
            myPane.YAxis.Title.Text = "Lap Time";
            // Grid
            myPane.YAxis.MajorGrid.Color = System.Drawing.Color.White;
            myPane.YAxis.MajorGrid.IsVisible = true;
            // Grid Step
            myPane.YAxis.Scale.MajorStep = 1;
            myPane.YAxis.Scale.MajorStepAuto = false;
            myPane.YAxis.Scale.MinorStep = 1;
            myPane.YAxis.Scale.MinorStepAuto = false;

            ///
            /// Chart
            /// 
            myPane.Chart.Fill.Brush = new System.Drawing.SolidBrush(Color.Black);
            myPane.Chart.Fill.Color = System.Drawing.Color.Black;

            this.Controls.Add(graphControl);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="session"></param>
        public void SetSession(Session session)
        {
            this.session = session;
            session.NewLapEvent += this.OnNewLap;

            GraphPane graphPane = graphControl.GraphPane;

            graphPane.CurveList.Clear();

            graphPane.Title.Text = session.Name;

            PointPairList dataList = new PointPairList();

            foreach (Lap lap in session.Laps)
            {
                dataList.Add(lap.LapNumber, (double)(lap.LapTime / 1000.0f));

                //TextObj text = new TextObj(
                //    Util.FormatTime(lap.LapTime),
                //    lap.LapNumber,
                //    (lap.LapTime / 1000) + 2,
                //    CoordType.AxisXYScale,
                //    AlignH.Left,
                //    AlignV.Center);

                //text.ZOrder = ZOrder.A_InFront;
                //text.FontSpec.Border.IsVisible = false;
                ////text.FontSpec.Fill.IsVisible = false;
                ////myPane.GraphObjList.Add(text);
            }

            lapTimeCurve = graphPane.AddCurve("Lap Time", dataList, Color.Red, SymbolType.Circle);

            // Symbol
            lapTimeCurve.Line.Width = 2;
            lapTimeCurve.Symbol.Fill = new Fill(Color.Blue);
            lapTimeCurve.Symbol.Size = 10;

            FitSession();
            UpdateBestLap();

            // Redraw
            graphControl.AxisChange();
            graphControl.Invalidate();
        }

        /// <summary>
        /// Fit Session To Graph.
        /// </summary>
        private void FitSession()
        {
            GraphPane graphPane = graphControl.GraphPane;

            if (session.Laps.Count() > 0)
            {
                double min = (session.GetBestLap().LapTime - 1000) / 1000;

                double max = (session.GetWorstLap().LapTime + 1000) / 1000;
                
                graphPane.XAxis.Scale.Min = 0;
                graphPane.XAxis.Scale.Max = session.Laps.Count() + 1;
                graphPane.YAxis.Scale.Min = min;
                graphPane.YAxis.Scale.Max = max;                
            }
        }          

        /// <summary>
        /// Draw the Best Lap Reference Line.
        /// </summary>
        private void UpdateBestLap()
        {
            GraphPane graphPane = graphControl.GraphPane;

            if (bestLapTimeLine != null)
            {
                graphPane.GraphObjList.Remove(bestLapTimeLine); 
            }

            double threshHoldY = (double)(session.GetBestLap().LapTime / 1000.0f);

            bestLapTimeLine = new LineObj(
                    Color.Blue,
                    graphPane.XAxis.Scale.Min,
                    threshHoldY,
                    graphPane.XAxis.Scale.Max,
                    threshHoldY);

            bestLapTimeLine.Line.Width = 2;

            graphPane.GraphObjList.Add(bestLapTimeLine);
        }

        /// <summary>
        /// New Session Lap Event.
        /// </summary>
        private void OnNewLap(object sender, NewLapEventArgs args)
        {
            lapTimeCurve.AddPoint(args.Lap.LapNumber, args.Lap.LapTime / 1000);

            GraphPane myPane = graphControl.GraphPane;
            myPane.XAxis.Scale.Max = session.Laps.Count() + 1;

            UpdateBestLap();

            // Redraw
            graphControl.AxisChange();
            graphControl.Invalidate();
        }
    }
}
