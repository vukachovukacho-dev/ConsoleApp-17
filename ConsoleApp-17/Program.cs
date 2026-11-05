namespace ConsoleApp_17
{
    public delegate int DifferenceDelegate(int a, int b);
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("task1");

            List<string> words = new List<string> { "apple", "pear", "peach", "strawberry", "watermelon", "kiwi" };

            Predicate<string> lengthFilter = word => word.Length > 5;
            Action<string> printUpper = word => Console.WriteLine(word.ToUpper());

            foreach (string word in words)
            {
                if (lengthFilter(word))
                {
                    printUpper(word);
                }
            }

            
            Console.WriteLine("task2");

            
            DifferenceDelegate subtract = (x, y) => x - y;

            int num1 = 15;
            int num2 = 7;
            int result = subtract(num1, num2);

            Console.WriteLine($"{num1} and {num2} subtract is: {result}");

            Console.ReadLine();
        }
    }
}
