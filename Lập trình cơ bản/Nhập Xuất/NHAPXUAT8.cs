using System;

class Program
{
    static void Main()
    {
        string[] line1 = Console.ReadLine().Split();
        string[] line2 = Console.ReadLine().Split();
        string[] line3 = Console.ReadLine().Split();

        int a = int.Parse(line1[0]);
        int b = int.Parse(line1[1]);
        int c = int.Parse(line2[0]);
        int d = int.Parse(line2[1]);
        int e = int.Parse(line3[0]);
        int f = int.Parse(line3[1]);
        double res = (a + b + c) / (double)(d + e + f);
        Console.Write("{0:F1}", res);
    }
}