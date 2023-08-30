
namespace InterfaceSegregationEXM.UsingISP
{
    public class AllInOneDevice : IPrinter, IScanner, IFaxMachine
    {
        public void Print()
        {
            // Implementation
            Console.WriteLine("Hello from AllInOneDevice: Print Machine.....");
        }
        public void Scan()
        {
            // Implementation
            Console.WriteLine("Hello from AllInOneDevice: Scan Machine.....");
        }
        public void Fax()
        {
            // Implementation
            Console.WriteLine("Hello from AllInOneDevice: Fax Machine.....");
        }
    }
}
