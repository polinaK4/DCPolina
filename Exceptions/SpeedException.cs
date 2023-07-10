namespace Exceptions
{
    public class SpeedException : Exception
    {
        public int Value { get; }
        public SpeedException(string message, int val) : base(message) 
        {
            Value = val;
        }
    }
}
