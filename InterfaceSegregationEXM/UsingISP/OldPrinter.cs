
namespace InterfaceSegregationEXM.UsingISP
{
    public class OldPrinter : IPrinter
    {
        public void Print()
        {
            // Implementation
            Console.WriteLine("\n\nHello from OldPrinter: Print Machine.....");
        }
    }
}
