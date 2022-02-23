using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int i , j;
            int x = 5;
            int y = 5;
            int length = 9;
            for ( i = 1; i <= length; i++)
            {
                Console.WriteLine(i);

                for ( j = 2; j <= length; j++)
                {                    
                    Console.WriteLine(i + ""+ j);
                   
                }
            }
        }
    }
}
