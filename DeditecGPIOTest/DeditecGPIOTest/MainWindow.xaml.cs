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
using System.Threading;

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
                DeLibNET.DAPI_OPENMODULEEX_STRUCT t = new DeLibNET.DAPI_OPENMODULEEX_STRUCT();
                t.address = "192.168.1.23";
                t.portno = 9912;
                t.timeout = 100;
                t.encryption_type = 0;

                handle = DeLibNET.DapiOpenModuleEx((uint)DeLibNET.ModuleID.NET_ETH_LC, 0, t, 0);


                if (handle == 0)
                {
                    IsError();
                    Environment.Exit(0);
                }

                DeLibNET.DapiSpecialCommand(handle, DeLibNET.DAPI_SPECIAL_CMD_TIMEOUT, DeLibNET.DAPI_SPECIAL_TIMEOUT_ACTIVATE, 0, 0);
                DeLibNET.DapiSpecialCommand(handle, DeLibNET.DAPI_SPECIAL_CMD_TIMEOUT, DeLibNET.DAPI_SPECIAL_TIMEOUT_SET_VALUE_SEC, 0, 5);
                DeLibNET.DapiSpecialCommand(handle, DeLibNET.DAPI_SPECIAL_CMD_TIMEOUT, DeLibNET.DAPI_SPECIAL_TIMEOUT_ACTIVATE_AUTO_REACTIVATE, 0, 0);
                DeLibNET.DapiSpecialCommand(handle, DeLibNET.DAPI_SPECIAL_CMD_TIMEOUT, DeLibNET.DAPI_SPECIAL_TIMEOUT_DO_VALUE_LOAD_DEFAULT, 0, 0);

                Task.Run(() =>
                {
                    try
                    {
                        while (true)
                        {
                            if (joyStat.Buttons[11])
                            {
                                DeLibNET.DapiDOSet1(handle, 5, 1);
                                DeLibNET.DapiDOSet1(handle, 6, 1);
                                DeLibNET.DapiDOSet1(handle, 7, 1);
                                DeLibNET.DapiDOSet1(handle, 8, 1);
                                DeLibNET.DapiDOSet1(handle, 9, 1);
                                DeLibNET.DapiDOSet1(handle, 10, 1);
                                DeLibNET.DapiDOSet1(handle, 11, 1);
                                DeLibNET.DapiDOSet1(handle, 12, 1);
                                DeLibNET.DapiDOSet1(handle, 13, 1);
                                DeLibNET.DapiDOSet1(handle, 14, 1);
                                DeLibNET.DapiDOSet1(handle, 15, 1);
                            }
                            else
                            {
                                DeLibNET.DapiDOSet1(handle, 5, 0);
                                DeLibNET.DapiDOSet1(handle, 6, 0);
                                DeLibNET.DapiDOSet1(handle, 7, 0);
                                DeLibNET.DapiDOSet1(handle, 8, 0);
                                DeLibNET.DapiDOSet1(handle, 9, 0);
                                DeLibNET.DapiDOSet1(handle, 10, 0);
                                DeLibNET.DapiDOSet1(handle, 11, 0);
                                DeLibNET.DapiDOSet1(handle, 12, 0);
                                DeLibNET.DapiDOSet1(handle, 13, 0);
                                DeLibNET.DapiDOSet1(handle, 14, 0);
                                DeLibNET.DapiDOSet1(handle, 15, 0);
                            }

                            if(JoyRead > 50 && JoyRead < 51)
                            {
                                for(uint i = 0; i < 15; i++)
                                {
                                    DeLibNET.DapiPWMOutSet(handle, i, 0);
                                }
                            }

                            if (JoyRead < 49.99)
                            {
                                float final = 0 + (JoyRead - 50) * (100 - 0) / (0 - 50);
                                DeLibNET.DapiPWMOutSet(handle, 0, final);
                                DeLibNET.DapiPWMOutSet(handle, 1, 0);

                                Console.WriteLine("Write :" +final + "   READ :" + DeLibNET.DapiPWMOutReadback(handle, 0));

                                DeLibNET.DapiDOSet1(handle, 3, 1);
                                DeLibNET.DapiDOSet1(handle, 4, 0);
                            }
                            else if (JoyRead > 50.99)
                            {
                                float final = (float)(0 + (JoyRead - (float)50.99) * (100 - 0) / (100 - (float)50.99));
                                DeLibNET.DapiPWMOutSet(handle, 1, final);
                                DeLibNET.DapiPWMOutSet(handle, 0, 0);

                                Console.WriteLine("Write :" + final + "   READ :" + DeLibNET.DapiPWMOutReadback(handle, 1));

                                DeLibNET.DapiPWMOutSet(handle, 2, final);
                                DeLibNET.DapiPWMOutSet(handle, 3, final);
                                DeLibNET.DapiPWMOutSet(handle, 4, final);
                                DeLibNET.DapiPWMOutSet(handle, 5, final);
                                DeLibNET.DapiPWMOutSet(handle, 6, final);
                                DeLibNET.DapiPWMOutSet(handle, 7, final);
                                DeLibNET.DapiPWMOutSet(handle, 8, final);
                                DeLibNET.DapiPWMOutSet(handle, 9, final);
                                DeLibNET.DapiPWMOutSet(handle, 10, final);
                                DeLibNET.DapiPWMOutSet(handle, 11, final);
                                DeLibNET.DapiPWMOutSet(handle, 12, final);
                                DeLibNET.DapiPWMOutSet(handle, 13, final);
                                DeLibNET.DapiPWMOutSet(handle, 14, final);
                                DeLibNET.DapiPWMOutSet(handle, 15, final);
                                DeLibNET.DapiDOSet1(handle, 3, 0);
                                DeLibNET.DapiDOSet1(handle, 4, 1);
                            }

                            DataDeditec.analog1 = 0 + (DeLibNET.DapiADGetVolt(handle, 0) - 0) * (100 - 0) / (5 - 0);
                            DataDeditec.analog2 = 0 + (DeLibNET.DapiADGetVolt(handle, 1) - 0) * (100 - 0) / (5 - 0);

                            DataDeditec.digital1 = DeLibNET.DapiADGetVolt(handle, 4) < 2;
                            DataDeditec.digital2 = DeLibNET.DapiADGetVolt(handle, 2) < 2;
                            DataDeditec.digital3 = DeLibNET.DapiADGetVolt(handle, 3) < 2;

                            Thread.Sleep(10);
                        }
                    }
                    catch (Exception ex) { Console.WriteLine(ex.ToString()); }
                });
            }
            catch (Exception ex)
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
                DeLibNET.DapiGetLastErrorText(msg, 256);
                MessageBox.Show("Error code :" + Convert.ToString(error) + "\n\n\n  Message error : " + msg);
                Environment.Exit(0);
            }
        }
    }
}
