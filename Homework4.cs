namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
        int Largest = LargerNumber(3, 5);
        Console.WriteLine("the larger number is: " + Largest);
        Console.WriteLine();
        //Question 2
        int n = 5;
        Console.WriteLine("Enter direction for shape (left or right): ");
        string shape = Console.ReadLine();
         Printshape(n, shape);
    }

    //Question 1 Method
    static int LargerNumber(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
    //Question 2 Method
    static void Printshape(int n, string shape)
    {   Console.WriteLine("N is "+ n +", shape is " + shape);
        if (shape == "left")
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        else if (shape == "right")    
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        
    }

}