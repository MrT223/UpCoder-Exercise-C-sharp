using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int res = 0;
        while(a > 0) {
            res += a % 10;
            a /= 10;
        }
        Console.Write(res);
    }
}