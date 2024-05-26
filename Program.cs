using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(CountNumbersWithoutFive(1, 9));     
        Console.WriteLine(CountNumbersWithoutFive(4, 17));    
    }

    static int CountNumbersWithoutFive(int start, int end)
    {
        int count = 0;
        for (int i = start; i <= end; i++)
        {
            if (!ContainsDigit(i, 5))
            {
                count++;
            }
        }
        return count;
    }

    static bool ContainsDigit(int number, int digit)
    {
        while (number != 0)
        {
            if (number % 10 == digit)
            {
                return true;
            }
            number /= 10;
        }
        return false;
    }
}