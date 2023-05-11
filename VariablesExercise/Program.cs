namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string myName = "Anthony";
            int myAge = 42;
            string dogName = "Lucy";
            bool isCrazy = true;
            double percCrazy = 123.4;
            decimal dogAge = 7.77m;

            Console.WriteLine($"Hello, my name is {myName}. I am {myAge} years old.");
            Console.WriteLine($"I have a dog named {dogName}, she is {dogAge} years old.");
            Console.WriteLine($"It is {isCrazy} that she is {percCrazy} percent crazy!");
        }
    }
}
