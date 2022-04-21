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

        private float analog1Value;
        private float analog2Value;

        private bool digital1Value;
        private bool digital2Value;
        private bool digital3Value;

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

        public float analog1
        {
            get { return this.analog1Value; }
            set
            {
                if (value != this.analog1Value)
                {
                    this.analog1Value = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public float analog2
        {
            get { return this.analog2Value; }
            set
            {
                if (value != this.analog2Value)
                {
                    this.analog2Value = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool digital3
        {
            get { return this.digital3Value; }
            set
            {
                if (value != this.digital3Value)
                {
                    this.digital3Value = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public bool digital2
        {
            get { return this.digital2Value; }
            set
            {
                if (value != this.digital2Value)
                {
                    this.digital2Value = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public bool digital1
        {
            get { return this.digital1Value; }
            set
            {
                if (value != this.digital1Value)
                {
                    this.digital1Value = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}
