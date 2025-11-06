using System.Security.Cryptography.X509Certificates;

namespace StructAdapter
{
    internal class Program : IUsbC
    {
    
        static void Main(string[] args)
        {
           
        }

        public void UsbAtoC()
        {
            Console.WriteLine("Charger is now using usb c");
        }
    }
}
