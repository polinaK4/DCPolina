namespace Exceptions
{
   public class Task8Exceptions
   {
        public static void ShowMassiveElement()
        {
            try
            {
                int[] massive = { 8, 7, 1, 4, 2 };
                Console.WriteLine("Input index of element in massive:");
                string? inputedValue = Console.ReadLine();
                string? checkedValue = inputedValue.Equals(string.Empty) ? null : inputedValue;
                int inputtedNumber = Int32.Parse(checkedValue);
                int massiveElement = massive[inputtedNumber];
                Console.WriteLine($"Massive element that has index {inputedValue} has value {massiveElement}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("This is IndexOutOfRangeException");
                Console.WriteLine($"{ex.StackTrace}");
            }
            catch (ArgumentException ex) //empty
            {
                Console.WriteLine("This is ArgumentException");
                Console.WriteLine($"{ex.StackTrace}");
            }
            catch (FormatException ex) //letters,symbols
            {
                Console.WriteLine("This is FormatException");
                Console.WriteLine($"{ex.StackTrace}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("This is any other exception");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
                Console.WriteLine($"InnerException: {ex.InnerException}");
            }
            finally
            {
                  Console.WriteLine("Finally!!");
            }
        }
   }
}
