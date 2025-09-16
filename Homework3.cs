namespace Homework3;

class Program
{

    static void Main(string[] args)
    {

        // Code for Q1
        Console.WriteLine("Q1: Prime Number Check");
        Console.Write("Enter a number N: ");
        int N = Convert.ToInt16(Console.ReadLine());

        bool isPrime = true;

        if (N <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i * i <= N; i++)
            {
                if (N % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        Console.WriteLine(isPrime ? $"{N} is prime" : $"{N} is non-prime");
        // Code for Q2
        Console.Write("Assign an integer value to N:");
        int N1 = Convert.ToInt16(Console.ReadLine());
        for (int row = 0; row < N1; row++)
        {
            for (int col = 0; col < N1; col++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        // Code for Q3
        Console.Write("Assign an integer value to N:");
        int N2 = Convert.ToInt16(Console.ReadLine());
        for (int row = 0; row < N2; row++)
        {
            for (int col = 0; col <= row; col++)
            {
                if (col <= row)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}