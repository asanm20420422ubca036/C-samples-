using System;
using System.Collections;
class collection
{
    static void Main()
    {
        ArrayList Array = new ArrayList();
        Array.Add(1);
        Array.Add("Priya");
        Array.Add(20);


        foreach (var items in Array)
        {
            Console.WriteLine(items);
        }
    }
