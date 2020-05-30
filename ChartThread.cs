using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Threading;
using System.Windows.Media;
using CartesianChart = LiveCharts.WinForms.CartesianChart;

namespace Covid_19
{
    class ChartThread
    {
        private CartesianChart CartesianChart;
        private ChartValues<int> InfectedValues;
        private ChartValues<int> DeathQuarantineValues;
        private ChartValues<int> HealthyValues;
        private SimulationForm SimulationForm;
        private bool update;

        public ChartThread(SimulationForm SimulationForm)
        {
            this.SimulationForm = SimulationForm;
            CartesianChart = SimulationForm.DataChart;
            Init();
            Start();
        }

        private void Init()
        {
            InfectedValues = new ChartValues<int> { SimulationForm.InfectedNumber + SimulationForm.SymptomlessNumber };
            DeathQuarantineValues = new ChartValues<int> { SimulationForm.QuarantineNumber + SimulationForm.DeathNumber };
            HealthyValues = new ChartValues<int> { SimulationForm.AliveNumber - (SimulationForm.InfectedNumber + SimulationForm.SymptomlessNumber) };
            CartesianChart.AxisY.Clear();
            CartesianChart.AxisY.Add(new Axis
            {
                MinValue = 0
            });
            CartesianChart.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Infetti",
                    Values = InfectedValues,
                    StrokeThickness = 3,
                    PointGeometrySize = 0,
                    Stroke = Brushes.Red,
                    Fill = new SolidColorBrush(Color.FromRgb(253, 227, 226)),
                    DataLabels = false
                },
                new LineSeries
                {
                    Title = "In salute",
                    Values = HealthyValues,
                    StrokeThickness = 3,
                    PointGeometrySize = 0,
                    DataLabels = false
                },
                new LineSeries
                {
                    Title = "Deceduti o in quarantena",
                    Values = DeathQuarantineValues,
                    StrokeThickness = 3,
                    PointGeometrySize = 0,
                    Stroke = Brushes.Black,
                    Fill = new SolidColorBrush(Color.FromArgb(100, 240, 240, 240)),
                    DataLabels = false
                }
            };
        }

        public void Start()
        {
            update = true;
            new Thread(() =>
            {
                while (update)
                {
                    Thread.CurrentThread.IsBackground = true;
                    InfectedValues.Add(SimulationForm.InfectedNumber + SimulationForm.SymptomlessNumber);
                    DeathQuarantineValues.Add(SimulationForm.QuarantineNumber + SimulationForm.DeathNumber);
                    HealthyValues.Add(SimulationForm.AliveNumber - (SimulationForm.InfectedNumber + SimulationForm.SymptomlessNumber));
                    Thread.Sleep(1000);
                }
            }).Start();
        }

        public void Stop()
        {
            update = false;
        }
    }
}
