namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
        // Q1 method
        int largestOfTwo = Q1_method();
        Console.WriteLine("Largest Number is: " + largestOfTwo);

        //Q2 method
        int largestOfFour = Q2_method();
        Console.WriteLine("Largest Number is: " + largestOfFour);

        // Q3 method
        createAccount();
    }

    // Q1 method
    static int Q1_method()
    {
        Console.Write("a=");
        int a = Convert.ToInt16(Console.ReadLine());

        Console.Write("b=");
        int b = Convert.ToInt16(Console.ReadLine());

        return MaxOfTwo(a, b);
    }

    static int MaxOfTwo(int x, int y)
    {
        if (x > y) return x;
        else return y;
    }

    // Q2 method
    static int Q2_method()
    {
        Console.Write("a=");
        int a = Convert.ToInt16(Console.ReadLine());

        Console.Write("b=");
        int b = Convert.ToInt16(Console.ReadLine());

        Console.Write("c=");
        int c = Convert.ToInt16(Console.ReadLine());

        Console.Write("d=");
        int d = Convert.ToInt16(Console.ReadLine());

        int max1 = MaxOfTwo(a, b);
        int max2 = MaxOfTwo(c, d);
        int max = MaxOfTwo(max1, max2);

        return max;
    }

    // Q3 method
    static bool checkAge(int birth_Year)
    {
        int current_Year = 2025;
        int age = current_Year - birth_Year;

        if (age >= 18) return true;
        else return false;
    }

    static void createAccount()
    {
        Console.Write("Enter Your Username:");
        string username = Console.ReadLine();

        Console.Write("Enter Your Password:");
        string password = Console.ReadLine();

        Console.Write("Enter Your Password Again:");
        string passwordAgain = Console.ReadLine();

        Console.Write("Enter Your Birth Year:");
        int birthYear = Convert.ToInt16(Console.ReadLine());

        if (checkAge(birthYear))
        {
            if (password == passwordAgain)
            {
                Console.WriteLine("Account is created successfully");
            }
            else
            {
                Console.WriteLine("Wrong password");
            }
        }
        else
        {
            Console.WriteLine("Could not create an account");
        }
    }
}
