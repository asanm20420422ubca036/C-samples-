using System;
using System.ComponentModel.DataAnnotations;
namespace program
{
    class looping

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter when the loop get start");
            int loopstart = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter when the loops get end");
            int loopend = Convert.ToInt32(Console.ReadLine());
            for (int i = loopstart; i <= loopend; i++)
            {
                Console.WriteLine($"{i}");
            }
                for (int j = loopend; j >= loopstart; j--)
                {
                    Console.WriteLine($"{j}");
                }
                
            

        }
    }
}