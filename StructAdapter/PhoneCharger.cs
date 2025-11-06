using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAdapter
{
    public class PhoneCharger :IOverideUSB
    {
     private  PhoneCharger _phoneCharger;
        public PhoneCharger() {
            Console.WriteLine("The phone uses usb A");
        }

        public void OverideUsb()
        {
            Console.WriteLine($"The charger is now compatible with usb C");
        }
    }
}
