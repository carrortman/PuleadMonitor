using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PuleadMonitor
{
    /// <summary>
    /// ParameterConfigView.xaml 的交互逻辑
    /// </summary>
    public partial class ParameterConfigView : Window
    {
        public ParameterConfigView()
        {
            InitializeComponent();
            this.DataContext = new  ParameterConfigViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var parameterConfigViewModel = new ParameterConfigViewModel();
            parameterConfigViewModel.SetParamater();
            this.Close();
               
        }
    }
}
