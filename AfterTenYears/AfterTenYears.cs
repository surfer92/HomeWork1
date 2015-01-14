using System;

class AfterTenYears
{
    static void Main()
    {
        Console.WriteLine("На колко си години");
        byte age = byte.Parse(Console.ReadLine());
        Console.WriteLine("След 10 години ще си на "+(age+10));
    }
}

