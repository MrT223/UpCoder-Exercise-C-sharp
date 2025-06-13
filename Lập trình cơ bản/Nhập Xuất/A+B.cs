using System;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int a = Convert.ToInt32(input[0]);  //Nhập int kiểu 1
        int b = int.Parse(input[1]);        //Nhập int kiểu 2
        Console.WriteLine(a + b);
    }
}