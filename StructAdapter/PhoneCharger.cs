using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAdapter
{
    public class PhoneCharger :IAdapter
    {
        private  UsbType _type;
        public PhoneCharger(UsbType usbType) {
             _type = usbType;
        

            
        }
        

        public string OverideUsb()
        {
            return$"We now have usb C charger to use for this phone";
        }
    }
}
