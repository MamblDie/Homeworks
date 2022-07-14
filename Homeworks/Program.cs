internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Number: ");

        int.TryParse(Console.ReadLine(), out int number);

        Console.WriteLine(Factorial(number));
    }

    private static void Fibonacci()
    {
        Console.Write("Count: ");

        int.TryParse(Console.ReadLine(), out int count);

        int[] numbers = new int[count];

        int first = 0, last = 0, current = 0;

        List<int> result = numbers.Select((_, index) =>
        {
            first = index <= 1 ? 0 : last;
            last = index <= 1 ? 1 : current;

            current = first + last;

            return current;
        })
            .ToList();

        foreach (int i in result)
        {
            Console.WriteLine(i);
        }

        Console.ReadKey();
    }


    private static int Factorial(int number)
    {
        var numbers = Enumerable.Range(1, number);

        return numbers.Aggregate((current, previous) => current * previous);
    }
}