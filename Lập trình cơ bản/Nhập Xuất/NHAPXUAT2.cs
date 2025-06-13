using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        int temp = a;
        a = b;
        b = temp;
        Console.Write(a + " " + b);
    }
}