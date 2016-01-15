using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USBLib;

namespace USB3
{
    class Program
    {
        static void Main(string[] args)
        {

            CheckUSB3();
            Console.Write("USB 3.0 ");
            if (CheckUSB30())
            {
                Console.WriteLine("IS TRUE");
            }
            else
            {
                Console.WriteLine("IS FALSE");
            }

            Console.ReadLine();
        }

        static bool CheckUSB30()
        {
            var hostCtrls = USB.GetHostControllers();
            //bool result = false;
            foreach (var hostCtrl in hostCtrls)
            {
                var hub = hostCtrl.GetRootHub();
                foreach (var port in hub.GetPorts())
                {
                    if (port.IsDeviceConnected && !port.IsHub)
                    {
                        var device = port.GetDevice();

                        //Console.WriteLine("Product: " + device.Product);
                        //Console.WriteLine("Instance: " + device.InstanceID);

                        //Console.WriteLine("Name: " + device.Name);
                        //Console.WriteLine("Serial: " + device.SerialNumber);
                        //Console.WriteLine("Speed:  " + port.Speed);
                        //Console.WriteLine("Port:   " + device.PortNumber + Environment.NewLine);

                        if (port.Speed == "3")
                        {
                            //Console.WriteLine("USB 3.0");
                            return true;
                        }
                        else
                        {
                            //Console.WriteLine("USB 3.0");
                            //Console.WriteLine("Speed:  " + port.Speed);
                        }

                    }
                }
            }

         return false;
        }

        static void CheckUSB3()
        {
                 var hostCtrls = USB.GetHostControllers();
              
            foreach (var hostCtrl in hostCtrls)
            {
                var hub = hostCtrl.GetRootHub();
                foreach (var port in hub.GetPorts())
                {
                    if (port.IsDeviceConnected && !port.IsHub)
                    {
                        var device = port.GetDevice();
                        
                        Console.WriteLine("Product: " + device.Product);
                        Console.WriteLine("Instance: " + device.InstanceID); 
                        
                        Console.WriteLine( "Name: " + device.Name ); 
                        Console.WriteLine("Serial: " + device.SerialNumber);
                        Console.WriteLine("Speed:  " + port.Speed);
                        Console.WriteLine( "Port:   " + device.PortNumber + Environment.NewLine );

                  

                    }
                }
            }
   
            //Console.ReadLine();
        }
    }
}
