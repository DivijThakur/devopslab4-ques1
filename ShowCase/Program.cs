using UtilityLibraries;

class Program
{
    static void Main(string[] args)
    {
        int row = 0;

        do
        {
            if (row == 0 || row >= 20)
                ResetConsole();

            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) break;
            Console.WriteLine($"Input: {input}");
            Console.WriteLine("Does it start with uppercase letter? " +
                 $"{(input.StartsWithUpper() ? "Yes" : "No")}");

            Console.WriteLine();
            row += 4;
        } while (true);
        return;

        void ResetConsole()
        {
            if (row > 0)
            {
             
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine($"{Environment.NewLine}Press enter to continue:{Environment.NewLine}");
            row = 3;
        }
    }
}