using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PuleadMonitor
{
    internal class ParameterConfigViewModel : ObservableObject
    {
        private double productSetTemp1;
        public double ProductSetTemp1 { get => productSetTemp1; set => SetProperty(ref productSetTemp1, value, nameof(ProductSetTemp1)); }
        private double productSetTemp1Max;
        public double ProductSetTemp1Max { get => productSetTemp1Max; set => SetProperty(ref productSetTemp1Max, value, nameof(ProductSetTemp1Max)); }
        private double productSetTemp1Min;
        public double ProductSetTemp1Min { get => productSetTemp1Min; set=>SetProperty(ref productSetTemp1Min,value,nameof(ProductSetTemp1Min)); }
        private double productSetHum1;
        public double ProductSetHum1 { get =>productSetHum1; set =>SetProperty(ref productSetHum1,value,nameof(ProductSetHum1)); }  
        private double productSetHum1Max;
        public double ProductSetHum1Max { get=> productSetHum1Max; set=>SetProperty(ref productSetHum1Max, value,nameof(ProductSetHum1Max)); }
        private double productSetHum1Min;
        public double ProductSetHum1Min { get=>productSetHum1Min; set=>SetProperty(ref productSetHum1Min,value,nameof(ProductSetHum1Min)); }
        private double productSetTemp2;
        public double ProductSetTemp2 { get => productSetTemp2; set => SetProperty(ref productSetTemp2,value,nameof(ProductSetTemp2)); }
        private double productSetTemp2Max;
        public double ProductSetTemp2Max { get=>productSetTemp2Max; set=>SetProperty(ref productSetTemp2Max,value,nameof(ProductSetTemp2Max)); }
        private double productSetTemp2Min;
        public double ProductSetTemp2Min { get => productSetTemp2Min; set => SetProperty(ref productSetTemp2Min, value, nameof(ProductSetTemp2Min)); }
        private double productSetHum2;
        public double ProductSetHum2 { get => productSetHum2; set => SetProperty(ref productSetHum2, value, nameof(ProductSetHum2)); }
        private double productSetHum2Max;
        public double ProductSetHum2Max { get => productSetHum2Max; set => SetProperty(ref productSetHum2Max, value, nameof(ProductSetHum2Max)); }
        private double productSetHum2Min;
        public double ProductSetHum2Min { get => productSetHum2Min; set => SetProperty(ref productSetHum2Min, value, nameof(ProductSetHum2Min)); }


        private double materialSetTemp1;
        public double MaterialSetTemp1 { get => materialSetTemp1; set => SetProperty(ref materialSetTemp1, value, nameof(MaterialSetTemp1)); }
        private double materialSetTemp1Max;
        public double MaterialSetTemp1Max { get => materialSetTemp1Max; set => SetProperty(ref materialSetTemp1Max, value, nameof(MaterialSetTemp1Max)); }
        private double materialSetTemp1Min;
        public double MaterialSetTemp1Min { get => materialSetTemp1Min; set => SetProperty(ref materialSetTemp1Min, value, nameof(MaterialSetTemp1Min)); }
        private double materialSetHum1;
        public double MaterialSetHum1 { get => materialSetHum1; set => SetProperty(ref materialSetHum1, value, nameof(MaterialSetHum1)); }
        private double materialSetHum1Max;
        public double MaterialSetHum1Max { get => materialSetHum1Max; set => SetProperty(ref materialSetHum1Max, value, nameof(MaterialSetHum1Max)); }
        private double materialSetHum1Min;
        public double MaterialSetHum1Min { get => materialSetHum1Min; set => SetProperty(ref materialSetHum1Min, value, nameof(MaterialSetHum1Min)); }
        private double materialSetTemp2;
        public double MaterialSetTemp2 { get => materialSetTemp2; set => SetProperty(ref materialSetTemp2, value, nameof(MaterialSetTemp2)); }
        private double materialSetTemp2Max;
        public double MaterialSetTemp2Max { get => materialSetTemp2Max; set => SetProperty(ref materialSetTemp2Max, value, nameof(MaterialSetTemp2Max)); }
        private double materialSetTemp2Min;
        public double MaterialSetTemp2Min { get => materialSetTemp2Min; set => SetProperty(ref materialSetTemp2Min, value, nameof(MaterialSetTemp2Min)); }
        private double materialSetHum2;
        public double MaterialSetHum2 { get => materialSetHum2; set => SetProperty(ref materialSetHum2, value, nameof(MaterialSetHum2)); }
        private double materialSetHum2Max;
        public double MaterialSetHum2Max { get => materialSetHum2Max; set => SetProperty(ref materialSetHum2Max, value, nameof(MaterialSetHum2Max)); }
        private double materialSetHum2Min;
        public double MaterialSetHum2Min { get => materialSetHum2Min; set => SetProperty(ref materialSetHum2Min, value, nameof(MaterialSetHum2Min)); }

        public event EventHandler OnSetParameter;

        public void SetParamater() 
        {
            OnSetParameter(new ParameterConfigModel()
            {
          ProductSetTemp1 = this.productSetTemp1,
          ProductSetTemp1Max  = this.productSetTemp1Max,

          ProductSetTemp1Min = this.productSetTemp1Min ,

          ProductSetHum1 =this.productSetHum1,

          ProductSetHum1Max =this.productSetHum1Max,

          ProductSetHum1Min =this.productSetHum1Min,

          ProductSetTemp2 =this.productSetTemp2,

          ProductSetTemp2Max =this.productSetTemp2Max,

          ProductSetTemp2Min =this.productSetTemp2Min,

          ProductSetHum2=this.productSetHum2,

          ProductSetHum2Max =this.productSetHum2Max,

          ProductSetHum2Min =this.productSetHum2Min,

          MaterialSetTemp1 =this.materialSetTemp1,

          MaterialSetTemp1Max=this.materialSetTemp1Max,

          MaterialSetTemp1Min =this.materialSetTemp1Min,

          MaterialSetHum1 =this.materialSetHum1,

          MaterialSetHum1Max=this.materialSetHum1Max,

          MaterialSetHum1Min =this.materialSetHum1Min,

          MaterialSetTemp2 =this.materialSetTemp2,

          MaterialSetTemp2Max =this.materialSetTemp2Max,

          MaterialSetTemp2Min =this.materialSetTemp2Min,

          MaterialSetHum2 =this.materialSetHum2,

          MaterialSetHum2Max =this.materialSetHum2Max,

          MaterialSetHum2Min=this.materialSetHum2Min,
    },new EventArgs());
        }
    }
}
