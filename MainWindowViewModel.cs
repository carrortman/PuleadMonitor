using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;
using Timer = System.Timers.Timer;

namespace PuleadMonitor
{
    internal class MainWindowViewModel :ObservableObject
    {
        private double productCurrentTemp1;
        public double ProductCurrentTemp1 { get=> productCurrentTemp1; set =>SetProperty(ref productCurrentTemp1,value,nameof(ProductCurrentTemp1)); }
        private double productCurrentHum1;
        public double ProductCurrentHum1 { get=> productCurrentHum1; set=>SetProperty(ref productCurrentHum1,value,nameof(ProductCurrentHum1)); }
        private double productCurrentTemp2;
        public double ProductCurrentTemp2 { get=> productCurrentTemp2; set; }
        private double productCurrentHum2;
        public double ProductCurrentHum2 { get=> productCurrentHum2; set; }
        private double materialCurrentTemp1;
        public double MaterialCurrentTemp1 { get=> materialCurrentTemp1; set; }
        private double materialCurrentHum1;
        public double MaterialCurrentHum1 { get=> materialCurrentHum1; set; }
        private double materialCurrentTemp2;
        public double MaterialCurrentTemp2 { get=> materialCurrentTemp2; set; }
        private double materialCurrentHum2;
        public double MaterialCurrentHum2 { get=> materialCurrentHum2; set; }
        private string productCurrentTH1;
        public string ProductCurrentTH1 { get => productCurrentTH1; }
        private string productCurrentTH2;
        public string ProductCurrentTH2 { get => productCurrentTH2; }
        private string materialCurrentTH1;
        public string MaterialCurrentTH1 { get => materialCurrentTH1; }
        private string materialCurrentTH2;
        public string MaterialCurrentTH2 { get => materialCurrentTH2; }

        private ChartValues<double> productTemp1Series;
        public ChartValues<double> ProductTemp1Series { get;set; }
        private ChartValues<double> productTemp2Series;
        public ChartValues<double> ProductTemp2Series { get;set; }
        private ChartValues<double> materialTemp1Series;
        public ChartValues<double> MaterialTemp1Series { get;set; }
        private ChartValues<double> materialTemp2Series;
        public ChartValues<double> MaterialTemp2Series { get;set; }
        

        public RelayCommand OpenParameterConfigCommand { get; set; }

        private Timer timerProduct1;
        private Timer timerProduct2;
        private Timer timerMaterial1;
        private Timer timerMaterial2;

        public MainWindowViewModel()
        {
            OpenParameterConfigCommand = new RelayCommand(OpenParameterConfig);
            ProductTemp1Series = new ChartValues<double>();
            ProductTemp2Series = new ChartValues<double>();
            MaterialTemp1Series = new ChartValues<double>();
            MaterialTemp2Series = new ChartValues<double>();
        }

        public void OpenParameterConfig()
        {
            ParameterConfigView parameterConfigView = new ParameterConfigView();
            parameterConfigView.Width = 400;
            parameterConfigView.Height = 450;
            parameterConfigView.Title =  "参数配置";
            var parameterConfigViewModel = (ParameterConfigViewModel)parameterConfigView.DataContext;
            parameterConfigViewModel.OnSetParameter += ConfigParameter;
            parameterConfigView.ShowDialog();
        }
        private void ConfigParameter(object sender,EventArgs args)
        {
            var parameterConfig = (ParameterConfigModel)sender;
            if(ProductTemp1Series!=null)
            {
                ProductTemp1Series.Clear();
            }
            if (ProductTemp2Series != null)
            {
                ProductTemp2Series.Clear();
            }
            if (MaterialTemp1Series != null)
            {
                MaterialTemp1Series.Clear();
            }
            if (MaterialTemp2Series != null)
            {
                MaterialTemp2Series.Clear();
            }
            timerProduct1 = new Timer(2000);
            timerProduct2 = new Timer(2000);
            timerMaterial1 = new Timer(2000);
            timerMaterial2 = new Timer(2000);

            var random = new Random();
            timerProduct1.Elapsed += (x, y) =>
            {
                var temp = Math.Round(random.NextDouble() * (parameterConfig.ProductSetTemp1Max - parameterConfig.ProductSetTemp1Min) + parameterConfig.ProductSetTemp1Min, 2);
                if (ProductTemp1Series.Count > 12)
                {
                    ProductTemp1Series.RemoveAt(0);
                    ProductTemp1Series.Add(temp);
                }
                else
                {
                    ProductTemp1Series.Add(temp);
                }
                var hum = Math.Round(random.NextDouble() * (parameterConfig.ProductSetHum1Max - parameterConfig.ProductSetHum1Min) + parameterConfig.ProductSetHum1Min, 2);
                ProductCurrentTemp1 = temp;
                ProductCurrentHum1 = hum;
                Dispatcher.CurrentDispatcher.BeginInvoke(DispatcherPriority.Normal, new Action(() => { SetProperty( ); }));
            };
            timerProduct1.Start();


        }

        private void StartRecordTemp(Timer timer, double maxTemp,double minTemp,ChartValues<double> points)
        {
            var random = new Random();
            timer.Elapsed += (x, y) =>
            {
                var temp = Math.Round(random.NextDouble() * (maxTemp - minTemp) + minTemp, 2);
                if(points.Count > 12)
                {
                    points.RemoveAt(0);
                    points.Add(temp);
                }
                else
                {
                    points.Add(temp);
                }

            };
            timer.Start();
            
        }
        
    }
    
}
