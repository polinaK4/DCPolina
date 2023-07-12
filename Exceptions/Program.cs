using Exceptions;
public class ProgramTask8
{   
    static void Main(string[] args)
    {
        Task8Exceptions.ShowMassiveElement(); //for task1
        try
        {            
            Car car = new Car { Type = "BMV", Speed = 220 }; //for task2
        }
        catch (SpeedException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            Console.WriteLine($"Incorrect value: {ex.Value}");
        }
        catch
        {
            Console.WriteLine("Any exception in Main");
        }
        finally
        {
            Console.WriteLine("Finally in Main");
        }
    }
}

