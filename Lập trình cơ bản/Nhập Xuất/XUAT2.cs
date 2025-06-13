using System;

class Program
{
    static void Main()
    {
        for(int i = 2; i < 7; i++) {
            for(int j = 1; j < i; j++) {
                Console.Write(j);
            }
            Console.Write("\n");
        }
    }
}