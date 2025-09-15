using System;

class Array
{

    enum Books { priya,kaviya,viji,banu,vaishu }

    public static void Main(string[] args)
    {
        
        Console.WriteLine("Book: priya at Index of: " + (int)Books.priya);
        Console.WriteLine("Book: kaviya at Index of: " + (int)Books.kaviya);
        Console.WriteLine("Book: viji at Index of: " + (int)Books.viji);
        Console.WriteLine("Book: banu at Index of: " + (int)Books.banu);
        Console.WriteLine("Book: vaishu at Index of: " + (int)Books.vaishu);
        string str = Books.vaishu.ToString();
        foreach(string name in Enum.GetNames(typeof(Books)))
        {
            Console.WriteLine(name);
        }
    }
}
