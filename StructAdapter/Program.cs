using System.Security.Cryptography.X509Certificates;

namespace StructAdapter
{
    internal class Program
    {
    
        static void Main(string[] args)
        {
             UsbA usbA = new UsbA();
            IOverideUSB overideUSB = new PhoneCharger();
            overideUSB.OverideUsb();
     
        }

     
    }
}
