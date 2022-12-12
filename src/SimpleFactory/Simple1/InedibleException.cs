namespace Demos
{
    public class InedibleException : Exception 
    {
        public InedibleException(string message) : base(message) { }
    }
}
