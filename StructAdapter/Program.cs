using System.Security.Cryptography.X509Certificates;

namespace StructAdapter
{
    internal class Program
    {
    
        static void Main(string[] args)
        {
         UsbType usbType = new UsbType();
            IAdapter overideUSB = new PhoneCharger(usbType);


            Console.WriteLine("Adaptee interface is incompatible with the client.\n");
            Console.WriteLine("But with adapter client can call it's method.\n");

            Console.WriteLine(overideUSB.OverideUsb());

        }

     
    }
}
