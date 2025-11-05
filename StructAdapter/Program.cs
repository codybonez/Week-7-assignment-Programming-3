using System.Security.Cryptography.X509Certificates;

namespace StructAdapter
{
    internal class Program : IAdapter
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
