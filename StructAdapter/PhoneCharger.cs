using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAdapter
{
    public class PhoneCharger : IUsbC
    {
        private UsbA _UsbA;
        public PhoneCharger(IUsbC usbC) {
        
        }
    }
}
