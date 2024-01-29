using System;

class Program
{
    static void Main()
    {
        int num1, num2;

        
        Console.Write("Please enter two numbers: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        num2 = Convert.ToInt32(Console.ReadLine());

       
        Console.Write("Prime numbers between " + num1 + " و " + num2 + ": ");
        for (int i = num1; i <= num2; i++)
        {
            if (IsPrime(i))
            {
                Console.Write(i + " ");
            }
        }

        Console.WriteLine();
    }

    
    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
