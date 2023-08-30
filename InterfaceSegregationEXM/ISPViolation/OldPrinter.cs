
namespace InterfaceSegregationEXM.ISPViolation
{
    public class OldPrinter : IMachine
    {
        public void Print()
        {
            // Implementation
        }
        public void Scan()
        {
            // This method doesn't make sense for an old printer
            throw new NotImplementedException("Scan not supported");
        }
        public void Fax()
        {
            // This method doesn't make sense for an old printer
            throw new NotImplementedException("Fax not supported");
        }
    }
}
