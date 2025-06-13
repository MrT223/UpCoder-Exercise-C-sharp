using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int alast = a % 10;
        int blast = b % 10;
        Console.WriteLine(alast + blast);
    }
}