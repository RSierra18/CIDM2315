namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        //Code for question 1
        Console.WriteLine("Please input a letter grade (A, B, C, D, F):");
        string grade = Console.ReadLine();

        int score;
        if (grade == "A")
        {
            score = 4;
        }
        else if (grade == "B")
        {
            score = 3;
        }
        else if (grade == "C")
        {
            score = 2;

        }
        else if (grade == "D")
        {
            score = 1;
        }
        else if (grade == "F")
        {
            score = 0;
        }
        else
        {
            Console.WriteLine("Wrong Letter Grade!");
            return;


        }
        Console.WriteLine($"GPA Point: {score}");

        //end of code 1
        //Code for question 2
          Console.WriteLine("Please input the first number:");
            int n1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Please input the second number:");
            int n2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("PLease input the third number:");
            int n3 = Convert.ToInt16(Console.ReadLine());

            int smallest;
            if (n1 < n2)
            {
                if (n1 < n3)
                {
                    smallest = n1;
                }
                else
                {
                    smallest = n3;
                }
            }
            else
            {
                if (n2 < n3)
                {
                    smallest = n2;
                }
                else
                {
                    smallest = n3;
                }
            }

            Console.WriteLine($"The smallest value is: {smallest}");
    


    }
    

}

