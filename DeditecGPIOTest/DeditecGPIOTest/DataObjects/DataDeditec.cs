using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DeditecGPIOTest.DataObjects
{
    public class DataDeditec : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private float pwm1Value;
        private float pwm2Value;

        public float pwm1
        {
            get { return this.pwm1Value; }
            set
            {
                if (value != this.pwm1Value)
                {
                    this.pwm1Value = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public float pwm2
        {
            get { return this.pwm2Value; }
            set
            {
                if (value != this.pwm2Value)
                {
                    this.pwm2Value = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}
