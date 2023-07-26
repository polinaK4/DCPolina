namespace AutomationCources.Lecture_7.Homework
{
    public interface IPrint
    {
        public int PaperWidth { get; set; }
        public int PaperHeight { get; set; }

        public void Print()
        {
            Console.WriteLine("Printing...");
        }
    }
}
