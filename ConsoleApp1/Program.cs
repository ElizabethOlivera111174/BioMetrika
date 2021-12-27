using System;

namespace ConsoleApp1
{
    class Program
    {


        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {

                if (i % 6==0)
                {
                    Console.WriteLine("bio");
                }
                else if(i % 9 == 0)
                {
                    Console.WriteLine("metrika");
                }
                else
                {
                    Console.WriteLine(i);
                }
               
            }
            
        }
    }
}
