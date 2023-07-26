namespace Exceptions
{
    public class Car
    {
        private int _speed;
        public string Type { get; set; }
        public int Speed
        {
            get => _speed;
            set
            {
                if (value > 200)
                    throw new SpeedException("Speed more than 200 is not allowed", value);
                else
                    _speed = value;
            }
        }
    }
}
