using System;

class NumberSequence2
{
    static void Main()
    {
        int numberToPrint;
        for (int i = 2; i <= 100; i++) 
        {
            if (i % 2 == 0)
            {
                numberToPrint = i;
            }
            else
            {
                numberToPrint = i * (-1);
            }
            Console.WriteLine(numberToPrint);
        }
    }
}

