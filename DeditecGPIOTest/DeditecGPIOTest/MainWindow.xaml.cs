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
using SharpDX;
using SharpDX.DirectInput;
using DeLib;

namespace DeditecGPIOTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
         DataObjects.DataDeditec DataDeditec;
         DirectInput input;
        Joystick mainJoy;
        JoystickState joyStat;

        float JoyRead;

        uint handle, value;

        public MainWindow()
        {
            InitializeComponent();

            DataDeditec = new DataObjects.DataDeditec();
            this.DataContext = new { DataDeditecBind = DataDeditec };

            this.StartJoystick();
            
            this.StartDediteccommunication();
        }

        private void StartJoystick()
        {
            try
            {
                input = new DirectInput();
                foreach (var itm in input.GetDevices())
                {
                    if (itm.InstanceName == "RIGHT VPC Stick WarBRD")
                    {
                        mainJoy = new Joystick(input, itm.InstanceGuid);
                    }
                }

                Task.Run(() =>
                {
                    while (true)
                    {
                        mainJoy.Acquire();
                        joyStat = mainJoy.GetCurrentState();

                        JoyRead = 0 + ((float)joyStat.Y - 0) * (100 - 0) / (65534 - 0);

                        if(JoyRead < 49.999)
                        {
                            DataDeditec.pwm1 = JoyRead * -1;
                        }
                        else if(JoyRead > 50)
                        {
                            DataDeditec.pwm2 = JoyRead;

                        }

                    }
                });

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void StartDediteccommunication()
        {
            try
            {
                handle = DeLibNET.DapiOpenModule((uint)DeLibNET.ModuleID.NET_ETH_LC, 0);
                if (handle == 0)
                {
                    Console.WriteLine("Could not open module!");
                    IsError();
                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey();
                    Environment.Exit(0);
                }

                bool IsActive = false;

                Task.Run(() => 
                { 
                    while(true)
                    {
                        if(joyStat.Buttons[11])
                        {
                           DeLibNET.DapiDOSet1(handle, 5, 1);
                        }
                        if (!joyStat.Buttons[11])
                        {
                            DeLibNET.DapiDOSet1(handle, 5, 0);
                        }

                        if (JoyRead < 50)
                        {
                            float final = 0 + (JoyRead - 50) * (100 - 0) / (0 - 50);
                            DeLibNET.DapiPWMOutSet(handle, 0, final);
                            DeLibNET.DapiDOSet1(handle, 3, 1);
                            DeLibNET.DapiDOSet1(handle, 4, 0);
                        }
                        else if (JoyRead > 50)
                        {
                            float final = 0 + (JoyRead - 50) * (100 - 0) / (100 - 50);
                            DeLibNET.DapiPWMOutSet(handle, 1, final);
                            DeLibNET.DapiDOSet1(handle, 3, 0);
                            DeLibNET.DapiDOSet1(handle, 4, 1);
                        }
                        Task.Delay(100);
                    }
                });
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DeLibNET.DapiPWMOutSet(handle, 0, 0);
            DeLibNET.DapiPWMOutSet(handle, 1, 0);
        }

        public static void IsError()
        {
            uint error = DeLibNET.DapiGetLastError();
            StringBuilder msg = new StringBuilder(256);

            if (error != 0)
            {
                DeLibNET.DapiGetLastErrorText(msg, 256);    //msg.Capacity
                Console.WriteLine("Error Code = {0}, Message = {1}", Convert.ToString(error), msg);
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}
