using System;

namespace project
{
    public class Laptop  //single inheritance
    {

        public string name = "lenovo";
        public double amount = 40000.50;

    }
    class Desktop : Laptop   //hierarchical inheritance
    {
        public void lap()
        {
            Console.WriteLine("Iam gonna to use acer lap");
        }
        class Mouse : Laptop
        {
            public void mouse()
            {
                Console.WriteLine("Hello iam using mouse ");
            }
        }
        public static void Main()
        {
            Mouse ds = new Mouse();
            ds.name = "lenovo";
            ds.mouse();
            Desktop d = new Desktop();
            d.lap();
            Console.WriteLine("Hello world iam using  " + ds.name + " and its amount is " + ds.amount);
            Console.WriteLine("hello world");
            
}
    
