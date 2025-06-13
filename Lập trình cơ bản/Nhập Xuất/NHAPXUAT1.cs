using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int temp1 = a % 10;
        int temp2 = a / 10 % 10;
        int temp3 = a / 100;
        Console.Write($"{temp1}\n{temp3}\n{temp2}");
    }
}